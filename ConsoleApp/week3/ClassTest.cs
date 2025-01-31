
using ConsoleApp.week1;

namespace ConsoleApp.week3
{

    internal class ClassTest
    {
        public static void Run(int iCase)
        {
            switch (iCase)
            {
                case 1:
                    {
                        List<GameBase.Card> cards = new List<GameBase.Card>();
                        //for (byte rank = 9; rank <= 14; rank++)
                        for (byte rank = 14; rank >= 9; rank--)
                        {
                            cards.Add(new Euchre.Card(GameBase.CardSuit.Heart, rank));
                            //cards.Add(new Euchre.Card(GameBase.CardSuit.Spade, rank));
                            //cards.Add(new Euchre.Card(GameBase.CardSuit.Diamond, rank));
                            //cards.Add(new Euchre.Card(GameBase.CardSuit.Club, rank));
                        }
                        cards.Sort();
                    }
                    break;
                case 2: //implement interface
                        //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface
                    {
                        /*                        using (IDisposable person2 = new Person("FirstName", "LastName"))
                                                {
                                                    Console.WriteLine($"Dispose of Person will be called when out the scope");
                                                }*/
                        using (GameBase.Card card = new GameBase.Card(GameBase.CardSuit.Heart, 1))
                        {
                            Console.WriteLine(card.ToString());
                            card.Dispose();
                            Console.WriteLine($"Dispose of Person will be called when out the scope");
                        }
                    }
                    break;
            }
        }

    }
}
