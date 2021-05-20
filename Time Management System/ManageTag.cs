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
    public partial class ManageTag : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();
        string name, code, reltag;

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            name = dataGridView1[0, i].Value.ToString();
            code = dataGridView1[1, i].Value.ToString();
            reltag = dataGridView1[2, i].Value.ToString();
        }


        public ManageTag()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());
            LoadRecords();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Tag f2 = new Add_Tag();
            f2.Show();
        }

        public void LoadRecords()
        {

            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("select * from tagtable order by tagname, tagcode, relatedtag", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            cn.Close();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (ColName == "colEdit")
            {
                Add_Tag frm = new Add_Tag();
                frm.textBox1.Text = name;
                frm.textBox2.Text = code;
                frm.comboBox1.Text = reltag;
                frm.ShowDialog();


            }
            else if (ColName == "colDelete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    cn.Open();
                    cm = new MySqlCommand("delete from tagtable where tagcode like'" + code + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been Successfully deleted !", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();

                }

            }
        }


    }

}

    