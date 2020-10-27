using System.Net.Http;
using System.Threading.Tasks;
using Nancy.Json;
using System.Collections.Generic;
using System;

namespace AppsCsharp
{
    class Program
    {
        public class Gold // formato de json em classse
        {
            public int Price { get; set; }
            public string Timestamp { get; set; }
        }

        static HttpClient client = new HttpClient();

        static async Task getPromisse ()
        {
            string url = "https://www.albion-online-data.com/api/v2/stats/gold?count=1"; // Link pra api do albion online
            HttpResponseMessage response = await client.GetAsync(url);
            string jsonString = await response.Content.ReadAsStringAsync();

            JavaScriptSerializer serializer = new JavaScriptSerializer(); // Instancia do JavaScriptSerializer
            List<Gold> result = serializer.Deserialize<List<Gold>>(jsonString); // converte pra lista de classes

            Console.WriteLine(result[0].Price);

            
        }
        static async Task Main()
        {
            await getPromisse();
        }
    }
}
