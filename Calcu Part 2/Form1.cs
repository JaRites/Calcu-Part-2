using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcu_Part_2
{
    public partial class Form1 : Form
    {
        OOP oop = new OOP();
        public Form1()
        {
            InitializeComponent();
        }

        private void Variables_Click(object sender, EventArgs e)
        {
            if ((FinalTxtBx.Text == "0") || (oop.Operation_Used1))
                FinalTxtBx.Clear();

            oop.Operation_Used1 = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!FinalTxtBx.Text.Contains("."))
                    FinalTxtBx.Text = FinalTxtBx.Text + b.Text;
            }
            else
                FinalTxtBx.Text = FinalTxtBx.Text + b.Text;
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            oop.Operation = b.Text;
            oop.Value = float.Parse(FinalTxtBx.Text);
            oop.Operation_Used1 = true;
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (oop.Operation.Equals("+"))
            {
                FinalTxtBx.Text = (oop.Value + float.Parse(FinalTxtBx.Text)).ToString();
            }

            if (oop.Operation.Equals("-"))
            {
                FinalTxtBx.Text = (oop.Value - float.Parse(FinalTxtBx.Text)).ToString();
            }

            if (oop.Operation.Equals("X"))
            {
                FinalTxtBx.Text = (oop.Value * float.Parse(FinalTxtBx.Text)).ToString();
            }
            if (oop.Operation.Equals("/"))
            {
                FinalTxtBx.Text = (oop.Value / float.Parse(FinalTxtBx.Text)).ToString();
            }

            if (oop.Operation.Equals("%"))
            {
                FinalTxtBx.Text = (oop.Value * (float.Parse(FinalTxtBx.Text) / 100)).ToString();
            }

            if (oop.Operation.Equals("x²"))
            {
                FinalTxtBx.Text = (oop.Value * oop.Value).ToString();
            }

            if (oop.Operation.Equals("1/X"))
            {
                FinalTxtBx.Text = ((oop.Value = 1) / float.Parse(FinalTxtBx.Text)).ToString();
            }
        }

        private void BtnPosNeg_Click(object sender, EventArgs e)
        {
            FinalTxtBx.Text = "-";

            if (FinalTxtBx.Equals("-"))
            {
                FinalTxtBx.Text = "";
            }
            oop.Operation_Used1 = false;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            FinalTxtBx.Clear();
            oop.Value = 0;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (FinalTxtBx.Text.Length > 0)
            {
                FinalTxtBx.Text = FinalTxtBx.Text.Remove(FinalTxtBx.Text.Length - 1, 1);
            }
        }
    }
}
