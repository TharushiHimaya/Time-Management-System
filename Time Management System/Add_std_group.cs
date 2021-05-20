using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Time_Management_System
{
    public partial class Add_std_group : Form
    {

        MySqlConnection cn;
        MySqlCommand cm;
       // MySqlDataReader dr;
        DB clscon = new DB();
        

        public Add_std_group()

        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());
           
            
        }

        //clear all data
        public void Clear()
        {
            textBox1.Clear();
            button2.Enabled = true;
            comboBox1.Text=string.Empty;
            numericUpDown1.Text=string.Empty;
            numericUpDown2.Text=string.Empty;
            

        }

        //Add data to database
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if ((textBox1.Text == string.Empty) || (comboBox1.Text == string.Empty) || (numericUpDown1.Text == string.Empty) || (numericUpDown2.Text == string.Empty))
                {
                    MessageBox.Show("Warning:Required empty field:!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                cn.Open();
                cm = new MySqlCommand("insert into stdgroup_table(year,Program,Gnumber,SubGnumber) values('"  + textBox1.Text + "','" + comboBox1.Text + "','" + numericUpDown1.Text + "','" + numericUpDown2.Text + "')",cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully saved.", "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
               
 
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Warning:" + ex.Message, "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }

        }

        //update
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == string.Empty) || (comboBox1.Text == string.Empty) || (numericUpDown1.Text == string.Empty) || (numericUpDown2.Text == string.Empty))
                {
                    MessageBox.Show("Warning:Required empty field:!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                cn.Open();
                cm = new MySqlCommand("update stdgroup_table set year = '"+textBox1.Text+"', Program = '" + comboBox1.Text + "', Gnumber = '" + numericUpDown1.Text + "', SubGnumber = '" + numericUpDown2.Text + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully Updated.", "Student Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();


            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Warning:" + ex.Message, "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_std_Group f2 = new Manage_std_Group();
            this.Hide();
            f2.Show();
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text + "." + numericUpDown1.Text;
            textBox3.Text = textBox1.Text + "." + numericUpDown1.Text + "." + numericUpDown2.Text;
        }
    }
}
