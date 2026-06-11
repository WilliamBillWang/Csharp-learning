using System;
using System.Globalization;
namespace LOOPS_PRACTICE
{
    class LOOPS
    {
        public static void loops()
        {   
            // Console.WriteLine("How many cool number do you want:");
            // int count = Convert.ToInt16(Console.ReadLine());

            // for(int i =0; i< count; i++)
            //     {
            //         int result = Convert.ToInt32(Math.Pow(2,i));
            //         Console.WriteLine(result);
            //     } 
            
            Console.WriteLine("press Enter to roll a dice");
            Random dice = new Random();
            int roll = 0;
            int attempts = 0;
            while(roll != 6)
            {   
                Console.ReadKey();
                roll = dice.Next(1,7);
                Console.WriteLine("you get " + roll);
                attempts ++;
            }
            Console.WriteLine("You've tried " + attempts);
        }
    
    }
}