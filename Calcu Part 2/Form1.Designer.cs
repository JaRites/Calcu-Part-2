
namespace Calcu_Part_2
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
            this.BtnFraction = new System.Windows.Forms.Button();
            this.BtnSquare = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnPosNeg = new System.Windows.Forms.Button();
            this.BtnPercent = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnEquals = new System.Windows.Forms.Button();
            this.BtnPeriod = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.FinalTxtBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnFraction
            // 
            this.BtnFraction.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnFraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFraction.Location = new System.Drawing.Point(47, 199);
            this.BtnFraction.Name = "BtnFraction";
            this.BtnFraction.Size = new System.Drawing.Size(78, 79);
            this.BtnFraction.TabIndex = 0;
            this.BtnFraction.Text = "1/X";
            this.BtnFraction.UseVisualStyleBackColor = false;
            this.BtnFraction.Click += new System.EventHandler(this.Operation_Click);
            // 
            // BtnSquare
            // 
            this.BtnSquare.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSquare.Location = new System.Drawing.Point(131, 199);
            this.BtnSquare.Name = "BtnSquare";
            this.BtnSquare.Size = new System.Drawing.Size(78, 79);
            this.BtnSquare.TabIndex = 1;
            this.BtnSquare.Text = "x²";
            this.BtnSquare.UseVisualStyleBackColor = false;
            this.BtnSquare.Click += new System.EventHandler(this.Operation_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(215, 199);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(78, 79);
            this.BtnClear.TabIndex = 2;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(299, 199);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(162, 79);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Del";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnPosNeg
            // 
            this.BtnPosNeg.BackColor = System.Drawing.Color.MistyRose;
            this.BtnPosNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPosNeg.Location = new System.Drawing.Point(383, 284);
            this.BtnPosNeg.Name = "BtnPosNeg";
            this.BtnPosNeg.Size = new System.Drawing.Size(78, 79);
            this.BtnPosNeg.TabIndex = 9;
            this.BtnPosNeg.Text = "+/-";
            this.BtnPosNeg.UseVisualStyleBackColor = false;
            this.BtnPosNeg.Click += new System.EventHandler(this.BtnPosNeg_Click);
            // 
            // BtnPercent
            // 
            this.BtnPercent.BackColor = System.Drawing.Color.MistyRose;
            this.BtnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPercent.Location = new System.Drawing.Point(299, 284);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(78, 79);
            this.BtnPercent.TabIndex = 8;
            this.BtnPercent.Text = "%";
            this.BtnPercent.UseVisualStyleBackColor = false;
            this.BtnPercent.Click += new System.EventHandler(this.Operation_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.MistyRose;
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn9.Location = new System.Drawing.Point(215, 284);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(78, 79);
            this.Btn9.TabIndex = 7;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.Variables_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.MistyRose;
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn8.Location = new System.Drawing.Point(131, 284);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(78, 79);
            this.Btn8.TabIndex = 6;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Variables_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.MistyRose;
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn7.Location = new System.Drawing.Point(47, 284);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(78, 79);
            this.Btn7.TabIndex = 5;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Variables_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivide.Location = new System.Drawing.Point(383, 369);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(78, 79);
            this.BtnDivide.TabIndex = 14;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = false;
            this.BtnDivide.Click += new System.EventHandler(this.Operation_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiply.Location = new System.Drawing.Point(299, 369);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(78, 79);
            this.BtnMultiply.TabIndex = 13;
            this.BtnMultiply.Text = "X";
            this.BtnMultiply.UseVisualStyleBackColor = false;
            this.BtnMultiply.Click += new System.EventHandler(this.Operation_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.LavenderBlush;
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn6.Location = new System.Drawing.Point(215, 369);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(78, 79);
            this.Btn6.TabIndex = 12;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Variables_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.LavenderBlush;
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn5.Location = new System.Drawing.Point(131, 369);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(78, 79);
            this.Btn5.TabIndex = 11;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Variables_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.LavenderBlush;
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4.Location = new System.Drawing.Point(47, 369);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(78, 79);
            this.Btn4.TabIndex = 10;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Variables_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.BackColor = System.Drawing.Color.MistyRose;
            this.BtnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinus.Location = new System.Drawing.Point(383, 454);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(78, 79);
            this.BtnMinus.TabIndex = 19;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = false;
            this.BtnMinus.Click += new System.EventHandler(this.Operation_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.BackColor = System.Drawing.Color.MistyRose;
            this.BtnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlus.Location = new System.Drawing.Point(299, 454);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(78, 79);
            this.BtnPlus.TabIndex = 18;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = false;
            this.BtnPlus.Click += new System.EventHandler(this.Operation_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.MistyRose;
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(215, 454);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(78, 79);
            this.Btn3.TabIndex = 17;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Variables_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.MistyRose;
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(131, 454);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(78, 79);
            this.Btn2.TabIndex = 16;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Variables_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.MistyRose;
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(47, 454);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(78, 79);
            this.Btn1.TabIndex = 15;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Variables_Click);
            // 
            // BtnEquals
            // 
            this.BtnEquals.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEquals.Location = new System.Drawing.Point(299, 539);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(162, 79);
            this.BtnEquals.TabIndex = 24;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = false;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // BtnPeriod
            // 
            this.BtnPeriod.BackColor = System.Drawing.Color.LavenderBlush;
            this.BtnPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPeriod.Location = new System.Drawing.Point(215, 539);
            this.BtnPeriod.Name = "BtnPeriod";
            this.BtnPeriod.Size = new System.Drawing.Size(78, 79);
            this.BtnPeriod.TabIndex = 22;
            this.BtnPeriod.Text = ".";
            this.BtnPeriod.UseVisualStyleBackColor = false;
            this.BtnPeriod.Click += new System.EventHandler(this.Variables_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.Color.LavenderBlush;
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn0.Location = new System.Drawing.Point(47, 539);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(162, 79);
            this.Btn0.TabIndex = 20;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.Variables_Click);
            // 
            // FinalTxtBx
            // 
            this.FinalTxtBx.BackColor = System.Drawing.Color.LavenderBlush;
            this.FinalTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalTxtBx.Location = new System.Drawing.Point(47, 46);
            this.FinalTxtBx.Name = "FinalTxtBx";
            this.FinalTxtBx.Size = new System.Drawing.Size(414, 116);
            this.FinalTxtBx.TabIndex = 30;
            this.FinalTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(511, 643);
            this.Controls.Add(this.FinalTxtBx);
            this.Controls.Add(this.BtnEquals);
            this.Controls.Add(this.BtnPeriod);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnPosNeg);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSquare);
            this.Controls.Add(this.BtnFraction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculator";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFraction;
        private System.Windows.Forms.Button BtnSquare;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnPosNeg;
        private System.Windows.Forms.Button BtnPercent;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnEquals;
        private System.Windows.Forms.Button BtnPeriod;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.TextBox FinalTxtBx;
    }
}

