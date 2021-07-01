using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    class Card
    {
        public string Suit { get; }

        public int Number { get; }

        public Card(string suit, int number)
        {
            Suit = suit;
            if(number == 1)
            {
                number = 14;
            }
            Number = number;

        }

        override public string ToString()
        {
            if(Number == 14)
            {
                return $"Ace of {Suit}s";
            }
            else if(Number == 11)
            {
                return $"Jack of {Suit}s";
            }
            else if(Number == 12)
            {
                return $"Queen of {Suit}s";
            }
            else if(Number == 13)
            {
                return $"King of {Suit}s";
            }
            else
            {
                return $"{Number} of {Suit}";
            }

        }


    }
}
