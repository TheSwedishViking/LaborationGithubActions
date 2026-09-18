using System;
using System.Collections.Generic;
using System.Text;

namespace _1510.Calculation
{
    public class WordCounter
    {
        public string CountNumberSequence(string inputSequence)
        {

            char[] numberArray = inputSequence.ToCharArray();
            string completeString = "";

            int currentRepeatingNumberCount = 1;

            for (int i = 0; i < numberArray.Length; i++)
            {
                if (char.IsNumber(numberArray[i]))
                {
                    //Limit array out of bounds, end here
                    if (i + 1 >= numberArray.Length)
                    {
                        completeString += currentRepeatingNumberCount;
                        completeString += numberArray[i];

                    }
                    else
                    {
                        //If next is different
                        if (numberArray[i] != numberArray[i + 1])
                        {
                            completeString += $"{currentRepeatingNumberCount}{numberArray[i]}";
                            currentRepeatingNumberCount = 1;
                        }
                        else
                        {
                            currentRepeatingNumberCount++;
                        }
                    }
                }
                
            }
            return completeString;

        }
    }
}
