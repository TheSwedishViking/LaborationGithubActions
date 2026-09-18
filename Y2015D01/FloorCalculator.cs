using System;
using System.Collections.Generic;
using System.Text;

namespace Y2015D01
{
    public class FloorCalculator
    {
        public int CountFloors(string floors)
        {
            int floorChange  = 0;
            char[] walkedFloors = floors.ToCharArray();

            foreach (char c in walkedFloors)
            {
                if(c == '(')
                {
                    floorChange++;
                }
                else if(c == ')')
                {
                    floorChange --;
                }
            }
            return floorChange;
        }
    }
}
