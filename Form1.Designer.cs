﻿namespace tictactoeAmer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            resetBtn = new Button();
            scoreX = new Label();
            scoreO = new Label();
            nextRound = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(106, 87);
            button1.Name = "button1";
            button1.Size = new Size(92, 93);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(204, 87);
            button2.Name = "button2";
            button2.Size = new Size(92, 93);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(302, 87);
            button3.Name = "button3";
            button3.Size = new Size(92, 93);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(106, 186);
            button4.Name = "button4";
            button4.Size = new Size(92, 93);
            button4.TabIndex = 0;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(204, 186);
            button5.Name = "button5";
            button5.Size = new Size(92, 93);
            button5.TabIndex = 0;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(302, 186);
            button6.Name = "button6";
            button6.Size = new Size(92, 93);
            button6.TabIndex = 0;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(106, 285);
            button7.Name = "button7";
            button7.Size = new Size(92, 93);
            button7.TabIndex = 0;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(204, 285);
            button8.Name = "button8";
            button8.Size = new Size(92, 93);
            button8.TabIndex = 0;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(302, 285);
            button9.Name = "button9";
            button9.Size = new Size(92, 93);
            button9.TabIndex = 0;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(302, 399);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(92, 37);
            resetBtn.TabIndex = 1;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // scoreX
            // 
            scoreX.AutoSize = true;
            scoreX.BackColor = Color.White;
            scoreX.ForeColor = Color.Blue;
            scoreX.Location = new Point(106, 22);
            scoreX.Name = "scoreX";
            scoreX.Size = new Size(15, 17);
            scoreX.TabIndex = 2;
            scoreX.Text = "0";
            // 
            // scoreO
            // 
            scoreO.AutoSize = true;
            scoreO.ForeColor = Color.FromArgb(192, 0, 0);
            scoreO.Location = new Point(379, 22);
            scoreO.Name = "scoreO";
            scoreO.Size = new Size(15, 17);
            scoreO.TabIndex = 3;
            scoreO.Text = "0";
            scoreO.Click += label2_Click;
            // 
            // nextRound
            // 
            nextRound.Location = new Point(106, 399);
            nextRound.Name = "nextRound";
            nextRound.Size = new Size(92, 37);
            nextRound.TabIndex = 1;
            nextRound.Text = "Play Again";
            nextRound.UseVisualStyleBackColor = true;
            nextRound.Click += nextRound_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 507);
            Controls.Add(scoreO);
            Controls.Add(scoreX);
            Controls.Add(nextRound);
            Controls.Add(resetBtn);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button resetBtn;
        private Label scoreX;
        private Label scoreO;
        private Button nextRound;
    }
}
