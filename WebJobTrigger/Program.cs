using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebJobTrigger
{
    class Program
    {

        static void Main(string[] args)
        {
            HttpClient Client = new HttpClient();
            

            while (true)
            {
                var Response = RunJob(Client);
                Console.WriteLine("Job ran");
                Console.WriteLine(Response.Result);
                Thread.Sleep(3600000);
            }
            
        }

        public static async Task<HttpResponseMessage> RunJob(HttpClient Client)
        {
            var ByteArray = Encoding.ASCII.GetBytes("");

            var Address = new Uri("");

            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(ByteArray));

            return Client.PostAsync(Address, null).Result;
        }

    }
}
