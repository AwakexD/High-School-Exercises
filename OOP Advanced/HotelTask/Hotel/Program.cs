namespace Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Hotel> hotels = new List<Hotel>();

                string input = Console.ReadLine();
                while (input.ToLower() != "exit") 
                {
                    string[] hotelData = input.Split(',');
                    hotels.Add(new Hotel(hotelData[0], int.Parse(hotelData[1])));

                    string[] roomsData = Console.ReadLine().Split(' ');


                    for (int i = 0; i < roomsData.Length; i+=2)
                    {
                        hotels.Last().AddRoom(new Room(int.Parse(roomsData[i]), decimal.Parse(roomsData[i + 1])));
                    }

                    input = Console.ReadLine();
                }

                foreach (Hotel item in hotels)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}