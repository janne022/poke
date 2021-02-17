using System;
using RestSharp;
using Newtonsoft.Json;

namespace pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            RestClient client = new RestClient("https://pokeapi.co/api/v2/");
            RestRequest request = new RestRequest("pokemon/charmander");
            IRestResponse respone = client.Get(request);
            Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(respone.Content);

            System.Console.WriteLine(respone.Content);
            Console.ReadLine();
        }
    }
}
