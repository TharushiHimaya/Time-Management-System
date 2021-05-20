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
    public partial class AddLec : Form
    {

        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();

        public AddLec()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if ((textBox1.Text == string.Empty) || (textBox2.Text == string.Empty) || (comboBox1.Text == string.Empty) || (comboBox2.Text == string.Empty) || (comboBox3.Text == string.Empty) || (comboBox4.Text == string.Empty) || (textBox7.Text == string.Empty) || (comboBox5.Text == string.Empty))
                {
                    MessageBox.Show("Warning:Required empty field:!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                cn.Open();
                cm = new MySqlCommand("insert into tbllecturer ( id, name, faculty, department, building, center, rank, level) values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + textBox7.Text + "','" + comboBox5.Text + "')", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully saved.", "Lecturer Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.Hide();
                ManageLec f2 = new ManageLec();
                f2.Show();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Warning:" + ex.Message, "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = String.Empty;
            comboBox2.Text = String.Empty;
            comboBox3.Text = String.Empty;
            comboBox4.Text = String.Empty;
            textBox7.Clear();
            comboBox5.Text = String.Empty;
            button1.Enabled = true;
            btnupdate.Enabled = false;
        }
        public void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text == string.Empty) || (textBox2.Text == string.Empty) || (comboBox1.Text == string.Empty) || (comboBox2.Text == string.Empty) || (comboBox3.Text == string.Empty) || (comboBox4.Text == string.Empty) || (textBox7.Text == string.Empty) || (comboBox5.Text == string.Empty))
                {
                    MessageBox.Show("Warning:Required empty field:!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                cn.Open();
                cm = new MySqlCommand("update tbllecturer set name = '" + textBox2.Text + "', faculty = '" + comboBox1.Text + "', department = '" + comboBox2.Text + "', building = '" + comboBox3.Text + "', center = '" + comboBox4.Text + "', rank = '" + textBox7.Text + "', level = '" + comboBox5.Text + "' where id like'" + textBox1.Text + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully Updated.", "Lecturer Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
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

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
