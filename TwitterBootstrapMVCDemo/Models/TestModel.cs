using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwitterBootstrapMVCDemo.Models
{
    public class TestModel
    {
        public Double Amount { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }

        public string Email { get; set; }

    }

    public class Location
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }

    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }

    public class MyViewModel
    {
        public int CarsDriven { get; set; }
        public List<Car> AllCars { get; set; }
        public List<Color> Colors { get; set; }
    }

    public enum Color
    {
        Red = 1,
        Green = 2,
        Blue = 3,
        Yellow = 4
    }
}