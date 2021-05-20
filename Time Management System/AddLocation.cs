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
    public partial class AddLocation : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();
        ManageLocation ml;
        string AddNo = "";

        public AddLocation(ManageLocation manageLocation)
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());
            ml = manageLocation;
        }


        string RoomType;
        private bool IsPostBack;

        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button3.Enabled = true;
            button4.Enabled = false;

        }




        private void button3_Click(object sender, EventArgs e)
        {
            validateDepartmentName();
            validateRoomName();
            validateCapacity();

            if (comboBox1.SelectedItem == null)
            {
                errorProvider1.SetError(comboBox1, "Please select item!!");
                MessageBox.Show("Department Name field is required");
            }

            else if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Room Type is required");
            }

            else if (comboBox2.SelectedItem == null)
            {
                errorProvider1.SetError(comboBox2, "Please select item!!");
                MessageBox.Show("Room Name field is required");
            }

            else if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Enter capacity!");
                MessageBox.Show("Capacity field is required");

            }
            else

            {
                try
                {
                    cn.Open();
                    cm = new MySqlCommand("insert into location(AddNo,DepartmentName,RoomType,RoomName,Capacity) values('" + textBox2.Text + "','" + comboBox1.Text + "','" + RoomType + "','" + comboBox2.Text + "','" + textBox1.Text + "')", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully saved.", "Location Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();

                    ml.LoadRecords();
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show("Warning:" + ex.Message, "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }


            /* if (radioButton1.Checked == true)
             {
                 RoomType = radioButton1.Text;
             }

             else if (radioButton2.Checked == true)
             {
                 RoomType = radioButton2.Text;
             }*/

        }

        protected bool validateDepartmentName()
        {
            bool chk = false;

            if (comboBox1.SelectedItem == null)
            {
                errorProvider1.SetError(comboBox1, "Please select item!!");
                chk = true;
            }
            else errorProvider1.SetError(comboBox1, "");
            return chk;
        }
        protected bool validateRoomName()
        {
            bool chk = false;

            if (comboBox2.SelectedItem == null)
            {
                errorProvider1.SetError(comboBox2, "Please select item!!");
                chk = true;
            }
            else errorProvider1.SetError(comboBox2, "");
            return chk;
        }

        protected bool validateCapacity()
        {
            bool chk = false;

            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Enter capacity!");
                chk = true;
            }
            else errorProvider1.SetError(textBox1, "");
            return chk;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new MySqlCommand("update location set DepartmentName ='" + comboBox1.Text + "',RoomName ='" + comboBox2.Text + "',Capacity ='" + textBox1.Text + "' where AddNo like '" + textBox2.Text + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully updated.", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ml.LoadRecords();
                this.Dispose();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Warning:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }



        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            RoomType = "Lecture Hall";
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            RoomType = "Laboratory";
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GenerateAutoID();
            }
        }

        private void GenerateAutoID()
        {
            cn.Open();
            MySqlCommand cm = new MySqlCommand("Select Count(AddNo)from location", cn);
            int i = Convert.ToInt32(cm.ExecuteScalar());
            cn.Close();
            i++;
            textBox2.Text = i.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddLocation_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                GenerateAutoID();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            ManageLocation manageLocation = new ManageLocation();
            manageLocation.Show();

        }
    }
}

