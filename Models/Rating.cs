using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TravelClient.Models
{
  public class Rating
  {
    public int RatingId { get; set; }
    public int Stars { get; set; }
    public int PlaceId { get; set; }
    public int UserId { get; set; }
    public string Comments { get; set; }
 
    public static Rating GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Rating rating = JsonConvert.DeserializeObject<Rating>(jsonResponse.ToString());

      return rating;
    }
    public static void Post(Rating rating)
    {
      string jsonRating = JsonConvert.SerializeObject(rating);
      var apiCallTask = ApiHelper.Post(jsonRating);
    }

    public static void Put(Rating rating)
    {
      string jsonRating = JsonConvert.SerializeObject(rating);
      var apiCallTask = ApiHelper.Put(rating.RatingId, jsonRating);
    }

    public static void Delete(int id)
    {
      var apiCallTask = ApiHelper.Delete(id);
    }
  }
}