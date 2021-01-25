using System;
using System.Threading.Tasks;
using Project3_FinalExam.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Project3_FinalExam.Services
{
    public class GetEmployerTableData
    {
        public async Task<EmploymentTable> GetEmployerTable()
        {
            using (var client1 = new HttpClient())
            {
                client1.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client1.DefaultRequestHeaders.Accept.Clear();
                client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client1.GetAsync("api/employment/employmentTable", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();
                    JObject job = JObject.Parse(data);

                    EmploymentTable employTable = JsonConvert.DeserializeObject<EmploymentTable>(job["employmentTable"].ToString());

                    return employTable;

                }

                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    EmploymentTable employTableData = new EmploymentTable();
                    return employTableData;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    EmploymentTable employTableData = new EmploymentTable();
                    return employTableData;
                }
            }
        }
    }
}
