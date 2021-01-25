﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Project3_FinalExam.Services
{
    public class GetEmployersData
    {
        public async Task<Employers> GetEmployersInfo()
        {
            using (var client1 = new HttpClient())
            {
                client1.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client1.DefaultRequestHeaders.Accept.Clear();
                client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client1.GetAsync("api/employment/employers", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();
                    JObject job = JObject.Parse(data);

                    Employers employIntro = JsonConvert.DeserializeObject<Employers>(job["employers"].ToString());

                    return employIntro;

                }

                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    Employers employData = new Employers();
                    return employData;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    Employers employData = new Employers();
                    return employData;
                }
            }
        }
    }
}
