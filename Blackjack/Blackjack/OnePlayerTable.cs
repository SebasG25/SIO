using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class frmOnePlayerTable : Form
    {
        private int cardsGiven = 0;
        Deck deck;
        Computer computer;
        Player player;
        
        public frmOnePlayerTable(string name, int betMoneyPlayer, int betMoneyComputer)
        {
            InitializeComponent();

            player = new Player(name, betMoneyPlayer);
            computer = new Computer(betMoneyComputer);
            deck = new Deck();

            lblPlayerName.Text = player.Name;
            lblComputerName.Text = computer.Name;
            lblComputerTotalMoney.Text = computer.BetMoney.ToString();
            lblPlayerTotalMoney.Text = player.BetMoney.ToString();
            

            BeginGameComputer();
            BeginGamePlayer();
        }

        public void BeginGameComputer()
        {
            if (!CheckCardsGiven())
            {
                computer.FirstCard = deck.GetDeck()[cardsGiven];
                lblCFCS1.Text = " ";
                lblCFCS2.Text = " ";
                lblCFCT.Text = "?";
                cardsGiven++;
            }
            else
            {
                deck.SortDeck();
                cardsGiven = 0;
                BeginGameComputer();
            }

            if (!CheckCardsGiven())
            {
                computer.SecondCard = deck.GetDeck()[cardsGiven];
                lblCSCS1.Text = computer.SecondCard.CardSymbol;
                lblCSCS2.Text = computer.SecondCard.CardSymbol;
                lblCSCT.Text = computer.SecondCard.CardType.ToString();
                cardsGiven++;
            }
            else
            {
                deck.SortDeck();
                cardsGiven = 0;
                BeginGameComputer();
            }

            computer.Accumulated += computer.FirstCard.CardValue + computer.SecondCard.CardValue;
            lblComputerScore.Text = computer.Accumulated.ToString(); //QUITAR!!
            //lblComputerScore.Text = "?";
        }

        public void BeginGamePlayer()
        {
            if (!CheckCardsGiven())
            {
                player.FirstCard = deck.GetDeck()[cardsGiven];
                lblPFCS1.Text = player.FirstCard.CardSymbol;
                lblPFCS2.Text = player.FirstCard.CardSymbol;
                lblPFCT.Text = player.FirstCard.CardType.ToString();
                cardsGiven++;
            }
            else
            {
                deck.SortDeck();
                cardsGiven = 0;

            }

            if (!CheckCardsGiven())
            { 
                player.SecondCard = deck.GetDeck()[cardsGiven];
                lblPSCS1.Text = player.SecondCard.CardSymbol;
                lblPSCS2.Text = player.SecondCard.CardSymbol;
                lblPSCT.Text = player.SecondCard.CardType.ToString();
                cardsGiven++;
            }
            else
            {
                deck.SortDeck();
                cardsGiven = 0;
                BeginGamePlayer();
            }

            player.Accumulated += player.FirstCard.CardValue + player.SecondCard.CardValue;
            lblPlayerScore.Text = player.Accumulated.ToString();
        }

        public void GiveCardComputer()
        {
            if (!CheckCardsGiven())
            {
                computer.ExtraCard = deck.GetDeck()[cardsGiven];
                lblCECS1.Text = computer.ExtraCard.CardSymbol;
                lblCECS2.Text = computer.ExtraCard.CardSymbol;
                lblCECT.Text = computer.ExtraCard.CardType.ToString();
                computer.Accumulated += computer.ExtraCard.CardValue;
                cardsGiven++;

                if (CheckVictoryComputer())
                {
                    DialogResult result;
                    result = MessageBox.Show("¡¡You lose!!", "Defeat", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.Retry)
                    {
                        computer.BetMoney += player.BetValue + computer.BetValue;

                        frmOnePlayerTable onePlayerTable = new frmOnePlayerTable(player.Name, player.BetMoney, computer.BetMoney);

                        int temp1 = onePlayerTable.computer.Accumulated;
                        int temp2 = onePlayerTable.player.Accumulated;

                        onePlayerTable.computer = this.computer;
                        onePlayerTable.player = this.player;
                        onePlayerTable.computer.Accumulated = temp1;
                        onePlayerTable.player.Accumulated = temp2;

                        this.Hide();
                    }
                    else if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        frmMainMenu mainMenu = new frmMainMenu();
                        mainMenu.Show();
                        this.Close();
                    }
                }
                else if (CheckDefeatComputer())
                {
                    DialogResult result;
                    result = MessageBox.Show("¡¡You won!!", "Victory", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.Retry)
                    {
                        player.BetMoney += player.BetValue + computer.BetValue;

                        frmOnePlayerTable onePlayerTable = new frmOnePlayerTable(player.Name, player.BetMoney, computer.BetMoney);

                        int temp1 = onePlayerTable.computer.Accumulated;
                        int temp2 = onePlayerTable.player.Accumulated;

                        onePlayerTable.computer = this.computer;
                        onePlayerTable.player = this.player;
                        onePlayerTable.computer.Accumulated = temp1;
                        onePlayerTable.player.Accumulated = temp2;
                    }
                    else if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        frmMainMenu mainMenu = new frmMainMenu();
                        mainMenu.Show();
                        this.Close();
                    }
                }
            }
            else
            {
                deck.SortDeck();
                cardsGiven = 0;
                GiveCardComputer();
            }
        }

        public void GiveCardPlayer()
        {
            if (!CheckCardsGiven())
            {
                player.ExtraCard = deck.GetDeck()[cardsGiven];
                lblPECS1.Text = player.ExtraCard.CardSymbol;
                lblPECS2.Text = player.ExtraCard.CardSymbol;
                lblPECT.Text = player.ExtraCard.CardType.ToString();
                player.Accumulated += player.ExtraCard.CardValue;
                lblPlayerScore.Text = player.Accumulated.ToString();
                cardsGiven++;

                if (CheckVictoryPlayer())
                {
                    DialogResult result;
                    result = MessageBox.Show("¡¡You won!!", "Victory", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    
                    if (result == System.Windows.Forms.DialogResult.Retry)
                    {
                        player.BetMoney += player.BetValue + computer.BetValue;
                        frmOnePlayerTable onePlayerTable = new frmOnePlayerTable(player.Name, player.BetMoney, computer.BetMoney);

                        int temp1 = onePlayerTable.computer.Accumulated;
                        int temp2 = onePlayerTable.player.Accumulated;

                        onePlayerTable.computer = this.computer;
                        onePlayerTable.player = this.player;
                        onePlayerTable.computer.Accumulated = temp1;
                        onePlayerTable.player.Accumulated = temp2;

                        onePlayerTable.Show();
                        this.Hide();
                    }
                    else if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        frmMainMenu mainMenu = new frmMainMenu();
                        mainMenu.Show();
                        this.Close();
                    }
                }
                else if (CheckDefeatPlayer())
                {
                    DialogResult result;
                    result = MessageBox.Show("¡¡You lose!!", "Defeat", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.Retry)
                    {
                        computer.BetMoney += player.BetValue + computer.BetValue;
                        frmOnePlayerTable onePlayerTable = new frmOnePlayerTable(player.Name, player.BetMoney, computer.BetMoney);

                        int temp1 = onePlayerTable.computer.Accumulated;
                        int temp2 = onePlayerTable.player.Accumulated;

                        onePlayerTable.computer = this.computer;
                        onePlayerTable.player = this.player;
                        onePlayerTable.computer.Accumulated = temp1;
                        onePlayerTable.player.Accumulated = temp2;

                        onePlayerTable.Show();
                        this.Hide();
                    }
                    else if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        frmMainMenu mainMenu = new frmMainMenu();
                        mainMenu.Show();
                        this.Close();
                    }
                }
            }
            else
            {
                deck.SortDeck();
                cardsGiven = 0;
                GiveCardPlayer();
            }
        }

        private bool CheckCardsGiven()
        {
            return cardsGiven == 52;
        }

        private bool CheckVictoryComputer()
        {
            return computer.Accumulated == 21;
        }

        private bool CheckDefeatComputer()
        {
            return computer.Accumulated > 21;
        }
        private bool CheckVictoryPlayer()
        {
            return player.Accumulated == 21;
        }

        private bool CheckDefeatPlayer()
        {
            return player.Accumulated > 21;
        }

        private bool checkDrawBegin()
        {
            if(player.Accumulated == 21 && computer.Accumulated == 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkDraw()
        {
            return player.Accumulated == computer.Accumulated;
        }

        private void CheckVictory()
        {
            if (!CheckDefeatPlayer() && !CheckDefeatComputer() && !CheckVictoryPlayer() && !CheckVictoryComputer())
            {
                if (player.Accumulated > computer.Accumulated)
                {
                    lblComputerScore.Text = computer.Accumulated.ToString();
                    DialogResult result;
                    result = MessageBox.Show("¡¡You have won with a score of " + player.Accumulated + " points!!", "Victory", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.Retry)
                    {
                        player.BetMoney += player.BetValue + computer.BetValue;
                        frmOnePlayerTable onePlayerTable = new frmOnePlayerTable(player.Name, player.BetMoney, computer.BetMoney);

                        int temp1 = onePlayerTable.computer.Accumulated;
                        int temp2 = onePlayerTable.player.Accumulated;

                        onePlayerTable.computer = this.computer;
                        onePlayerTable.player = this.player;
                        onePlayerTable.computer.Accumulated = temp1;
                        onePlayerTable.player.Accumulated = temp2;


                        onePlayerTable.Show();
                        this.Hide();
                    }
                    else if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        frmMainMenu mainMenu = new frmMainMenu();
                        mainMenu.Show();
                        this.Close();
                    }
                }
                else if (player.Accumulated < computer.Accumulated)
                {
                    lblComputerScore.Text = computer.Accumulated.ToString();
                    DialogResult result;
                    result = MessageBox.Show("¡¡You have lost to a score of  " + computer.Accumulated + " points!!", "Defeat", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.Retry)
                    {
                        computer.BetMoney += player.BetValue + computer.BetValue;
                        frmOnePlayerTable onePlayerTable = new frmOnePlayerTable(player.Name, player.BetMoney, computer.BetMoney);

                        int temp1 = onePlayerTable.computer.Accumulated;
                        int temp2 = onePlayerTable.player.Accumulated;

                        onePlayerTable.computer = this.computer;
                        onePlayerTable.player = this.player;
                        onePlayerTable.computer.Accumulated = temp1;
                        onePlayerTable.player.Accumulated = temp2;


                        onePlayerTable.Show();
                        this.Hide();
                    }
                    else if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        frmMainMenu mainMenu = new frmMainMenu();
                        mainMenu.Show();
                        this.Close();
                    }
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("¡¡It's a tie!!", "Draw", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                    if (result == System.Windows.Forms.DialogResult.Retry)
                    {
                        computer.BetMoney += computer.BetValue;
                        player.BetMoney += player.BetValue;

                        frmOnePlayerTable onePlayerTable = new frmOnePlayerTable(player.Name, player.BetMoney, computer.BetMoney);

                        int temp1 = onePlayerTable.computer.Accumulated;
                        int temp2 = onePlayerTable.player.Accumulated;

                        onePlayerTable.computer = this.computer;
                        onePlayerTable.player = this.player;
                        onePlayerTable.computer.Accumulated = temp1;
                        onePlayerTable.player.Accumulated = temp2;

                        onePlayerTable.Show();
                        this.Hide();
                    }
                    else if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        frmMainMenu mainMenu = new frmMainMenu();
                        mainMenu.Show();
                        this.Close();
                    }
                }
            }
        }

        private void frmOnePlayerTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void txtPlayerBet_Click(object sender, EventArgs e)
        {
            if(txtPlayerBet.Text == "Bet")
            {
                txtPlayerBet.Text = "";
            }
        }

        private void txtPlayerBet_Leave(object sender, EventArgs e)
        {
            if (txtPlayerBet.Text == "")
            {
                txtPlayerBet.Text = "Bet";
            }
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (txtPlayerBet.Text == "Bet" || txtPlayerBet.Text == "")
            {
                MessageBox.Show("Yo have to bet to start the game", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                player.BetValue = Convert.ToInt32(txtPlayerBet.Text);

                if (player.BetValue > 100000)
                {
                    MessageBox.Show("Bet must be less than 100,000", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(player.BetMoney > 0)
                    {
                        if(player.BetMoney >= player.BetValue)
                        {
                            player.BetMoney -= player.BetValue;
                            computer.Bet();
                            txtComputerBet.Text = computer.BetValue.ToString();

                            btnBegin.Enabled = false;
                            txtPlayerBet.Enabled = false;
                            lblTurn.Visible = true;
                            btnAsk.Enabled = true;
                            btnPass.Enabled = true;
                            btnBegin.Enabled = false;
                            lblPlayerTotalMoney.Text = player.BetMoney.ToString();
                            lblComputerTotalMoney.Text = computer.BetMoney.ToString();
                            lblComputerTotalMoney.Visible = true;
                            lblPlayerTotalMoney.Visible = true;
                            btnAsk.Visible = true;
                            btnPass.Visible = true;

                            if (checkDrawBegin())
                            {
                                DialogResult result;
                                result = MessageBox.Show("¡¡It's a tie!!", "Draw", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                                if (result == System.Windows.Forms.DialogResult.Retry)
                                {
                                    computer.BetMoney += computer.BetValue;
                                    player.BetMoney += player.BetValue;
                                    frmOnePlayerTable onePlayerTable = new frmOnePlayerTable(player.Name, player.BetMoney, computer.BetMoney);

                                    int temp1 = onePlayerTable.computer.Accumulated;
                                    int temp2 = onePlayerTable.player.Accumulated;

                                    onePlayerTable.computer = this.computer;
                                    onePlayerTable.player = this.player;
                                    onePlayerTable.computer.Accumulated = temp1;
                                    onePlayerTable.player.Accumulated = temp2;


                                    onePlayerTable.Show();
                                    this.Hide();
                                }
                                else if (result == System.Windows.Forms.DialogResult.Cancel)
                                {
                                    frmMainMenu mainMenu = new frmMainMenu();
                                    mainMenu.Show();
                                    this.Close();
                                }

                            }
                            else if (CheckVictoryPlayer())
                            {
                                DialogResult result;
                                result = MessageBox.Show("¡¡You won!!", "Victory", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                                if (result == System.Windows.Forms.DialogResult.Retry)
                                {
                                    player.BetMoney += player.BetValue + computer.BetValue;
                                    frmOnePlayerTable onePlayerTable = new frmOnePlayerTable(player.Name, player.BetMoney, computer.BetMoney);

                                    int temp1 = onePlayerTable.computer.Accumulated;
                                    int temp2 = onePlayerTable.player.Accumulated;

                                    onePlayerTable.computer = this.computer;
                                    onePlayerTable.player = this.player;
                                    onePlayerTable.computer.Accumulated = temp1;
                                    onePlayerTable.player.Accumulated = temp2;


                                    onePlayerTable.Show();
                                    this.Hide();
                                }
                                else if (result == System.Windows.Forms.DialogResult.Cancel)
                                {
                                    frmMainMenu mainMenu = new frmMainMenu();
                                    mainMenu.Show();
                                    this.Close();
                                }

                            }else if (CheckVictoryComputer())
                            {
                                DialogResult result;
                                result = MessageBox.Show("¡¡You lose!!", "Defeat", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                                if (result == System.Windows.Forms.DialogResult.Retry)
                                {
                                    computer.BetMoney += player.BetValue + computer.BetValue;

                                    frmOnePlayerTable onePlayerTable = new frmOnePlayerTable(player.Name, player.BetMoney, computer.BetMoney);

                                    int temp1 = onePlayerTable.computer.Accumulated;
                                    int temp2 = onePlayerTable.player.Accumulated;

                                    onePlayerTable.computer = this.computer;
                                    onePlayerTable.player = this.player;
                                    onePlayerTable.computer.Accumulated = temp1;
                                    onePlayerTable.player.Accumulated = temp2;

                                    onePlayerTable.Show();
                                    this.Hide();
                                }
                                else if (result == System.Windows.Forms.DialogResult.Cancel)
                                {
                                    frmMainMenu mainMenu = new frmMainMenu();
                                    mainMenu.Show();
                                    this.Close();
                                }

                            }

                        }
                        else
                        {
                            MessageBox.Show("You don't have all that money available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        DialogResult result;
                        result = MessageBox.Show("You lost all your money", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if(result == System.Windows.Forms.DialogResult.OK)
                        {
                            frmMainMenu mainMenu = new frmMainMenu();
                            mainMenu.Show();
                            this.Close();
                        }
                    }
                }
            }
        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            GiveCardPlayer();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            int turn = 0;

            while (turn != 2)
            {
                turn++;

                lblTurn.Visible = false;

                System.Threading.Thread.Sleep(1000);

                while (computer.AskForAnother())
                {
                    GiveCardComputer();

                    System.Threading.Thread.Sleep(1000);
                }

                turn++;

                lblTurn.Visible = true;
            }
            
            btnAsk.Visible = false;
            btnPass.Visible = false;
            CheckVictory();
        }

        private void TxtPlayerBet_TextChanged(object sender, EventArgs e)
        {
            btnBegin.Enabled = true;
        }
    }
}
