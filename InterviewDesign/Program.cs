using System;
using InterviewDesign.AlgorithmDesign;
using InterviewDesign.DesignPattern.DecoratorDesignPattern;

namespace InterviewDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            // test GreedyAlgorithm
            var greedyAlgorithm = new GreedyAlgorithm();
            var result = greedyAlgorithm.SmallestNumberOfCoins(new[] { 5, 2, 1 }, 17);

            Console.WriteLine("greedyAlgorithm.SmallestNumberOfCoins(new[] { 5,2, 1 }, 17)");
            Console.WriteLine($"result: {result}");

            Console.ReadKey();

            // desing Decorator pattern
            //Create EcomomyCar instance.   
            ICar objCar = new OffRaodCar();

            //Wrp EconomyCar instancw with BasicAccessories.   
            PackageDecorator decorator = new BasicPackage(objCar);
        }
    }
}