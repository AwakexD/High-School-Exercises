using System;

class Program
{
    static void Main(string[] args)
    {
        for (int suit = 1; suit <= 4; suit++)
        {
            for (int rank = 2; rank <= 14; rank++)
            {
                string card = GetCardName(rank) + GetSuitSymbol(suit);
                Console.Write(card + " ");
            }
            Console.WriteLine();
        }
    }

    static string GetCardName(int rank)
    {
        switch (rank)
        {
            case 11:
                return "J";
            case 12:
                return "Q";
            case 13:
                return "K";
            case 14:
                return "A";
            default:
                return rank.ToString();
        }
    }

    static string GetSuitSymbol(int suit)
    {
        switch (suit)
        {
            case 1:
                return "♠";
            case 2:
                return "♦";
            case 3:
                return "♥";
            case 4:
                return "♣";
            default:
                throw new ArgumentException("Invalid suit");
        }
    }
}