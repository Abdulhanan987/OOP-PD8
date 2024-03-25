using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class BlackJackHandUI
    {
       public static void displayhand(BlackJackHand blackJack)
        {
            for (int i = 0;i<blackJack.GetCards().Count;i++ )
            {
                Console.WriteLine(blackJack.GetCards()[i].getValueAsString());
            }
        }
    }
}
