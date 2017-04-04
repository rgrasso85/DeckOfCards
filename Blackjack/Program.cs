using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(newDeck.deck[i]);
               
            }
            Console.ReadLine();
        }
    }
}

