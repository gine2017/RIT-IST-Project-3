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
    public class GetEmployIntro
    {
        public async Task<EmployIntro> GetEmployStatData()
        {
            using (var client1 = new HttpClient())
            {
                client1.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client1.DefaultRequestHeaders.Accept.Clear();
                client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client1.GetAsync("api/employment/introduction", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();
                    JObject job = JObject.Parse(data);

                    EmployIntro employIntro = JsonConvert.DeserializeObject<EmployIntro>(job["introduction"].ToString());
                    //Debug.WriteLine("THE EMPLOY INTRO" + job["introduction"].ToString());

                    return employIntro;

                }

                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    EmployIntro employData = new EmployIntro();
                    return employData;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    EmployIntro employData = new EmployIntro();
                    return employData;
                }
            }
        }
    }
}
