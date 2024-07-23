using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            var alexsCarLot = new CarLot();

            //Done-Create a seperate class file called Car
            //Done-Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Done-Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //Done-The methods should take one string parameter: the respective noise property


            //Done-Now that the Car class is created we can instanciate 3 new cars
            //Done-Set the properties for each of the cars
            //Done-Call each of the methods for each car

            
            //Instantiation 1
            var car1 = new Car();
            car1.Make = "Chevy";
            car1.Model = "Silverado";
            car1.Year = 2011;
            car1.EnginNoise = "Vroom";
            car1.HonkNoise = "Honk";
            car1.MakeEngineNoise();
            car1.MakeHonkNoise();
            alexsCarLot.ParkingLot.Add(car1);



            //Instantiation 2
            var car2 = new Car()
            {
                Make = "Ford",
                Model = "F-150",
                Year = 2018,
                EnginNoise = "Vroom",
                HonkNoise = "Honk"
            };
            car2.MakeEngineNoise();
            car2.MakeHonkNoise();
            alexsCarLot.ParkingLot.Add(car2);

            //Instantiation 3
            var car3 = new Car("Chevy", "Malibu",2023,true,"Vroom","Honk");
            alexsCarLot.ParkingLot.Add(car3);
            
            alexsCarLot.CheckCars();

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            //*************BONUS*************//

            //Done - Set the properties utilizing the 3 different ways we learned about, one way for each car
            
            

            //*************BONUS X 2*************// -Done

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            
            
        } 
    }
}
