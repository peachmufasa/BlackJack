using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Node
    {
        public Card Card { get; set; }
        public Node Next { get; set; }

        public Node(Card card)
        {
            Card = card;
            Next = null;
        }
    }
}
