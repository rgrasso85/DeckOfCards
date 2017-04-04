using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
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

