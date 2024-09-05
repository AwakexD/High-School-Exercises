using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Hotel
    {
        private string name;
        private int stars;
        List<Room> rooms;

        public Hotel(string name, int stars)
        {
            this.Name = name;
            this.Stars = stars;
            this.rooms = new List<Room>();
        }

        public string Name 
        {
            get { return name; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                this.name = value;
            }

        }
        public int Stars 
        {
            get { return stars; }
            set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentException("Invalid stars!");
                }
                this.stars = value;
            }
        }

        public void AddRoom(Room room)
        {
            this.rooms.Add(room);
        }

        public override string ToString() 
        {
            return $"{this.Name} - stars number: {this.Stars}. Number of rooms: {rooms.Count}";
        }
    }
}
