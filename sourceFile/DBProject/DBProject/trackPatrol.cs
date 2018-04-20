using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBProject
{
    public partial class trackPatrol : Form
    {
        static Report newReport;
        static Patrol newPatrol;
        OverAllReportClass OverAllReport1;
        static int ID=0 ;

        public trackPatrol()
        {
            InitializeComponent();
         
        }
           
        

        public void Recieve(Report Rep , Patrol Pat)
        {
            newReport = Rep;
            newPatrol = Pat;
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Name.Text = newPatrol.name.Fname;
            BadgeNumber.Text = Convert.ToString(newPatrol.badegNumber);
            RegionPatrol.Text = newPatrol.patrolLocation.region;
            
            String Xpat = Convert.ToString(newPatrol.patrolLocation.XCoordinate);
            String Ypat = Convert.ToString(newPatrol.patrolLocation.YCoordinate);
            int trackPX = newPatrol.patrolLocation.XCoordinate;
            int trackPY = newPatrol.patrolLocation.XCoordinate;
            XPatrol.Text = Xpat;
            YPatrol.Text = Ypat;
            Iregion.Text = newReport.newIncident.incidentLocation.region;
            String XInc = Convert.ToString(newReport.newIncident.incidentLocation.XCoordinate);
            String YInc = Convert.ToString(newReport.newIncident.incidentLocation.YCoordinate);
            int trackIX = newReport.newIncident.incidentLocation.XCoordinate;
            int trackIY = newReport.newIncident.incidentLocation.YCoordinate;
            XIncident.Text = XInc;
            Yincident.Text = YInc;
            
            
            MessageBox.Show("Patrol arrived");
            OverAllReport1 = new OverAllReportClass(newReport, newPatrol,ID);
            ID++; 
            OverAllReport1.insert(OverAllReport1);
           
            }
       
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void BadgeNumber_Click(object sender, EventArgs e)
        {

        }

        private void trackPatrol_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            OverAllReport oar = new OverAllReport();
            oar.Show(); 
        }
    }
}
