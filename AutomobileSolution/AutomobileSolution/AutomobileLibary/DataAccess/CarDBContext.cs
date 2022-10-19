using System;
using AutomobileLibary.BussinessObject;
using System.Collections.Generic;
namespace AutomobileLibary.DataAccess
{
    public class CarDBContext
    {
        //Initialize car list
        private static List<Car> CarList = new List<Car>()
        {
            new Car{CarID=1,CarName="CRV",Manufacturer="Honda",Price=30000,ReleaseYear=2021},
            new Car{CarID=2,CarName="Ford Focus",Manufacturer="Ford", Price=15000,ReleaseYear=2020}
        };
        //-------------------------------
        //Using Singleton Pattern
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }

        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }
        //-------------------------------
        public
        //-------------------------------

        public Car GetCarByID(int carID)
        {
            //using linQ to object

        }

    }
}