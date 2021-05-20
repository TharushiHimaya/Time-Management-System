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
    public partial class Manage_nat : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();
        string _id, _lecturer, _group, _sub_gp,_day,_stime,_etime;

        private void button3_Click(object sender, EventArgs e)
        {
            Add_nat add_nat = new Add_nat();


            add_nat.button3.Enabled = true;
            add_nat.button5.Enabled = false;
            add_nat.textBox1.Enabled = true;
            openContentForm(new Add_nat());

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

        public Manage_nat()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());
            LoadRecords();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            _id = dataGridView1[1, i].Value.ToString();
            _lecturer = dataGridView1[2, i].Value.ToString();
            _group = dataGridView1[3, i].Value.ToString();
            _sub_gp = dataGridView1[4, i].Value.ToString();
            _day= dataGridView1[5, i].Value.ToString();
            _stime = dataGridView1[6, i].Value.ToString();
            _etime = dataGridView1[7, i].Value.ToString();



        }

        private void Manage_nat_Load(object sender, EventArgs e)
        {

        }

        public void LoadRecords()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("select * from add_nat order by lecturer", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());


            }
            dr.Close();
            cn.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                Add_nat add_nat = new Add_nat();


                add_nat.button3.Enabled = false;
                add_nat.button5.Enabled = true;
                add_nat.textBox1.Enabled = false;
                add_nat.textBox1.Text = _id;
                add_nat.comboBox2.Text =_lecturer ;
                add_nat.comboBox3.Text = _group;
                add_nat.comboBox4.Text = _sub_gp;
                add_nat.comboBox1.Text = _day;
                add_nat.dateTimePicker2.Text = _stime;
                add_nat.dateTimePicker3.Text = _etime;
                this.Hide();
                add_nat.Show();

            }
            else if (colName == "colDelete")

            {
                if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    cn.Open();
                    cm = new MySqlCommand("delete from add_nat where ID like'" +_id +"' ", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been Successfully deleted !", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();

                }
            }
        }
    }
}
