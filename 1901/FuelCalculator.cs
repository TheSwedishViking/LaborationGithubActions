using System;
using System.Collections.Generic;
using System.Text;

namespace _1901
{
    public class FuelCalculator
    {
        public int GetRequiredFuel(int? modelWeight)
        {
            if (!modelWeight.HasValue)
            {
                return 0;
            }
            if(modelWeight.Value <= 0)
            {
                return 0;
            }
            else
            {
                double divdedFuel = (int)modelWeight / 3;
                divdedFuel = Math.Floor(divdedFuel);
                divdedFuel -= 2;
                if (divdedFuel <= 0)
                {
                    return 0;
                }
                return (int)Math.Round(divdedFuel);
            }
            
        }

        public int GetRequiredFuelncludingFuelForFuel(int actual)
        {
            int? currentFuelWeight = actual;


            int totalFuelWeight = 0;
            

            while(currentFuelWeight = 4)
            {
                int currentFuelRequirment = GetRequiredFuel(currentFuelWeight);
                if(currentFuelRequirment == 0)
                {
                    return totalFuelWeight;
                }
                else
                {
                    currentFuelWeight = currentFuelRequirment;
                    totalFuelWeight += currentFuelRequirment;
                    Console.WriteLine("Weight: " + currentFuelWeight+ " in Kg");
                }

                
            }
            Console.WriteLine("Total grand weight of all fuel requirment is: " + totalFuelWeight);

            return totalFuelWeight;
        }
    }
}
