using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon
{
    public class SmartPhone:ICallable 
    {
        public string Browse(string url)
        {
            if(url.Any(ch=>char.IsDigit (ch)))
            {
                throw new ArgumentException("Invalid URL!");
            }
            return $"Browsing: {url}";
        }
        public string Call(string number)
        {
            if(number.All(ch=>char.IsDigit (ch)))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Calling... {number}!";
        }
    }
}
