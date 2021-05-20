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
    public partial class ManageSessions : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();
        string _ID, _Lecturer1, _Lecturer2, _SubjectCode, _SubjectName, _GroupID, _Tag, _RoomName, _StudentCount, _Duration;

        public ManageSessions()
        {
            InitializeComponent();

            cn = new MySqlConnection(clscon.dbconnect());
            LoadRecords();
            LoadRecordings();
        }

        public void LoadRecords()
        {

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("select * from session_Room order by ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
            }
            dr.Close();
            cn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Hide();
            button1.Hide();
            button7.Hide();
            dataGridView1.Show();
            button5.Show();
            button6.Show();
            textBox1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "Convert(Subject Name, 'System.String') Like '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = bs;

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openContentForm(new Location_nat());

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

        public void LoadRecordings()
        {

            int i = 0;
            dataGridView2.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("select * from consecutive_Room order by ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView2.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
            }
            dr.Close();
            cn.Close();

        }

        private void ManageSession_Load(object sender, EventArgs e)
        {
            dataGridView2.Hide();
            button1.Hide();
            button7.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddConsecutiveRooms addConsecutiveRooms = new AddConsecutiveRooms(this);
            addConsecutiveRooms.comboBox1.Enabled = true;
            addConsecutiveRooms.button3.Enabled = true;
            addConsecutiveRooms.button4.Enabled = false;
            addConsecutiveRooms.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            button5.Hide();
            button6.Hide();
            textBox1.Hide();
            dataGridView2.Show();
            button1.Show();
            button7.Show();

        }




        private void button5_Click(object sender, EventArgs e)
        {
            AddSessionRooms addSessionRooms = new AddSessionRooms(this);
            addSessionRooms.comboBox1.Enabled = true;
            addSessionRooms.button3.Enabled = true;
            addSessionRooms.button4.Enabled = false;
            addSessionRooms.ShowDialog();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            _ID = dataGridView1[1, i].Value.ToString();
            _Lecturer1 = dataGridView1[2, i].Value.ToString();
            _Lecturer2 = dataGridView1[3, i].Value.ToString();
            _SubjectCode = dataGridView1[4, i].Value.ToString();
            _SubjectName = dataGridView1[5, i].Value.ToString();
            _GroupID = dataGridView1[6, i].Value.ToString();
            _Tag = dataGridView1[7, i].Value.ToString();
            _StudentCount = dataGridView1[8, i].Value.ToString();
            _Duration = dataGridView1[9, i].Value.ToString();
            _RoomName = dataGridView1[10, i].Value.ToString();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView2.CurrentRow.Index;
            _ID = dataGridView2[1, i].Value.ToString();
            _Lecturer1 = dataGridView2[2, i].Value.ToString();
            _Lecturer2 = dataGridView2[3, i].Value.ToString();
            _SubjectCode = dataGridView2[4, i].Value.ToString();
            _SubjectName = dataGridView2[5, i].Value.ToString();
            _GroupID = dataGridView2[6, i].Value.ToString();
            _Tag = dataGridView2[7, i].Value.ToString();
            _StudentCount = dataGridView2[8, i].Value.ToString();
            _Duration = dataGridView2[9, i].Value.ToString();
            _RoomName = dataGridView2[10, i].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "colEdit")
            {

                AddSessionRooms addSessionRooms = new AddSessionRooms(this);
                addSessionRooms.button3.Enabled = false;
                addSessionRooms.button4.Enabled = true;
                addSessionRooms.comboBox1.Enabled = false;
                addSessionRooms.comboBox1.Text = _ID;
                addSessionRooms.textBox1.Enabled = false;
                addSessionRooms.textBox2.Enabled = false;
                addSessionRooms.textBox3.Enabled = false;
                addSessionRooms.textBox4.Enabled = false;
                addSessionRooms.textBox5.Enabled = false;
                addSessionRooms.textBox6.Enabled = false;
                addSessionRooms.textBox7.Enabled = false;
                addSessionRooms.textBox8.Enabled = false;
                addSessionRooms.textBox1.Text = _Lecturer1;
                addSessionRooms.textBox2.Text = _Lecturer2;
                addSessionRooms.textBox3.Text = _SubjectCode;
                addSessionRooms.textBox4.Text = _SubjectName;
                addSessionRooms.textBox5.Text = _GroupID;
                addSessionRooms.textBox6.Text = _Tag;
                addSessionRooms.textBox7.Text = _StudentCount;
                addSessionRooms.textBox8.Text = _Duration;
                addSessionRooms.comboBox2.Text = _RoomName;
                addSessionRooms.ShowDialog();
            }
            else if (colName == "colDelete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new MySqlCommand("delete from session_Room where ID like '" + _ID + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted.", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView2.Columns[e.ColumnIndex].Name;
            if (colName == "colUpdate")
            {

                AddConsecutiveRooms addConsecutiveRooms = new AddConsecutiveRooms(this);
                addConsecutiveRooms.button3.Enabled = false;
                addConsecutiveRooms.button4.Enabled = true;
                addConsecutiveRooms.comboBox1.Enabled = false;
                addConsecutiveRooms.comboBox1.Text = _ID;
                addConsecutiveRooms.textBox1.Enabled = false;
                addConsecutiveRooms.textBox2.Enabled = false;
                addConsecutiveRooms.textBox3.Enabled = false;
                addConsecutiveRooms.textBox4.Enabled = false;
                addConsecutiveRooms.textBox5.Enabled = false;
                addConsecutiveRooms.textBox6.Enabled = false;
                addConsecutiveRooms.textBox7.Enabled = false;
                addConsecutiveRooms.textBox8.Enabled = false;
                addConsecutiveRooms.textBox1.Text = _Lecturer1;
                addConsecutiveRooms.textBox2.Text = _Lecturer2;
                addConsecutiveRooms.textBox3.Text = _SubjectCode;
                addConsecutiveRooms.textBox4.Text = _SubjectName;
                addConsecutiveRooms.textBox5.Text = _GroupID;
                addConsecutiveRooms.textBox6.Text = _Tag;
                addConsecutiveRooms.textBox7.Text = _StudentCount;
                addConsecutiveRooms.textBox8.Text = _Duration;
                addConsecutiveRooms.comboBox2.Text = _RoomName;
                addConsecutiveRooms.ShowDialog();
            }
            else if (colName == "colDelete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new MySqlCommand("delete from consecutive_Room where ID like '" + _ID + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted.", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }
            }


        }







    }
}

