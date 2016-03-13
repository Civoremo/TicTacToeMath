namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /*protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }*/

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlayerOneScore = new System.Windows.Forms.Button();
            this.btnPlayerTwoScore = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnA1 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.playerXLb = new System.Windows.Forms.Label();
            this.playerOLb = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Motorwerk", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Motorwerk", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem,
            this.practiceToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            // 
            // startGameToolStripMenuItem
            // 
            this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            this.startGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startGameToolStripMenuItem.Text = "Start";
            this.startGameToolStripMenuItem.Click += new System.EventHandler(this.startGameToolStripMenuItem_Click);
            // 
            // practiceToolStripMenuItem
            // 
            this.practiceToolStripMenuItem.Name = "practiceToolStripMenuItem";
            this.practiceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.practiceToolStripMenuItem.Text = "Practice";
            this.practiceToolStripMenuItem.Click += new System.EventHandler(this.practiceToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btnPlayerOneScore
            // 
            this.btnPlayerOneScore.Enabled = false;
            this.btnPlayerOneScore.Font = new System.Drawing.Font("Motorwerk", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerOneScore.Location = new System.Drawing.Point(243, 50);
            this.btnPlayerOneScore.Name = "btnPlayerOneScore";
            this.btnPlayerOneScore.Size = new System.Drawing.Size(75, 50);
            this.btnPlayerOneScore.TabIndex = 3;
            this.btnPlayerOneScore.Text = "0";
            this.btnPlayerOneScore.UseVisualStyleBackColor = true;
            // 
            // btnPlayerTwoScore
            // 
            this.btnPlayerTwoScore.Enabled = false;
            this.btnPlayerTwoScore.Font = new System.Drawing.Font("Motorwerk", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerTwoScore.Location = new System.Drawing.Point(371, 50);
            this.btnPlayerTwoScore.Name = "btnPlayerTwoScore";
            this.btnPlayerTwoScore.Size = new System.Drawing.Size(75, 50);
            this.btnPlayerTwoScore.TabIndex = 4;
            this.btnPlayerTwoScore.Text = "0";
            this.btnPlayerTwoScore.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Motorwerk", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // btnA1
            // 
            this.btnA1.BackColor = System.Drawing.Color.SeaShell;
            this.btnA1.Font = new System.Drawing.Font("Andy", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA1.Location = new System.Drawing.Point(226, 141);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(75, 75);
            this.btnA1.TabIndex = 6;
            this.btnA1.UseVisualStyleBackColor = false;
            this.btnA1.Click += new System.EventHandler(this.btnA1_Click);
            // 
            // btnA2
            // 
            this.btnA2.BackColor = System.Drawing.Color.SeaShell;
            this.btnA2.Font = new System.Drawing.Font("Andy", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA2.Location = new System.Drawing.Point(307, 141);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(75, 75);
            this.btnA2.TabIndex = 7;
            this.btnA2.UseVisualStyleBackColor = false;
            this.btnA2.Click += new System.EventHandler(this.btnA2_Click);
            // 
            // btnA3
            // 
            this.btnA3.BackColor = System.Drawing.Color.SeaShell;
            this.btnA3.Font = new System.Drawing.Font("Andy", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA3.Location = new System.Drawing.Point(388, 141);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(75, 75);
            this.btnA3.TabIndex = 8;
            this.btnA3.UseVisualStyleBackColor = false;
            this.btnA3.Click += new System.EventHandler(this.btnA3_Click);
            // 
            // btnB3
            // 
            this.btnB3.BackColor = System.Drawing.Color.SeaShell;
            this.btnB3.Font = new System.Drawing.Font("Andy", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB3.Location = new System.Drawing.Point(388, 222);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(75, 75);
            this.btnB3.TabIndex = 11;
            this.btnB3.UseVisualStyleBackColor = false;
            this.btnB3.Click += new System.EventHandler(this.btnB3_Click);
            // 
            // btnB2
            // 
            this.btnB2.BackColor = System.Drawing.Color.SeaShell;
            this.btnB2.Font = new System.Drawing.Font("Andy", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB2.Location = new System.Drawing.Point(307, 222);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(75, 75);
            this.btnB2.TabIndex = 10;
            this.btnB2.UseVisualStyleBackColor = false;
            this.btnB2.Click += new System.EventHandler(this.btnB2_Click);
            // 
            // btnB1
            // 
            this.btnB1.BackColor = System.Drawing.Color.SeaShell;
            this.btnB1.Font = new System.Drawing.Font("Andy", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB1.Location = new System.Drawing.Point(226, 222);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(75, 75);
            this.btnB1.TabIndex = 9;
            this.btnB1.UseVisualStyleBackColor = false;
            this.btnB1.Click += new System.EventHandler(this.btnB1_Click);
            // 
            // btnC3
            // 
            this.btnC3.BackColor = System.Drawing.Color.SeaShell;
            this.btnC3.Font = new System.Drawing.Font("Andy", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC3.Location = new System.Drawing.Point(388, 303);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(75, 75);
            this.btnC3.TabIndex = 14;
            this.btnC3.UseVisualStyleBackColor = false;
            this.btnC3.Click += new System.EventHandler(this.btnC3_Click);
            // 
            // btnC2
            // 
            this.btnC2.BackColor = System.Drawing.Color.SeaShell;
            this.btnC2.Font = new System.Drawing.Font("Andy", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC2.Location = new System.Drawing.Point(307, 303);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(75, 75);
            this.btnC2.TabIndex = 13;
            this.btnC2.UseVisualStyleBackColor = false;
            this.btnC2.Click += new System.EventHandler(this.btnC2_Click);
            // 
            // btnC1
            // 
            this.btnC1.BackColor = System.Drawing.Color.SeaShell;
            this.btnC1.Font = new System.Drawing.Font("Andy", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC1.Location = new System.Drawing.Point(226, 303);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(75, 75);
            this.btnC1.TabIndex = 12;
            this.btnC1.UseVisualStyleBackColor = false;
            this.btnC1.Click += new System.EventHandler(this.btnC1_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Lime;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(258, 384);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(171, 50);
            this.btnNewGame.TabIndex = 15;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Visible = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // playerXLb
            // 
            this.playerXLb.AutoSize = true;
            this.playerXLb.Font = new System.Drawing.Font("Motorwerk", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerXLb.Location = new System.Drawing.Point(66, 233);
            this.playerXLb.Name = "playerXLb";
            this.playerXLb.Size = new System.Drawing.Size(55, 49);
            this.playerXLb.TabIndex = 16;
            this.playerXLb.Text = "X";
            // 
            // playerOLb
            // 
            this.playerOLb.AutoSize = true;
            this.playerOLb.Font = new System.Drawing.Font("Motorwerk", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOLb.Location = new System.Drawing.Point(531, 233);
            this.playerOLb.Name = "playerOLb";
            this.playerOLb.Size = new System.Drawing.Size(60, 49);
            this.playerOLb.TabIndex = 17;
            this.playerOLb.Text = "O";
            this.playerOLb.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(669, 437);
            this.Controls.Add(this.playerOLb);
            this.Controls.Add(this.playerXLb);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnC3);
            this.Controls.Add(this.btnC2);
            this.Controls.Add(this.btnC1);
            this.Controls.Add(this.btnB3);
            this.Controls.Add(this.btnB2);
            this.Controls.Add(this.btnB1);
            this.Controls.Add(this.btnA3);
            this.Controls.Add(this.btnA2);
            this.Controls.Add(this.btnA1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPlayerTwoScore);
            this.Controls.Add(this.btnPlayerOneScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnPlayerOneScore;
        private System.Windows.Forms.Button btnPlayerTwoScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewGame;
        public System.Windows.Forms.Button btnA1;
        public System.Windows.Forms.Button btnA2;
        public System.Windows.Forms.Button btnA3;
        public System.Windows.Forms.Button btnB3;
        public System.Windows.Forms.Button btnB2;
        public System.Windows.Forms.Button btnB1;
        public System.Windows.Forms.Button btnC3;
        public System.Windows.Forms.Button btnC2;
        public System.Windows.Forms.Button btnC1;
        public System.Windows.Forms.Label playerXLb;
        public System.Windows.Forms.Label playerOLb;
    }
}

