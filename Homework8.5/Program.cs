using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8._2
{
    public struct Car
    {
        public string Marka;
        public int Year;
        public int Price;
        public float Amount;

        public string GetString()
        {
            return "Mark : " + Marka + " Year : " + Year + " Price : " + Price + "$ Amount : " + Amount + " liters";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Car №" + i);

                Console.Write("Enter Marka ");
                string MarkaCar = Console.ReadLine();
                Console.Write("Enter Year ");
                int YearCar = int.Parse(Console.ReadLine());
                Console.Write("Enter Price ");
                int PriceCar = int.Parse(Console.ReadLine());
                Console.Write("Enter Amount ");
                float AmountCar = float.Parse(Console.ReadLine());

                Car car = new Car();
                car.Marka = MarkaCar;
                car.Year = YearCar;
                car.Price = PriceCar;
                car.Amount = AmountCar;

                cars.Add(car);
            }


            for (int j = 0; j < cars.Count; j++)
            {
                Console.WriteLine(cars[j].GetString());
            }



        }
    }
}
