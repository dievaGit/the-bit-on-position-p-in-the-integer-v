using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring data
            int v = 0, p = 0;

            //Requesting data from the user
            Console.Write(" Enter the number: ");
            v = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter the posicion: ");
            p = Convert.ToInt32(Console.ReadLine());

            int i = 1, move = 0;

            // Moving 1 to the given position
            move = i << (p - 1);

            if ((v & move) == 0)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

            Console.ReadKey();
        }
    }
}
