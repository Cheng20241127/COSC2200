
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
                        for (byte rank = 9; rank <= 14; rank++)
                        {
                            cards.Add(new Euchre.Card(GameBase.CardSuit.Heart, rank));
                            cards.Add(new Euchre.Card(GameBase.CardSuit.Spade, rank));
                            cards.Add(new Euchre.Card(GameBase.CardSuit.Diamond, rank));
                            cards.Add(new Euchre.Card(GameBase.CardSuit.Club, rank));
                        }
                        cards.Sort();
                    }
                    break;
                case 2:
                    {

                    }
                    break;
            }
        }

    }
}
