using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form2 : Form
    {
        Form1 f1;

        public Form2(Form1 incomingForm)
        {
            InitializeComponent();

            f1 = incomingForm;
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            btnQuestionAnswer.Text += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            btnQuestionAnswer.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            btnQuestionAnswer.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            btnQuestionAnswer.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            btnQuestionAnswer.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            btnQuestionAnswer.Text += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            btnQuestionAnswer.Text += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            btnQuestionAnswer.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            btnQuestionAnswer.Text += "9";
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            btnQuestionAnswer.Text += "0";
        }

        private void btnNumClear_Click(object sender, EventArgs e)
        {
            btnQuestionAnswer.Text = "";
        }

        public void btnAnswer_Click(object sender, EventArgs e)
        {
            int a, b, c, d;

            if (btnQuestionAnswer.Text != "")
            {
                a = Convert.ToInt16(btnQuestionOne.Text);
                b = Convert.ToInt16(btnQuestionTwo.Text);
                d = Convert.ToInt16(btnQuestionAnswer.Text);

                c = a + b;

                if (playerNum.Text == "1")
                {
                    if (d == c)
                    {
                        if (positionLb.Text == "1")
                        {
                            f1.btnA1.Text = "X";
                            f1.btnA1.Enabled = false;
                            f1.checkForWinner();
                            f1.playerSelect = true;
                            f1.tieGame();
                            this.Hide();
                            f1.Visible = true;
                            f1.playerXLb.Visible = false;
                            f1.playerOLb.Visible = true;

                            
                        }
                        if (positionLb.Text == "2")
                        {
                            f1.btnA2.Text = "X";
                            f1.btnA2.Enabled = false;
                            f1.checkForWinner();
                            f1.playerSelect = true;
                            f1.tieGame();
                            this.Hide();
                            f1.Visible = true;
                            f1.playerXLb.Visible = false;
                            f1.playerOLb.Visible = true;

                            
                        }
                        if (positionLb.Text == "3")
                        {
                            f1.btnA3.Text = "X";
                            f1.btnA3.Enabled = false;
                            f1.checkForWinner();
                            f1.playerSelect = true;
                            f1.tieGame();
                            f1.Visible = true;
                            f1.playerXLb.Visible = false;
                            f1.playerOLb.Visible = true;

                            this.Hide();
                        }
                        if (positionLb.Text == "4")
                        {
                            f1.btnB1.Text = "X";
                            f1.btnB1.Enabled = false;
                            f1.checkForWinner();
                            f1.playerSelect = true;
                            f1.tieGame();
                            f1.Visible = true;
                            f1.playerXLb.Visible = false;
                            f1.playerOLb.Visible = true;

                            this.Hide();
                        }
                        if (positionLb.Text == "5")
                        {
                            f1.btnB2.Text = "X";
                            f1.btnB2.Enabled = false;
                            f1.checkForWinner();
                            f1.playerSelect = true;
                            f1.tieGame();
                            f1.Visible = true;
                            f1.playerXLb.Visible = false;
                            f1.playerOLb.Visible = true;

                            this.Hide();
                        }
                        if (positionLb.Text == "6")
                        {
                            f1.btnB3.Text = "X";
                            f1.btnB3.Enabled = false;
                            f1.checkForWinner();
                            f1.playerSelect = true;
                            f1.tieGame();
                            f1.Visible = true;
                            f1.playerXLb.Visible = false;
                            f1.playerOLb.Visible = true;

                            this.Hide();
                        }
                        if (positionLb.Text == "7")
                        {
                            f1.btnC1.Text = "X";
                            f1.btnC1.Enabled = false;
                            f1.checkForWinner();
                            f1.playerSelect = true;
                            f1.tieGame();
                            f1.Visible = true;
                            f1.playerXLb.Visible = false;
                            f1.playerOLb.Visible = true;

                            this.Hide();
                        }
                        if (positionLb.Text == "8")
                        {
                            f1.btnC2.Text = "X";
                            f1.btnC2.Enabled = false;
                            f1.checkForWinner();
                            f1.playerSelect = true;
                            f1.tieGame();
                            f1.Visible = true;
                            f1.playerXLb.Visible = false;
                            f1.playerOLb.Visible = true;

                            this.Hide();
                        }
                        if (positionLb.Text == "9")
                        {
                            f1.btnC3.Text = "X";
                            f1.btnC3.Enabled = false;
                            f1.checkForWinner();
                            f1.playerSelect = true;
                            f1.tieGame();
                            f1.Visible = true;
                            f1.playerXLb.Visible = false;
                            f1.playerOLb.Visible = true;

                            this.Hide();
                        }
                    }
                }                

                else if (playerNum.Text == "2")
                {
                    if (d == c)
                    {
                        if (positionLb.Text == "1")
                        {
                            f1.btnA1.Text = "O";
                            f1.btnA1.Enabled = false;
                            f1.checkForWinner();
                            f1.playerSelect = false;
                            f1.tieGame();
                            f1.Visible = true;
                            f1.playerXLb.Visible = true;
                            f1.playerOLb.Visible = false;

                            this.Hide();
                        }
                        if (positionLb.Text == "2")
                        {
                            f1.btnA2.Text = "O";
                            f1.btnA2.Enabled = false;
                            f1.checkForWinner();
                            f1.playerSelect = false;
                            f1.tieGame();
                            f1.Visible = true;
                            f1.playerXLb.Visible = true;
                            f1.playerOLb.Visible = false;

                            this.Hide();
                        }
                        if (positionLb.Text == "3")
                        {
                            f1.btnA3.Text = "O";
                            f1.btnA3.Enabled = false;
                            f1.checkForWinner();
                            f1.playerSelect = false;
                            f1.tieGame();
                            f1.Visible = true;
                            f1.playerXLb.Visible = true;
                            f1.playerOLb.Visible = false;

                            this.Hide();
                        }
                        if (positionLb.Text == "4")
                        {
                            f1.btnB1.Text = "O";
                            f1.btnB1.Enabled = false;
                            f1.checkForWinner();
                            f1.playerSelect = false;
                            f1.tieGame();
                            f1.Visible = true;
                            f1.playerXLb.Visible = true;
                            f1.playerOLb.Visible = false;

                            this.Hide();
                        }
                        if (positionLb.Text == "5")
                        {
                            f1.btnB2.Text = "O";
                            f1.btnB2.Enabled = false;
                            f1.checkForWinner();
                            f1.playerSelect = false;
                            f1.tieGame();
                            f1.Visible = true;
                            f1.playerXLb.Visible = true;
                            f1.playerOLb.Visible = false;

                            this.Hide();
                        }
                        if (positionLb.Text == "6")
                        {
                            f1.btnB3.Text = "O";
                            f1.btnB3.Enabled = false;
                            f1.checkForWinner();
                            f1.playerSelect = false;
                            f1.tieGame();
                            f1.Visible = true;
                            f1.playerXLb.Visible = true;
                            f1.playerOLb.Visible = false;

                            this.Hide();
                        }
                        if (positionLb.Text == "7")
                        {
                            f1.btnC1.Text = "O";
                            f1.btnC1.Enabled = false;
                            f1.checkForWinner();
                            f1.playerSelect = false;
                            f1.tieGame();
                            f1.Visible = true;
                            f1.playerXLb.Visible = true;
                            f1.playerOLb.Visible = false;

                            this.Hide();
                        }
                        if (positionLb.Text == "8")
                        {
                            f1.btnC2.Text = "O";
                            f1.btnC2.Enabled = false;
                            f1.checkForWinner();
                            f1.playerSelect = false;
                            f1.tieGame();
                            f1.Visible = true;
                            f1.playerXLb.Visible = true;
                            f1.playerOLb.Visible = false;

                            this.Hide();
                        }
                        if (positionLb.Text == "9")
                        {
                            f1.btnC3.Text = "O";
                            f1.btnC3.Enabled = false;
                            f1.checkForWinner();
                            f1.playerSelect = false;
                            f1.tieGame();
                            f1.Visible = true;
                            f1.playerXLb.Visible = true;
                            f1.playerOLb.Visible = false;

                            this.Hide();
                        }
                    }
                }
                if (d != c)
                {
                    f1.playerSelect = !f1.playerSelect;

                    if (f1.playerSelect == false)
                    {
                        f1.playerXLb.Visible = true;
                        f1.playerOLb.Visible = false;
                    }
                    if (f1.playerSelect == true)
                    {
                        f1.playerXLb.Visible = false;
                        f1.playerOLb.Visible = true;
                    }

                    f1.Visible = true;
                    this.Hide();
                }
            }
        }


    }
}
