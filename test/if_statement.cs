using System;
namespace IF_stat
{
    class IF_statement
    {
        public static void execute()
        {
            Console.WriteLine("The item is 5$. Please insert cash.");
            int cash = Convert.ToInt32(Console.ReadLine());
            if(cash < 5)
            {
                Console.WriteLine("I need more!!!");
            }
            else
            {
                Console.WriteLine("thank you");
            }
            Console.ReadKey();
        }
    }
}