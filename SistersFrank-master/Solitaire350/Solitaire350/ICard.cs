using System;
namespace CS350.Solitaire.Design
{
    interface ICard
    {
        bool isEqual(Card rhs);
        void printCard();
        Card.RankType Rank { get; }
        Card.SuitType Suit { get; }
    }
}
