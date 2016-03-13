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
    public partial class Form1 : Form
    {
        public bool playerSelect;
        public int buttonCount;
        Form2 f2;
        
        
        
        public Form1()
        {
            InitializeComponent();

            playerSelect = false;
            buttonCount = 0;
                        
        }

        public void btnA1_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();

            int firstNumber = randomNumber.Next(0, 10);
            int secondNumber = randomNumber.Next(0, 10);

            if (playerSelect == false)
            {
                f2 = new Form2(this);
                f2.btnQuestionOne.Text = Convert.ToString(firstNumber);
                f2.btnQuestionTwo.Text = Convert.ToString(secondNumber);
                f2.positionLb.Text = "1";
                f2.playerNum.Text = "1";
                f2.Show();
                this.Visible = false;
            }
            if (playerSelect == true)
            {
                f2 = new Form2(this);
                f2.btnQuestionOne.Text = Convert.ToString(firstNumber);
                f2.btnQuestionTwo.Text = Convert.ToString(secondNumber);
                f2.positionLb.Text = "1";
                f2.playerNum.Text = "2";
                f2.Show();
                this.Visible = false;
            }

            /*
            if (playerSelect == false)
            {
                btnA1.Text = "X";
            }
            else
            {
                btnA1.Text = "O";
            }
            btnA1.Enabled = false;
            checkForWinner();
            playerSelect = !playerSelect;
            tieGame();
             * */
        }

        public void btnA2_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();

            int firstNumber = randomNumber.Next(0, 10);
            int secondNumber = randomNumber.Next(0, 10);

            if (playerSelect == false)
            {
                f2 = new Form2(this);
                f2.btnQuestionOne.Text = Convert.ToString(firstNumber);
                f2.btnQuestionTwo.Text = Convert.ToString(secondNumber);
                f2.positionLb.Text = "2";
                f2.playerNum.Text = "1";
                f2.Show();
                this.Visible = false;
            }
            if (playerSelect == true)
            {
                f2 = new Form2(this);
                f2.btnQuestionOne.Text = Convert.ToString(firstNumber);
                f2.btnQuestionTwo.Text = Convert.ToString(secondNumber);
                f2.positionLb.Text = "2";
                f2.playerNum.Text = "2";
                f2.Show();
                this.Visible = false;
            }

            /*
            if (playerSelect == false)
            {
                btnA2.Text = "X";
            }
            else
            {
                btnA2.Text = "O";
            }
            btnA2.Enabled = false;
            checkForWinner();
            playerSelect = !playerSelect;
            tieGame();
             */ 
        }

        public void btnA3_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();

            int firstNumber = randomNumber.Next(0, 10);
            int secondNumber = randomNumber.Next(0, 10);

            if (playerSelect == false)
            {
                f2 = new Form2(this);
                f2.btnQuestionOne.Text = Convert.ToString(firstNumber);
                f2.btnQuestionTwo.Text = Convert.ToString(secondNumber);
                f2.positionLb.Text = "3";
                f2.playerNum.Text = "1";
                f2.Show();
                this.Visible = false;
            }
            if (playerSelect == true)
            {
                f2 = new Form2(this);
                f2.btnQuestionOne.Text = Convert.ToString(firstNumber);
                f2.btnQuestionTwo.Text = Convert.ToString(secondNumber);
                f2.positionLb.Text = "3";
                f2.playerNum.Text = "2";
                f2.Show();
                this.Visible = false;
            }

            /*
            if (playerSelect == false)
            {
                btnA3.Text = "X";
            }
            else
            {
                btnA3.Text = "O";
            }
            btnA3.Enabled = false;
            checkForWinner();
            playerSelect = !playerSelect;
            tieGame();
             */ 
        }

        public void btnB1_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();

            int firstNumber = randomNumber.Next(0, 10);
            int secondNumber = randomNumber.Next(0, 10);

            if (playerSelect == false)
            {
                f2 = new Form2(this);
                f2.btnQuestionOne.Text = Convert.ToString(firstNumber);
                f2.btnQuestionTwo.Text = Convert.ToString(secondNumber);
                f2.positionLb.Text = "4";
                f2.playerNum.Text = "1";
                f2.Show();
                this.Visible = false;
            }
            if (playerSelect == true)
            {
                f2 = new Form2(this);
                f2.btnQuestionOne.Text = Convert.ToString(firstNumber);
                f2.btnQuestionTwo.Text = Convert.ToString(secondNumber);
                f2.positionLb.Text = "4";
                f2.playerNum.Text = "2";
                f2.Show();
                this.Visible = false;
            }

            /*
            if (playerSelect == false)
            {
                btnB1.Text = "X";
            }
            else
            {
                btnB1.Text = "O";
            }
            btnB1.Enabled = false;
            checkForWinner();
            playerSelect = !playerSelect;
            tieGame();
             */ 
        }

        public void btnB2_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();

            int firstNumber = randomNumber.Next(0, 10);
            int secondNumber = randomNumber.Next(0, 10);

            if (playerSelect == false)
            {
                f2 = new Form2(this);
                f2.btnQuestionOne.Text = Convert.ToString(firstNumber);
                f2.btnQuestionTwo.Text = Convert.ToString(secondNumber);
                f2.positionLb.Text = "5";
                f2.playerNum.Text = "1";
                f2.Show();
                this.Visible = false;
            }
            if (playerSelect == true)
            {
                f2 = new Form2(this);
                f2.btnQuestionOne.Text = Convert.ToString(firstNumber);
                f2.btnQuestionTwo.Text = Convert.ToString(secondNumber);
                f2.positionLb.Text = "5";
                f2.playerNum.Text = "2";
                f2.Show();
                this.Visible = false;
            }

            /*
            if (playerSelect == false)
            {
                btnB2.Text = "X";
            }
            else
            {
                btnB2.Text = "O";
            }
            btnB2.Enabled = false;
            checkForWinner();
            playerSelect = !playerSelect;
            tieGame();
             */ 
        }

        public void btnB3_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();

            int firstNumber = randomNumber.Next(0, 10);
            int secondNumber = randomNumber.Next(0, 10);

            if (playerSelect == false)
            {
                f2 = new Form2(this);
                f2.btnQuestionOne.Text = Convert.ToString(firstNumber);
                f2.btnQuestionTwo.Text = Convert.ToString(secondNumber);
                f2.positionLb.Text = "6";
                f2.playerNum.Text = "1";
                f2.Show();
                this.Visible = false;
            }
            if (playerSelect == true)
            {
                f2 = new Form2(this);
                f2.btnQuestionOne.Text = Convert.ToString(firstNumber);
                f2.btnQuestionTwo.Text = Convert.ToString(secondNumber);
                f2.positionLb.Text = "6";
                f2.playerNum.Text = "2";
                f2.Show();
                this.Visible = false;
            }

            /*
            if (playerSelect == false)
            {
                btnB3.Text = "X";
            }
            else
            {
                btnB3.Text = "O";
            }
            btnB3.Enabled = false;
            checkForWinner();
            playerSelect = !playerSelect;
            tieGame();
             */ 
        }

        public void btnC1_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();

            int firstNumber = randomNumber.Next(0, 10);
            int secondNumber = randomNumber.Next(0, 10);

            if (playerSelect == false)
            {
                f2 = new Form2(this);
                f2.btnQuestionOne.Text = Convert.ToString(firstNumber);
                f2.btnQuestionTwo.Text = Convert.ToString(secondNumber);
                f2.positionLb.Text = "7";
                f2.playerNum.Text = "1";
                f2.Show();
                this.Visible = false;
            }
            if (playerSelect == true)
            {
                f2 = new Form2(this);
                f2.btnQuestionOne.Text = Convert.ToString(firstNumber);
                f2.btnQuestionTwo.Text = Convert.ToString(secondNumber);
                f2.positionLb.Text = "7";
                f2.playerNum.Text = "2";
                f2.Show();
                this.Visible = false;
            }

            /*
            if (playerSelect == false)
            {
                btnC1.Text = "X";
            }
            else
            {
                btnC1.Text = "O";
            }
            btnC1.Enabled = false;
            checkForWinner();
            playerSelect = !playerSelect;
            tieGame();
             */ 
        }

        public void btnC2_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();

            int firstNumber = randomNumber.Next(0, 10);
            int secondNumber = randomNumber.Next(0, 10);

            if (playerSelect == false)
            {
                f2 = new Form2(this);
                f2.btnQuestionOne.Text = Convert.ToString(firstNumber);
                f2.btnQuestionTwo.Text = Convert.ToString(secondNumber);
                f2.positionLb.Text = "8";
                f2.playerNum.Text = "1";
                f2.Show();
                this.Visible = false;
            }
            if (playerSelect == true)
            {
                f2 = new Form2(this);
                f2.btnQuestionOne.Text = Convert.ToString(firstNumber);
                f2.btnQuestionTwo.Text = Convert.ToString(secondNumber);
                f2.positionLb.Text = "8";
                f2.playerNum.Text = "2";
                f2.Show();
                this.Visible = false;
            }

            /*
            if (playerSelect == false)
            {
                btnC2.Text = "X";
            }
            else
            {
                btnC2.Text = "O";
            }
            btnC2.Enabled = false;
            checkForWinner();
            playerSelect = !playerSelect;
            tieGame();
             */ 
        }

        public void btnC3_Click(object sender, EventArgs e)
        {
            Random randomNumber = new Random();

            int firstNumber = randomNumber.Next(0, 10);
            int secondNumber = randomNumber.Next(0, 10);

            if (playerSelect == false)
            {
                f2 = new Form2(this);
                f2.btnQuestionOne.Text = Convert.ToString(firstNumber);
                f2.btnQuestionTwo.Text = Convert.ToString(secondNumber);
                f2.positionLb.Text = "9";
                f2.playerNum.Text = "1";
                f2.Show();
                this.Visible = false;
            }
            if (playerSelect == true)
            {
                f2 = new Form2(this);
                f2.btnQuestionOne.Text = Convert.ToString(firstNumber);
                f2.btnQuestionTwo.Text = Convert.ToString(secondNumber);
                f2.positionLb.Text = "9";
                f2.playerNum.Text = "2";
                f2.Show();
                this.Visible = false;
            }

            /*
            if (playerSelect == false)
            {
                btnC3.Text = "X";
            }
            else
            {
                btnC3.Text = "O";
            }
            btnC3.Enabled = false;
            checkForWinner();
            playerSelect = !playerSelect;
            tieGame();
             */ 
        }


        // Check for a winner after each button press 
        public void checkForWinner()
        {
            // checking a winner with buttons starting in A
            if (btnA1.Text != "")
            {
                if (btnA1.Text == btnA2.Text && btnA2.Text == btnA3.Text && btnA1.Text != "")
                {
                    if (playerSelect == false)
                    {
                        changeButtonDisabled();
                        MessageBox.Show("Player 1 is the Winner!");
                        playerScore();
                        newGameButton();
                    }
                    else
                    {
                        changeButtonDisabled();
                        MessageBox.Show("Player 2 is the Winner!");
                        playerScore();
                        newGameButton();
                    }
                }
                else if (btnA1.Text == btnB2.Text && btnB2.Text == btnC3.Text && btnA1.Text != "")
                {
                    if (playerSelect == false)
                    {
                        changeButtonDisabled();
                        MessageBox.Show("Player 1 is the Winner!");
                        playerScore();
                        newGameButton();
                    }
                    else
                    {
                        changeButtonDisabled();
                        MessageBox.Show("Player 2 is the Winner!");
                        playerScore();
                        newGameButton();

                    }
                }
                else if (btnA1.Text == btnB1.Text && btnB1.Text == btnC1.Text && btnA1.Text != "")
                {
                    if (playerSelect == false)
                    {
                        changeButtonDisabled();
                        MessageBox.Show("Player 1 is the Winner!");
                        playerScore();
                        newGameButton();
                    }
                    else
                    {
                        changeButtonDisabled();
                        MessageBox.Show("Player 2 is the Winner!");
                        playerScore();
                        newGameButton();
                    }
                }
            }


            // checking a winner with buttons starting in B
                if (btnB1.Text == btnB2.Text && btnB2.Text == btnB3.Text && btnB1.Text != "")
                {
                    if (playerSelect == false)
                    {
                        changeButtonDisabled();
                        MessageBox.Show("Player 1 is the Winner!");
                        playerScore();
                        newGameButton();
                    }
                    else
                    {
                        changeButtonDisabled();
                        MessageBox.Show("Player 2 is the Winner!");
                        playerScore();
                        newGameButton();
                    }
                }
                else if (btnA2.Text == btnB2.Text && btnB2.Text == btnC2.Text && btnB2.Text != "")
                {
                    if (playerSelect == false)
                    {
                        changeButtonDisabled();
                        MessageBox.Show("Player 1 is the Winner!");
                        playerScore();
                        newGameButton();
                    }
                    else
                    {
                        changeButtonDisabled();
                        MessageBox.Show("Player 2 is the Winner!");
                        playerScore();
                        newGameButton();
                    }
                }


            // checking a winner with buttons starting in C
                if (btnC1.Text == btnC2.Text && btnC2.Text == btnC3.Text && btnC1.Text != "")
                {
                    if (playerSelect == false)
                    {
                        changeButtonDisabled();
                        MessageBox.Show("Player 1 is the Winner!");
                        playerScore();
                        newGameButton();
                    }
                    else
                    {
                        changeButtonDisabled();
                        MessageBox.Show("Player 2 is the Winner!");
                        playerScore();
                        newGameButton();
                    }
                }
                else if (btnC1.Text == btnB2.Text && btnB2.Text == btnA3.Text && btnC1.Text != "")
                {
                    if (playerSelect == false)
                    {
                        changeButtonDisabled();
                        MessageBox.Show("Player 1 is the Winner!");
                        playerScore();
                        newGameButton();
                    }
                    else
                    {
                        changeButtonDisabled();
                        MessageBox.Show("Player 2 is the Winner!");
                        playerScore();
                        newGameButton();
                    }
                }
                else if (btnA3.Text == btnB3.Text && btnB3.Text == btnC3.Text && btnC3.Text != "")
                {
                    if (playerSelect == false)
                    {
                        changeButtonDisabled();
                        MessageBox.Show("Player 1 is the Winner!");
                        playerScore();
                        newGameButton();
                    }
                    else
                    {
                        changeButtonDisabled();
                        MessageBox.Show("Player 2 is the Winner!");
                        playerScore();
                        newGameButton();
                        
                    }
                }
                else if (buttonCount == 8)
                {
                    MessageBox.Show("It is a Tie Game!");
                    newGameButton();
                }
        } // end of winner check

        // if a winner is found, all the buttons are to be disabled
        public void changeButtonDisabled()
        {
            btnA1.Enabled = false;
            btnA2.Enabled = false;
            btnA3.Enabled = false;

            btnB1.Enabled = false;
            btnB2.Enabled = false;
            btnB3.Enabled = false;

            btnC1.Enabled = false;
            btnC2.Enabled = false;
            btnC3.Enabled = false;
        } //end of button disable

        // increase the score
        public void playerScore()
        {
            int a, b;

            if (playerSelect == false)
            {
                a = Convert.ToInt16(btnPlayerOneScore.Text);
                a++;
                btnPlayerOneScore.Text = Convert.ToString(a);
            }

            if (playerSelect == true)
            {
                b = Convert.ToInt16(btnPlayerTwoScore.Text);
                b++;
                btnPlayerTwoScore.Text = Convert.ToString(b);
            }
        } // end of score increase


        public void tieGame()
        {
            if (buttonCount < 8)
            {
                buttonCount++;
            }          
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // resets all the text in the buttons for a new game to be played
            btnA1.Text = "";
            btnA2.Text = "";
            btnA3.Text = "";

            btnB1.Text = "";
            btnB2.Text = "";
            btnB3.Text = "";

            btnC1.Text = "";
            btnC2.Text = "";
            btnC3.Text = "";

            // enable all the buttons, so a new game can be played
            btnA1.Enabled = true;
            btnA2.Enabled = true;
            btnA3.Enabled = true;

            btnB1.Enabled = true;
            btnB2.Enabled = true;
            btnB3.Enabled = true;

            btnC1.Enabled = true;
            btnC2.Enabled = true;
            btnC3.Enabled = true;

            // reset the button click count; so we can check for a tie game
            buttonCount = 0;

            // starting player is X / player 1
            //playerSelect = false;

            // make the new game button invisible
            btnNewGame.Visible = false;
            //playerXLb.Visible = true;
            //playerOLb.Visible = false;
        }

        public void newGameButton()
        {
            btnNewGame.Visible = true;
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // resets all the text in the buttons for a new game to be played
            btnA1.Text = "";
            btnA2.Text = "";
            btnA3.Text = "";

            btnB1.Text = "";
            btnB2.Text = "";
            btnB3.Text = "";

            btnC1.Text = "";
            btnC2.Text = "";
            btnC3.Text = "";

            // enable all the buttons, so a new game can be played
            btnA1.Enabled = true;
            btnA2.Enabled = true;
            btnA3.Enabled = true;

            btnB1.Enabled = true;
            btnB2.Enabled = true;
            btnB3.Enabled = true;

            btnC1.Enabled = true;
            btnC2.Enabled = true;
            btnC3.Enabled = true;

            // reset the button click count; so we can check for a tie game
            buttonCount = 0;

            // reset the scores
            btnPlayerOneScore.Text = "0";
            btnPlayerTwoScore.Text = "0";

            // make the new game button invisible
            btnNewGame.Visible = false;

            // starting player is X / player 1
            playerSelect = false;
            playerXLb.Visible = true;
            playerOLb.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void practiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


    }
}
