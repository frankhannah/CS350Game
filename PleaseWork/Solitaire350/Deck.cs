using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS350.Solitaire.Design
{

    public class Deck : CS350.Solitaire.Design.IDeck
    {
        public const int CAPACITY = 52;

        private Card[] deckOfCards_ = new Card[CAPACITY];

        public Deck()
        {
            size_ = 0;

            for (int i = 0; i < Card.MAX_SUIT; i++)
            {
                for (int j = 0; j < Card.MAX_RANK; j++)
                {
                    deckOfCards_[size_] = new Card((Card.RankType)j, (Card.SuitType)i);
                    size_++;
                }
            }

        }

        //swaps the position of two cards in the deck
        public void swap(int lhs, int rhs)
        {
            Card tempCard = new Card(deckOfCards_[lhs]);
            deckOfCards_[lhs] = deckOfCards_[rhs];
            deckOfCards_[rhs] = tempCard;
        }

        //overrides [] operator for Deck
        public Card this[int index]
        {
            get
            {
                return deckOfCards_[index];
            }
            set
            {
                deckOfCards_[index] = value;
            }
        }

        public void shuffle()
        {
            Random randomNumber = new Random();

            for (int card = 0; card < CAPACITY; ++card)
            {
                swap(card, randomNumber.Next(CAPACITY));
            }
        }

        public void printDeck()
        {
            for (int i = 0; i < size_; i++)
            {
                Console.WriteLine("{0}", deckOfCards_[i]);
            }
        }

        public Card top()
        {
            if (size_ > 0) //if there are cards in our deck
                return deckOfCards_[size_ - 1]; //the top one is the last one put into the deck
            else
                return null;
        }

        public void pop()
        {
            if (size_ > 0)
                size_--;   
        }
        public int size_ { get; private set; }

    }
}
