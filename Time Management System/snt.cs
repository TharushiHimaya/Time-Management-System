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
    public partial class snt : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();
        string _id, _lec1, _lec2, _subn, _subc, _gid, _tag, _stno, _du;

        private Form activeForm = null;

        private void openContentForm(Form contentForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = contentForm;
            contentForm.BringToFront();
            contentForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //openContentForm(new FormContentNAT());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            _id = dataGridView1[1, i].Value.ToString();
            _lec1 = dataGridView1[2, i].Value.ToString();
            _lec2 = dataGridView1[3, i].Value.ToString();
            _subc = dataGridView1[4, i].Value.ToString();
            _subn = dataGridView1[5, i].Value.ToString();
            _gid = dataGridView1[6, i].Value.ToString();
            _tag = dataGridView1[7, i].Value.ToString();
            _stno = dataGridView1[8, i].Value.ToString();
            _du = dataGridView1[9, i].Value.ToString();
        }
        public snt()
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
            cm = new MySqlCommand("select * from session order by ID, Lecturer1, Lecturer2, SubjectCode , SubjectName , GroupID, Tag, StudentCount , Duration", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
            }
            dr.Close();
            cn.Close();



        }

        

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
       
    }
}
