namespace TreIRadSlutProj
{
    partial class TicTacForm
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
            Status = new Label();
            Statistik = new Label();
            ButtonNew = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Status.Location = new Point(12, 314);
            Status.Name = "Status";
            Status.Size = new Size(60, 20);
            Status.TabIndex = 0;
            Status.Text = "Turn: X";
            // 
            // Statistik
            // 
            Statistik.AutoSize = true;
            Statistik.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            Statistik.Location = new Point(12, 344);
            Statistik.Name = "Statistik";
            Statistik.Size = new Size(178, 16);
            Statistik.TabIndex = 1;
            Statistik.Text = "X wins: 0,  O wins: 0,  Draws: 0";
            // 
            // ButtonNew
            // 
            ButtonNew.Location = new Point(263, 332);
            ButtonNew.Name = "ButtonNew";
            ButtonNew.Size = new Size(94, 29);
            ButtonNew.TabIndex = 2;
            ButtonNew.Text = "New Game";
            ButtonNew.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            button1.Location = new Point(32, 28);
            button1.Name = "button1";
            button1.Size = new Size(100, 80);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            button2.Location = new Point(32, 114);
            button2.Name = "button2";
            button2.Size = new Size(100, 80);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            button3.Location = new Point(32, 200);
            button3.Name = "button3";
            button3.Size = new Size(100, 80);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            button4.Location = new Point(138, 28);
            button4.Name = "button4";
            button4.Size = new Size(100, 80);
            button4.TabIndex = 8;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            button5.Location = new Point(138, 114);
            button5.Name = "button5";
            button5.Size = new Size(100, 80);
            button5.TabIndex = 7;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            button6.Location = new Point(138, 200);
            button6.Name = "button6";
            button6.Size = new Size(100, 80);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            button7.Location = new Point(244, 28);
            button7.Name = "button7";
            button7.Size = new Size(100, 80);
            button7.TabIndex = 11;
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            button8.Location = new Point(244, 114);
            button8.Name = "button8";
            button8.Size = new Size(100, 80);
            button8.TabIndex = 10;
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            button9.Location = new Point(244, 200);
            button9.Name = "button9";
            button9.Size = new Size(100, 80);
            button9.TabIndex = 9;
            button9.UseVisualStyleBackColor = true;
            // 
            // TicTacForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 373);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ButtonNew);
            Controls.Add(Statistik);
            Controls.Add(Status);
            Name = "TicTacForm";
            Text = "Tre i rad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Status;
        private Label Statistik;
        private Button ButtonNew;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}
