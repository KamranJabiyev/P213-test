using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            DrugType type1 = new DrugType("headache");
            DrugType type2 = new DrugType("stomachache");
            Console.WriteLine(type1.Id);
            Console.WriteLine(type2.Id);
        }
    }
}
