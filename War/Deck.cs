using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    class Deck
    {
        public readonly List<Card> cards = new List<Card>();

        public Deck()
        {
            string suit = "Heart";
            for(int i =0; i < 4; i++)
            {
                if (i == 1) { suit = "Diamond"; }
                else if (i == 2) { suit = "Club"; }
                else if (i == 3) { suit = "Spade"; }
                for(int j = 1; j < 14; j++)
                {
                    Card card = new Card(suit, j);
                    cards.Add(card);
                }
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            for(int i = 0; i < 52; i++)
            {
                int num = random.Next(0, 51);
                Card placeholder = cards[i];
                cards[i] = cards[num];
                //cards[0] = cards[15];
                cards[num] = placeholder;
            }
        }
        public void Shuffle(int NumberOfShuffles)
        {
            Random random = new Random();
            for (int j = 0; j < NumberOfShuffles; j++)
            {
                for (int i = 0; i < 52; i++)
                {
                    int num = random.Next(0, 51);
                    Card placeholder = cards[i];
                    cards[i] = cards[num];
                    //cards[0] = cards[15];
                    cards[num] = placeholder;
                }
            }
        }
        public void PrintDeck()
        {
            foreach(Card card in cards)
            {
                Console.WriteLine(card.ToString());
            }
        }
        public void DealDeck(Player player1, Player player2)
        {
            while(cards.Count > 0)
            {
                player1.AddCard(cards[0]);
                cards.Remove(cards[0]);
                player2.AddCard(cards[0]);
                cards.Remove(cards[0]);
            }
        }
    }
}
