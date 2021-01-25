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
    public class GetDegreeStats
    {
        public async Task<DegreeStats> GetStatData()
        {
            using (var client1 = new HttpClient())
            {
                client1.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client1.DefaultRequestHeaders.Accept.Clear();
                client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client1.GetAsync("api/employment/degreeStatistics", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();
                    JObject job = JObject.Parse(data);

                    DegreeStats stats = JsonConvert.DeserializeObject<DegreeStats>(job["degreeStatistics"].ToString());
                    //Debug.WriteLine("THE DEGREE STATS" + job["degreeStatistics"].ToString());
                    //Debug.WriteLine("STATS IN DEGRE OBJ" + stats.statistics.Count);
                    /*foreach(var stat in stats.statistics)
                    {
                        Debug.WriteLine(stat.description);
                    }*/

                    return stats;

                }

                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    DegreeStats statData = new DegreeStats();
                    return statData;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    DegreeStats statData = new DegreeStats();
                    return statData;
                }
            }
        }
    }
}
