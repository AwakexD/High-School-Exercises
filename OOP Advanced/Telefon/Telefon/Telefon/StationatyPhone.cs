using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon
{
    public class StationatyPhone
    {
        public StationatyPhone()
        {

        }
        public string Call(string number)
        {
            if (number.All(ch => char.IsDigit(ch)))
                throw new ArgumentException("Invalid number!");
            
            return $"Dialing... {number}";
        }
    }
}
