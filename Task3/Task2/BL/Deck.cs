using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Deck
    {
        private Card[] Cards;
        private int numCards;
        public Deck()
        {
            Cards = new Card[52];
            numCards = 0;
        }
        public void Shuffle()
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=1;j<=13;j++)
                {
                    Cards[numCards] = new Card(j,i);
                    numCards++;
                }
            }
            Random rand = new Random();
            for (int i = numCards-1 ; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                Card temp = Cards[i];
                Cards[i] = Cards[j];
                Cards[j] = temp;
            }
        }
        public int cardsLeft()
        {
            return numCards;  
        }
        public Card dealCard()
        {
            if (numCards == 0)
                return null;
            else
            {
                numCards--;
                return Cards[numCards];
            }
        }
        public Card[] GetCards()
        {
            return Cards;
        }


    }
}
