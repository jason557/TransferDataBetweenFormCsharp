using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferDatain2FormBest
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public Label  lab1;
        public Form2()
        {
            InitializeComponent();
            instance = this;
            lab1 = label1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.instance.lab1.Text = "Set from Form2 label";
            Form1.instance.tb1.Text = "Set from Form2 text";
            //Form1.instance.label1.Text = "Set from Form2 label";
            //Form1.instance.textBox1.Text = "Set from Form2 text";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.instance.lab1.Text = "label1";
            Form1.instance.tb1.Text = " ";
            //Form1.instance.label1.Text = "label1";
            //Form1.instance.textBox1.Text = " ";
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Point Position2 = Properties.Settings.Default.Position2;
            this.Location = Position2;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Point Position2 = this.Location;
            Properties.Settings.Default.Position2 = Position2;
            Properties.Settings.Default.Save();
            label1.Text = "label1";
            this.Hide();
            e.Cancel = true;

        }

        
    }
}
