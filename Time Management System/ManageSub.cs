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
    public partial class ManageSub : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();
        string _code, _name, _year, _sem, _lechrs, _tutorialhrs, _labhrs, _evalutionhrs;

      

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            _code = dataGridView1[0, i].Value.ToString();
            _name = dataGridView1[1, i].Value.ToString();
            _year = dataGridView1[2, i].Value.ToString();
            _sem = dataGridView1[3, i].Value.ToString();
            _lechrs = dataGridView1[4, i].Value.ToString();
            _tutorialhrs = dataGridView1[5, i].Value.ToString();
            _labhrs = dataGridView1[6, i].Value.ToString();
            _evalutionhrs = dataGridView1[7, i].Value.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        public ManageSub()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());
            LoadRecord();
        }

        public void LoadRecord()
        {

            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("select * from tblsubject order by  name, year, sem, lechrs, tutorialhrs, labhrs, evalutionhrs", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSub f2 = new AddSub();
            f2.Show();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                AddSub frm = new AddSub();
                frm.button1.Enabled = false;
                frm.button2.Enabled = true;
                frm.textBox1.Text = _code;
                frm.textBox2.Text = _name;
                frm.textBox3.Text = _year;
                frm.radioButton1.Text = _sem;
                frm.radioButton2.Text = _sem;
                frm.numericUpDown1.Text = _lechrs;
                frm.numericUpDown2.Text = _tutorialhrs;
                frm.numericUpDown3.Text = _labhrs;
                frm.numericUpDown4.Text = _evalutionhrs;
                frm.ShowDialog();


            }
            else if (colName == "colDelete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    cn.Open();
                    cm = new MySqlCommand("delete from tblsubject where code like'" + _code + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been Successfully deleted !", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecord();

                }

            }
        }
    }
}
