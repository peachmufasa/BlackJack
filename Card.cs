using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Card
    {
        public string cardName { get; private set; }

        public string cardSuit { get; private set; }
        public int cardPoints { get; private set; }

        public Card(string cardName, string cardSuit, int cardPoints)
        {
            this.cardName = cardName;
            this.cardSuit = cardSuit;
            this.cardPoints = cardPoints;
        }
    }
}
