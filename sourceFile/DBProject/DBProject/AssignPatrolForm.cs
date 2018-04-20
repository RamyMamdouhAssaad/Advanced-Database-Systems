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
    public partial class AssignPatrolForm : Form
    {
        public static Officer off1 = new Officer();
        public Patrol pat1 = new Patrol();
        public ArrayList allpat = Officer.foundpatrols;
        public AssignPatrolForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            trackPatrol TrackPatrol = new trackPatrol();
            TrackPatrol.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AssignPatrolForm_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < allpat.Count; i++)
            {
                pat1 = (Patrol)allpat[i];
                PatrolscomboBox1.Items.Add(pat1.name.Fname.ToString());
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            trackPatrol tp = new trackPatrol();
            for (int i = 0; i < allpat.Count; i++)
            {
                pat1 = (Patrol)allpat[i];
                String patrolFullName = pat1.name.Fname;
                if (patrolFullName == PatrolscomboBox1.SelectedItem.ToString())
                {
                    tp.Recieve(IncidentForm.newrep, pat1);
                    if (pat1.patrolLocation.region == "Maadi")
                    {
                        RedP1pictureBox1.Visible = true;
                    }
                    else if (pat1.patrolLocation.region == "Mohandseen")
                    {
                        RedP2pictureBox2.Visible = true;
                    }
                    else if (pat1.patrolLocation.region == "Dokki")
                    {
                        RedP3pictureBox3.Visible = true;
                    }

                }
            }
        }
    }
}
