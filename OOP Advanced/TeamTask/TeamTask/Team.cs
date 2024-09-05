using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TeamTask
{
    public class Team
    {
		private string name;
		private string city;
		List<Player> players;

        public Team(string n, string c)
        {
            Name = n;
			City = c;
			players = new List<Player>();
        }

        public string Name
		{
			get { return this.name; }
			set 
			{
				if(string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Invalid name!");
				}
				this.name = value;
			}
		}


		public string City
		{
			get { return city; }
			set 
			{ 
				if(value.Length < 3)
				{
					throw new ArgumentException("Invalid city!");
				}
				this.city = value;
			}
		}

		public void AddPlayer (Player player)
		{
			this.players.Add(player);
		}

		private string GetMaxSalary() => this.players.Max(x => x.Salary).ToString();

		public override string ToString()
		{
			return $"{this.Name} from {this.City} - max salary {this.GetMaxSalary():f2}";
		}
	}
}
