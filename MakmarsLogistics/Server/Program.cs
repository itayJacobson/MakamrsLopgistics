﻿using Microsoft.Owin.Hosting;
using Server.ApiContent;
using Server.DbContent;
using Server.Models;
using System;
using System.Net.Http;

namespace Server
{
    class Program
    {
        public static void Main(string[] args)
        {

        /*  string baseAddress = "http://localhost:9000/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                // Create HttpClient and make a request to api/values 
                HttpClient client = new HttpClient();

                var response = client.GetAsync(baseAddress + "api/soldiers").Result;

                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.ReadLine();
            }*/
        }
    }
}