using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BurgerLib;

namespace Burgers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Burger b;
        Decorator d;

        private void button1_Click(object sender, EventArgs e)
        {
            b = new CheesBurger();
            pictureBox1.Tag = b.GetCode();
            pictureBox1.Image = imageList1.Images[b.GetCode() - 1];
            label1.Text = b.Name();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b = new ChickenBurger();
            pictureBox1.Tag = b.GetCode();
            pictureBox1.Image = imageList1.Images[b.GetCode() - 1];
            label1.Text = b.Name();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b = new BigMac();
            pictureBox1.Tag = b.GetCode();
            pictureBox1.Image = imageList1.Images[b.GetCode() - 1];
            label1.Text = b.Name();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            d = new Box();
            d.SetBurger(b);

            pictureBox3.Tag = d.GetCode();
            panel1.Tag = d.codD;

            panel1.BackgroundImage = imageList2.Images[d.codD - 1];
            pictureBox3.Image = imageList1.Images[d.GetCode() - 1];

            label2.Text = d.Name();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            d = new Package();
            d.SetBurger(b);

            pictureBox3.Tag = d.GetCode();
            panel1.Tag = d.codD;

            panel1.BackgroundImage = imageList2.Images[d.codD - 1];
            pictureBox3.Image = imageList1.Images[d.GetCode() - 1];

            label2.Text = d.Name();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
