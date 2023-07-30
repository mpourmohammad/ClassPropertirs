using System;

namespace ClassPropertirs
{
    class Program
    {
        static void Main(string[] args)
        {
            CarModel carModel1 = new CarModel("Perayd", "Saipa", "blue");
            CarModel carModel2 = new CarModel("G650", "Benz", "red");
             
            Console.WriteLine(carModel1.Color);
            Console.WriteLine(carModel2.Color);

            Console.ReadLine();
        }
    }
}