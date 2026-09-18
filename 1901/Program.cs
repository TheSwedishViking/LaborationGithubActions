using AdventOfCode.Common;

namespace _1901
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var sut = new FuelCalculator();
            //sut.GetRequiredFuelncludingFuelForFuel(100756);


            var path = Path.Combine(AppContext.BaseDirectory, "input.txt");

            var sut = new FuelCalculator();

            string fuelDataString = File.ReadAllText(path);

            int[] numbers = Input.Numbers(fuelDataString);

            int totalRequirment = 0;
            foreach (var n in numbers)
            {

                Console.WriteLine($"Calculating fuel requirment for mass: {n}. Required is :{sut.GetRequiredFuelncludingFuelForFuel(n)}");
                totalRequirment += sut.GetRequiredFuelncludingFuelForFuel(n);
            }

            Console.WriteLine($"Total requirment is: {totalRequirment} !!!!!!");
        }
    }
}
