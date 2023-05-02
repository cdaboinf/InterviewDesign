using System;
using DesignPatterns.DesignPattern.Behavioral_ObserverDesignPattern;

namespace InterviewDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            //*** Algorithms ***//

            //** Greed Algorithm **//
            //var greedyAlgorithm = new GreedyAlgorithm();
            //var result = greedyAlgorithm.SmallestNumberOfCoins(new[] { 5, 2, 1 }, 17);

            //Console.WriteLine("greedyAlgorithm.SmallestNumberOfCoins(new[] { 5,2, 1 }, 17)");
            //Console.WriteLine($"result: {result}");

            //*** Desing Pattern ***//

            //** Structural-Decorator pattern **//
            //Create EcomomyCar instance.   
            //ICar objCar = new OffRaodCar();

            //Wrap EconomyCar instancw with BasicAccessories.   
            //PackageDecorator decorator = new BasicPackage(objCar);

            //** Behavioral-Observer pattern **//
            BaggageHandler provider = new BaggageHandler();
            ArrivalsMonitor observer1 = new ArrivalsMonitor("BaggageClaimMonitor1");
            ArrivalsMonitor observer2 = new ArrivalsMonitor("SecurityExit");

            provider.BaggageStatus(712, "Detroit", 3);
            //observer1.Subscribe(provider);
            provider.BaggageStatus(712, "Kalamazoo", 3);
            provider.BaggageStatus(400, "New York-Kennedy", 1);
            provider.BaggageStatus(712, "Detroit", 3);
            observer2.Subscribe(provider);
            provider.BaggageStatus(511, "San Francisco", 2);
            //provider.BaggageStatus(712);
            observer2.Unsubscribe();
            //provider.BaggageStatus(400);
            provider.LastBaggageClaimed();

            Console.ReadKey();
        }
    }
}