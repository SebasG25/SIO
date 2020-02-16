namespace Blackjack
{
    partial class TwoPlayersMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(21, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 2);
            this.panel1.TabIndex = 7;
            // 
            // btnContinuar
            // 
            this.btnContinuar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnContinuar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(19, 116);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(179, 67);
            this.btnContinuar.TabIndex = 6;
            this.btnContinuar.Text = "Continue";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.BtnContinuar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.LightSalmon;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(37, 17);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 24);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Tag = "";
            this.txtNombre.Text = "Insert name player 1";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.Click += new System.EventHandler(this.TxtNombre_Click);
            this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.txtNombre.Leave += new System.EventHandler(this.TxtNombre_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(21, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 2);
            this.panel2.TabIndex = 9;
            // 
            // txtNombre2
            // 
            this.txtNombre2.BackColor = System.Drawing.Color.LightSalmon;
            this.txtNombre2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre2.Location = new System.Drawing.Point(37, 62);
            this.txtNombre2.Multiline = true;
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(143, 24);
            this.txtNombre2.TabIndex = 8;
            this.txtNombre2.Tag = "";
            this.txtNombre2.Text = "Insert name player 2";
            this.txtNombre2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre2.Click += new System.EventHandler(this.TxtNombre2_Click);
            this.txtNombre2.TextChanged += new System.EventHandler(this.TxtNombre2_TextChanged);
            this.txtNombre2.Leave += new System.EventHandler(this.TxtNombre2_Leave);
            // 
            // TwoPlayersMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(217, 231);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.txtNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TwoPlayersMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuDosJugadores_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNombre2;
    }
}