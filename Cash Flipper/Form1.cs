using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Flipper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input.Text += 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            input.Text += 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            float inputAmount;
            int outputAmount;

            if (float.TryParse(input.Text, out inputAmount)) {
                if (inputAmount < 214700000 && inputAmount > -1)
                {
                    outputAmount = Convert.ToInt32(inputAmount * 10);
                    output.Text = outputAmount.ToString();
                }
                else
                {
                    output.Text = "Money machine broke";
                }
            }
            else
            {
                //it works don't touch
                output.Text = "00F!";
                bigBigTimer.Enabled = true;
                notSoBigTimer.Enabled = true;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            input.Text = "";
            output.Text = "";
        }

        private void bigBigTimer_Tick(object sender, EventArgs e)
        {
            bigBigTimer.Enabled = false;
            notSoBigTimer.Enabled = false;
            BackColor = SystemColors.Control;
        }

        private void notSoBigTimer_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            //Shake
            this.Location = new Point(this.Location.X + (r.Next(-10, 11)), this.Location.Y + (r.Next(-10, 11)));

            //Random Colors
            BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), (r.Next(0, 256)));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form f2 = new SettingsForm();
            f2.Show();
        }
    }
}
