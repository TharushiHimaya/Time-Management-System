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
    public partial class AddSub : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();


        public AddSub()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());
        }


        string offeredsem;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            offeredsem = "1st Sem";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                offeredsem = radioButton1.Text;
            }

            else if (radioButton2.Checked == true)
            {
                offeredsem = radioButton2.Text;
            }

            try
            {
                if ((textBox1.Text == string.Empty) || (textBox2.Text == string.Empty) || (textBox3.Text == string.Empty) || (offeredsem == string.Empty) || (numericUpDown1.Text == string.Empty) || (numericUpDown2.Text == string.Empty) || (numericUpDown3.Text == string.Empty) || (numericUpDown4.Text == string.Empty))
                {
                    MessageBox.Show("Warning:Required empty field:!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                cn.Open();
                cm = new MySqlCommand("insert into tblsubject ( code, name, year, sem, lechrs, 	tutorialhrs, labhrs, evalutionhrs) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + offeredsem + "','" + numericUpDown1.Text + "','" + numericUpDown2.Text + "','" + numericUpDown3.Text + "','" + numericUpDown4.Text + "')", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully saved.", "Lecturer Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                button2.Enabled = false;


                this.Hide();
                ManageSub f2 = new ManageSub();
                f2.Show();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Warning:" + ex.Message, "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }






        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            offeredsem = "2nd Sem";

        }

        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            offeredsem = String.Empty;
            numericUpDown1.Text = String.Empty;
            numericUpDown2.Text = String.Empty;
            numericUpDown3.Text = String.Empty;
            numericUpDown4.Text = String.Empty;
            button1.Enabled = true;
            button2.Enabled = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == string.Empty) || (textBox2.Text == string.Empty) || (textBox3.Text == string.Empty) || (offeredsem == string.Empty) || (numericUpDown1.Text == string.Empty) || (numericUpDown2.Text == string.Empty) || (numericUpDown3.Text == string.Empty) || (numericUpDown4.Text == string.Empty))
                {
                    MessageBox.Show("Warning:Required empty field:!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                cn.Open();
                cm = new MySqlCommand("update tblsubject set name = '" + textBox2.Text + "', year  = '" + textBox3.Text + "', sem = '" + offeredsem + "', lechrs = '" + numericUpDown1.Text + "', tutorialhrs = '" + numericUpDown2.Text + "', labhrs = '" + numericUpDown3.Text + "', evalutionhrs = '" + numericUpDown4.Text + "' where code like'" + textBox1.Text + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully Updated.", "Lecturer Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Dispose();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Warning:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
