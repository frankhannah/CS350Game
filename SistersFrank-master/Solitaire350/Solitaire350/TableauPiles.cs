using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS350.Solitaire.Design
{
    public class TableauPiles
    {

        //How should the tableau piles be implemented? As a 2D array filled with Cards? 
        public TableauPiles(int numPiles)
        {
            howManyPiles_ = numPiles;

            Card NULLCARD = new Card(Card.RankType.NULLRANK, Card.SuitType.NULLSUIT);
            for (int pile = 0; pile < howManyPiles_; pile++)
            {
                for (int cardInPile = 0; cardInPile < Card.MAX_RANK; cardInPile++)
                {
                    //go through in and fill in each tableau pile with a null card
                    Piles_[cardInPile, pile] = new Card(NULLCARD);
                }
            }
        }

        private Card[,] Piles_ = new Card[Card.MAX_RANK, 52]; //Piles_ is a private data member 
        //which is a 2D Array of cards

        /// <summary>
        /// Add Card to Tableau Pile
        /// </summary>
        /// <param name="cardToAdd">card to add</param>
        /// <param name="whichPile">while pile to add to</param>
        public void AddCardToPile(Card cardToAdd, int whichPile)
        {
            if (whichPile < howManyPiles_)
            {
                Card NULLCARD = new Card(Card.RankType.NULLRANK, Card.SuitType.NULLSUIT);
                int currentCard = 0;
                //Find the top of that pile
                while (!(NULLCARD.isEqual(Piles_[currentCard, whichPile])))
                {
                    ++currentCard;
                }

                Piles_[currentCard, whichPile - 1] = new Card(cardToAdd); //place card in that spot
            }
        }

        /// <summary>
        /// Get a card from a particular pile on the Tableau
        /// </summary>
        /// <param name="numOfCardInPile">which card in the pile</param>
        /// <param name="PileNum">while pile</param>
        /// <returns></returns>
        public Card getCardFromPile(int numOfCardInPile, int PileNum)
        {
            return Piles_[numOfCardInPile - 1, PileNum - 1];
        }

        public int numCardsInPile(int PileNum)
        {
            int numCards = 0;
            Card NULLCARD = new Card(Card.RankType.NULLRANK, Card.SuitType.NULLSUIT);
            if (PileNum <= howManyPiles_)
            {
                while (!(NULLCARD.isEqual(Piles_[numCards, PileNum - 1])))
                {
                    ++numCards;
                }
            }
            return numCards;
        }

        public int howManyPiles_ { get; private set; }

    }
}
