using System.Threading.Tasks;
using RestSharp;
using System;

namespace deliver_me_deliveries.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll(string apiKey)
    {
      RestClient client = new RestClient("https://eatstreet.com/publicapi/v1");
      RestRequest request = new RestRequest($"restaurant/search?method=both&street-address=316+W.+Washington+Ave.+Madison+WI", Method.GET);
      request.AddHeader("X-Access-Token", apiKey);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}



    // these ones in api helper
    // public static async Task<string> GetAll()
    // {
    //   RestClient client = new RestClient("http://localhost:5006/api");
    //   RestRequest request = new RestRequest($"restaurant", Method.GET);
    //   var response = await client.ExecuteTaskAsync(request);
      
    //   return response.Content;
    // }

    //  public static async Task<string> GetPage(string page)
    // {
    //   Console.WriteLine($"Page: {page} <========================");
    //   RestClient client = new RestClient("http://localhost:5006/api");
    //   RestRequest request = new RestRequest($"books?page={page}", Method.GET);
    //   var response = await client.ExecuteTaskAsync(request);
      
    //   return response.Content;
    // }


    // public static async Task<string> Get(int id)
    // {
    //   RestClient client = new RestClient("http://localhost:5006/api");
    //   RestRequest request = new RestRequest($"books/{id}", Method.GET);
    //   var response = await client.ExecuteTaskAsync(request);
    //   return response.Content;
    // }

// P5LG4JN6VERBYZJRTPHAMLF75I======