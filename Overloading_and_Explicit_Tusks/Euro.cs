using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_and_Explicit_Tusks
{
    class Euro
    {
        public decimal Sum { get; set; }
        public static explicit operator Dollar(Euro euro)
        {
            return new Dollar
            {
                Sum = euro.Sum * 1.2M
            };
        }
        public static Euro operator +(Euro euro1, Euro euro2)
        {
            Euro euro3 = new Euro();
            euro3.Sum = euro1.Sum + euro2.Sum;
            return euro3;
        }
    }
}
