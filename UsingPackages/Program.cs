using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace UsingPackages
{
    class Program
    {
        static void Main(string[] args)
        {
            GetPeople();
        }
        private static async void GetPeople()
        {
            List<People> allPeople = new List<People>();
            var apiEndpoint = "https://my.api.mockaroo.com/peopleforclass.json?key=9a55a0e0";
            using (HttpClient httpClient = new HttpClient())
            {
                var apiResponse = httpClient.GetAsync(apiEndpoint).Result;
                //var apiResponse = await httpClient.GetAsync(apiEndpoint);
                if (apiResponse.IsSuccessStatusCode)
                {
                    allPeople = JsonConvert.DeserializeObject<List<People>>(await apiResponse.Content.ReadAsStringAsync());
                }
            }
            Console.WriteLine("ID. Name\tEmail Address");
            foreach (var people in allPeople)
            {
                Console.WriteLine($"{people.ID}. {people.FirstName} {people.LastName}\t{people.EmailAddress}");
            }
        }
    }
}
