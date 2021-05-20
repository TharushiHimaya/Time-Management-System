using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Time_Management_System
{
    public partial class Add_time_slot : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();

        public Add_time_slot()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_wds_hrs add_wds_hrs = new Add_wds_hrs();
            this.Hide();
            add_wds_hrs.Show();
        }


        private void Add_time_slot_Load(object sender, EventArgs e)
        {

           


            dateTimePicker2.CustomFormat = "HH:mm:ss";
            dateTimePicker3.CustomFormat = "HH:mm:ss";
            count();

        }
        public void Clear()
        {
            comboBox1.Text=string.Empty;
            dateTimePicker1.Text=string.Empty;
            dateTimePicker2.Text=string.Empty;
            dateTimePicker3.Text = string.Empty;
            label3.Text =string.Empty;
            button4.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBox1.Text == string.Empty) || (dateTimePicker1.Text == string.Empty) || (dateTimePicker2.Text == string.Empty) || (dateTimePicker3.Text == string.Empty))
                {
                    MessageBox.Show("Warning:Required empty field:!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                cn.Open();
                cm = new MySqlCommand("insert into timeslot_table(Listing,Date,Stime,Etime,Duration) values('" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "','" + label3.Text + "')", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully saved.", "Timeslot Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Warning:" + ex.Message, "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void count()
        {
            string count = (dateTimePicker2.Value - dateTimePicker3.Value).ToString();
            string[] interval = count.Replace("-", "").Substring(0, 8).Split(':');
            label3.Text = interval[0] + "  Hour(s)  " + interval[1] + "  Minute(s)  " + interval[2] + "  Second(s)  ";

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            count();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            count();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }



}







