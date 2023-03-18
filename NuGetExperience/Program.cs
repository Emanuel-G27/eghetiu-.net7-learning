// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using NuGetExperience;

Console.WriteLine("Hello, World!");


Product product = new Product
{
    ProductName = "Notebook",
    ProductPrice = 10
};

var json = JsonConvert.SerializeObject(product, new JsonSerializerSettings
{
    ContractResolver = new DefaultContractResolver
    {
        NamingStrategy = new KebabCaseNamingStrategy()
    }
});

Console.WriteLine(json);