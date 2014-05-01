using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CS350.Solitaire.Design
{

    [TestFixture]
    public class TestCardandDeck
    {
        [Test]
        public void createCard() //tests that a card can be created of a designated suit and rank
        {
            //const int MY_CARD_RANK = 3;
            Card myCard = new Card(Card.RankType.ACE, Card.SuitType.CLUBS); //created a card of rank ace and suit clubs
            Assert.AreEqual(myCard.Suit, Card.SuitType.CLUBS); //assert that the card's suit is equal to clubs
            Assert.AreEqual(myCard.Rank, Card.RankType.ACE); //assert that the card's rank is equal to ace
        }

        [Test]
        public void copyCard() //tests the copy constructor for Card
        {
            // Create an instance of a card
            Card myCard = new Card(Card.RankType.ACE, Card.SuitType.SPADES);
            // Create another Card, copying myCard 
            Card copiedCard = new Card(myCard);
            Assert.IsTrue(myCard.isEqual(copiedCard));
        }

        [Test]
        public void assignCard() //tests the assignment operator for Card
        {
            //create instance of a card
            Card myCard = new Card(Card.RankType.ACE, Card.SuitType.SPADES);
            //create another instance of a card
            Card assignedCard = new Card(Card.RankType.KING, Card.SuitType.HEARTS);
            //set one equal to another to test assignment operator
            assignedCard = myCard;
            Assert.IsTrue(myCard.isEqual(assignedCard));
        }

        [Test]
        public void equalCards() //tests that two cards of the same type and rank are the same
        {
            Card myCard = new Card(Card.RankType.THREE, Card.SuitType.CLUBS);
            Card yourCard = new Card(Card.RankType.THREE, Card.SuitType.CLUBS);
            Assert.IsTrue(myCard.isEqual(yourCard));
        }

        [Test]
        public void printCard() //tests our print card function
        {
            Card myCard = new Card(Card.RankType.ACE, Card.SuitType.SPADES);
            myCard.printCard();
        }
    }

    [TestFixture]
    public class TestDeck
    {
        const int DECK_SIZE = 52;

        [Test]
        public void createDeck() //tests that a deck can be created with ability
        //to hold 52 cards
        {
            Card[] newDeck = new Card[DECK_SIZE];
            Deck myDeck = new Deck();
            Assert.AreEqual(myDeck.size_, DECK_SIZE);
        }

        [Test]
        public void overrideDeckBrackets()//to test the Deck's [] operator
        {
            Deck myDeck = new Deck();
            Card myCard = new Card(Card.RankType.ACE, Card.SuitType.HEARTS);
            Assert.IsTrue(myCard.isEqual(myDeck[0]));
        }
        [Test]
        public void swap() //tests our swap function
        {
            Deck myDeck = new Deck();
            Card myCard = new Card(Card.RankType.ACE, Card.SuitType.HEARTS);
            myDeck.swap(0, 10);
            Assert.IsTrue(myCard.isEqual(myDeck[10]));
        }

        [Test]
        public void shuffle() //tests to see if the cards are being randomly shuffled
        {
            Deck unshuffledDeck = new Deck();
            Deck shuffledDeck = new Deck();
            shuffledDeck.shuffle();
            Assert.AreNotEqual(unshuffledDeck, shuffledDeck); //a shuffled and an unshuffled deck should not be equal
        }

        [Test]
        public void printDeck() //tests our print deck function
        {
            Deck unshuffledDeck = new Deck();
            Deck shuffledDeck = new Deck();
            shuffledDeck.shuffle();
            unshuffledDeck.printDeck();
            shuffledDeck.printDeck();
        }

        //Tests the top function
        [Test]
        public void returnTopCard()
        {
            Deck myDeck = new Deck();
            Assert.AreEqual(myDeck.top(), myDeck[DECK_SIZE - 1]);
            myDeck.shuffle();
        }

        //Tests the pop function
        [Test]
        public void popTopCard()
        {
            Deck myDeck = new Deck();
            Assert.AreEqual(myDeck.size_, 52);
            Card LastCard = new Card(Card.RankType.KING, Card.SuitType.SPADES);
            Assert.AreEqual(myDeck.top().Suit, LastCard.Suit, "Last card suit is not correct 1");
            Assert.AreEqual(myDeck.top().Rank, LastCard.Rank, "Last card rank is not correct 1");
            myDeck.pop(); //now last card is queen of spades
            Assert.AreEqual(myDeck.top().Suit, LastCard.Suit, "Last card Suit is not correct 2"); //suit is the same
            Assert.AreNotEqual(myDeck.top().Rank, LastCard.Rank, "Last card Rank is not correct 2"); //rank is not the same
        }

    }
        
}




