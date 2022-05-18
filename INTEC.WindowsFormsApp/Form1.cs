using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTEC.WindowsFormsApp
{
    public partial class Form1 : Form
    {
        int count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 5000;
        }

        void GenerateNumber(int i)
        {
            Random rnd = new Random();

            switch (i)
            {
                case 1:
                    txtP1.Text = rnd.Next(100).ToString();
                    break;
                case 2:
                    txtP2.Text = rnd.Next(100).ToString();
                    break;
                case 3:
                    txtP3.Text = rnd.Next(100).ToString();
                    break;
                case 4:
                    txtP4.Text = rnd.Next(100).ToString();
                    break;
            }

            System.Threading.Thread.Sleep(1000);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GenerateNumber(count);

            count++;
        }
    }
}
