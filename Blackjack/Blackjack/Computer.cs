using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Computer
    {
        Random random = new Random();

        private string name;
        private Card firstCard, secondCard, extraCard;
        private int accumulated, betMoney, betValue;

        public Computer(int betMoney)
        {
            this.name = "Computer";
            this.accumulated = 0;
            this.betMoney = betMoney;
            this.betValue = 0;
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
            set { BetValue = value; }
        }

        public bool AskForAnother()
        {
            if (this.accumulated <= 14 && random.Next(0, 100) < 75)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Bet()
        {
            this.betValue = 4000 * random.Next(1, 21);
            betMoney -= betValue;
        }
    }   
}
