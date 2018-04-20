using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Db4objects.Db4o;
using System.Collections;

namespace DBProject
{
    public partial class OverAllReport : Form
    {
        OverAllReportClass report = new OverAllReportClass();
        IObjectSet allreports = Complainant.db.QueryByExample(typeof(OverAllReportClass));
        public OverAllReport()
        {
            InitializeComponent();
            IObjectSet allreports = Complainant.db.QueryByExample(typeof(OverAllReportClass));
            for (int i = 0; i < allreports.Count; i++)
            {
                report = (OverAllReportClass)allreports[i];
                comboBox1.Items.Add(report.id);          
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = (int)comboBox1.SelectedItem;
            IObjectSet allreports = Complainant.db.QueryByExample(typeof(OverAllReportClass));
            for (int i = 0; i < allreports.Count; i++)
            {
                report = (OverAllReportClass)allreports[i];
                if (report.id == id) ;
                {
                    Pname.Text =report.NewPatrol.name.Fname;
                    IID.Text = Convert.ToString(report.NewReport.newIncident.incidentID);
                    CName.Text = report.NewReport.newComplainant.name.Fname;
                        
                }
            }
        }

        private void OverAllReport_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Start st = new Start();
            st.Show(); 
        }
    }
}
