using BlackJack;

Game game = new Game();

while (game.IsInProgress == true)

if(game.Player.Points == 21 && game.Croupier.Points == 21)
{
    game.IsInProgress = false;
    game.Croupier.CountHandPoints();
    Console.WriteLine();
    Console.WriteLine("Ничья");
}
else if (game.Player.Points == 21)
{
    game.IsInProgress = false;
    game.Croupier.CountHandPoints();
    Console.WriteLine();
    Console.WriteLine("Вы выиграли!");
}
else if (game.Croupier.Points == 21 || game.Player.Points > 21)
{
    game.IsInProgress = false;
    game.Croupier.CountHandPoints();
    Console.WriteLine();
    Console.WriteLine("Вы проиграли!");
}
else if (game.Croupier.Points > 21 && game.Player.Points < 21)
    {
        game.IsInProgress = false;
        game.Croupier.CountHandPoints();
        Console.WriteLine();
        Console.WriteLine("Вы выиграли!");
    }
else
{
    Console.WriteLine("Взять новую карту? Y/N");
    string answer = Console.ReadLine();
    Console.WriteLine();

    if(answer == "Y")
    {
        game.Player.TakeCard(game.GameDeck);
        game.Croupier.TakeCard(game.GameDeck);
        Console.WriteLine();
        game.PrintHandInfo(game.Player);
    }
    else if(answer == "N")
    {
        game.IsInProgress = false;
        game.Croupier.CountHandPoints();
        Console.WriteLine();
        if(game.Player.Points > game.Croupier.Points)
        {
            Console.WriteLine("Вы выиграли!");
        }
        else 
        {
            Console.WriteLine("Вы проиграли!");
        }
    }
}
