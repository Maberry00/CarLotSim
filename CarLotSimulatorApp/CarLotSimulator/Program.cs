using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //done=Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            var lot = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            
            //Dot Notation

            var jamesCar = new Car();

            jamesCar.Make = "Chevy";
            jamesCar.Model = "Nova";
            jamesCar.Year = 1975;
            jamesCar.EngineNoise = "wowo";
            jamesCar.HonkNoise = "puu";
            jamesCar.IsDrivable = true;

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

            lot.Cars.Add(nicksCar);

            //Custom Constructor

            var dariusCar = new Car(2026, "Nissan", "Skyline", "zoom", "bipbop", false);

            lot.Cars.Add(dariusCar);

            //methods
            jamesCar.MakeEngineNoise(jamesCar.EngineNoise);
            nicksCar.MakeEngineNoise(nicksCar.EngineNoise);
            dariusCar.MakeEngineNoise(dariusCar.EngineNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

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
