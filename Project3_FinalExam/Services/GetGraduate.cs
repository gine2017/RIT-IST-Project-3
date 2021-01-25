using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace Project3_FinalExam.Services
{
    public class GetGraduates : IGetGraduate
    {
        public async Task<List<Graduate>> GetAllGrad()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/degrees/graduate", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();
                    JObject job = JObject.Parse(data);
                    //Debug.WriteLine("GRAD STUDD" + job["title"].ToString());

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<Graduate>>>(data);

                    List<Graduate> gradList = new List<Graduate>();
                    Graduate graduate = new Graduate();

                    foreach (KeyValuePair<string, List<Graduate>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            gradList.Add(item);
                        }
                    }
                    return gradList;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<Graduate> gradList = new List<Graduate>();
                    return gradList;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<Graduate> gradList = new List<Graduate>();
                    return gradList;
                    //return "Exception"; ;
                }
            }
        }
    }
}
