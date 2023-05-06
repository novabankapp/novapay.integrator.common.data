using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Net.Http.Headers;
using NovaPay.Integrator.Common.Services.Constants;
using NovaPay.Integrator.Common.Services.Settings;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPay.Integrator.Common.Services.Dependencies
{
    public static class ServiceDependencies
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddTransient<ITokenSettings,TokenSettings>();
            services.AddTransient<IEmailSettings, EmailSettings>();
            services.AddTransient<IWebhookSettings, WebhookSettings>();
            services.AddTransient<IGoogleSettings, GoogleSettings>();
            services.AddTransient<IIdentityServerSettings, IdentityServerSettings>();
        }
    }
    public static class AuthorizationDependencies
    {
        public static void RegisterAuthenticationServices(this IServiceCollection services, IConfiguration Configuration)
        {
            var issuer = Configuration.GetSection("Token").GetSection("JwtIssuer")?.Value;
            var key = Configuration.GetSection("Token").GetSection("JwtKey")?.Value;
            var audience = Configuration.GetSection("Token").GetSection("JwtAudience")?.Value;
            services.AddAuthorization(options =>
            {
                options.AddPolicy(
                         StringConstants.ADMIN,
                         policyBuilder => policyBuilder.RequireAssertion(
                             context => {
                                
                                 var roles = context.User.Claims.Where(c => c.Type == StringConstants.Role).FirstOrDefault()?.Value;
                                 return roles.Contains(StringConstants.ADMIN);
                             }
                     )
                  );
                var identityJwtSchemePolicyBuilder = new AuthorizationPolicyBuilder(StringConstants.IDENTITYSCHEME);
                options.AddPolicy(StringConstants.IDENTITYSCHEME, identityJwtSchemePolicyBuilder
                    .RequireAuthenticatedUser()
                    .Build());
                var userJwtSchemePolicyBuilder = new AuthorizationPolicyBuilder(StringConstants.USERSCHEME);
                options.AddPolicy(StringConstants.USERSCHEME, userJwtSchemePolicyBuilder
                    .RequireAuthenticatedUser()
                    .Build());

            });
            services.AddAuthentication(config =>
            {
                config.DefaultAuthenticateScheme = StringConstants.MULTISCHEMES;
                config.DefaultScheme = StringConstants.MULTISCHEMES;
                config.DefaultChallengeScheme = StringConstants.MULTISCHEMES;

            })
            .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
             {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = issuer,
                        ValidAudience = audience,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))
                    };
                })
            .AddJwtBearer(StringConstants.USERSCHEME, options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = issuer,
                    ValidAudience = audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))
                };
            })
            .AddJwtBearer(StringConstants.IDENTITYSCHEME, options =>
            {
                options.Authority = $"{Configuration["IdentityServer"]}";
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = false
                };
            })
            .AddPolicyScheme(StringConstants.MULTISCHEMES, JwtBearerDefaults.AuthenticationScheme, options =>
            {
                options.ForwardDefaultSelector = context =>
                {
                    string authorization = context.Request.Headers[HeaderNames.Authorization];
                    if (!string.IsNullOrEmpty(authorization) && authorization.StartsWith("Bearer "))
                    {
                        var token = authorization.Substring("Bearer ".Length).Trim();
                        var jwtHandler = new JwtSecurityTokenHandler();
                        var roles = context.User.Claims.Where(c => c.Type == StringConstants.Role).FirstOrDefault()?.Value;
                        var isAdmin = roles != null ? roles.Contains(StringConstants.ADMIN) : false;
                        return (jwtHandler.CanReadToken(token) && jwtHandler.ReadJwtToken(token).Issuer.Equals(issuer))
                            ? (isAdmin ? StringConstants.ADMIN : StringConstants.USERSCHEME ) : StringConstants.IDENTITYSCHEME;
                    }
                    return JwtBearerDefaults.AuthenticationScheme;
                };
            });
        }
    }
}
