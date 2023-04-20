using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enWinner
        {
            Player1, Player2, InProgress, Draw
        }

        enum enPlayers
        {
            Player1, Player2
        }

        struct stGame
        {
            public enWinner Winner;
            public enPlayers Turn;

        }

        stGame Game;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;
            Pen pen = new Pen(White, 10);

            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;

            //Draw Horizontal Lines
            e.Graphics.DrawLine(pen, 340, 190, 760, 190);
            e.Graphics.DrawLine(pen, 340, 310, 760, 310);

            //Draw Vertical Lines
            e.Graphics.DrawLine(pen, 480, 80, 480, 420);
            e.Graphics.DrawLine(pen, 630, 80, 630, 420);
        }

        void EndGame() {

            lblTurn.Text = "Game Over";

            if(Game.Winner == enWinner.Player1)
            {
                lblWinner.Text = "Player1";
            }
            else if(Game.Winner == enWinner.Player2)
            {
                lblWinner.Text = "Player2";
            }
            else
            {
                lblWinner.Text = "Draw Game";
            }

            MessageBox.Show("Game Over", "Game Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void ResetButton(Button btn)
        {
            btn.BackColor = Color.Transparent;
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
        }
        bool CheckButtons(Button btn1, Button btn2, Button btn3)
        {
            if(btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn2.Tag.ToString() == btn3.Tag.ToString()) {

                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if(btn1.Tag.ToString() == "X")
                {
                    Game.Winner = enWinner.Player1;
                    EndGame();
                }
                else
                {
                    Game.Winner = enWinner.Player2;
                    EndGame();
                }

                return true;
            
            }
            return false;
        }
        void CheckWinner()
        {
            if (CheckButtons(button1, button2, button3)) return;
            if (CheckButtons(button4, button5, button6)) return;
            if (CheckButtons(button7, button8, button9)) return;
            if (CheckButtons(button1, button4, button7)) return;
            if (CheckButtons(button2, button5, button8)) return;
            if (CheckButtons(button3, button6, button9)) return;
            if (CheckButtons(button1, button5, button9)) return;
            if (CheckButtons(button3, button5, button7)) return;

        }
        void ChangeImage(Button btn)
        {
            if(btn.Tag.ToString() == "?")
            {
                switch (Game.Turn)
                {
                    case enPlayers.Player1:
                        btn.Tag = "X";
                        Game.Turn = enPlayers.Player2;
                        lblTurn.Text = "Player2";
                        btn.Image = Resources.X;
                        CheckWinner();
                        break;

                    case enPlayers.Player2:
                        btn.Tag = "O";
                        Game.Turn = enPlayers.Player1;
                        lblTurn.Text = "Player1";
                        btn.Image = Resources.O;
                        CheckWinner();
                        break;
                }

            }
            else
            {
                MessageBox.Show("Invalid Choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button) sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ResetButton(button1);
            ResetButton(button2);
            ResetButton(button3);
            ResetButton(button4);
            ResetButton(button5);
            ResetButton(button6);
            ResetButton(button7);
            ResetButton(button8);
            ResetButton(button9);

            Game.Turn = enPlayers.Player1;
            Game.Winner = enWinner.InProgress;
            lblWinner.Text = "In Progress";
            lblTurn.Text = "Player1";
        }
    }
}
