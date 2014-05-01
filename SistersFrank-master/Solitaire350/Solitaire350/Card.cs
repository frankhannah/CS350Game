using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS350.Solitaire.Design
{

    public class Card : CS350.Solitaire.Design.ICard
    {
        public const int MAX_SUIT = 4;
        public const int MAX_RANK = 13;
        public enum SuitType { HEARTS, DIAMONDS, CLUBS, SPADES, NULLSUIT};
        public enum RankType { ACE, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, NULLRANK};

        public Card(RankType rank, SuitType suit)
        {
            Rank = rank;
            Suit = suit;
        }

        //copy constructor
        public Card(Card orig)
        {
            Rank = orig.Rank;
            Suit = orig.Suit;
        }

        public bool isEqual(Card rhs)
        {
            return (rhs.Suit == Suit && rhs.Rank == Rank);
        }

        public void printCard()
        {
            switch (Rank)
            {
                case RankType.ACE:
                    System.Console.WriteLine("A");
                    break;
                case RankType.TWO:
                    System.Console.WriteLine("2");
                    break;
                case RankType.THREE:
                    System.Console.WriteLine("3");
                    break;
                case RankType.FOUR:
                    System.Console.WriteLine("4");
                    break;
                case RankType.FIVE:
                    System.Console.WriteLine("5");
                    break;
                case RankType.SIX:
                    System.Console.WriteLine("6");
                    break;
                case RankType.SEVEN:
                    System.Console.WriteLine("7");
                    break;
                case RankType.EIGHT:
                    System.Console.WriteLine("8");
                    break;
                case RankType.NINE:
                    System.Console.WriteLine("9");
                    break;
                case RankType.TEN:
                    System.Console.WriteLine("10");
                    break;
                case RankType.JACK:
                    System.Console.WriteLine("J");
                    break;
                case RankType.QUEEN:
                    System.Console.WriteLine("Q");
                    break;
                case RankType.KING:
                    System.Console.WriteLine("K");
                    break;
            }

            switch (Suit)
            {
                case SuitType.HEARTS:
                    System.Console.WriteLine("{0}", (char)3);
                    break;
                case SuitType.DIAMONDS:
                    System.Console.WriteLine("{0}", (char)4);
                    break;
                case SuitType.CLUBS:
                    System.Console.WriteLine("{0}", (char)5);
                    break;
                case SuitType.SPADES:
                    System.Console.WriteLine("{0}", (char)6);
                    break;
            }
        }
        
        public RankType Rank { get; private set; }
        public SuitType Suit { get; private set; }
    }
}
