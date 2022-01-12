using ImTools;
using System;
using System.Collections.Generic;
using System.Text;

namespace Uno
{
    class DeckOfCards
    {
        public List<Card> unoDeck = new List<Card>();
        public void creait()
        {
            unoDeck.Add (new Card(Card.Color.Red ,Card.Number.Zero));
            unoDeck.Add (new Card(Card.Color.Yellow, Card.Number.Zero));
            unoDeck.Add (new Card(Card.Color.Blue, Card.Number.Zero));
            unoDeck.Add (new Card(Card.Color.Green, Card.Number.Zero));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.One));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.One));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.One));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.One));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.One));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.One));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.One));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.One));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.Two));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.Two));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.Two));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.Two));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.Two));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.Two));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.Two));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.Two));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.Three));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.Three));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.Three));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.Three));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.Three));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.Three));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.Three));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.Three));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.Four));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.Four));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.Four));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.Four));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.Four));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.Four));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.Four));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.Four));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.Five));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.Five));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.Five));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.Five));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.Five));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.Five));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.Five));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.Five));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.Six));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.Six));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.Six));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.Six));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.Six));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.Six));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.Six));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.Six));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.Seven));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.Seven));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.Seven));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.Seven));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.Seven));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.Seven));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.Seven));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.Seven));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.Eight));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.Eight));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.Eight));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.Eight));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.Eight));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.Eight));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.Eight));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.Eight));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.Nine));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.Nine));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.Nine));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.Nine));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.Nine));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.Nine));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.Nine));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.Nine));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.TakeTwo));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.TakeTwo));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.TakeTwo));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.TakeTwo));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.TakeTwo));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.TakeTwo));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.TakeTwo));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.TakeTwo));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.Apass));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.Apass));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.Apass));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.Apass));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.Apass));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.Apass));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.Apass));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.Apass));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.Uturn));
            unoDeck.Add(new Card(Card.Color.Red, Card.Number.Uturn));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.Uturn));
            unoDeck.Add(new Card(Card.Color.Yellow, Card.Number.Uturn));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.Uturn));
            unoDeck.Add(new Card(Card.Color.Blue, Card.Number.Uturn));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.Uturn));
            unoDeck.Add(new Card(Card.Color.Green, Card.Number.Uturn));
            unoDeck.Add(new Card(Card.Color.Blac, Card.Number.TakeFour));
            unoDeck.Add(new Card(Card.Color.Blac, Card.Number.TakeFour));
            unoDeck.Add(new Card(Card.Color.Blac, Card.Number.TakeFour));
            unoDeck.Add(new Card(Card.Color.Blac, Card.Number.TakeFour));
            unoDeck.Add(new Card(Card.Color.Blac, Card.Number.ColorSelection));
            unoDeck.Add(new Card(Card.Color.Blac, Card.Number.ColorSelection));
            unoDeck.Add(new Card(Card.Color.Blac, Card.Number.ColorSelection));
            unoDeck.Add(new Card(Card.Color.Blac, Card.Number.ColorSelection));
        }

       





    }

}
