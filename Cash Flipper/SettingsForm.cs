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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            oofCheckBox.Checked = Form1.randomFail;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            if (moneyRainCheck.Checked)
            {
                moneyRainPicture.Visible = true;
                label1.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), (r.Next(0, 256)));
            }
            else { moneyRainPicture.Visible = false; }

            if (oofCheckBox.Checked) { Form1.randomFail = true; }
            else { Form1.randomFail = false; }
        }

        private void oofCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
