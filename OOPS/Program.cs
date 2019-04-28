using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 


            // 1 yo =u can access only normal methods by creating object of a class and not non-static metyhods
            private_Constructor p = new private_Constructor();
            p.NormalMethod1();

            // 2
            private_Constructor.StaticMethod1();

            //3. if constructor is private, you cannot create an object of a class
            private_Constructor p1 = private_Constructor.Instance;
            p1.NormalMethod1();

        }
    }
}
