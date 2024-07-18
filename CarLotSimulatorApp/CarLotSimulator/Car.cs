using System;
using System.Dynamic;
using System.Xml.Schema;

namespace CarLotSimulator;

public class Car
{
        //Default constructor
    public Car()
    {
        
    }
    //Constructor with perams
    public Car(string make,
        string model,
        int year,
        bool isDrivable,
        string enginNoise,
        string honkNoise)
    {
        Year = year;
        Model = model;
        Make = make;
        IsDrivable = isDrivable;
        EnginNoise = enginNoise;
        HonkNoise = honkNoise;
    }

    //Properties for Car class
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year {get; set; }
    public bool IsDrivable { get; set; }
    public string EnginNoise { get; set; }
    public string HonkNoise { get; set; }
    
    
            //Methods for Car class
    public void MakeEngineNoise()
    {
        
        Console.WriteLine($"This cars engine sounds like {EnginNoise}"); 
    }

    public void MakeHonkNoise()
    {
        Console.WriteLine($" The horn on this car sounds like {HonkNoise}");
    }

   








}