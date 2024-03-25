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
            Console.WriteLine("Welcome to The High Low Game");
            int score = 0;
           
            Deck deck = new Deck();
            deck.Shuffle();
            Card current = deck.dealCard();
            Console.WriteLine("First Card: " + current.getValueAsString());
            int counter = 1;
            while (true)
            {
               
             
               
               
                Console.WriteLine("Will the next card be higher or lower?(h/l)");
                string res = Console.ReadLine().ToLower();
                Card next = deck.dealCard();
                if(res=="h"&& next.getValue() > current.getValue()||res=="l"&& next.getValue()<current.getValue() )
                    {
                    Console.WriteLine("Excellent you made the rigth answer");
                    score++;
                    current = next;
                    Console.WriteLine("Next Card: " + current.toString());
                }
                else
                {

                    Console.WriteLine("Sorry you can't predict the rigth answer");
                    Console.WriteLine("will you want to play another game?(y/n)");
                    string ans = Console.ReadLine().ToLower();
                    if(ans=="n")
                    break;
                    else
                    {
                        deck = new Deck();
                        deck.Shuffle();
                        current = deck.dealCard();
                        Console.WriteLine("First Card: " + current.toString());
                        counter++;
                    }
                   
                }
                
            }
            float totalscore = score / counter;
            Console.WriteLine("The total score for this game is : " + totalscore);
            Console.ReadKey();
        }
    }
}
