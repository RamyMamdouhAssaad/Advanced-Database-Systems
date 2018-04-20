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
    public partial class OfficerForm : Form
    {
        public static IObjectContainer db;  // this is container for storing all objects
        public OfficerForm()
        {
            InitializeComponent();
        }

        private void OfficerForm_Load(object sender, EventArgs e)
        {

        }

        private void SubmitOfficerbutton1_Click(object sender, EventArgs e)
        {
            Officer newOff = new Officer();
            Name offName = new Name((FNametextBox3.Text),(LNametextBox4.Text));

            Address offAdress = new Address((CitytextBox5.Text), (StreettextBox6.Text), int.Parse(ApartNumtextBox8.Text), int.Parse(BuildingNumtextBox7.Text));
            ArrayList listOfPhoneNums = new ArrayList();
            listOfPhoneNums.Add(PhoneNum1textBox9.Text);
            listOfPhoneNums.Add(PhoneNum2textBox12.Text);
            // double salary, int badgeNumber, string[] phoneNumber, Name name, int ID, Address address, Shift newshift, ArrayList patrol_officer)
                Shift s1 = new Shift(1,"man ya man" ,12,12,12) ;

            Officer off1 = new Officer((StationCodetextBox11.Text), double.Parse(SalarytextBox10.Text), int.Parse(BadgeNumtextBox2.Text), 
            listOfPhoneNums, offName, int.Parse(OffPoliceIDtextBox1.Text), offAdress,s1 );
            newOff.InsertOfficerData(off1);
           
            MessageBox.Show("Officer Successfully Saved!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employeesform ef = new Employeesform();
            ef.Show();
        }
    }
}
