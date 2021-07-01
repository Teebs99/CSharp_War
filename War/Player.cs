using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    class Player
    {
        public List<Card> Hand { get; set; }
        public Player()
        {
            Hand = new List<Card>();
        }
        public bool AddCard(Card stolenCard)
        {
            int Count1 = Hand.Count;
            Hand.Add(stolenCard);
            int Count2 = Hand.Count;
            if (Count1 < Count2)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
        public bool LoseCard(Card lostCard)
        {
            int Count1 = Hand.Count;
            Hand.Remove(lostCard);
            int Count2 = Hand.Count;
            if (Count1 > Count2)
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }
    }
}
