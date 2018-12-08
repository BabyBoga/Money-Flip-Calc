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
        // Settings
        public static bool randomFail = true;
        public static bool flashyColors = true;

        public Random r = new Random();
        float inputAmount;
        int outputAmount;

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
            int i = 1;
            if (randomFail == true){ i = r.Next(7); }

            if (float.TryParse(input.Text, out inputAmount)) {
                if (inputAmount < 214700000 && inputAmount > -1 && i != 0)
                {
                    outputAmount = Convert.ToInt32(inputAmount * 10);
                    output.Text = outputAmount.ToString();
                }
                else{ oof(); }
            }
            else { oof(); }
        }

        private void oof()
        {
            //it works don't touch
            output.Text = "00F";
            bigBigTimer.Enabled = true;
            notSoBigTimer.Enabled = true;
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
            //Shake
            this.Location = new Point(this.Location.X + (r.Next(-10, 11)), this.Location.Y + (r.Next(-10, 11)));

            //Random Colors
            if (flashyColors) { BackColor = Color.FromArgb(r.Next(30, 256), r.Next(30, 256), (r.Next(30, 256))); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form f2 = new SettingsForm();
            f2.Show();
        }
    }
}
