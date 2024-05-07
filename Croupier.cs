using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Croupier : Entity
    {
        public override void TakeCard(Deck deck)
        {
            Card card = deck.TakeFromTop();
            Hand.AddToTop(card);
            Points += card.cardPoints;
        }
        public override void CountHandPoints()
        {
            base.CountHandPoints();
            Console.WriteLine($"Количество очков крупье: {Points}");
        }

        public override void PrintHand()
        {
            Console.WriteLine("У крупье в руке:");
            base.PrintHand();
        }
    }
}
