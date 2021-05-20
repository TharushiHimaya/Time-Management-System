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
    public partial class Location_nat : Form
    {

        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();

        public Location_nat()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());

        }

        private void Location_nat_Load(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "HH:mm:ss";
            dateTimePicker3.CustomFormat = "HH:mm:ss";
        }

        public void Clear()
        {
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
            dateTimePicker3.Text = string.Empty;
            
            button4.Enabled = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBox1.Text == string.Empty) || (comboBox2.Text == string.Empty) || (dateTimePicker2.Text == string.Empty) || (dateTimePicker3.Text == string.Empty))
                {
                    MessageBox.Show("Warning:Required empty field:!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                cn.Open();
                cm = new MySqlCommand("insert into nat_for_rooms(room,day,Stime,Etime) values('" + comboBox2.Text + "','" + comboBox1.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "')", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully saved.", "rooms Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Warning:" + ex.Message, "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
