using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CardDeck
{
    class Card
    {
        //attributes:
     
        private string rank;
        private string suit;
        private string newRank;
        private string newSuit;

        //properties:
        Card()
        {
        }
        //Parameter values:
        public Card(string firstSign, string secondSign )
        {
            rank = firstSign;
            suit = secondSign; 
        }
        //Instance method:


        public string GetRank()
        {
            if (int.TryParse(rank, out int num))
            {
                if (num == 2)
                {
                    newRank = "Two";
                }
                if (num == 3)
                {
                    newRank =  "Three";
                }
                if (num == 4)
                {
                    newRank = "Four";
                }
                if (num == 5)
                {
                    newRank = "Five";
                }
                if (num == 6)
                {
                    newRank = "Six";
                }
                if (num == 7)
                {
                    newRank = "Seven";
                }
                if (num == 8)
                {
                    newRank = "Eight";
                }
                if (num == 9)
                {
                    newRank =  "Nine";
                }
            }
            else 
            {
                if (rank == "T" ||  rank == "10")
                {
                    newRank = "Ten";
                }
                if (rank == "A")
                {
                    newRank = "Ace";
                }
                if (rank == "J")
                {
                    newRank =  "Jack";
                }
                if (rank == "Q")
                {
                    newRank = "Queen";
                }
                if (rank == "K")
                {
                    newRank = "King";
                }
            }
            return newRank;
        }
        public string GetSuit()
        {
            if (suit == "C")
            {
                newSuit = "Clubs";
            }
            if (suit == "D")
            {
                newSuit = "Diamonds";
            }
            if (suit == "H")
            {
               newSuit = "Hearts";
            }
            if (suit == "S")
            {
                newSuit = "S";
            }
            return newSuit;
        }
        public override string ToString()
        {
            return

                "Your card is the " + GetRank() + " of " + GetSuit();
            
        }

    }

}
