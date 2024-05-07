using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Player : Entity
    {
        public override void TakeCard(Deck deck)
        {
            Card card = deck.TakeFromTop();
            Hand.AddToTop(card);
            Points += card.cardPoints;
            Console.WriteLine($"Вы взяли {card.cardName} {card.cardSuit}");
        }
        public override void CountHandPoints()
        {
            base.CountHandPoints();
            Console.WriteLine($"Ваши очки: {Points}");
        }

        public override void PrintHand()
        {
            Console.WriteLine("У Вас в руке:");
            base.PrintHand();
        }
    }
}
