using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Game
    {
        public GameDeck GameDeck {get;set;}
        public Entity Croupier {get;set;}
        public Entity Player {get;set;}

        public bool IsInProgress { get;set;}

        public Game()
        {
            IsInProgress = true;

            GameDeck = new GameDeck();
            Croupier = new Croupier();
            Player = new Player();

            MakeFirstTMove(Player);
            MakeFirstTMove(Croupier);

            PrintHandInfo(Player);
        }

        private void MakeFirstTMove(Entity entity)
        {
            entity.TakeCard(GameDeck);
            entity.TakeCard(GameDeck);
            Console.WriteLine();
        }

        public void PrintHandInfo(Entity entity)
        {
            entity.PrintHand();
            entity.CountHandPoints();
            Console.WriteLine();
        }
    }
}
