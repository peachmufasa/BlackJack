using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Entity
    {
        public Deck Hand { get; set; }

        public int Points { get; set; }

        public Entity()
        {
            Hand = new Deck();
            Points = 0;
        }

        public virtual void TakeCard(Deck deck)
        {
            Card card = deck.TakeFromTop();
            Hand.AddToTop(card);
            Points += card.cardPoints;
        }

        public virtual void CountHandPoints()
        {
            Points = Hand.CountPoints();
        }

        public virtual void PrintHand()
        {
            Node curr = Hand.Head;
            while (curr != null)
            {
                Console.WriteLine($"{curr.Card.cardName} {curr.Card.cardSuit}");
                curr = curr.Next;
            }
        }
    }
}
