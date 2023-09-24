
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using NovaPay.Integrator.Common.Services.Resources.Responses;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Reflection;
using System.Drawing;
using System.Xml;

namespace NovaPay.Integrator.Adapters
{
    public class Converters
    {
        public static Task<List<string>> GetValidationMappingFields()
        {
            var validationType = typeof(ValidationResponse);
            IList<PropertyInfo> validationProps = new List<PropertyInfo>(validationType.GetProperties());

            return Task.FromResult(validationProps.Select(x => x.Name).ToList());
        }
        public static Task<List<string>> GetPaymentMappingFields()
        {
            var validationType = typeof(TransactionResponse);
            IList<PropertyInfo> validationProps = new List<PropertyInfo>(validationType.GetProperties());

            return Task.FromResult(validationProps.Select(x => x.Name).ToList());
        }
        public static Task<TransactionResponse> ConvertTransactionResponse(string response, Dictionary<string, string> fields)
        {
            var expandoConverter = new ExpandoObjectConverter();
            var transactionResponse = new TransactionResponse();
            dynamic res = JsonConvert.DeserializeObject<ExpandoObject>(response, expandoConverter);
            Type resType = res.GetType();
            Type validationType = transactionResponse.GetType();

            IDictionary<string, object> propertyValues = res;

            IList<PropertyInfo> validationProps = new List<PropertyInfo>(validationType.GetProperties());

            foreach (var prop in propertyValues)
            {


                var validationName = fields.GetValueOrDefault(prop.Key);

                if (validationName == null)
                {
                    continue;
                }

                var val = validationProps.FirstOrDefault(t => t.Name == validationName);

                if (val == null) { continue; }

                val.SetValue(transactionResponse, prop.Value, null);
            }

            return Task.FromResult(transactionResponse);
        }
        public  static Task<ValidationResponse> ConvertValidationResponse(string response, Dictionary<string, string> fields)
        {
            var expandoConverter = new ExpandoObjectConverter();
            var validationResponse = new ValidationResponse();
            dynamic res = JsonConvert.DeserializeObject<ExpandoObject>(response, expandoConverter);
            Type resType = res.GetType();
            Type validationType = validationResponse.GetType();

            IDictionary<string, object> propertyValues = res;

            IList<PropertyInfo> validationProps = new List<PropertyInfo>(validationType.GetProperties());

            foreach (var prop in propertyValues)
            {
               

                var validationName = fields.GetValueOrDefault(prop.Key);

                if (validationName == null)
                {
                    continue;
                }

                var val = validationProps.FirstOrDefault(t => t.Name == validationName);

                if (val == null) { continue; }

                val.SetValue(validationResponse, prop.Value, null);
            }

            return Task.FromResult(validationResponse);

        }
    }
}
