using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutorials.LinqExamples;



namespace Tutorials
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExample_Click(object sender, EventArgs e)
        {
            BasicExamples be = new BasicExamples();
            be.example1();
        }
    }
}
