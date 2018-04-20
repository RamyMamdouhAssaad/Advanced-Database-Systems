using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections; 

namespace DBProject
{
    public partial class PatrolForm : Form
    {
        public PatrolForm()
        {
            InitializeComponent();
            comboBox4.Items.Add("Morning shift - from 6:00 am to 6:00 pm");
            comboBox4.Items.Add("evening shift - from 6:00 pm to 6:00 am");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitIncidentbutton1_Click(object sender, EventArgs e)
        {
            Complainant newcomp = new Complainant();
            Name n1 = new Name((Lname.Text), (Fname.Text));
            

            Address a1 = new Address(City.Text, Street.Text, int.Parse(ANumber.Text), int.Parse(BNumber.Text));
            //db.Store(a1);
            Location L1 = new Location(int.Parse(Ycoordinate.Text), int.Parse(Xcoordinate.Text), Region.Text);
            ArrayList listOfPhoneNums = new ArrayList();
            Shift s = new Shift(); 
            listOfPhoneNums.Add(PhoneNumber1.Text);
            listOfPhoneNums.Add(PhoneNumber2.Text);
            if (comboBox4.SelectedItem.ToString().Equals("Morning shift - from 6:00 am to 6:00 pm"))
            {
               s = new Shift(1, "Morning", 6, 6, 12);
            }
            else
            {
                s = new Shift(2, "evening", 6, 6, 12);
            }
            
            Patrol patrol = new Patrol(L1,double.Parse(Salary.Text),int.Parse(BadgeNumber.Text),listOfPhoneNums,n1,int.Parse(ID.Text),a1,s);

            MessageBox.Show("Patrol Successfully Saved!");
            Patrol Patrolinsert = new Patrol();
            Patrolinsert.InsertPatrolData(patrol);
        }

        private void PatrolForm_Load(object sender, EventArgs e)
        {

        }

        private void Region_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employeesform epf = new Employeesform();
            epf.Show(); 
        }

    }
}
