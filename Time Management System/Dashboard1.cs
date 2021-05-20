using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Management_System
{
    public partial class Dashboard1 : Form
    {
        public Dashboard1()
        {
            InitializeComponent();
        }

        private void Dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_std_Group msg = new Manage_std_Group();
            msg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageTag mt = new ManageTag();
            mt.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageLec f3 = new ManageLec();
            f3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageSub f3 = new ManageSub();

            f3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Manage_wds_hrs manage_Wds_Hrs = new Manage_wds_hrs();
            manage_Wds_Hrs.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ManageLocation manageLocation = new ManageLocation();
            manageLocation.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            StatisticalTable statisticalTable= new StatisticalTable();
            statisticalTable.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TimeTable timeTable = new TimeTable();
            timeTable.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ManageSession f3 = new ManageSession();
            f3.Show();
        }
    }
}
