using Microsoft.VisualBasic;

namespace DiceGame;

class Program
{
    static void Main()
    {
        System.Console.WriteLine("tryck y för att kasta tärningarna");
        var key = Console.ReadLine();

        if(key != "y")
        {
            System.Console.WriteLine("Fel knapp");
        }
        else if(key == "y")
        {
            Game();
        }
    }

    static void Game()
    {
        Random random = new();
        var dice1 = random.Next(1, 7);
        var dice2 = random.Next(1, 7);

        var diceSum = dice1 + dice2;
        try
        {
            while (true)
            {
                System.Console.WriteLine("Tärning 1: " + dice1);
                System.Console.WriteLine("Tärning 2: " + dice2);
                System.Console.WriteLine("Summan: " + diceSum);

                if(diceSum == 12)
                {
                    System.Console.WriteLine("Grattis, du vann spelet!");
                }
                else
                {
                    System.Console.WriteLine("Du vann inte");
                }

                System.Console.WriteLine("Vill du spela igen? (y/n)");
                var playAgain = Console.ReadLine();

                switch (playAgain)
                {
                    case "y":
                        Game();
                        return;
                    case "n":
                        System.Console.WriteLine("Hejdå!");
                        Environment.Exit(0);
                        break;
                }
                
            }
        }
        catch(Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }
}
