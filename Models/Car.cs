using System;
using System.Collections.Generic;
namespace CarDealership.Models
{
  public class Car
  {
    private string _brand;
    private string _model;
    private int _price;
    private int _mileage;
    private static List<Car> _carList = new List<Car>();

    public Car(string brand, string model, int price, int mileage)

    {
      _brand = brand;
      _model = model;
      _price = price;
      _mileage = mileage;
    }
    public string GetBrand()
    {
      return _brand;
    }
    public string GetModel()
    {
      return _model;
    }
    public int GetPrice()
    {
      return _price;
    }
    public int GetMileage()
    {
      return _mileage;
    }
    public static List<Car> GetAll()
    {
      return _carList;
    }
    public void Save()
    {
      _carList.Add(this);
    }
    public static void ClearAll()
    {
      _carList.Clear();
    }
  }
}
