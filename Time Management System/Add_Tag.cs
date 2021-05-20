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
    public partial class Add_Tag : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        //MySqlDataReader dr;
        DB clscon = new DB();

        public Add_Tag()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());
        }

        //clear all data
        public void Clear()
        {
            textBox1.Clear();
            button2.Enabled = true;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            comboBox1.Text = string.Empty;
        }

        //Add data to database
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == string.Empty) || (textBox1.Text == string.Empty) || (comboBox1.Text == string.Empty))
                {
                    MessageBox.Show("Warning:Required empty field:!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                cn.Open();
                cm = new MySqlCommand("insert into tagtable(tagname,tagcode,relatedtag) values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "')", cn);
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

        private void button1_Click(object sender, EventArgs e)
        {
            ManageTag f5 = new ManageTag();
            f5.ShowDialog();
        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == string.Empty) || (textBox2.Text == string.Empty) || (comboBox1.Text == string.Empty))
                {
                    MessageBox.Show("Warning:Required empty field:!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                cn.Open();
                cm = new MySqlCommand("update tagtable set tagname '" + textBox1.Text + "', tagcode = '" + textBox2.Text + "', relatedtag = '" + comboBox1.Text + "'", cn);
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
    }
}
