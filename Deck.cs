using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Deck
    {
        public Node? Head { get; set; }
        public int Length { get; set; }
        public Deck() 
        { 
            Head = null;
            Length = 0;
        }

        public void AddToTop(Card card)
        {
            if (Head == null)
            {
                Head = new Node(card);
            }
            else
            {
                Node newNode = new Node(card);
                newNode.Next = Head;
                Head = newNode;
            }

            Length++;
        }

        public Card TakeFromTop()
        {
            if (Head == null)
            {
                return null;
            }
            else
            {
                Card card = Head.Card;
                Head = Head.Next;
                Length--;
                return card;
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            int positionIndex = random.Next(0, Length);

            Node newNode = new Node(TakeFromTop());
            Node current = Head;
            Node previous = null;
            int currentIndex = 0;

            while (current != null && currentIndex < positionIndex)
            {
                previous = current;
                current = current.Next;
                currentIndex++;
            }

            if(previous != null)
            {
                previous.Next = newNode;
                newNode.Next = current;
            }

            Length++;
        }

        public int CountPoints()
        {
            int points = 0;
            Node curr = Head;
            while (curr != null)
            {
                points += curr.Card.cardPoints;
                curr = curr.Next;
            }

            return points;
        }

        public void Print()
        {
            Node curr = Head;
            while (curr != null)
            {
                Console.WriteLine($"{curr.Card.cardName} of {curr.Card.cardSuit}");
                curr = curr.Next;
            }
        }
    }
}
