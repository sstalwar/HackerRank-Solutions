using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmup
    {
    class Program
        {
        static void Main (string[] args)
            {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            var solveMeFirst = new SolveMeFirst(val1, val2);
            Console.ReadKey();
            }
        }
    }
