using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Management_System
{
    public partial class NonOverlapping : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();
        string _id, _lec1, _lec2, _subn, _subc, _gid, _tag, _stno, _du;



        public NonOverlapping()
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
    }
}
