using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var lot = new CarLot();
            
            //Dot Notation

            var jamesCar = new Car();

            jamesCar.Make = "Chevy";
            jamesCar.Model = "Nova";
            jamesCar.Year = 1975;
            jamesCar.EngineNoise = "wowo";
            jamesCar.HonkNoise = "puu";
            jamesCar.IsDrivable = true;

            Console.WriteLine($"Number of Cars in the lot is: {CarLot.numberOfCars}");

            lot.Cars.Add(jamesCar);

            //Object Initializer Syntax

            var nicksCar = new Car()
            {
                Year = 1968,
                Make = "Dodge",
                Model = "Challenger",
                EngineNoise = "wom wom",
                HonkNoise = "beep",
                IsDrivable = true
            };
            Console.WriteLine($"Number of Cars in the lot is: {CarLot.numberOfCars}");


            lot.Cars.Add(nicksCar);

            //Custom Constructor

            var dariusCar = new Car(2026, "Nissan", "Skyline", "zoom", "bipbop", false);
            Console.WriteLine($"Number of Cars in the lot is: {CarLot.numberOfCars}");

            lot.Cars.Add(dariusCar);

            //methods
            //jamesCar.MakeEngineNoise(jamesCar.EngineNoise);
            //nicksCar.MakeEngineNoise(nicksCar.EngineNoise);
            //dariusCar.MakeEngineNoise(dariusCar.EngineNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            foreach(var car in lot.Cars) 
            {
                Console.WriteLine
                    ($"Year: {car.Year} " +
                    $"Make: {car.Make} " +
                    $"Model: {car.Model}");
            }

        }
    }
}
