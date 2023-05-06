
using Microsoft.IdentityModel.Tokens;
using NovaPay.Integrator.Common.Services.Constants;
using NovaPay.Integrator.Common.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NovaPay.Integrator.Common.Services.Utilities
{
    public class TokenValidation
    {
        public static bool IsAdmin(string token, string jwtKey, string issuer)
        {
            var claimToken = ValidationAndDecode(token, jwtKey,
                          issuer);
            var roles = claimToken.Claims.Where(c => c.Type == StringConstants.Role).FirstOrDefault()?.Value;
            return roles != null ? roles.Contains(StringConstants.ADMIN) : false;
        }
        public static string GetUserId(string token, string userSlug, string jwtKey, string issuer)
        {
            var claimToken = ValidationAndDecode(token, jwtKey,
                          issuer);
            var userId = claimToken.Claims.Where(c => c.Type == userSlug).FirstOrDefault()?.Value;
            return userId;
        }
        public static ClaimsPrincipal ValidationAndDecode(string jwt, string jwtKey, string issuer)
        {
            var validationParameters = new TokenValidationParameters
            {
                ClockSkew = TimeSpan.FromMinutes(5),
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey)),
                RequireSignedTokens = true,
                RequireExpirationTime = true,
                ValidateLifetime = true,
                ValidateAudience = true,
                ValidAudience = issuer,
                ValidateIssuer = true,
                ValidIssuer = issuer

            };
            try
            {
                var claimsPrincipal = new JwtSecurityTokenHandler()
                     .ValidateToken(jwt, validationParameters, out var rawValidatedToken);
                return claimsPrincipal;
            }
            catch (SecurityTokenValidationException stvex)
            {
                throw new ValidationErrorException($"Token failed validation: {stvex.Message}");
            }
            catch (ArgumentException argex)
            {
                throw new Exception($"Token was invalid: {argex.Message}");
            }
        }
    }
}
