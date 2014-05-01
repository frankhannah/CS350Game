using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CS350.Solitaire.Design
{
    [TestFixture]
    class TestSolitaireModel
    {
        [SetUp]
        public void setup()
        {
            //setup the playing board
            int nTableauPiles = 7;
            int nFoundationPiles = 4;
            int nWastePile = 1;
            int nStockPile = 1;
            GameModel gameModel = new GameModel(nTableauPiles, nFoundationPiles, nWastePile, nStockPile);
            Assert.IsTrue(typeof(GameModel).IsInstanceOfType(gameModel));
        }

        [Test]
        public void dealTheDeck()
        {
            //start the game by dealing the deck of cards
            int nTableauPiles = 7;
            int nFoundationPiles = 4;
            int nWastePile = 1;
            int nStockPile = 1;
            GameModel gameModel = new GameModel(nTableauPiles, nFoundationPiles, nWastePile, nStockPile);
            gameModel.dealTheDeck();

            //Assert.AreEqual(1, gameModel.GamePilesOnTheTableau_.numCardsInPile(1));
            //Assert.AreEqual(2, gameModel.GamePilesOnTheTableau_.numCardsInPile(2));
            //Assert.AreEqual(3, gameModel.GamePilesOnTheTableau_.numCardsInPile(3));
            //Assert.AreEqual(4, gameModel.GamePilesOnTheTableau_.numCardsInPile(4));
            //Assert.AreEqual(5, gameModel.GamePilesOnTheTableau_.numCardsInPile(5));
            //Assert.AreEqual(6, gameModel.GamePilesOnTheTableau_.numCardsInPile(6));
            //Assert.AreEqual(7, gameModel.GamePilesOnTheTableau_.numCardsInPile(7));

            for (int pile = 1; pile <= nTableauPiles; ++pile)
            {
                Assert.AreEqual(pile, gameModel.GamePilesOnTheTableau_.numCardsInPile(pile));
            }               
        }

    }
}
