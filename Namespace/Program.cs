using System;
using Namespace.Andrew;
using Vasya.hiVasya;

namespace Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            NameAndrew Indrew = new NameAndrew();
            NameIgor Igor = new NameIgor();
            NameVasya vasya2 = new NameVasya();
            Vasya.hiVasya.NameVasya vasya = new Vasya.hiVasya.NameVasya();
        }
    }

    class NameIgor
    {
        static NameIgor()
        {
            Console.WriteLine("\nhi, Igor");
        }
    }

    namespace Andrew
    {
        class NameAndrew
        {
            static NameAndrew()
            {
                Console.WriteLine("\nhi, Andrew");
            }
        }
    }
}

namespace Vasya
{
    namespace hiVasya
    {

        class NameVasya
        {
            static NameVasya()
            {
                Console.WriteLine("\nhi, Vasya"); ;
            }
        }
    }
}
