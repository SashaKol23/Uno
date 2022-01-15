using System;
using System.Collections.Generic;

namespace Uno
{
    class Program
    {
        static void Main(string[] args)
        {

            DeckOfCards deck = new DeckOfCards();
            deck.creait();
            Random randomDeck = new Random();
            
            for (int i =0; i < deck.unoDeck.Count; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine($"{deck.unoDeck[i].unoColor} {deck.unoDeck[i].unoNumber}");
            }
            
        }
    }
}
