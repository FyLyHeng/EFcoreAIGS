using System.Net.Http.Headers;
using System.Net.Http.Json;
using Newtonsoft.Json;
using RestSharp.Authenticators;
using RestSharp.Portable;
using RestSharp.Portable.Authenticators;
using RestSharp.Portable.HttpClient;

namespace EFCore.AIGS.Infrastructure;

public class SyncData
{
    private const string URL1 = "http://127.0.0.1:8000/v1/api/sale-order/all";
    private const string URL = "http://127.0.0.1:8000/v1/api/";
    private const string TokenKey = "eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiIxfGFkbWluIiwiZXhwIjoxNjYwNDUxOTUxLCJpYXQiOjE2NTc4NTk5NTF9.4MjxCp4LlvEZJQvSSsGpfOAH_SFMDRuap4MAU7ng5qPWQpBeN97ldZKyqB7OLriwAypCb2QfHp8f5QEwO84v7A";
    
    
    public static void Do1()
    {
        var client = new RestClient(URL1);
        var request = new RestRequest(Method.GET);
        request.AddHeader("authorization", "Bearer " + TokenKey);


        
        Task<IRestResponse> response = client.Execute(request);
        
        
        var content = response.Result.Content;
        dynamic json = JsonConvert.DeserializeObject(content);

        foreach (var data in json)
        {
            Console.WriteLine($"DATA :: {data}");

        }
        
        //Console.WriteLine($"DATA :: {json}");
        //JObject customerObjJson = json.userId;
        //var customerObj = customerObjJson.ToObject<string>();
        
    }


    
    public static void Do()
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(URL);

        // Add an Accept header for JSON format.
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenKey);


        // List data response.
        HttpResponseMessage response = client.GetAsync("sale-order/all").Result;
        if (response.IsSuccessStatusCode)
        {
            // Parse the response body.
            var dataObjects1 = response.Content.ReadFromJsonAsync<string>();  //Make sure to add a reference to System.Net.Http.Formatting.dll

            Console.WriteLine($"DATA :: {dataObjects1}");
        }
        else
        {
            Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
        }
        
        client.Dispose();
    }
}
