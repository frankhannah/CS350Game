using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS350.Solitaire.Design
{
    class GameModel
    {
        //Number of different kinds of piles on playing board
        public int nTableauPiles_;
        //public int nCardsInTableauPiles_;
        public int nFoundationPiles_;
        public int nCardsInStockPile_;
        public int nCardsInWastePile_;

        public TableauPiles GamePilesOnTheTableau_; //our game's tableau piles
        private Deck GameDeck_;

        public GameModel(int nTableauPiles, int nFoundationPiles, int nWastePile, int nStockPile)
        {
            nTableauPiles_ = nTableauPiles;
            nFoundationPiles_ = nFoundationPiles;
            nCardsInWastePile_ = nWastePile;
            nCardsInStockPile_ = nStockPile;
            GamePilesOnTheTableau_ = new TableauPiles(nTableauPiles_);
            GameDeck_ = new Deck();
        }

        public void dealTheDeck()
        {
            int beginningPile = 1;
            while (beginningPile <= nTableauPiles_)
            {
                for (int currentPile = beginningPile; currentPile <= nTableauPiles_; currentPile++)
                {
                    GamePilesOnTheTableau_.AddCardToPile(GameDeck_.top(), currentPile);
                }
                ++beginningPile;
            }
        }

    }
}
