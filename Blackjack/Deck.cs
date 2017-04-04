using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    
    public class Deck
    {
        public Card[] deck;
        private int deckSize = 52;

        public Deck()
        {
            string[] value = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Spades", "Clubs", "Hearts", "Diamonds" };
            deck = new Card[deckSize];
            for (int i = 0; i < deck.Length; i++)
                deck[i] = new Card(value[i % 13], suits[i / 13]);
        }
    }
}
