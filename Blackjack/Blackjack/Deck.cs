using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Deck
    {
        private char[] types = { '♥', '♦', '♠', '♣' };
        private string[] Symbols = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        private Card[] deck = new Card[52];

        public Deck()
        {
            FillDeck();
            SortDeck();
        }

        public void FillDeck()
        {
            int cont = 0;
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card(types[j], Symbols[i]);

                    if (Symbols[i] == "J" || Symbols[i] == "Q" || Symbols[i] == "K")
                    {
                        card.CardValue = 10;
                    }
                    else if (Symbols[i] == "A")
                    {
                        card.CardValue = 11;
                    }
                    else
                    {
                        card.CardValue = i + 2;
                    }

                    deck[cont] = card;

                    cont++;
                }
            }
        }

        public void SortDeck()
        {
            Random random = new Random();

            for (int i = 0; i < 52; i++)
            {
                int ran = random.Next(0, 52);
                Card temp = deck[i];
                deck[i] = deck[ran];
                deck[ran] = temp;
            }
        }

        public Card[] GetDeck()
        {
            return deck;
        }
    }
}
