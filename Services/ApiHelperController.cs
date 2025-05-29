using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace EmployeeBookXpert.Services
{
    public class ApiHelperController : ApiController
    {
        string baseURl = "https://localhost:44304/api/";

        public async Task<HttpResponseMessage> getApiResponse(string apiUrl)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress=new Uri(baseURl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage getResponse= await client.GetAsync(apiUrl);
            return getResponse;
        }

        public async Task<HttpResponseMessage> getPostResponse(string apiUrl, object parameters=null)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage postResponse=new HttpResponseMessage(); 

            client.BaseAddress=new Uri(baseURl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if(parameters != null)
            {
                string Json = JsonConvert.SerializeObject(parameters);
                System.Diagnostics.Debug.WriteLine("Requesting JSON :", Json);
                var paramToJson = new StringContent(Json, System.Text.Encoding.UTF8, "application/json");
                postResponse = await client.PostAsync(apiUrl, paramToJson);
            }
            else
            {
                var JsonError = new StringContent(string.Empty, System.Text.Encoding.UTF8, "application/json");
                postResponse = await client.PostAsync(apiUrl, JsonError);
            }

            string responseText=await postResponse.Content.ReadAsStringAsync();
            System.Diagnostics.Debug.WriteLine("Response Text :", responseText);
            client.Dispose();
            return postResponse;
        }
    }
}
