using System;
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
    public class GetCareerData
    {
        public async Task<Careers> GetCareerInfoData()
        {
            using (var client1 = new HttpClient())
            {
                client1.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client1.DefaultRequestHeaders.Accept.Clear();
                client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client1.GetAsync("api/employment/careers", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();
                    JObject job = JObject.Parse(data);

                    Careers careerData = JsonConvert.DeserializeObject<Careers>(job["careers"].ToString());

                    return careerData;

                }

                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    Careers careerData = new Careers();
                    return careerData;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    Careers careerData = new Careers();
                    return careerData; 
                }
            }
        }
    }
}
