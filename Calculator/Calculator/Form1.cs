using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public static int Operator = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpertor_Click(object sender, EventArgs e)
        {
            char[] operators = {'+', '-', '*', '/', 'M', 'D' };
            Operator++;
            Operator = NumLoop(Operator, 0, operators.Length - 1);
            buttonOpertor.Text = Convert.ToString(operators[Operator]);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            switch (buttonOpertor.Text)
            {
                case "+":
                    textBoxEnd.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text));
                    break;
                case "-":
                    textBoxEnd.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text));
                    break;
                case "*":
                    textBoxEnd.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text));
                    break;
                case "/":
                    textBoxEnd.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text));
                    break;
                case "M":
                    textBoxEnd.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) % Convert.ToDouble(textBox2.Text));
                    break;
                case "D":
                    textBoxEnd.Text = Convert.ToString((Convert.ToInt16(textBox1.Text) / Convert.ToInt16(textBox2.Text) * Convert.ToInt16(textBox2.Text)));
                    break;
            }
        }

        private static int NumLoop(int input, int lower, int upper)
        {
            if (input < lower)
            {
                input = upper;
            }
            else if (input > upper)
            {
                input = lower;
            }

            return input;

        } //Number Loop End
    }
}
