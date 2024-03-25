using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class BlackJackHand : Hand
    { 
        public int getBlackJackValue()
        {
            int val;
            bool ace;
            int cards= getCardCount();
            val = 0;
            ace = false;
            for(int i = 0; i < Cards.Count;i++)
            {
                if ( 
                    Cards[i].getValue() ==1 )

                {
                    ace = true;
                }
                else if (Cards[i].getValue() <= 10)
                {
                    val += Cards[i].getValue();
                }
                else if (ace = true && val + 10<21 )
                {
                    val = val + 10;
                }
                else if (Cards[i].getValue() > 10)
                {
                    val = val + 10;
                }
            }

            return val;
        }
    }
}
