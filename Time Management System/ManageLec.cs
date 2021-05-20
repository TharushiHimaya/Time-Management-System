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
    public partial class ManageLec : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();
        string _id, _name, _faculty, _department, _building, _center, _rank, _level;

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

       /* private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard f2 = new Dashboard();
            f2.Show();
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddLec f2 = new AddLec();
            f2.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            _id = dataGridView1[0, i].Value.ToString();
            _name = dataGridView1[1, i].Value.ToString();
            _faculty = dataGridView1[2, i].Value.ToString();
            _department = dataGridView1[3, i].Value.ToString();
            _building = dataGridView1[4, i].Value.ToString();
            _center = dataGridView1[5, i].Value.ToString();
            _rank = dataGridView1[6, i].Value.ToString();
            _level = dataGridView1[7, i].Value.ToString();


        }

        public ManageLec()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());
            LoadRecord();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void LoadRecord()
        {

            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("select * from tbllecturer order by name, faculty, department, building, center, rank, level", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {

                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "colEdit")
            {
                AddLec frm = new AddLec();
                frm.button1.Enabled = false;
                frm.btnupdate.Enabled = true;
                frm.textBox1.Text = _id;
                frm.textBox2.Text = _name;
                frm.comboBox1.Text = _faculty;
                frm.comboBox2.Text = _department;
                frm.comboBox3.Text = _building;
                frm.comboBox4.Text = _center;
                frm.textBox7.Text = _rank;
                frm.comboBox5.Text = _level;
                frm.ShowDialog();


            }
            else if (colName == "colDelete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    cn.Open();
                    cm = new MySqlCommand("delete from tbllecturer where id like'" + _id + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been Successfully deleted !", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecord();

                }

            }
        }
    }
}
