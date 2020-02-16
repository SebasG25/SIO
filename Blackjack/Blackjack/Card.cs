using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card
    {
        private char cardType;
        private string cardSymbol;
        private int cardValue;

        public Card(char cardType, string cardSymbol)
        {
            this.cardType = cardType;
            this.cardSymbol = cardSymbol;
        }

        public char CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }

        public string CardSymbol
        {
            get { return cardSymbol; }
            set { cardSymbol = value; }
        }

        public int CardValue
        {
            get { return cardValue; }
            set { cardValue = value; }
        }
    }
}
