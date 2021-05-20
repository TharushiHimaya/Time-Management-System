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
    public partial class Add_nat : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();

        public Add_nat()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());

        }

        private void Add_nat_Load(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "HH:mm:ss";
            dateTimePicker3.CustomFormat = "HH:mm:ss";
        }

        public void Clear()
        {
            textBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
            comboBox4.Text = string.Empty;
            comboBox1.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
            dateTimePicker3.Text = string.Empty;

            button4.Enabled = true;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            openContentForm(new Manage_nat());
        }

        private Form activeForm = null;

        private void openContentForm(Form contentForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentForm;
            contentForm.TopLevel = false;
            contentForm.FormBorderStyle = FormBorderStyle.None;
            contentForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(contentForm);
            panel1.Tag = contentForm;
            contentForm.BringToFront();
            contentForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                if ((textBox1.Text == string.Empty) || (comboBox2.Text == string.Empty) || (comboBox3.Text == string.Empty) || (comboBox4.Text == string.Empty) || (comboBox1.Text == string.Empty) || (dateTimePicker2.Text == string.Empty) || (dateTimePicker3.Text == string.Empty))
                {
                    MessageBox.Show("Warning:Required empty field:!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                cn.Open();

                cm = new MySqlCommand("insert into add_nat(ID,lecturer,gp,sub_gp,day,stime,etime) values('" + textBox1.Text + "' ,'" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "','" + comboBox1.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker3.Text + "')", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully saved.", "not available times Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {


                if ((textBox1.Text == string.Empty) || (comboBox2.Text == string.Empty) || (comboBox3.Text == string.Empty) || (comboBox4.Text == string.Empty) || (comboBox1.Text == string.Empty) || (dateTimePicker2.Text == string.Empty) || (dateTimePicker3.Text == string.Empty))
                {
                    MessageBox.Show("Warning:Required empty field:!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                cn.Open();

                cm = new MySqlCommand("update  add_nat set   lecturer='" + comboBox2.Text + "',gp='" + comboBox3.Text + "',sub_gp='" + comboBox4.Text + "',day='" + comboBox1.Text + "',stime='" + dateTimePicker2.Text + "',etime='" + dateTimePicker3.Text + "' ", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully updated.", "not available times Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Warning:" + ex.Message, "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void paneNAT_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
