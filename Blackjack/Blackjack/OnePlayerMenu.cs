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
    public partial class frmOnePlayerMenu : Form
    {
        private string playerName;

        public frmOnePlayerMenu()
        {
            InitializeComponent();
        }

        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            if (name == "Insert your name")
            {
                MessageBox.Show("Before continuing, please insert your name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PlayerName = name;
                frmOnePlayerTable onePlayerTable = new frmOnePlayerTable(name, 200000, 200000);
                onePlayerTable.Show();
                this.Hide();
            }
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "Insert your name")
            {
                txtName.Text = "";
            }
        }

        private void frmOnePlayerMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void TxtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Insert your name";
            }
        }
    }
}