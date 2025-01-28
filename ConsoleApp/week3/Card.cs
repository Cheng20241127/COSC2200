
namespace Euchre
{
    public class Card : GameBase.Card
    {
        public Card(GameBase.CardSuit suit, byte rank) : base(suit,rank) {
            Console.WriteLine("Euchre.Card constructor");
        }
        public override int CompareTo(GameBase.Card? other)
        {
            if (other is Card otherChild)
            {
                return rank.CompareTo(otherChild.rank);
            }
            return base.CompareTo(other);
        }
    }
}
