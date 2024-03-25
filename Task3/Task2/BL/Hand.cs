using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Hand
    {
        protected List<Card> Cards = new List<Card>(); 
        public Hand()
        {
           
        }
        public void Clear()
        {
            for(int i = 0; i < Cards.Count; i++)
            {
                Cards[i] = null;
            }
        }
        public void Add(Card card)
        {
            Cards.Add(card);
        }
        public void RemoveCard(Card card)
        {
            for (int i = 0;i < Cards.Count;i++)
            {
                if (Cards[i].getSuit() == card.getSuit() && Cards[i].getValue()==card.getValue())
                {
                    Cards.RemoveAt(i);
                }
            }
        }
        public void RemoveCard(int position)
        {
            Cards.RemoveAt(position - 1);
        }
        public int getCardCount()
        {
            return Cards.Count;
        }
        public Card getcard(int index)
        {
            return Cards[index-1];
        }
        public void SortBySuit()
        {
           Cards = Cards.OrderBy(x => x.getSuit()).ToList();
        }
        public void SortByvalue()
        {
            Cards= Cards.OrderByDescending(x => x.getValue()).ToList();
        }
        public List<Card> GetCards()
        {
            return Cards;
        }
    }
}
