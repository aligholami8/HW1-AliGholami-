using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current date & time is {0}", DateTime.Now);
            Console.WriteLine("The current date is {0:dd / MM / yyy}", DateTime.Now);
            
            Console.Read();
        }
    }
}
