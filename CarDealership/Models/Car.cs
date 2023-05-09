using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    // private int _id; 
    private string _make;
    private string _model;  
    private string _year;
    public bool IsAvailable { get; set; }
    public int Price { get; set; }
    private static List<Car> _instances = new List<Car> { };

    public Car (string make, string model, int year, bool isAvailable, int price)
    {
      _make = make;
      _model = model;
      _year = year;
      IsAvailable = isAvailable;
      Price = price;
      // _id = _instances.Count + 1;
      _instances.Add(this);
    }

    // For the List
    public static List<Car> GetAll()
    {
      return _instances; 
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public string[] GetCarInformation()
    {
      string[] info = {_make, _model, _year};
      return info;
    }
  }
}
