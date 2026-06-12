using System;
using System.Collections.Generic;
namespace ARRAY
{
    class array_practice
    {
        public static void run()
        {   
            string[] len = new string[8];
            string[] movies = {"lord of ring", "fight club", "top gun"};
            for(int i = 0; i< movies.Length; i++)
            {
                int rank = i + 1;
                Console.WriteLine(rank + ", " + movies[i]);
            }
            List<string> shoppinglist = new List<string>();
            shoppinglist.Add("Dreams");
            shoppinglist.Add("Sony");
            for(int i = 0; i < shoppinglist.Count;i++)
            {
                Console.WriteLine(shoppinglist[i]);
            }
            shoppinglist.RemoveAt(0);
            for(int i = 0; i < shoppinglist.Count;i++)
            {
                Console.WriteLine(shoppinglist[i]);
            }
        }
    }
}