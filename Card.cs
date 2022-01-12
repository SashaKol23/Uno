using System;
using System.Collections.Generic;
using System.Text;

namespace Uno
{
    public class Card
    {
        public enum Color
        {
            Red,
            Yellow,
            Green,
            Blue,
            Blac
        }
        public Color unoColor = Color.Red;
        public enum Number
        {
            Zero,
            One,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            TakeTwo,
            Apass,
            Uturn,
            TakeFour,
            ColorSelection
        }
        public Number unoNumber = Number.Zero;

        public Card(Color color,Number number)
        {
            unoColor = color;
            unoNumber = number;
        }


    }
}
