using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_and_Explicit_Tusks
{
    class Dollar
    {
        public decimal Sum { get; set; }
        public static explicit operator Euro(Dollar dollar)
        {
            return new Euro
            {
                Sum = dollar.Sum / 1.2M
            };
        }
        public static Dollar operator +(Dollar dollar1, Dollar dollar2)
        {
            Dollar dollar3 = new Dollar();
            dollar3.Sum = dollar1.Sum + dollar2.Sum;
            return dollar3;
        }
        public static Dollar operator +(Dollar dollar1, Euro euro1)
        {
            Dollar dollar2 = new Dollar();
            dollar2 = dollar1 + (Dollar)euro1;
            return dollar2;
        }
        public static Dollar operator +(Euro euro1, Dollar dollar1)
        {
            Dollar dollar2 = new Dollar();
            dollar2 = (Dollar)euro1 + dollar1;
            return dollar2;
        }
    }
}