﻿using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId+"--"+car.BrandId+"--"+car.ColorId+"--"+car.ModelYear+"--"+car.DailyPrice+"--"+car.Description);
            }
        }
    }
}