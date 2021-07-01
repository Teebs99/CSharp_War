using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    class Program
    {
        int[,] nums = new int[3,3];


        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Player player1 = new Player();
            Player player2 = new Player();
            deck.Shuffle(12);
            deck.DealDeck(player1, player2);
            int count = 0;

            void War()
            {

                if (player1.Hand.Count >= 5 & player2.Hand.Count >= 5)
                {
                    if (player1.Hand[4].Number > player2.Hand[4].Number)
                    {
                      
                        for (int i = 0; i < 5; i++)
                        {
                            player1.AddCard(player2.Hand[0]);
                            player1.AddCard(player1.Hand[0]);
                            player1.LoseCard(player1.Hand[0]);
                            player2.LoseCard(player2.Hand[0]);
                        }
                    }
                    else if (player1.Hand[4].Number < player2.Hand[4].Number)
                    {
                       
                        for (int i = 0; i < 5; i++)
                        {
                            player2.AddCard(player1.Hand[0]);
                            player2.AddCard(player2.Hand[0]);
                            player2.LoseCard(player2.Hand[0]);
                            player1.LoseCard(player1.Hand[0]);
                        }
                    }
                    else //If cards are equal
                    {
                        if (player1.Hand[3].Number > player2.Hand[3].Number)
                        {
                           
                            for (int i = 0; i < 5; i++)
                            {
                                player1.AddCard(player2.Hand[0]);
                                player1.AddCard(player1.Hand[0]);
                                player1.LoseCard(player1.Hand[0]);
                                player2.LoseCard(player2.Hand[0]);
                            }
                        }
                        else if (player1.Hand[3].Number < player2.Hand[3].Number)
                        {
                           
                            for (int i = 0; i < 5; i++)
                            {
                                player2.AddCard(player1.Hand[0]);
                                player2.AddCard(player2.Hand[0]);
                                player2.LoseCard(player2.Hand[0]);
                                player1.LoseCard(player1.Hand[0]);
                            }
                        }
                        else //If cards are equal
                        {
                            if (player1.Hand[2].Number > player2.Hand[2].Number)
                            {
                                
                                for (int i = 0; i < 5; i++)
                                {
                                    player1.AddCard(player2.Hand[0]);
                                    player1.AddCard(player1.Hand[0]);
                                    player1.LoseCard(player1.Hand[0]);
                                    player2.LoseCard(player2.Hand[0]);
                                }
                            }
                            else if (player1.Hand[2].Number < player2.Hand[2].Number)
                            {
                                
                                for (int i = 0; i < 5; i++)
                                {
                                    player2.AddCard(player1.Hand[0]);
                                    player2.AddCard(player2.Hand[0]);
                                    player2.LoseCard(player2.Hand[0]);
                                    player1.LoseCard(player1.Hand[0]);
                                }
                            }
                            else //If cards are equal
                            {
                                if (player1.Hand[1].Number > player2.Hand[1].Number)
                                {
                                   
                                    for (int i = 0; i < 5; i++)
                                    {
                                        player1.AddCard(player2.Hand[0]);
                                        player1.AddCard(player1.Hand[0]);
                                        player1.LoseCard(player1.Hand[0]);
                                        player2.LoseCard(player2.Hand[0]);
                                    }
                                }
                                else if (player1.Hand[1].Number < player2.Hand[1].Number)
                                {
                                   
                                    for (int i = 0; i < 5; i++)
                                    {
                                        player2.AddCard(player1.Hand[0]);
                                        player2.AddCard(player2.Hand[0]);
                                        player2.LoseCard(player2.Hand[0]);
                                        player1.LoseCard(player1.Hand[0]);
                                    }
                                }
                                else
                                {
                                    for (int i = 0; i < 5; i++)
                                    {
                                        player1.AddCard(player1.Hand[0]);
                                        player1.LoseCard(player1.Hand[0]);
                                        player2.AddCard(player2.Hand[0]);
                                        player2.LoseCard(player2.Hand[0]);

                                    }
                                }
                            }
                        }
                    }
                }
                else if (player1.Hand.Count < 5)
                {
                    int handCount = player1.Hand.Count;
                    if (player1.Hand[handCount - 1].Number > player2.Hand[handCount - 1].Number)
                    {
                        for (int i = 0; i < handCount; i++)
                        {
                            player1.AddCard(player2.Hand[0]);
                            player1.AddCard(player1.Hand[0]);
                            player1.LoseCard(player1.Hand[0]);
                            player2.LoseCard(player2.Hand[0]);
                            
                        }
                    }
                    else
                    {
                        while(player1.Hand.Count > 0)
                        {
                            player2.AddCard(player1.Hand[0]);
                            player1.LoseCard(player1.Hand[0]);
                        }
                    }
                }
                else if (player2.Hand.Count < 5)// if player2's hand has less than 5 cards
                {
                    int handCount = player2.Hand.Count;
                    if (player1.Hand[handCount - 1].Number < player2.Hand[handCount - 1].Number)
                    {
                        for (int i = 0; i < handCount; i++)
                        {
                            player2.AddCard(player1.Hand[0]);
                            player2.AddCard(player2.Hand[0]);
                            player2.LoseCard(player2.Hand[0]);
                            player1.LoseCard(player1.Hand[0]);
                           
                        }
                    }
                    else
                    {
                        while (player2.Hand.Count > 0)
                        {
                            player1.AddCard(player2.Hand[0]);
                            player2.LoseCard(player2.Hand[0]);
                        }
                    }
                }
                else
                {
                    
                }
            }




            //Console.WriteLine(player1.Hand.Count);
            //Console.WriteLine(player2.Hand.Count);
            while (player1.Hand.Count > 0 & player2.Hand.Count > 0)
            {
                int p1Card = player1.Hand[0].Number;
                int p2Card = player2.Hand[0].Number;

                Console.WriteLine(player1.Hand[0].ToString() + ", " + player2.Hand[0].ToString());

                if (p1Card > p2Card)
                {
                    player1.AddCard(player2.Hand[0]);
                    player1.AddCard(player1.Hand[0]);
                    player1.LoseCard(player1.Hand[0]);
                    player2.LoseCard(player2.Hand[0]);
                }
                else if (p1Card < p2Card)
                {
                    player2.AddCard(player1.Hand[0]);
                    player2.AddCard(player2.Hand[0]);
                    player2.LoseCard(player2.Hand[0]);
                    player1.LoseCard(player1.Hand[0]);
                }
                else //If the cards are equal
                {
                    Console.WriteLine("War!");
                    War();
                }
                count++;
            }
            if (player1.Hand.Count == 0)
            {
                Console.WriteLine("Player 2 wins");
            }
            else
            {
                Console.WriteLine("Player 1 wins");
            }
            Console.WriteLine(count);
            Console.ReadLine();


        }
    }
}
