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
    public partial class Manage_std_Group : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();
        string _yr, _pro, _gno, _subno;

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            _yr = dataGridView1[1, i].Value.ToString();
            _pro = dataGridView1[2, i].Value.ToString();
            _gno = dataGridView1[3, i].Value.ToString();
            _subno = dataGridView1[4, i].Value.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_std_group f2 = new Add_std_group();
            this.Hide();
            f2.Show();
        }

        public Manage_std_Group()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());
            LoadRecords();
            
        }

        public void LoadRecords()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("select * from stdgroup_table order by year, Program, Gnumber,SubGnumber", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            dr.Close();
            cn.Close();
            


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (ColName == "colEdit")
            {
                Add_std_group frm = new Add_std_group();
                frm.textBox1.Text = _yr;
                frm.comboBox1.Text = _pro;
                frm.numericUpDown1.Text = _gno;
                frm.numericUpDown2.Text = _subno;
                frm.ShowDialog();

            }
            else if (ColName == "colDelete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    cn.Open();
                    cm = new MySqlCommand("delete from stdgroup_table where year like'" + _yr + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been Successfully deleted !", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();

                }

            }


        }
    }
}
