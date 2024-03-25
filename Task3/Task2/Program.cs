using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Black Jack Game");
            while(true)
            {
                Console.Clear();
                BlackJackHand playerhand = new BlackJackHand();
                BlackJackHand dealerhand = new BlackJackHand();
                Deck deck = new Deck();
                deck.Shuffle();
                playerhand.Add(deck.dealCard());
                playerhand.Add(deck.dealCard());
                dealerhand.Add(deck.dealCard());
                dealerhand.Add(deck.dealCard());
                Console.WriteLine("Palyer Cards");
               BlackJackHandUI.displayhand(playerhand);
                Console.WriteLine("Dealer Cards");
                Console.WriteLine(dealerhand.GetCards()[0].getValueAsString());
                Console.WriteLine("Second Card is hidden");
                while(true)
                {
                    Console.WriteLine("Do you want to hit or stand(h/s)");
                    string ans = Console.ReadLine().ToLower();
                    if(ans=="h")
                    {
                        playerhand.Add(deck.dealCard());
                        BlackJackHandUI.displayhand(playerhand);
                        if(playerhand.getBlackJackValue()>21)
                        {
                            Console.WriteLine("You Busted");
                            Console.ReadKey();
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }

                }
                while(dealerhand.getBlackJackValue()<17)
                {
                    dealerhand.Add(deck.dealCard());
                   
                }
                Console.WriteLine("Dealers Final hand");
                BlackJackHandUI.displayhand(dealerhand);
                int PlayerValue  = playerhand.getBlackJackValue();
                int dealervalue = dealerhand.getBlackJackValue();
                if(PlayerValue>21||(dealervalue<21 && PlayerValue<dealervalue))
                {
                    Console.WriteLine("Dealer wins");
                }
                else if (dealervalue>21||PlayerValue>dealervalue)
                {
                    Console.WriteLine("You win");
                }
                else
                {
                    Console.WriteLine("It's s tie");
                }
                Console.WriteLine("Do you want to play again?(y/n)");
                string res = Console.ReadLine().ToLower();
                if(res!="yes")
                {
                    break;
                }
               
            }
            Console.WriteLine("Thanks for playing Black jack game");
            Console.ReadKey();


        }
    }
}
