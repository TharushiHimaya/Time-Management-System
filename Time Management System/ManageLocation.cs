
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

    public partial class ManageLocation : Form
    {

        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();
        string _AddNo, _DepartmentName, _RoomName, _Capacity, _RoomType;

        public ManageLocation()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());
            LoadRecords();
        }

        private void ManageLocation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadRecords()
        {

            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("select * from location order by AddNo", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            cn.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddLocation addLocation = new AddLocation(this);
            addLocation.textBox2.Enabled = true;
            addLocation.button3.Enabled = true;
            addLocation.button4.Enabled = false;
            this.Hide();
            addLocation.ShowDialog();
           

        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            _AddNo = dataGridView1[1, i].Value.ToString();
            _DepartmentName = dataGridView1[2, i].Value.ToString();
            _RoomType = dataGridView1[3, i].Value.ToString();
            _RoomName = dataGridView1[4, i].Value.ToString();
            _Capacity = dataGridView1[5, i].Value.ToString();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "colEdit")
            {

                AddLocation addLocation = new AddLocation(this);
                addLocation.button3.Enabled = false;
                addLocation.button4.Enabled = true;
                addLocation.textBox2.Enabled = true;
                //addLocation.textBox2.Enabled = false;
                addLocation.textBox2.Text = _AddNo;
                addLocation.comboBox1.Text = _DepartmentName;
                addLocation.radioButton1.Checked = true;
                addLocation.radioButton2.Checked = true;
                addLocation.comboBox2.Text = _RoomName;
                addLocation.textBox1.Text = _Capacity;
                addLocation.ShowDialog();
            }
            else if (colName == "colDelete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new MySqlCommand("delete from location where AddNo like '" + _AddNo + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been successfully deleted.", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }
            }


        }







    }
}
