﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        { 
            Car car = new Car();

            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;

            Console.WriteLine($"MAke: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}
