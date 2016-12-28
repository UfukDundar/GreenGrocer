using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greengrocer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal decPrice = nmTomatoPrice.Value * nmTomatoKg.Value;
            nmTomatoTotalKg.Value += nmTomatoKg.Value;
            nmTotalPrice.Value += decPrice;
            //nmTotalPrice.Value = nmTotalPrice.Value + decPrice; Aynı işlemi yapar yukardıakiyle
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal decPrice = nmPatatoPrice.Value * nmPatatoKg.Value;
            nmPatatoTotalKg.Value += nmPatatoKg.Value;
            nmTotalPrice.Value += decPrice;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal decPrice = nmPepperPrice.Value * nmPepperKg.Value;
            nmPepperTotalKg.Value += nmPepperKg.Value;
            nmTotalPrice.Value += decPrice;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nmTomatoKg.Value = 0;
            nmPatatoKg.Value = 0;
            nmPepperKg.Value = 0;
            nmTomatoTotalKg.Value = 0;
            nmPatatoTotalKg.Value = 0;
            nmPepperTotalKg.Value = 0;
            nmTotalPrice.Value = 0;
        }
    }
}
