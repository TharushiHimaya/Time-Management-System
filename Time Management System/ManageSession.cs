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
    public partial class ManageSession : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();
        string _sid, _lec1, _lec2, _tag, _groupid, _subject, _studentno, _duration;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SessionPanel f2 = new SessionPanel();
            f2.Show();

        }

        public ManageSession()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());
            LoadRecord();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSession f2 = new AddSession();
            f2.Show();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            _sid = dataGridView1[0, i].Value.ToString();
            _lec1 = dataGridView1[1, i].Value.ToString();
            _lec2 = dataGridView1[2, i].Value.ToString();
            _tag = dataGridView1[3, i].Value.ToString();
            _groupid = dataGridView1[4, i].Value.ToString();
            _subject = dataGridView1[5, i].Value.ToString();
            _studentno = dataGridView1[6, i].Value.ToString();
            _duration = dataGridView1[7, i].Value.ToString();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "ColEdit")
            {
                AddSession frm = new AddSession();
                frm.button1.Enabled = true;
                frm.button4.Enabled = true;
                frm.button3.Enabled = false;

                frm.textBox4.Text = _sid;
                frm.textBox2.Text = _lec1;
                frm.textBox1.Text = _lec2;
                frm.comboBox2.Text = _tag;
                frm.comboBox6.Text = _groupid;
                frm.comboBox5.Text = _subject;
                frm.textBox3.Text = _studentno;
                frm.comboBox3.Text = _duration;
                frm.ShowDialog();


            }
            else if (colName == "ColDelete")
                if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
            {
                cn.Open();
                cm = new MySqlCommand("delete from tblsession where sid like'" + _sid + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been Successfully deleted !", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRecord();

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadRecord()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("select * from tblsession order by lec1, lec2, tag, groupid, subject, studentno, duration", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[7].ToString());
            }
            dr.Close();
            cn.Close();
        }
    }
}
