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
        

        static void Sort(List<Car> mass)
        {
            Car p = new Car();
            for (int i = 0; i < mass.Count; i++)
            {
                for (int j = 0; j < mass.Count; j++)
                {
                    if (mass[i].Price < mass[j].Price)
                    {
                        p = mass[i];
                        mass[i] = mass[j];
                        mass[j] = p;
                    }
                }
            }
        }

        

        static void Main(string[] args)
        {
            Console.WriteLine("How many cars?");
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Car №" + (i + 1));

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
            Sort(cars);

            for (int i = 0; i < cars.Count; i++)
            {

                Console.WriteLine(cars[i].GetString());
            }



        }
    }
}
