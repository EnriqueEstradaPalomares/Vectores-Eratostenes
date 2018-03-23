using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores_Eratostenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Eratostenes vec = new Eratostenes(1000);
            textBox1.Text = vec.returnEratostenes(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
