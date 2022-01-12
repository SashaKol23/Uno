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
            Dreen,
            Blue,
            Dlac
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

        
    }
}
