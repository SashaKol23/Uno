using System;
using System.Collections.Generic;
using System.Text;

namespace Uno
{
    public class Card
    {
        public int namber;

        public int colour;
        enum colors
        {
            Red,
            Yellow,
            Green,
            Blue,
            Black
        }
        public int abiliti;
        enum abiliti
        {
            TakeTwo,
            TakeFour,
            Apass,
            Uturn,
            ColorSelection
        }


    }
}
