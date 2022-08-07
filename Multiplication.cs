
//SquarRoot Program

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Multiplication
    {
        public static void Display()
        {
            Console.Write("Display the multiplication table:\n");
            
            Console.Write("Input the number  : ");

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 2; ;)
                {
                    Console.WriteLine($"{j} x {i} = {i * j}");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
    

