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
    public partial class AddSession : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();

        public AddSession()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            textBox4.Clear();
            textBox1.Clear();
            textBox2.Clear();
            comboBox2.Text = String.Empty;
            comboBox6.Text = String.Empty;
            comboBox5.Text = String.Empty;
            textBox3.Clear();
            comboBox3.Text = String.Empty;
            button4.Enabled = true;
            button3.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                if ((textBox4.Text == string.Empty) || (textBox2.Text == string.Empty) || (textBox1.Text == string.Empty) || (comboBox2.Text == string.Empty) || (comboBox6.Text == string.Empty) || (comboBox5.Text == string.Empty) || (textBox3.Text == string.Empty) || (comboBox3.Text == string.Empty))
                {
                    MessageBox.Show("Warning:Required empty field:!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                cn.Open();
                cm = new MySqlCommand("insert into tblsession ( sid, lec1, lec2, tag, groupid, subject, studentno, duration) values('" + textBox4.Text + "','" + textBox2.Text + "','" + textBox1.Text + "','" + comboBox2.Text + "','" + comboBox6.Text + "','" + comboBox5.Text + "','" + textBox3.Text + "','" + comboBox3.Text + "')", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully saved.", "Session Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();

                this.Hide();
                ManageSession f2 = new ManageSession();
                f2.Show();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Warning:" + ex.Message, "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if ((textBox4.Text == string.Empty) || (textBox2.Text == string.Empty) || (textBox1.Text == string.Empty) || (comboBox2.Text == string.Empty) || (comboBox6.Text == string.Empty) || (comboBox5.Text == string.Empty) || (textBox3.Text == string.Empty) || (comboBox3.Text == string.Empty))
                {
                    MessageBox.Show("Warning:Required empty field:!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                cn.Open();
                cm = new MySqlCommand("update tblsession set lec1 = '" + textBox2.Text + "', lec2 = '" + textBox1.Text + "', tag = '" + comboBox2.Text + "', groupid = '" + comboBox6.Text + "', subject = '" + comboBox5.Text + "', studentno = '" + textBox3.Text + "', duration = '" + comboBox3.Text + "' where id like'" + textBox4.Text + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully Updated.", "Session Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                this.Dispose();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Warning:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
