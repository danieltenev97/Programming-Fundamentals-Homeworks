using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
          
            List<City> cities = new List<City>();

            string pattern = @"[A-Z]{2}[\d]+\.[\d]+[A-Za-z]+\|";

            Regex regex = new Regex(pattern);

            while(true)
            {
                string input = Console.ReadLine();
                if(input=="end") { break; }
                var currentcity = new City();
                string citycode = "";
                double tempaverage = 0;
                string forecast = "";

                MatchCollection mathes = regex.Matches(input);

                foreach (Match item in mathes)
                {
                    var a = Regex.Split(item.Value, @"[A-Za-z]+");
                    var take = item.Value.Take(2);
                    citycode = string.Join("", take);
                    tempaverage = double.Parse(a[1]);
                    var b= Regex.Split(item.Value, @"[\d]+\.[\d]+");

                    forecast = b[1];
                    forecast = forecast.Remove(forecast.Length - 1);

                }

                

                currentcity.citycode = citycode;
                currentcity.temperatureaverage = tempaverage;
                currentcity.weather = forecast;

                foreach (var item in cities)
                {
                    if(item.citycode==citycode)
                    {
                        item.temperatureaverage = tempaverage;
                        item.weather = forecast;
                        break;
                    }
                }

                if(!cities.Exists(x=>x.citycode==citycode)&&citycode.Length==2)
                {
                    cities.Add(currentcity);
                }
            }

            foreach (var weather in cities.OrderBy(x=>x.temperatureaverage))
            {
                string code = weather.citycode;
                string cityweather = weather.weather;
                double tempaverage = weather.temperatureaverage;

                Console.WriteLine($"{code} => {tempaverage:f2} => {cityweather}");
            }

        }
    }
}
