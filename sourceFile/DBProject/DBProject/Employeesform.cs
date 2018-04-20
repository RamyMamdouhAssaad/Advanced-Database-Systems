using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject
{
    public partial class Employeesform : Form
    {
        public Employeesform()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatrolForm Pf = new PatrolForm();
            Pf.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OfficerForm of = new OfficerForm();
            of.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start st = new Start();
            st.Show(); 
        }
    }
}
