using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Player
    {
        private string name;
        private Card firstCard, secondCard, extraCard;
        private int accumulated, betMoney, betValue;

        public Player(string name, int betMoney)
        {
            this.name = name;
            this.accumulated = 0;
            this.betMoney = betMoney;
        }

        public string Name
        {
            get { return name; }
        }

        public Card FirstCard
        {
            get { return firstCard; }
            set { firstCard = value; }
        }

        public Card SecondCard
        {
            get { return secondCard; }
            set { secondCard = value; }
        }

        public Card ExtraCard
        {
            get { return extraCard; }
            set { extraCard = value; }
        }
        public int Accumulated
        {
            get { return accumulated; }
            set { accumulated = value; }
        }

        public int BetMoney
        {
            get { return betMoney; }
            set { betMoney = value; }
        }

        public int BetValue
        {
            get { return betValue; }
            set { betValue = value; }
        }
    }
}
