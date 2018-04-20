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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            Complainant Comp = new Complainant();
            Comp.startDatabase(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employeesform ep = new Employeesform();
            ep.Show(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComplainantForm cf = new ComplainantForm();
            cf.Show(); 
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
