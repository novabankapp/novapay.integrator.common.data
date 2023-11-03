// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using NovaPay.Integrator.Adapters;



var res = new Response
{
    Customer = "Lewis Msasa"
};
var dict = new Dictionary<string, string>
{
    { "Customer", "CustomerName" }
};
var response = await  Converters.ConvertValidationResponse(JsonConvert.SerializeObject(res), dict);
Console.WriteLine($"This is the name => {response.Name}");


class Response
{
    public string Customer { get; set; }
}
