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
    public partial class TwoPlayersMenu : Form
    {
        private string playerName1;
        private string playerName2;
        public TwoPlayersMenu()
        {
            InitializeComponent();
        }
        public string PlayerName1
        {
            get { return playerName1; }
            set { playerName1 = value; }
        }

        public string PlayerName2
        {
            get { return playerName2; }
            set { playerName2 = value; }
        }

        private void MenuDosJugadores_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu menuPrincipal = new frmMainMenu();
            menuPrincipal.Show();
            this.Hide();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Insert player name 1")
            {
                txtNombre.Text = "";
            }
        }

        private void TxtNombre2_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre2.Text == "Insert name player 2")
            {
                txtNombre2.Text = "";
            }
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Insert name player 1";
            }
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            string name = txtNombre.Text;
            string name2 = txtNombre2.Text;

            if (name == "Insert name player 1" || name2 == "Insert name player 2" || name2 == "")
            {
                MessageBox.Show("Before continuing, please insert your name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PlayerName1 = name;
                PlayerName2 = name2;
                frmTwoPlayersTable twoPlayersTable = new frmTwoPlayersTable(name, 200000, name2, 200000);
                twoPlayersTable.Show();
                this.Hide();
            }
        }

        private void TxtNombre2_Click(object sender, EventArgs e)
        {
            if (txtNombre2.Text == "Insert name player 2")
            {
                txtNombre2.Text = "";
            }
        }

        private void TxtNombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Insert name player 1")
            {
                txtNombre.Text = "";
            }
        }

        private void TxtNombre2_Leave(object sender, EventArgs e)
        {
            if (txtNombre2.Text == "")
            {
                txtNombre2.Text = "Insert name player 2";
            }
        }
    }
}
