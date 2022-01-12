using System;
using System.Collections.Generic;

namespace Uno
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(int, int)> array = new List<(int, int)>();
            array.Add((2, 4));
            Console.WriteLine(array[0].Item2);
        }
    }
}
