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
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        public static Form1 instance;        
        public TextBox tb1;
        public Label lab1;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            lab1 = label1;
            tb1 = textBox1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Point Position1 = Properties.Settings.Default.Position1;
            this.Location = Position1;                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.Show();
                                   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2.instance.lab1.Text = "Set by Form1";
            //Form2.instance.label1.Text = "Set by Form1";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form2.instance.lab1.Text = "label1";
            //Form2.instance.label1.Text = "label1";
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Point Position1 = this.Location;
            Properties.Settings.Default.Position1 = Position1;
            Properties.Settings.Default.Save();
        }

        
    }
}
