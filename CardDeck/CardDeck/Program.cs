using System;

namespace CardDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the card notation (Rank suit e.g. 5H or AD): ");
            string theCard = Console.ReadLine();
            string firstSign = theCard.Substring(0, 1);
            string secondSign = theCard.Substring(1, 1);

            Card newCard = new Card(firstSign, secondSign);
            Console.WriteLine(newCard.ToString());

        }
    }
}
