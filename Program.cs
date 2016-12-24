using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLoadnRidding
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.add();
            obj.add(12,14);
            //Console.ReadLine();
            obj.multiply();
            Class2 obj1 = new Class2();
            obj1.multiply();
            Console.ReadLine();
        }
    }
}
