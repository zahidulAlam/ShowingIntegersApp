using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowingIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Lower Limit Number: ");
            int lowerNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Upper Limit Number: ");
            int upperNumber = Convert.ToInt32(Console.ReadLine());
             
            if(lowerNumber>upperNumber)
            {
                Console.WriteLine("Wrong INPUT !!!");
            }
            else
            {
               Console.WriteLine("The Numbers are : ");
                for (int i = lowerNumber; i <= upperNumber; i++)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
