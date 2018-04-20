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
    public partial class ComplainantForm : Form
    {
        public static IObjectContainer db; // this is container for storing all objects
        public Incident inc;
        public static Complainant staticComp;

        public ComplainantForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void SubmitCompFormbutton1_Click(object sender, EventArgs e)
        {
            Complainant newcomp= new Complainant();
            Name n1 = new Name((FNametextBox1.Text), (LNametextBox2.Text));
            //db.Store(n1);

            Address a1 = new Address(CitytextBox5.Text, StreettextBox6.Text, int.Parse(ApartmentNumbertextBox8.Text), int.Parse(BuildingNumbertextBox7.Text));
            //db.Store(a1);

            ArrayList listOfPhoneNums = new ArrayList();
            listOfPhoneNums.Add(PhoneNumtextBox4.Text);
            listOfPhoneNums.Add(PhoneNumber2textBox.Text);

            Complainant comp1 = new Complainant(int.Parse(SSNtextBox3.Text), listOfPhoneNums, n1, a1);
            staticComp = comp1;
            //db.Store(comp1);
            newcomp.InsertComplainantData(comp1);

            //inc.RecieveComplainant(staticComp);
           

            MessageBox.Show("Complainant Successfully Saved!");
            this.Hide();
            IncidentForm IF = new IncidentForm();
            IF.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start st = new Start();
            st.Show(); 
        }
    }
}
