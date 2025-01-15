using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using NationalCities.Models;

namespace NationalCities.APIHandlerManager
{
  public class APIHandler
  {
    // Obtaining the API key is easy. The same key should be usable across the entire
    // data.gov developer network, i.e. all data sources on data.gov.
    // https://www.nps.gov/subjects/developer/get-started.htm

    static string BASE_URL = "https://developer.nps.gov/api/v1/";
    static string API_KEY = "uA7NhwVhz4trL1MizPbbvdgr2Dpw4i55yBib8ehC"; //Add your API key here inside ""

    HttpClient httpClient;

    /// <summary>
    ///  Constructor to initialize the connection to the data source
    /// </summary>
    public APIHandler()
    {
      httpClient = new HttpClient();
      httpClient.DefaultRequestHeaders.Accept.Clear();
      httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
      httpClient.DefaultRequestHeaders.Accept.Add(
          new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
    }

    /// <summary>
    /// Method to receive data from API end point as a collection of objects
    /// 
    /// JsonConvert parses the JSON string into classes
    /// </summary>
    /// <returns></returns>
    public Cities GetCities()
    {
      string NATIONAL_CITY_API_PATH = BASE_URL + "/api/cleap/v1/cities";
      string citiesData = "";

      Cities cities = null;

      httpClient.BaseAddress = new Uri(NATIONAL_CITY_API_PATH);

      // It can take a few requests to get back a prompt response, if the API has not received
      //  calls in the recent past and the server has put the service on hibernation
      try
      {
        HttpResponseMessage response = httpClient.GetAsync(NATIONAL_CITY_API_PATH).GetAwaiter().GetResult();
        if (response.IsSuccessStatusCode)
        {
          citiesData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
        }

        if (!citiesData.Equals(""))
        {
          // JsonConvert is part of the NewtonSoft.Json Nuget package
          cities = JsonConvert.DeserializeObject<Cities>(citiesData);
        }
      }
      catch (Exception e)
      {
        // This is a useful place to insert a breakpoint and observe the error message
        Console.WriteLine(e.Message);
      }

      return cities;
    }
  }
}