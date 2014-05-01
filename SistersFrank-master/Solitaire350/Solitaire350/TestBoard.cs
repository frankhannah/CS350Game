using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CS350.Solitaire.Design
{
   [TestFixture]
   public class TestBoard
   {
       SolitaireGame newGame = new SolitaireGame();
       //const string cardBack = "images/cardBackSmall.jpg";
       const int LEFT_X_FOUNDATION_LOC = 354;
       const int INCREMENT_X = 115;
       const int Y_FOUNDATION_LOC = 12; 
       const int LEFT_X_TABLEAU_LOC = 12;
       const int Y_TABLEAU_LOC = 234;

       [Test]
       public void createBoard() //tests if the visual playing board is created
       {
           Assert.IsTrue(newGame.BackColor.Equals(System.Drawing.Color.DarkGreen));
           //Assert.IsTrue(newGame.BackColor.IsSystemColor);
       }

       [Test]
       public void stockPilePlaceHolder()
       {
           const int X_STOCK_LOC = 12;
           const int Y_STOCK_LOC = 12;
           Assert.AreEqual(newGame.StockPile.Location.X, X_STOCK_LOC);
           Assert.AreEqual(newGame.StockPile.Location.Y, Y_STOCK_LOC);
       }

       [Test]
       public void createLeftFoundationPlaceHolder() //tests location of left place holder in foundation
        {  
            Assert.AreEqual(newGame.LeftFoundation.Location.X, LEFT_X_FOUNDATION_LOC);
            Assert.AreEqual(newGame.LeftFoundation.Location.Y, Y_FOUNDATION_LOC);         
       }

       [Test]
       public void createCenterLeftFoundationPlaceHolder() //tests location of center left place holder in foundation
       {
           Assert.AreEqual(newGame.CenterLeftFoundation.Location.X, LEFT_X_FOUNDATION_LOC+INCREMENT_X);
           Assert.AreEqual(newGame.CenterLeftFoundation.Location.Y, Y_FOUNDATION_LOC);
       }

       [Test]
       public void createCenterRightFoundationPlaceHolder() //tests location of center right place holder in foundation
       {
           const int DISTANCE_FROM_LEFT_PILE = 2;
           Assert.AreEqual(newGame.CenterRightFoundation.Location.X, LEFT_X_FOUNDATION_LOC + (DISTANCE_FROM_LEFT_PILE * INCREMENT_X));
           Assert.AreEqual(newGame.CenterRightFoundation.Location.Y, Y_FOUNDATION_LOC);
       }

       [Test]
       public void createRightFoundationPlaceHolder() //tests location of far right place holder in foundation
       {
           const int DISTANCE_FROM_LEFT_PILE = 3;
           Assert.AreEqual(newGame.RightFoundation.Location.X, LEFT_X_FOUNDATION_LOC+(DISTANCE_FROM_LEFT_PILE*INCREMENT_X));
           Assert.AreEqual(newGame.RightFoundation.Location.Y, Y_FOUNDATION_LOC);
       }

       [Test]
       public void firstTableauPilePlaceHolder()
       {
           Assert.AreEqual(newGame.firstTableauPile.Location.X, LEFT_X_TABLEAU_LOC);
           Assert.AreEqual(newGame.firstTableauPile.Location.Y, Y_TABLEAU_LOC);
       }

       [Test]
       public void secondTableauPilePlaceHolder()
       {
           Assert.AreEqual(newGame.secondTableauPile.Location.X, LEFT_X_TABLEAU_LOC+INCREMENT_X);
           Assert.AreEqual(newGame.secondTableauPile.Location.Y, Y_TABLEAU_LOC);
       }

       [Test]
       public void thirdTableauPilePlaceHolder()
       {
           const int DISTANCE_FROM_LEFT_PILE = 2;
           Assert.AreEqual(newGame.thirdTableauPile.Location.X, LEFT_X_TABLEAU_LOC + (DISTANCE_FROM_LEFT_PILE*INCREMENT_X));
           Assert.AreEqual(newGame.thirdTableauPile.Location.Y, Y_TABLEAU_LOC);
       }

       [Test]
       public void fourthTableauPilePlaceHolder()
       {
           const int DISTANCE_FROM_LEFT_PILE = 3;
           Assert.AreEqual(newGame.fourthTableauPile.Location.X, LEFT_X_TABLEAU_LOC + (DISTANCE_FROM_LEFT_PILE * INCREMENT_X));
           Assert.AreEqual(newGame.fourthTableauPile.Location.Y, Y_TABLEAU_LOC);
       }

       [Test]
       public void fifthTableauPilePlaceHolder()
       {
           const int DISTANCE_FROM_LEFT_PILE = 4;
           Assert.AreEqual(newGame.fifthTableauPile.Location.X, LEFT_X_TABLEAU_LOC + (DISTANCE_FROM_LEFT_PILE * INCREMENT_X));
           Assert.AreEqual(newGame.fifthTableauPile.Location.Y, Y_TABLEAU_LOC);
       }

       [Test]
       public void sixthTableauPilePlaceHolder()
       {
           const int DISTANCE_FROM_LEFT_PILE = 5;
           Assert.AreEqual(newGame.sixthTableauPile.Location.X, LEFT_X_TABLEAU_LOC + (DISTANCE_FROM_LEFT_PILE * INCREMENT_X));
           Assert.AreEqual(newGame.sixthTableauPile.Location.Y, Y_TABLEAU_LOC);
       }

       [Test]
       public void seventhTableauPilePlaceHolder()
       {
           const int DISTANCE_FROM_LEFT_PILE = 6;
           Assert.AreEqual(newGame.seventhTableauPile.Location.X, LEFT_X_TABLEAU_LOC + (DISTANCE_FROM_LEFT_PILE * INCREMENT_X));
           Assert.AreEqual(newGame.seventhTableauPile.Location.Y, Y_TABLEAU_LOC);
       }
   }    
}
