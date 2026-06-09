using System;
namespace Bill
{
    class variable
    {
        public static void run()
        {
            Console.WriteLine("What's your name?");
            string username = Console.ReadLine();
            Console.WriteLine("Hello " + username);
            int num1;
            int num2;
            Console.WriteLine("num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
        }
    }
}
    
    