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
    public partial class Manage_wds_hrs : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();
        string  _No_of_working_days, _Working_days, _Working_hrs_per_day, _Working_Mins_per_day;

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
           
            _No_of_working_days = dataGridView1[1, i].Value.ToString();
            _Working_days = dataGridView1[2, i].Value.ToString();
            _Working_hrs_per_day = dataGridView1[3, i].Value.ToString();
            _Working_Mins_per_day = dataGridView1[4, i].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if(colName=="colEdit")
            {
                Add_wds_hrs add_wds_hrs = new Add_wds_hrs();


                add_wds_hrs.button3.Enabled = false;
                add_wds_hrs.button5.Enabled = true;
                add_wds_hrs.numericUpDown1.Text = _No_of_working_days;
                //add_wds_hrs.checkBox1.Text= _Working_days; 
            
                add_wds_hrs.numericUpDown2.Text = _Working_hrs_per_day;
                add_wds_hrs.numericUpDown3.Text = _Working_Mins_per_day;
                this.Hide();
                add_wds_hrs.Show();

            }else  if(colName == "colDelete")

                {
                if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    cn.Open();
                    cm = new MySqlCommand("delete from working_ds_and_hrs_table where No_of_working_days like'" + _No_of_working_days+ "' ", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has been Successfully deleted !", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();

                }


            }
        }



        public Manage_wds_hrs()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());
            LoadRecords();
        }

        private void Manage_wds_hrs_Load(object sender, EventArgs e)
        {
            
            
        }
        public void LoadRecords()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new MySqlCommand("select * from working_ds_and_hrs_table order by No_of_working_days,Working_days,Working_hrs_per_day,Working_Mins_per_day", cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());


            }
            dr.Close();
            cn.Close();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_wds_hrs add_wds_hrs = new Add_wds_hrs();

           
            add_wds_hrs.button3.Enabled = true;
            add_wds_hrs.button5.Enabled = false;
            this.Hide();
            add_wds_hrs.Show();
        }
    }
    }






