namespace Blackjack
{
    partial class frmTwoPlayersTable
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
            this.lblPlayerTotalMoney = new System.Windows.Forms.Label();
            this.lblPlayer2TotalMoney = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.btnAsk = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnBegin = new System.Windows.Forms.Button();
            this.txtPlayerBet2 = new System.Windows.Forms.TextBox();
            this.txtPlayerBet = new System.Windows.Forms.TextBox();
            this.lblPlayerName2 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.pnlComputerScore = new System.Windows.Forms.Panel();
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.pnlPlayerScore = new System.Windows.Forms.Panel();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.pnlComputerExtraCard = new System.Windows.Forms.Panel();
            this.lblCECT = new System.Windows.Forms.Label();
            this.lblCECS2 = new System.Windows.Forms.Label();
            this.lblCECS1 = new System.Windows.Forms.Label();
            this.pnlPlayerExtraCard = new System.Windows.Forms.Panel();
            this.lblPECT = new System.Windows.Forms.Label();
            this.lblPECS2 = new System.Windows.Forms.Label();
            this.lblPECS1 = new System.Windows.Forms.Label();
            this.pnlComputerSecondCard = new System.Windows.Forms.Panel();
            this.lblCSCT = new System.Windows.Forms.Label();
            this.lblCSCS2 = new System.Windows.Forms.Label();
            this.lblCSCS1 = new System.Windows.Forms.Label();
            this.pnlComputerFirstCard = new System.Windows.Forms.Panel();
            this.lblCFCT = new System.Windows.Forms.Label();
            this.lblCFCS2 = new System.Windows.Forms.Label();
            this.lblCFCS1 = new System.Windows.Forms.Label();
            this.pnlPlayerSecondCard = new System.Windows.Forms.Panel();
            this.lblPSCT = new System.Windows.Forms.Label();
            this.lblPSCS2 = new System.Windows.Forms.Label();
            this.lblPSCS1 = new System.Windows.Forms.Label();
            this.pnlPlayerFirstCard = new System.Windows.Forms.Panel();
            this.lblPFCT = new System.Windows.Forms.Label();
            this.lblPFCS2 = new System.Windows.Forms.Label();
            this.lblPFCS1 = new System.Windows.Forms.Label();
            this.lblTurn2 = new System.Windows.Forms.Label();
            this.pnlComputerScore.SuspendLayout();
            this.pnlPlayerScore.SuspendLayout();
            this.pnlComputerExtraCard.SuspendLayout();
            this.pnlPlayerExtraCard.SuspendLayout();
            this.pnlComputerSecondCard.SuspendLayout();
            this.pnlComputerFirstCard.SuspendLayout();
            this.pnlPlayerSecondCard.SuspendLayout();
            this.pnlPlayerFirstCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPlayerTotalMoney
            // 
            this.lblPlayerTotalMoney.AutoSize = true;
            this.lblPlayerTotalMoney.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTotalMoney.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPlayerTotalMoney.Location = new System.Drawing.Point(932, 117);
            this.lblPlayerTotalMoney.Name = "lblPlayerTotalMoney";
            this.lblPlayerTotalMoney.Size = new System.Drawing.Size(22, 27);
            this.lblPlayerTotalMoney.TabIndex = 29;
            this.lblPlayerTotalMoney.Text = "0";
            // 
            // lblPlayer2TotalMoney
            // 
            this.lblPlayer2TotalMoney.AutoSize = true;
            this.lblPlayer2TotalMoney.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2TotalMoney.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPlayer2TotalMoney.Location = new System.Drawing.Point(932, 389);
            this.lblPlayer2TotalMoney.Name = "lblPlayer2TotalMoney";
            this.lblPlayer2TotalMoney.Size = new System.Drawing.Size(22, 27);
            this.lblPlayer2TotalMoney.TabIndex = 28;
            this.lblPlayer2TotalMoney.Text = "0";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTurn.Location = new System.Drawing.Point(377, 18);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(231, 46);
            this.lblTurn.TabIndex = 27;
            this.lblTurn.Text = "YOUR TURN";
            this.lblTurn.Visible = false;
            // 
            // btnAsk
            // 
            this.btnAsk.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAsk.Enabled = false;
            this.btnAsk.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsk.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnAsk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAsk.Location = new System.Drawing.Point(384, 235);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(216, 60);
            this.btnAsk.TabIndex = 18;
            this.btnAsk.Text = "Ask";
            this.btnAsk.UseVisualStyleBackColor = false;
            this.btnAsk.Click += new System.EventHandler(this.BtnAsk_Click_1);
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.Color.OliveDrab;
            this.btnPass.Enabled = false;
            this.btnPass.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPass.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPass.Location = new System.Drawing.Point(80, 235);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(275, 60);
            this.btnPass.TabIndex = 26;
            this.btnPass.Text = "Pass";
            this.btnPass.UseVisualStyleBackColor = false;
            this.btnPass.Click += new System.EventHandler(this.BtnPass_Click);
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBegin.Enabled = false;
            this.btnBegin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBegin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBegin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnBegin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBegin.Location = new System.Drawing.Point(870, 235);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(146, 60);
            this.btnBegin.TabIndex = 25;
            this.btnBegin.Text = "Begin";
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.BtnBegin_Click);
            // 
            // txtPlayerBet2
            // 
            this.txtPlayerBet2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerBet2.Location = new System.Drawing.Point(870, 336);
            this.txtPlayerBet2.Name = "txtPlayerBet2";
            this.txtPlayerBet2.Size = new System.Drawing.Size(146, 34);
            this.txtPlayerBet2.TabIndex = 24;
            this.txtPlayerBet2.Text = "Bet";
            this.txtPlayerBet2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlayerBet2.Click += new System.EventHandler(this.TxtPlayerBet2_Click);
            this.txtPlayerBet2.TextChanged += new System.EventHandler(this.TxtPlayerBet2_TextChanged);
            this.txtPlayerBet2.Leave += new System.EventHandler(this.TxtPlayerBet2_Leave_1);
            // 
            // txtPlayerBet
            // 
            this.txtPlayerBet.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerBet.Location = new System.Drawing.Point(870, 170);
            this.txtPlayerBet.Name = "txtPlayerBet";
            this.txtPlayerBet.Size = new System.Drawing.Size(146, 34);
            this.txtPlayerBet.TabIndex = 23;
            this.txtPlayerBet.Text = "Bet";
            this.txtPlayerBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlayerBet.Click += new System.EventHandler(this.TxtPlayerBet_Click);
            this.txtPlayerBet.TextChanged += new System.EventHandler(this.TxtPlayerBet_TextChanged);
            this.txtPlayerBet.Leave += new System.EventHandler(this.TxtPlayerBet_Leave_1);
            // 
            // lblPlayerName2
            // 
            this.lblPlayerName2.AutoSize = true;
            this.lblPlayerName2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPlayerName2.Location = new System.Drawing.Point(77, 496);
            this.lblPlayerName2.Name = "lblPlayerName2";
            this.lblPlayerName2.Size = new System.Drawing.Size(120, 23);
            this.lblPlayerName2.TabIndex = 12;
            this.lblPlayerName2.Text = "Player 2 Name";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPlayerName.Location = new System.Drawing.Point(77, 18);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(107, 23);
            this.lblPlayerName.TabIndex = 19;
            this.lblPlayerName.Text = "Player Name";
            // 
            // pnlComputerScore
            // 
            this.pnlComputerScore.BackColor = System.Drawing.Color.White;
            this.pnlComputerScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlComputerScore.Controls.Add(this.lblPlayer2Score);
            this.pnlComputerScore.Location = new System.Drawing.Point(511, 336);
            this.pnlComputerScore.Name = "pnlComputerScore";
            this.pnlComputerScore.Size = new System.Drawing.Size(87, 113);
            this.pnlComputerScore.TabIndex = 20;
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.lblPlayer2Score.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPlayer2Score.Location = new System.Drawing.Point(16, 37);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(41, 44);
            this.lblPlayer2Score.TabIndex = 10;
            this.lblPlayer2Score.Text = "0";
            // 
            // pnlPlayerScore
            // 
            this.pnlPlayerScore.BackColor = System.Drawing.Color.White;
            this.pnlPlayerScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayerScore.Controls.Add(this.lblPlayerScore);
            this.pnlPlayerScore.Location = new System.Drawing.Point(511, 79);
            this.pnlPlayerScore.Name = "pnlPlayerScore";
            this.pnlPlayerScore.Size = new System.Drawing.Size(87, 113);
            this.pnlPlayerScore.TabIndex = 21;
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.lblPlayerScore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPlayerScore.Location = new System.Drawing.Point(16, 37);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(41, 44);
            this.lblPlayerScore.TabIndex = 9;
            this.lblPlayerScore.Text = "0";
            // 
            // pnlComputerExtraCard
            // 
            this.pnlComputerExtraCard.BackColor = System.Drawing.Color.White;
            this.pnlComputerExtraCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlComputerExtraCard.Controls.Add(this.lblCECT);
            this.pnlComputerExtraCard.Controls.Add(this.lblCECS2);
            this.pnlComputerExtraCard.Controls.Add(this.lblCECS1);
            this.pnlComputerExtraCard.Location = new System.Drawing.Point(384, 336);
            this.pnlComputerExtraCard.Name = "pnlComputerExtraCard";
            this.pnlComputerExtraCard.Size = new System.Drawing.Size(87, 113);
            this.pnlComputerExtraCard.TabIndex = 22;
            // 
            // lblCECT
            // 
            this.lblCECT.AutoSize = true;
            this.lblCECT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCECT.Location = new System.Drawing.Point(32, 48);
            this.lblCECT.Name = "lblCECT";
            this.lblCECT.Size = new System.Drawing.Size(24, 17);
            this.lblCECT.TabIndex = 14;
            this.lblCECT.Text = "♣";
            // 
            // lblCECS2
            // 
            this.lblCECS2.AutoSize = true;
            this.lblCECS2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCECS2.Location = new System.Drawing.Point(64, 90);
            this.lblCECS2.Name = "lblCECS2";
            this.lblCECS2.Size = new System.Drawing.Size(16, 17);
            this.lblCECS2.TabIndex = 13;
            this.lblCECS2.Text = "0";
            // 
            // lblCECS1
            // 
            this.lblCECS1.AutoSize = true;
            this.lblCECS1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCECS1.Location = new System.Drawing.Point(5, 4);
            this.lblCECS1.Name = "lblCECS1";
            this.lblCECS1.Size = new System.Drawing.Size(16, 17);
            this.lblCECS1.TabIndex = 12;
            this.lblCECS1.Text = "0";
            // 
            // pnlPlayerExtraCard
            // 
            this.pnlPlayerExtraCard.BackColor = System.Drawing.Color.White;
            this.pnlPlayerExtraCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayerExtraCard.Controls.Add(this.lblPECT);
            this.pnlPlayerExtraCard.Controls.Add(this.lblPECS2);
            this.pnlPlayerExtraCard.Controls.Add(this.lblPECS1);
            this.pnlPlayerExtraCard.Location = new System.Drawing.Point(384, 79);
            this.pnlPlayerExtraCard.Name = "pnlPlayerExtraCard";
            this.pnlPlayerExtraCard.Size = new System.Drawing.Size(87, 113);
            this.pnlPlayerExtraCard.TabIndex = 15;
            // 
            // lblPECT
            // 
            this.lblPECT.AutoSize = true;
            this.lblPECT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPECT.Location = new System.Drawing.Point(32, 48);
            this.lblPECT.Name = "lblPECT";
            this.lblPECT.Size = new System.Drawing.Size(24, 17);
            this.lblPECT.TabIndex = 11;
            this.lblPECT.Text = "♣";
            // 
            // lblPECS2
            // 
            this.lblPECS2.AutoSize = true;
            this.lblPECS2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPECS2.Location = new System.Drawing.Point(64, 91);
            this.lblPECS2.Name = "lblPECS2";
            this.lblPECS2.Size = new System.Drawing.Size(16, 17);
            this.lblPECS2.TabIndex = 10;
            this.lblPECS2.Text = "0";
            // 
            // lblPECS1
            // 
            this.lblPECS1.AutoSize = true;
            this.lblPECS1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPECS1.Location = new System.Drawing.Point(3, 4);
            this.lblPECS1.Name = "lblPECS1";
            this.lblPECS1.Size = new System.Drawing.Size(16, 17);
            this.lblPECS1.TabIndex = 9;
            this.lblPECS1.Text = "0";
            // 
            // pnlComputerSecondCard
            // 
            this.pnlComputerSecondCard.BackColor = System.Drawing.Color.White;
            this.pnlComputerSecondCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlComputerSecondCard.Controls.Add(this.lblCSCT);
            this.pnlComputerSecondCard.Controls.Add(this.lblCSCS2);
            this.pnlComputerSecondCard.Controls.Add(this.lblCSCS1);
            this.pnlComputerSecondCard.Location = new System.Drawing.Point(229, 336);
            this.pnlComputerSecondCard.Name = "pnlComputerSecondCard";
            this.pnlComputerSecondCard.Size = new System.Drawing.Size(126, 147);
            this.pnlComputerSecondCard.TabIndex = 14;
            // 
            // lblCSCT
            // 
            this.lblCSCT.AutoSize = true;
            this.lblCSCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblCSCT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCSCT.Location = new System.Drawing.Point(46, 57);
            this.lblCSCT.Name = "lblCSCT";
            this.lblCSCT.Size = new System.Drawing.Size(39, 29);
            this.lblCSCT.TabIndex = 20;
            this.lblCSCT.Text = "♣";
            // 
            // lblCSCS2
            // 
            this.lblCSCS2.AutoSize = true;
            this.lblCSCS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblCSCS2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCSCS2.Location = new System.Drawing.Point(91, 113);
            this.lblCSCS2.Name = "lblCSCS2";
            this.lblCSCS2.Size = new System.Drawing.Size(26, 29);
            this.lblCSCS2.TabIndex = 19;
            this.lblCSCS2.Text = "0";
            // 
            // lblCSCS1
            // 
            this.lblCSCS1.AutoSize = true;
            this.lblCSCS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblCSCS1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCSCS1.Location = new System.Drawing.Point(5, 5);
            this.lblCSCS1.Name = "lblCSCS1";
            this.lblCSCS1.Size = new System.Drawing.Size(26, 29);
            this.lblCSCS1.TabIndex = 18;
            this.lblCSCS1.Text = "0";
            // 
            // pnlComputerFirstCard
            // 
            this.pnlComputerFirstCard.BackColor = System.Drawing.Color.White;
            this.pnlComputerFirstCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlComputerFirstCard.Controls.Add(this.lblCFCT);
            this.pnlComputerFirstCard.Controls.Add(this.lblCFCS2);
            this.pnlComputerFirstCard.Controls.Add(this.lblCFCS1);
            this.pnlComputerFirstCard.Location = new System.Drawing.Point(80, 336);
            this.pnlComputerFirstCard.Name = "pnlComputerFirstCard";
            this.pnlComputerFirstCard.Size = new System.Drawing.Size(126, 147);
            this.pnlComputerFirstCard.TabIndex = 13;
            // 
            // lblCFCT
            // 
            this.lblCFCT.AutoSize = true;
            this.lblCFCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblCFCT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCFCT.Location = new System.Drawing.Point(44, 57);
            this.lblCFCT.Name = "lblCFCT";
            this.lblCFCT.Size = new System.Drawing.Size(39, 29);
            this.lblCFCT.TabIndex = 17;
            this.lblCFCT.Text = "♣";
            // 
            // lblCFCS2
            // 
            this.lblCFCS2.AutoSize = true;
            this.lblCFCS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblCFCS2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCFCS2.Location = new System.Drawing.Point(92, 113);
            this.lblCFCS2.Name = "lblCFCS2";
            this.lblCFCS2.Size = new System.Drawing.Size(26, 29);
            this.lblCFCS2.TabIndex = 16;
            this.lblCFCS2.Text = "0";
            // 
            // lblCFCS1
            // 
            this.lblCFCS1.AutoSize = true;
            this.lblCFCS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblCFCS1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCFCS1.Location = new System.Drawing.Point(3, 5);
            this.lblCFCS1.Name = "lblCFCS1";
            this.lblCFCS1.Size = new System.Drawing.Size(26, 29);
            this.lblCFCS1.TabIndex = 15;
            this.lblCFCS1.Text = "0";
            // 
            // pnlPlayerSecondCard
            // 
            this.pnlPlayerSecondCard.BackColor = System.Drawing.Color.White;
            this.pnlPlayerSecondCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayerSecondCard.Controls.Add(this.lblPSCT);
            this.pnlPlayerSecondCard.Controls.Add(this.lblPSCS2);
            this.pnlPlayerSecondCard.Controls.Add(this.lblPSCS1);
            this.pnlPlayerSecondCard.Location = new System.Drawing.Point(229, 45);
            this.pnlPlayerSecondCard.Name = "pnlPlayerSecondCard";
            this.pnlPlayerSecondCard.Size = new System.Drawing.Size(126, 147);
            this.pnlPlayerSecondCard.TabIndex = 16;
            // 
            // lblPSCT
            // 
            this.lblPSCT.AutoSize = true;
            this.lblPSCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblPSCT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPSCT.Location = new System.Drawing.Point(46, 59);
            this.lblPSCT.Name = "lblPSCT";
            this.lblPSCT.Size = new System.Drawing.Size(39, 29);
            this.lblPSCT.TabIndex = 14;
            this.lblPSCT.Text = "♣";
            // 
            // lblPSCS2
            // 
            this.lblPSCS2.AutoSize = true;
            this.lblPSCS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblPSCS2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPSCS2.Location = new System.Drawing.Point(92, 115);
            this.lblPSCS2.Name = "lblPSCS2";
            this.lblPSCS2.Size = new System.Drawing.Size(26, 29);
            this.lblPSCS2.TabIndex = 13;
            this.lblPSCS2.Text = "0";
            // 
            // lblPSCS1
            // 
            this.lblPSCS1.AutoSize = true;
            this.lblPSCS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblPSCS1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPSCS1.Location = new System.Drawing.Point(5, 7);
            this.lblPSCS1.Name = "lblPSCS1";
            this.lblPSCS1.Size = new System.Drawing.Size(26, 29);
            this.lblPSCS1.TabIndex = 12;
            this.lblPSCS1.Text = "0";
            // 
            // pnlPlayerFirstCard
            // 
            this.pnlPlayerFirstCard.BackColor = System.Drawing.Color.White;
            this.pnlPlayerFirstCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayerFirstCard.Controls.Add(this.lblPFCT);
            this.pnlPlayerFirstCard.Controls.Add(this.lblPFCS2);
            this.pnlPlayerFirstCard.Controls.Add(this.lblPFCS1);
            this.pnlPlayerFirstCard.Location = new System.Drawing.Point(80, 45);
            this.pnlPlayerFirstCard.Name = "pnlPlayerFirstCard";
            this.pnlPlayerFirstCard.Size = new System.Drawing.Size(126, 147);
            this.pnlPlayerFirstCard.TabIndex = 17;
            // 
            // lblPFCT
            // 
            this.lblPFCT.AutoSize = true;
            this.lblPFCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblPFCT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPFCT.Location = new System.Drawing.Point(44, 59);
            this.lblPFCT.Name = "lblPFCT";
            this.lblPFCT.Size = new System.Drawing.Size(39, 29);
            this.lblPFCT.TabIndex = 17;
            this.lblPFCT.Text = "♣";
            // 
            // lblPFCS2
            // 
            this.lblPFCS2.AutoSize = true;
            this.lblPFCS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblPFCS2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPFCS2.Location = new System.Drawing.Point(92, 115);
            this.lblPFCS2.Name = "lblPFCS2";
            this.lblPFCS2.Size = new System.Drawing.Size(26, 29);
            this.lblPFCS2.TabIndex = 16;
            this.lblPFCS2.Text = "0";
            // 
            // lblPFCS1
            // 
            this.lblPFCS1.AutoSize = true;
            this.lblPFCS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblPFCS1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPFCS1.Location = new System.Drawing.Point(3, 7);
            this.lblPFCS1.Name = "lblPFCS1";
            this.lblPFCS1.Size = new System.Drawing.Size(26, 29);
            this.lblPFCS1.TabIndex = 15;
            this.lblPFCS1.Text = "0";
            // 
            // lblTurn2
            // 
            this.lblTurn2.AutoSize = true;
            this.lblTurn2.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn2.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTurn2.Location = new System.Drawing.Point(377, 467);
            this.lblTurn2.Name = "lblTurn2";
            this.lblTurn2.Size = new System.Drawing.Size(231, 46);
            this.lblTurn2.TabIndex = 30;
            this.lblTurn2.Text = "YOUR TURN";
            this.lblTurn2.Visible = false;
            // 
            // frmTwoPlayersTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1093, 533);
            this.Controls.Add(this.lblTurn2);
            this.Controls.Add(this.lblPlayerTotalMoney);
            this.Controls.Add(this.lblPlayer2TotalMoney);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.btnAsk);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.txtPlayerBet2);
            this.Controls.Add(this.txtPlayerBet);
            this.Controls.Add(this.lblPlayerName2);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.pnlComputerScore);
            this.Controls.Add(this.pnlPlayerScore);
            this.Controls.Add(this.pnlComputerExtraCard);
            this.Controls.Add(this.pnlPlayerExtraCard);
            this.Controls.Add(this.pnlComputerSecondCard);
            this.Controls.Add(this.pnlComputerFirstCard);
            this.Controls.Add(this.pnlPlayerSecondCard);
            this.Controls.Add(this.pnlPlayerFirstCard);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTwoPlayersTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTwoPlayersTable_FormClosing);
            this.pnlComputerScore.ResumeLayout(false);
            this.pnlComputerScore.PerformLayout();
            this.pnlPlayerScore.ResumeLayout(false);
            this.pnlPlayerScore.PerformLayout();
            this.pnlComputerExtraCard.ResumeLayout(false);
            this.pnlComputerExtraCard.PerformLayout();
            this.pnlPlayerExtraCard.ResumeLayout(false);
            this.pnlPlayerExtraCard.PerformLayout();
            this.pnlComputerSecondCard.ResumeLayout(false);
            this.pnlComputerSecondCard.PerformLayout();
            this.pnlComputerFirstCard.ResumeLayout(false);
            this.pnlComputerFirstCard.PerformLayout();
            this.pnlPlayerSecondCard.ResumeLayout(false);
            this.pnlPlayerSecondCard.PerformLayout();
            this.pnlPlayerFirstCard.ResumeLayout(false);
            this.pnlPlayerFirstCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerTotalMoney;
        private System.Windows.Forms.Label lblPlayer2TotalMoney;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Button btnAsk;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.TextBox txtPlayerBet2;
        private System.Windows.Forms.TextBox txtPlayerBet;
        private System.Windows.Forms.Label lblPlayerName2;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Panel pnlComputerScore;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Panel pnlPlayerScore;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Panel pnlComputerExtraCard;
        private System.Windows.Forms.Label lblCECT;
        private System.Windows.Forms.Label lblCECS2;
        private System.Windows.Forms.Label lblCECS1;
        private System.Windows.Forms.Panel pnlPlayerExtraCard;
        private System.Windows.Forms.Label lblPECT;
        private System.Windows.Forms.Label lblPECS2;
        private System.Windows.Forms.Label lblPECS1;
        private System.Windows.Forms.Panel pnlComputerSecondCard;
        private System.Windows.Forms.Label lblCSCT;
        private System.Windows.Forms.Label lblCSCS2;
        private System.Windows.Forms.Label lblCSCS1;
        private System.Windows.Forms.Panel pnlComputerFirstCard;
        private System.Windows.Forms.Label lblCFCT;
        private System.Windows.Forms.Label lblCFCS2;
        private System.Windows.Forms.Label lblCFCS1;
        private System.Windows.Forms.Panel pnlPlayerSecondCard;
        private System.Windows.Forms.Label lblPSCT;
        private System.Windows.Forms.Label lblPSCS2;
        private System.Windows.Forms.Label lblPSCS1;
        private System.Windows.Forms.Panel pnlPlayerFirstCard;
        private System.Windows.Forms.Label lblPFCT;
        private System.Windows.Forms.Label lblPFCS2;
        private System.Windows.Forms.Label lblPFCS1;
        private System.Windows.Forms.Label lblTurn2;
    }
}