using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Card
    {
        private int Suit;
        private int Value;
        public Card(int suit, int value)
        {
            Suit = suit;
            Value = value;
        }
        public void setValue(int value)
        {
            this.Value = value;
        }
        public int getValue()
        {
            return this.Value;
        }
        public void setSuit(int suit)
        {
            this.Suit = suit;
        }
        public int getSuit()
        {
            return this.Suit;
        }
        public string GetSuitAsString() 
        {
         
            if (Suit == 1)
            {
                return "Clubs";
            }

            else if (Suit == 2)
            {
                 return "Diamonds";
            }

            else if (Suit == 3)
            {
                return "Spades";
            }

            else if (Suit == 4)
            {
                return "Hearts";
            }
            else
            return "";
           
        }
        public string getValueAsString()
        {
            string res;
            if (Value == 1)
                res = "Ace";
            else if (Value == 11)
            {
                res = "Jack";
            }
            else if (Value == 12)
            {
                res = "Queen";
            }
            else if (Value == 13)
            {
                res = "King";
            }
            else
            {
                res = Value.ToString();
            }
            return res;
        }
        public string toString()
        {
            return getValueAsString()+" of "+GetSuitAsString();
        }
    }
    }
