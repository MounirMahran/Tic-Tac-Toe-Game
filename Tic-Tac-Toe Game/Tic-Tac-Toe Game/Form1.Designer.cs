namespace Tic_Tac_Toe_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Haettenschweiler", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Haettenschweiler", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(65, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turn";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Haettenschweiler", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.White;
            this.lblTurn.Location = new System.Drawing.Point(46, 130);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(106, 40);
            this.lblTurn.TabIndex = 2;
            this.lblTurn.Text = "Player 1";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Haettenschweiler", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblWinner.Location = new System.Drawing.Point(25, 257);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(148, 40);
            this.lblWinner.TabIndex = 4;
            this.lblWinner.Text = "In Progress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Haettenschweiler", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(50, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 40);
            this.label5.TabIndex = 3;
            this.label5.Text = "Winner";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button1.Location = new System.Drawing.Point(338, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 99);
            this.button1.TabIndex = 5;
            this.button1.Tag = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button2.Location = new System.Drawing.Point(491, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 99);
            this.button2.TabIndex = 6;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button3.Location = new System.Drawing.Point(644, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 99);
            this.button3.TabIndex = 7;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button6.Location = new System.Drawing.Point(644, 198);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 99);
            this.button6.TabIndex = 10;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button5.Location = new System.Drawing.Point(491, 198);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 99);
            this.button5.TabIndex = 9;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button4.Location = new System.Drawing.Point(338, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 99);
            this.button4.TabIndex = 8;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button9.Location = new System.Drawing.Point(644, 322);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(123, 99);
            this.button9.TabIndex = 13;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button8.Location = new System.Drawing.Point(491, 322);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(123, 99);
            this.button8.TabIndex = 12;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button7.Location = new System.Drawing.Point(338, 322);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(123, 99);
            this.button7.TabIndex = 11;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Gainsboro;
            this.button10.Font = new System.Drawing.Font("Haettenschweiler", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.ForestGreen;
            this.button10.Location = new System.Drawing.Point(30, 347);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(138, 48);
            this.button10.TabIndex = 14;
            this.button10.Text = "Restart Game";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
    }
}

