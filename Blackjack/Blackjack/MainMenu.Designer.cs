namespace Blackjack
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOnePlayer = new System.Windows.Forms.Button();
            this.btnTwoPlayers = new System.Windows.Forms.Button();
            this.lblBlackjack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOnePlayer
            // 
            this.btnOnePlayer.BackColor = System.Drawing.Color.OliveDrab;
            this.btnOnePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnePlayer.Location = new System.Drawing.Point(103, 117);
            this.btnOnePlayer.Name = "btnOnePlayer";
            this.btnOnePlayer.Size = new System.Drawing.Size(122, 53);
            this.btnOnePlayer.TabIndex = 0;
            this.btnOnePlayer.Text = "One Player";
            this.btnOnePlayer.UseVisualStyleBackColor = false;
            this.btnOnePlayer.Click += new System.EventHandler(this.btnOnePlayer_Click);
            // 
            // btnTwoPlayers
            // 
            this.btnTwoPlayers.BackColor = System.Drawing.Color.OliveDrab;
            this.btnTwoPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwoPlayers.Location = new System.Drawing.Point(103, 176);
            this.btnTwoPlayers.Name = "btnTwoPlayers";
            this.btnTwoPlayers.Size = new System.Drawing.Size(122, 53);
            this.btnTwoPlayers.TabIndex = 1;
            this.btnTwoPlayers.Text = "Two Players";
            this.btnTwoPlayers.UseVisualStyleBackColor = false;
            this.btnTwoPlayers.Click += new System.EventHandler(this.btnTwoPlayers_Click);
            // 
            // lblBlackjack
            // 
            this.lblBlackjack.AutoSize = true;
            this.lblBlackjack.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlackjack.Location = new System.Drawing.Point(98, 20);
            this.lblBlackjack.Name = "lblBlackjack";
            this.lblBlackjack.Size = new System.Drawing.Size(132, 27);
            this.lblBlackjack.TabIndex = 2;
            this.lblBlackjack.Text = "BLACKJACK";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(317, 294);
            this.Controls.Add(this.lblBlackjack);
            this.Controls.Add(this.btnTwoPlayers);
            this.Controls.Add(this.btnOnePlayer);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOnePlayer;
        private System.Windows.Forms.Button btnTwoPlayers;
        private System.Windows.Forms.Label lblBlackjack;
    }
}

