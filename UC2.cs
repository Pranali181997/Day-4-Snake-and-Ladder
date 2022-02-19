using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_And_Ladder
{
    class UC_2_diceRoll
    {
        public static void diceRoll() 
        {
            Random random = new Random();
            int num = random.Next(0, 7);
            Console.WriteLine("You Got " + num);
        }
    }
}
