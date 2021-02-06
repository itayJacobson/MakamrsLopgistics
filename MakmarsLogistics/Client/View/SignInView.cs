using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client.View
{
    public class SignInView
    {
        public void Login()
        {
            var userId = GetUserId();
            
            Authenticate(userId, GetPassword());
        }

        private int GetUserId()
        {
            Console.WriteLine("Enter username:");
            return int.Parse(Console.ReadLine());
        }

        private string GetPassword()
        {
            Console.WriteLine("Enter username:");
            return Console.ReadLine();
        }

        private void Authenticate(int id, string password)
        {
            HttpClient client = new HttpClient();

            var account = client.GetAsync("http://localhost:9000/" + $"api/accounts/{id}").Result.Content.ReadAsByteArrayAsync();

            
        }
    }
}