using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CS350.Solitaire.Design
{
    
    [TestFixture]
    public class TestTableauPiles
    {
        [Test]
        public void createTableau()
        {
            TableauPiles myTableau = new TableauPiles(7);
            Assert.IsTrue(typeof(TableauPiles).IsInstanceOfType(myTableau));
        }

        [Test]
        public void isTableauFilledWithNullCards()
        {
            const int NUM_PILES = 7;
            TableauPiles myTableau = new TableauPiles(NUM_PILES);
            Card NULLCARD = new Card(Card.RankType.NULLRANK, Card.SuitType.NULLSUIT);
            Assert.AreEqual(myTableau.getCardFromPile(1, 1).Rank, NULLCARD.Rank); //first card in first pile
            Assert.AreEqual(myTableau.getCardFromPile(1, 1).Rank, NULLCARD.Rank); 
            Assert.AreEqual(myTableau.getCardFromPile(Card.MAX_RANK, NUM_PILES).Rank, NULLCARD.Rank); //last card in last place
            Assert.AreEqual(myTableau.getCardFromPile(Card.MAX_RANK, NUM_PILES).Rank, NULLCARD.Rank);
        }

        [Test]
        public void addCardToTableauPile()
        {
            const int NUM_PILES = 7;
            TableauPiles myTableau = new TableauPiles(NUM_PILES);
            const int pileToAdd = 3;
            Card addCard = new Card(Card.RankType.ACE, Card.SuitType.DIAMONDS);
            Card NULLCARD = new Card(Card.RankType.NULLRANK, Card.SuitType.NULLSUIT);
            Assert.AreEqual(myTableau.getCardFromPile(1,3).Rank, NULLCARD.Rank); 
            Assert.AreEqual(myTableau.getCardFromPile(1, 3).Rank, NULLCARD.Rank); 
            myTableau.AddCardToPile(addCard, pileToAdd);
            Assert.AreEqual(myTableau.getCardFromPile(1, 3).Rank, addCard.Rank); 
            Assert.AreEqual(myTableau.getCardFromPile(1, 3).Rank, addCard.Rank); 
        }

        [Test]
        public void howManyCardsInAPile()
        {
            const int NUM_PILES = 7;
            TableauPiles myTableau = new TableauPiles(NUM_PILES);
            //make sure it returns 0 cards in an empty Tableau
            Assert.AreEqual(0, myTableau.numCardsInPile(1));//checks first pile 
            Assert.AreEqual(0, myTableau.numCardsInPile(3));//checks a pile in the middle
            const int pileToAdd = 3;
            Card addCard = new Card(Card.RankType.ACE, Card.SuitType.DIAMONDS);
            myTableau.AddCardToPile(addCard, pileToAdd);
            Assert.AreEqual(1, myTableau.numCardsInPile(pileToAdd));

            //Checking further to see if two cards being added are counted
            Card secondAddCard = new Card(Card.RankType.TWO, Card.SuitType.CLUBS);
            myTableau.AddCardToPile(secondAddCard, pileToAdd);
            Assert.AreEqual(2, myTableau.numCardsInPile(pileToAdd));
        }
    }
}
