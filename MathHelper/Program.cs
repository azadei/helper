using System;
using System.Data.SqlTypes;
using System.Diagnostics.Contracts;

namespace MathHelper
{   public class Helper
    {
        public int PrintValue(int a,  int b)
        { 
            
            return a + b; 
        
        }
        public int PrintValue(bool a)
        {
            if (a == true) return 1;
            
            else return 0;
        }

        public string PrintValue(string a, string b)
        {
            return a + " " + b;
        }
        public int PrintValue(int a, int b, int c)
        {
            return (a * b * c);
        }



    }

    internal class Program
    {
        static void Main(string[] args)
        {
          var Helper = new Helper();

            int sum = Helper.PrintValue(10, 20);

            int z = Helper.PrintValue(true);

            string d = Helper.PrintValue("front", "back");

            int sum2 = Helper.PrintValue(5, 6, 7);

            Console.WriteLine("int sum = " + sum);
            Console.WriteLine(z);
            Console.WriteLine("string = " + d);
            Console.WriteLine("int2 = " + sum2);
        }
    }       
        
}
