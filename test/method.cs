using System;
using System.Security.Cryptography;
namespace METHOD
{
    class Method
    {
        public void main()
        {
            meetalien();
            Console.WriteLine(multiply(2,5));
        }
        void meetalien()
        {
            Random numbergen = new Random();
            string name = "X- " + numbergen.Next(10, 1000);
            int age = numbergen.Next(10,500);

            Console.WriteLine("Hij, I'm " + name);
            Console.WriteLine("I'm " + age + "years old.");
        }
        int multiply(int num1 , int num2)
        {
           int result  = num1 * num2 ;
           return result; 
        }
    }
}