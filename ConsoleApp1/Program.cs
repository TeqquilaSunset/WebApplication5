using System;
using System.Net.Http;
using System.Net.Http.Json;

namespace ConsoleApp1
{
    internal class Program
    {
        static HttpClient httpClient = new HttpClient();
        static async Task Main()
        {
            var id = "981b0db3-b52d-4656-956a-c9ec8e9061fd";
            var data = await httpClient.GetFromJsonAsync($"http://localhost:5255/Catalog/{id}", typeof(ProductDto));
            if (data is ProductDto person)
            {
                Console.WriteLine($"ID: {person.Id} \nName: {person.Name}  \nDescription: {person.Description} \nPrice {person.Price}$" +
                    $"\nBrandId {person.BrandId} \nCategoryId: {person.CategoryId}");
            }
        }
    }
    record Person(string Name, int Age);
}