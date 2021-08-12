using System;

namespace Overloading_and_Explicit_Tusks
{
    class Program
    {
        static void Main(string[] args)
        {
            Dollar dollar1 = new Dollar();
            dollar1.Sum = 50;
            Euro euro1 = new Euro();
            euro1 = (Euro)dollar1;
            Console.WriteLine(euro1.Sum);
            Euro euro2 = new Euro();
            euro2.Sum = 10;
            Dollar dollar3 = dollar1 + euro2;
            Console.WriteLine(dollar3.Sum);
        }
    }
}
