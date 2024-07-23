using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{

    public static int numberOfCars = 0;
    public List<Car> ParkingLot { get; set; } = new List<Car>();

    public void CheckCars()
    {
        foreach (var carInLot in ParkingLot)
        {
            Console.WriteLine($"{carInLot.Year} {carInLot.Make} {carInLot.Model}");
        }
    }
}