using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;
using System.Collections;

namespace DBProject
{
    public partial class IncidentForm : Form
    {
        public static IObjectContainer db; // this is container for storing all objects
        public static Report newrep;
        //public Complainant Comp_Inc = new Complainant();
        public IncidentForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitIncidentbutton1_Click(object sender, EventArgs e)
        {

            Incident newincident = new Incident();
            int id = int.Parse(incidentIDtextBox1.Text);
            string city = City.Text;
            int risk = int.Parse(Riskdegree.Text);
            string type = incidentTypetextBox2.Text;
            string dateAndTime = incidentDateAndTimetextBox3.Text;
            string desciption = incidentDescriptiontextBox4.Text;

            Location location = new Location (int.Parse(YCoordinatetextBox1.Text), int.Parse(XCoordinatetextBox5.Text), RegiontextBox2.Text);
           //location constructor argument
            
            Incident incident1 = new Incident(type, risk , id , city , dateAndTime , desciption ,location );
            newincident.InsertIncidentData(incident1);
            newrep = new Report(ComplainantForm.staticComp, incident1, id);
            newrep.InsertReportData(newrep);
            MessageBox.Show("Incident Successfully Saved!");
            this.Hide();
            AssignPatrolForm APF = new AssignPatrolForm();
            APF.Show(); 
            
        }

        private void IncidentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
