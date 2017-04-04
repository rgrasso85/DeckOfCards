using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card
    {
        private string value;
        private string suit;

        public Card(string cardValue, string cardSuit)
        {
            value = cardValue;
            suit = cardSuit;
        }

        public override string ToString()
        {
            return value + " of " + suit;
        }
    }
}
