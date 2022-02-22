using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._2
{
    interface Crud
    {
        ICollection<Car> ReadCars();
        string GetMaxID();
        void AddRecord(Car obj);
        void DeleteRecord(Car obj);
        ICollection<Car> GetCars();
        Car FindCar(string id);
        void UpdateRecord(string id, Car carchanges);
    }

    class CarRepository : Crud
    {
        CarInventoryEntities entities;

        public CarRepository()
        {
            entities = new CarInventoryEntities();
        }

        public void AddRecord(Car obj)
        {
            entities.Cars.Add(obj);
            entities.SaveChanges();
        }
        
        public void DeleteRecord(Car obj)
        {
            entities.Cars.Remove(obj);
            entities.SaveChanges();

        }

        public Car FindCar(string id)
        {
            var car = entities.Cars.First(n => n.Vin == id);
            if (car != null)
            {
                return car;
            }
            else
                return null;
        }

        public ICollection<Car> GetCars()
        {
            return entities.Cars.ToList();
        }

        public string GetMaxID()
        {
            return entities.Cars.Max(p => p.Vin);
        }

        public ICollection<Car> ReadCars()
        {
            return entities.Cars.ToList();
        }

        public void UpdateRecord(string id, Car carchanges)
        {
            var cartoupdate = entities.Cars.Find(id);
            cartoupdate.Vin = carchanges.Vin;
            cartoupdate.Make=carchanges.Make;
            cartoupdate.Model=carchanges.Model;
            cartoupdate.Color=carchanges.Color;
            cartoupdate.Year=carchanges.Year;
            cartoupdate.Price=carchanges.Price;
            cartoupdate.Status = carchanges.Status;
            entities.SaveChanges();

        }

    }
}
