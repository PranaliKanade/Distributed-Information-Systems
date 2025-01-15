using System;
using System.Collections.Generic;

namespace NationalCities.Models
{
  // Model for parks data. These classes can be obtained by either using 
  // the Visual Studio editor (right-click -> Paste Special -> Paste Json as Classes)
  // or sites such as JsonToCSHarp
  public class City
  {
    public string city { get; set; }
    public string state_abbr { get; set; }
    public string zip { get; set; }
    public string designation { get; set; }
    public string parkCode { get; set; }
    public string id { get; set; }
    public string directionsInfo { get; set; }
    public string directionsUrl { get; set; }
    public string fullName { get; set; }
    public string url { get; set; }
    public string weatherInfo { get; set; }
    public string name { get; set; }
  }

  public class Cities
  {
    public string city { get; set; }
    public List<City> data { get; set; }
    public string state_abbr { get; set; }
    public string zip { get; set; }
  }
}