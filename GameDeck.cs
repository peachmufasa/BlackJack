using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class GameDeck : Deck
    {
        public GameDeck() 
        {
            AddToTop(new Card("2", "D", 2));
            AddToTop(new Card("2", "C", 2));
            AddToTop(new Card("2", "H", 2));
            AddToTop(new Card("2", "S", 2));
            AddToTop(new Card("3", "D", 3));
            AddToTop(new Card("3", "C", 3));
            AddToTop(new Card("3", "H", 3));
            AddToTop(new Card("3", "S", 3));
            AddToTop(new Card("4", "D", 4));
            AddToTop(new Card("4", "C", 4));
            AddToTop(new Card("4", "H", 4));
            AddToTop(new Card("4", "S", 4));
            AddToTop(new Card("5", "D", 5));
            AddToTop(new Card("5", "C", 5));
            AddToTop(new Card("5", "H", 5));
            AddToTop(new Card("5", "S", 5));
            AddToTop(new Card("6", "D", 6));
            AddToTop(new Card("6", "C", 6));
            AddToTop(new Card("6", "H", 6));
            AddToTop(new Card("6", "S", 6));
            AddToTop(new Card("7", "D", 7));
            AddToTop(new Card("7", "C", 7));
            AddToTop(new Card("7", "H", 7));
            AddToTop(new Card("7", "S", 7));
            AddToTop(new Card("8", "D", 8));
            AddToTop(new Card("8", "C", 8));
            AddToTop(new Card("8", "H", 8));
            AddToTop(new Card("8", "S", 8));
            AddToTop(new Card("9", "D", 9));
            AddToTop(new Card("9", "C", 9));
            AddToTop(new Card("9", "H", 9));
            AddToTop(new Card("9", "S", 9));
            AddToTop(new Card("10", "D", 10));
            AddToTop(new Card("10", "C", 10));
            AddToTop(new Card("10", "H", 10));
            AddToTop(new Card("10", "S", 10));
            AddToTop(new Card("J", "D", 10));
            AddToTop(new Card("J", "C", 10));
            AddToTop(new Card("J", "H", 10));
            AddToTop(new Card("J", "S", 10));
            AddToTop(new Card("Q", "D", 10));
            AddToTop(new Card("Q", "C", 10));
            AddToTop(new Card("Q", "H", 10));
            AddToTop(new Card("Q", "S", 10));
            AddToTop(new Card("K", "D", 10));
            AddToTop(new Card("K", "C", 10));
            AddToTop(new Card("K", "H", 10));
            AddToTop(new Card("K", "S", 10));
            AddToTop(new Card("A", "D", 11));
            AddToTop(new Card("A", "C", 11));
            AddToTop(new Card("A", "H", 11));
            AddToTop(new Card("A", "S", 11));

            for (int i = 0; i < Length; i++)
            {
                Shuffle();
            }

        }
    }
}
