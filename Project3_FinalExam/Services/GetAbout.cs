using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

/*
 View models differ from domain models in that view models only
contain the data (represented by properties) that you want to use on your view.

TO HELP ME WRAP EVERTYHGIN AROUND MY HEAD

Models: package that has classes that show the class version of json

Services: package that holds to functionality to grab data from api and return the appropiate class objects

ViewModels how you want your model class to be displayed 
 */

namespace Project3_FinalExam.Services
{
    public class GetAbout
    {
        public async Task<About> GetAboutData()
        {
            using (var client1 = new HttpClient())
            {
                client1.BaseAddress = new Uri("http://www.ist.rit.edu/");
                client1.DefaultRequestHeaders.Accept.Clear();
                client1.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client1.GetAsync("api/about", HttpCompletionOption.ResponseHeadersRead);
                    response.EnsureSuccessStatusCode();
                    var data = await response.Content.ReadAsStringAsync();

                    var rtnResults = JsonConvert.DeserializeObject<About>(data);
                    return rtnResults;

                }

                catch (HttpRequestException hre)
                {
                    var msg = hre.Message;
                    About aboutData = new About();
                    return aboutData;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                    About aboutData = new About();
                    return aboutData;
                }
            }
        }
    }
}
