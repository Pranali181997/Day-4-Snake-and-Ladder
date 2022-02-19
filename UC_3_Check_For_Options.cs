using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_And_Ladder
{
    class UC_3_Check_For_Options
    {
        public static void Check_For_3Option() 
        {
            Random random = new Random();
            int num = random.Next(0, 7);
            Console.WriteLine("You Got " + num);
            //constants
            const int Same_position = 0;
            const int Forword_Position = 1;

            Random random1 = new Random();
            int option1 = random.Next(0, 3);
            if(option1 == Same_position)
            {
                Console.WriteLine("You got No Play position");
            }
            else if(option1 == Forword_Position)
            {
                Console.WriteLine("You got Ladder by "+ num +"Number");
            }
            else
            {
                Console.WriteLine("You got Sanke by " + num + "Number");
            }
        }
    }
}
