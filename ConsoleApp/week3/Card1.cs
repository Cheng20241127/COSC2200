namespace GameBase
{
    public enum CardSuit
    {
        Heart,
        Diamond,
        Club,
        Spade
    }
    public class Card : IComparable<Card>
    {
        public CardSuit Suit { get; private set; }
        protected byte rank;
        public string Rank { 
            get {                
                switch (rank)
                {
                    case 1:
                    case 14:
                        return "A";
                    case 11:
                        return "J";
                    case 12:
                        return "Q";
                    default:
                        if (rank <= 10) return rank.ToString();
                        else return "K";
                }
            }
        }
        public Card(string suit, string rank)
        {
            switch (suit)
            {
                case "Hearts":
                case "hearts":
                case "H":
                case "h":
                    Suit = CardSuit.Heart;
                    break;
                case "Diamonds":
                case "D":
                case "d":
                    Suit = CardSuit.Diamond;
                    break;
                case "Clubs":
                case "C":
                case "c":
                    Suit = CardSuit.Club;
                    break;
                case "Spades":
                case "S":
                case "s":
                    Suit = CardSuit.Spade;
                    break;
                default:
                    throw new Exception("Wrong suit");
            }
            switch (rank)
            {
                case "A":
                case "Ace":
                    this.rank = 1;break;
                case "J":
                case "Joker":
                    this.rank = 11; break;
                case "Q":
                case "Queen":
                    this.rank = 12; break;
                case "K":
                case "King":
                    this.rank = 13; break;
                default: this.rank = byte.Parse(rank); break;
            }
            if (this.rank > 13)
            {
                throw new Exception("Wrong rank");
            }
        }
        public Card(CardSuit suit, byte rank)
        {
            Suit = suit;
            this.rank = rank;
        }
        public void TurnA()
        {
            if (this.rank == 14)
                this.rank = 1;
            else if (this.rank == 1)
                this.rank = 14;
        }
        public override string ToString()
        {
            return $"{Suit}{Rank}";
        }
        public virtual int CompareTo(Card? other)
        {
            if (other == null) return 1;
            return rank.CompareTo(other.rank);
        }
    }
}
