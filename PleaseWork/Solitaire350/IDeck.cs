using System;
namespace CS350.Solitaire.Design
{
    interface IDeck
    {
        void pop();
        void printDeck();
        void shuffle();
        int size_ { get; }
        void swap(int lhs, int rhs);
        Card this[int index] { get; set; }
        Card top();
    }
}
