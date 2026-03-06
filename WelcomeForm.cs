using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            this.Hide();         // Hide Form1
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlightSearchForm newForm = new FlightSearchForm();
            this.Hide();         // Hide Form1
            newForm.Show();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
