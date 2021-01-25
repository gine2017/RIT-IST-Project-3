using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Project3_FinalExam.Services
{
    public class GetMinors : IGetMinor
    {
        public async Task<List<UgMinor>> GetAllMinor()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/minors/UgMinors", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<Dictionary<string, List<UgMinor>>>(data);

                    List<UgMinor> minorList = new List<UgMinor>();
                    UgMinor minor = new UgMinor();

                    foreach (KeyValuePair<string, List<UgMinor>> kvp in rtnResults)
                    {
                        foreach (var item in kvp.Value)
                        {
                            minorList.Add(item);
                        }
                    }

                    return minorList;
                }
                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    List<UgMinor> minorList = new List<UgMinor>();
                    return minorList;
                    //return "HttpRequestException";
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    List<UgMinor> minorList = new List<UgMinor>();
                    return minorList;
                    //return "Exception"; ;
                }
            }
        }
    }
}
