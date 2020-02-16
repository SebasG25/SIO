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
    public partial class frmTwoPlayersTable : Form
    {
        private int turn = 0;
        private int cardsGiven = 0;
        Deck deck;
        Player player1;
        Player player2;
        public frmTwoPlayersTable(string name, int betMoneyPlayer1, string name2, int betMoneyPlayer2)
        {
            InitializeComponent();

            player1 = new Player(name, betMoneyPlayer1);
            player2 = new Player(name2, betMoneyPlayer2);
            deck = new Deck();

            lblPlayerName.Text = player1.Name;
            lblPlayerName2.Text = player2.Name;
            lblPlayerTotalMoney.Text = player1.BetMoney.ToString();
            lblPlayer2TotalMoney.Text = player2.BetMoney.ToString();

            BeginGamePlayer();
            BeginGamePlayer2();
        }

        public void BeginGamePlayer()
        {
            if (!CheckCardsGiven())
            {
                player1.FirstCard = deck.GetDeck()[cardsGiven];
                lblPFCS1.Text = player1.FirstCard.CardSymbol;
                lblPFCS2.Text = player1.FirstCard.CardSymbol;
                lblPFCT.Text = player1.FirstCard.CardType.ToString();
                cardsGiven++;
            }
            else
            {
                deck.SortDeck();
                cardsGiven = 0;
                BeginGamePlayer();
            }

            if (!CheckCardsGiven())
            {
                player1.SecondCard = deck.GetDeck()[cardsGiven];
                lblPSCS1.Text = player1.SecondCard.CardSymbol;
                lblPSCS2.Text = player1.SecondCard.CardSymbol;
                lblPSCT.Text = player1.SecondCard.CardType.ToString();
                cardsGiven++;
            }
            else
            {
                deck.SortDeck();
                cardsGiven = 0;
                BeginGamePlayer();
            }

            player1.Accumulated += player1.FirstCard.CardValue + player1.SecondCard.CardValue;
            lblPlayerScore.Text = player1.Accumulated.ToString();
        }

        public void BeginGamePlayer2()
        {
            if (!CheckCardsGiven())
            {
                player2.FirstCard = deck.GetDeck()[cardsGiven];
                lblCFCS1.Text = player2.FirstCard.CardSymbol;
                lblCFCS2.Text = player2.FirstCard.CardSymbol;
                lblCFCT.Text = player2.FirstCard.CardType.ToString();
                cardsGiven++;
            }
            else
            {
                deck.SortDeck();
                cardsGiven = 0;
                BeginGamePlayer2();
            }

            if (!CheckCardsGiven())
            {
                player2.SecondCard = deck.GetDeck()[cardsGiven];
                lblCSCS1.Text = player2.SecondCard.CardSymbol;
                lblCSCS2.Text = player2.SecondCard.CardSymbol;
                lblCSCT.Text = player2.SecondCard.CardType.ToString();
                cardsGiven++;
            }
            else
            {
                deck.SortDeck();
                cardsGiven = 0;
                BeginGamePlayer2();
            }

            player2.Accumulated += player2.FirstCard.CardValue + player2.SecondCard.CardValue;
            lblPlayer2Score.Text = player2.Accumulated.ToString();
        }

        public void GiveCardPlayer()
        {
            if (!CheckCardsGiven())
            {
                player1.ExtraCard = deck.GetDeck()[cardsGiven];
                lblPECS1.Text = player1.ExtraCard.CardSymbol;
                lblPECS2.Text = player1.ExtraCard.CardSymbol;
                lblPECT.Text = player1.ExtraCard.CardType.ToString();
                player1.Accumulated += player1.ExtraCard.CardValue;
                lblPlayerScore.Text = player1.Accumulated.ToString();
                cardsGiven++;

                if (CheckVictoryPlayer())
                {
                    DialogResult result;
                    result = MessageBox.Show("¡¡Player 1 wins!!", "Victory", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                    if (result == System.Windows.Forms.DialogResult.Retry)
                    {
                        player1.BetMoney += player1.BetValue + player2.BetValue;
                        frmTwoPlayersTable twoPlayersTable = new frmTwoPlayersTable(player1.Name, player1.BetMoney, player2.Name, player2.BetMoney);

                        int temp1 = twoPlayersTable.player2.Accumulated;
                        int temp2 = twoPlayersTable.player1.Accumulated;

                        twoPlayersTable.player2 = this.player2;
                        twoPlayersTable.player1 = this.player1;
                        twoPlayersTable.player2.Accumulated = temp1;
                        twoPlayersTable.player1.Accumulated = temp2;

                        twoPlayersTable.Show();
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
                    result = MessageBox.Show("¡¡Player 2 wins!!", "Victory", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.Retry)
                    {
                        player2.BetMoney += player1.BetValue + player2.BetValue;
                        frmTwoPlayersTable twoPlayerTable = new frmTwoPlayersTable(player1.Name, player1.BetMoney, player2.Name, player2.BetMoney);

                        int temp1 = twoPlayerTable.player2.Accumulated;
                        int temp2 = twoPlayerTable.player1.Accumulated;

                        twoPlayerTable.player2 = this.player2;
                        twoPlayerTable.player1 = this.player1;
                        twoPlayerTable.player2.Accumulated = temp1;
                        twoPlayerTable.player1.Accumulated = temp2;

                        twoPlayerTable.Show();
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

        public void GiveCardPlayer2()
        {
            if (!CheckCardsGiven())
            {
                player2.ExtraCard = deck.GetDeck()[cardsGiven];
                lblCECS1.Text = player2.ExtraCard.CardSymbol;
                lblCECS2.Text = player2.ExtraCard.CardSymbol;
                lblCECT.Text = player2.ExtraCard.CardType.ToString();
                player2.Accumulated += player2.ExtraCard.CardValue;
                lblPlayer2Score.Text = player2.Accumulated.ToString();
                cardsGiven++;

                if (CheckVictoryPlayer2())
                {
                    DialogResult result;
                    result = MessageBox.Show("¡¡Player 2 wins!!", "Victory", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.Retry)
                    {
                        player2.BetMoney += player1.BetValue + player2.BetValue;

                        frmTwoPlayersTable twoPlayersTable = new frmTwoPlayersTable(player1.Name, player1.BetMoney, player2.Name, player2.BetMoney);

                        int temp1 = twoPlayersTable.player2.Accumulated;
                        int temp2 = twoPlayersTable.player1.Accumulated;

                        twoPlayersTable.player2 = this.player2;
                        twoPlayersTable.player1 = this.player1;
                        twoPlayersTable.player2.Accumulated = temp1;
                        twoPlayersTable.player1.Accumulated = temp2;

                        twoPlayersTable.Show();
                        this.Hide();
                    }
                    else if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        frmMainMenu mainMenu = new frmMainMenu();
                        mainMenu.Show();
                        this.Close();
                    }
                }
                else if (CheckDefeatPlayer2())
                {
                    DialogResult result;
                    result = MessageBox.Show("¡¡Player 1 wins!!", "Victory", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.Retry)
                    {
                        player1.BetMoney += player1.BetValue + player2.BetValue;

                        frmTwoPlayersTable twoPlayersTable = new frmTwoPlayersTable(player1.Name, player1.BetMoney, player2.Name, player2.BetMoney);

                        int temp1 = twoPlayersTable.player2.Accumulated;
                        int temp2 = twoPlayersTable.player1.Accumulated;

                        twoPlayersTable.player2 = this.player2;
                        twoPlayersTable.player1 = this.player1;
                        twoPlayersTable.player2.Accumulated = temp1;
                        twoPlayersTable.player1.Accumulated = temp2;
                        twoPlayersTable.Show();
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
                GiveCardPlayer2();
            }
        }

        private bool CheckCardsGiven()
        {
            return cardsGiven == 52;
        }

        private bool CheckVictoryPlayer2()
        {
            return player2.Accumulated == 21;
        }

        private bool CheckDefeatPlayer2()
        {
            return player2.Accumulated > 21;
        }
        private bool CheckVictoryPlayer()
        {
            return player1.Accumulated == 21;
        }

        private bool CheckDefeatPlayer()
        {
            return player1.Accumulated > 21;
        }

        private bool checkDrawBegin()
        {
            if (player1.Accumulated == 21 && player2.Accumulated == 21)
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
            return player1.Accumulated == player2.Accumulated;
        }

        private void CheckVictory()
        {
            if (!CheckDefeatPlayer() && !CheckDefeatPlayer2() && !CheckVictoryPlayer() && !CheckVictoryPlayer2())
            {
                if (player1.Accumulated > player2.Accumulated)
                {
                    DialogResult result;
                    result = MessageBox.Show("¡¡Player 1 has won with a score of " + player1.Accumulated + " points!!", "Victory", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.Retry)
                    {
                        player1.BetMoney += player1.BetValue + player2.BetValue;
                        frmTwoPlayersTable twoPlayersTable = new frmTwoPlayersTable(player1.Name, player1.BetMoney, player2.Name, player2.BetMoney);

                        int temp1 = twoPlayersTable.player2.Accumulated;
                        int temp2 = twoPlayersTable.player1.Accumulated;

                        twoPlayersTable.player2 = this.player2;
                        twoPlayersTable.player1 = this.player1;
                        twoPlayersTable.player2.Accumulated = temp1;
                        twoPlayersTable.player1.Accumulated = temp2;


                        twoPlayersTable.Show();
                        this.Hide();
                    }
                    else if (result == System.Windows.Forms.DialogResult.Cancel)
                    {
                        frmMainMenu mainMenu = new frmMainMenu();
                        mainMenu.Show();
                        this.Close();
                    }
                }
                else if (player1.Accumulated < player2.Accumulated)
                {
                    DialogResult result;
                    result = MessageBox.Show("¡¡Player 2 has won with a score of  " + player2.Accumulated + " points!!", "Victory", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                    if (result == System.Windows.Forms.DialogResult.Retry)
                    {
                        player2.BetMoney += player1.BetValue + player2.BetValue;
                        frmTwoPlayersTable twoPlayersTable = new frmTwoPlayersTable(player1.Name, player1.BetMoney, player2.Name, player2.BetMoney);

                        int temp1 = twoPlayersTable.player2.Accumulated;
                        int temp2 = twoPlayersTable.player1.Accumulated;

                        twoPlayersTable.player2 = this.player2;
                        twoPlayersTable.player1 = this.player1;
                        twoPlayersTable.player2.Accumulated = temp1;
                        twoPlayersTable.player1.Accumulated = temp2;

                        this.Hide();
                        twoPlayersTable.Show();
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
                        player2.BetMoney += player2.BetValue;
                        player1.BetMoney += player1.BetValue;

                        frmTwoPlayersTable twoPlayersTable = new frmTwoPlayersTable(player1.Name, player1.BetMoney, player2.Name, player2.BetMoney);

                        int temp1 = twoPlayersTable.player2.Accumulated;
                        int temp2 = twoPlayersTable.player1.Accumulated;

                        twoPlayersTable.player2 = this.player2;
                        twoPlayersTable.player1 = this.player1;
                        twoPlayersTable.player2.Accumulated = temp1;
                        twoPlayersTable.player1.Accumulated = temp2;

                        twoPlayersTable.Show();
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

        private void FrmTwoPlayersTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void TxtPlayerBet2_TextChanged(object sender, EventArgs e)
        {
            if (txtPlayerBet.Text != "Bet")
            {
                btnBegin.Enabled = true;
            }
        }

        private void TxtPlayerBet_TextChanged(object sender, EventArgs e)
        {
            if (txtPlayerBet2.Text != "Bet")
            {
                btnBegin.Enabled = true;
            }
        }

        private void TxtPlayerBet2_Leave_1(object sender, EventArgs e)
        {
            if (txtPlayerBet2.Text == "")
            {
                txtPlayerBet2.Text = "Bet";
            }
        }

        private void TxtPlayerBet_Leave_1(object sender, EventArgs e)
        {
            if (txtPlayerBet.Text == "")
            {
                txtPlayerBet.Text = "Bet";
            }
        }

        private void TxtPlayerBet2_Click(object sender, EventArgs e)
        {
            if(txtPlayerBet2.Text == "Bet")
            {
                txtPlayerBet2.Text = "";
            }
        }

        private void TxtPlayerBet_Click(object sender, EventArgs e)
        {
            if (txtPlayerBet.Text == "Bet")
            {
                txtPlayerBet.Text = "";
            }
        }

        private void BtnBegin_Click(object sender, EventArgs e)
        {
            if (txtPlayerBet.Text == "Bet" || txtPlayerBet.Text == "" || txtPlayerBet2.Text == "Bet" || txtPlayerBet2.Text == "")
            {
                MessageBox.Show("Yo have to bet to start the game", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                player1.BetValue = Convert.ToInt32(txtPlayerBet.Text);
                player2.BetValue = Convert.ToInt32(txtPlayerBet2.Text);

                if (player1.BetValue > 100000 || player2.BetValue > 100000)
                {
                    MessageBox.Show("Bet must be less than 100,000", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (player1.BetMoney > 0 && player2.BetMoney > 0)
                    {
                        if (player1.BetMoney >= player1.BetValue && player2.BetMoney >= player2.BetValue)
                        {
                            player1.BetMoney -= player1.BetValue;
                            player2.BetMoney -= player2.BetValue;

                            btnBegin.Enabled = false;
                            txtPlayerBet.Enabled = false;
                            txtPlayerBet2.Enabled = false;
                            lblTurn.Visible = true;
                            btnAsk.Enabled = true;
                            btnPass.Enabled = true;
                            btnBegin.Enabled = false;
                            lblPlayerTotalMoney.Text = player1.BetMoney.ToString();
                            lblPlayer2TotalMoney.Text = player2.BetMoney.ToString();
                            lblPlayer2TotalMoney.Visible = true;
                            lblPlayerTotalMoney.Visible = true;
                            btnAsk.Visible = true;
                            btnPass.Visible = true;

                            if (checkDrawBegin())
                            {
                                DialogResult result;
                                result = MessageBox.Show("¡¡It's a tie!!", "Draw", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                                if (result == System.Windows.Forms.DialogResult.Retry)
                                {
                                    player2.BetMoney += player2.BetValue;
                                    player1.BetMoney += player1.BetValue;
                                    frmTwoPlayersTable twoPlayersTable = new frmTwoPlayersTable(player1.Name, player1.BetMoney, player2.Name, player2.BetMoney);

                                    int temp1 = twoPlayersTable.player2.Accumulated;
                                    int temp2 = twoPlayersTable.player1.Accumulated;

                                    twoPlayersTable.player2 = this.player2;
                                    twoPlayersTable.player1 = this.player1;
                                    twoPlayersTable.player2.Accumulated = temp1;
                                    twoPlayersTable.player1.Accumulated = temp2;


                                    twoPlayersTable.Show();
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
                                result = MessageBox.Show("¡¡Player 1 wins!!", "Victory", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                                if (result == System.Windows.Forms.DialogResult.Retry)
                                {
                                    player1.BetMoney += player1.BetValue + player2.BetValue;
                                    frmTwoPlayersTable twoPlayersTable = new frmTwoPlayersTable(player1.Name, player1.BetMoney, player2.Name, player2.BetMoney);

                                    int temp1 = twoPlayersTable.player2.Accumulated;
                                    int temp2 = twoPlayersTable.player1.Accumulated;

                                    twoPlayersTable.player2 = this.player2;
                                    twoPlayersTable.player1 = this.player1;
                                    twoPlayersTable.player2.Accumulated = temp1;
                                    twoPlayersTable.player1.Accumulated = temp2;


                                    twoPlayersTable.Show();
                                    this.Hide();
                                }
                                else if (result == System.Windows.Forms.DialogResult.Cancel)
                                {
                                    frmMainMenu mainMenu = new frmMainMenu();
                                    mainMenu.Show();
                                    this.Close();
                                }

                            }
                            else if (CheckVictoryPlayer2())
                            {
                                DialogResult result;
                                result = MessageBox.Show("¡¡Player 2 wins!!", "Victory", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                                if (result == System.Windows.Forms.DialogResult.Retry)
                                {
                                    player2.BetMoney += player1.BetValue + player2.BetValue;

                                    frmTwoPlayersTable twoPlayersTable = new frmTwoPlayersTable(player1.Name, player1.BetMoney, player2.Name, player2.BetMoney);

                                    int temp1 = twoPlayersTable.player2.Accumulated;
                                    int temp2 = twoPlayersTable.player1.Accumulated;

                                    twoPlayersTable.player2 = this.player2;
                                    twoPlayersTable.player1 = this.player1;
                                    twoPlayersTable.player2.Accumulated = temp1;
                                    twoPlayersTable.player1.Accumulated = temp2;

                                    this.Hide();
                                    twoPlayersTable.Show();
                                    
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
                        if (result == System.Windows.Forms.DialogResult.OK)
                        {
                            frmMainMenu mainMenu = new frmMainMenu();
                            mainMenu.Show();
                            this.Close();
                        }
                    }
                }
            }
        }

        private void BtnPass_Click(object sender, EventArgs e)
        {
            turn++;
            if(turn > 1)
            {
                lblTurn.Visible = false;
                lblTurn2.Visible = false;
                CheckVictory();
            }
            if(turn % 2 == 0)
            {
                lblTurn2.Visible = false;
                lblTurn.Visible = true;
            }
            else
            {
                lblTurn2.Visible = true;
                lblTurn.Visible = false;
            }
        }

        private void BtnAsk_Click_1(object sender, EventArgs e)
        {
            if(turn % 2 == 0)
            {
                GiveCardPlayer();
            }
            else
            {
                GiveCardPlayer2();
            }
        }
    }
}
