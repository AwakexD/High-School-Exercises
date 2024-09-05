using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Room
    {
        public int RoomNumber { get; set; }
        public decimal Price { get; set; }

        public Room(int number, decimal price)
        {
            this.RoomNumber = number;   
            this.Price = price;
        }
    }
}
