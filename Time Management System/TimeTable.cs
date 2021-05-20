using System;
using System.Collections;
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

    public partial class TimeTable : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();
        public int hr = 8;
        public int min = 30;
        public int sec = 0;
        public int TimetableID;

        public TimeTable()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());

        }

        private void TimeTable_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = null;
            comboBox1.Items.Clear();

            string query4 = "select RoomName FROM location";
            MySqlDataAdapter da4 = new MySqlDataAdapter(query4, cn);
            try
            {
                cn.Open();
                DataSet ds4 = new DataSet();
                da4.Fill(ds4, "location");

                comboBox1.DisplayMember = "RoomName";
                comboBox1.ValueMember = "RoomName";
                comboBox1.DataSource = ds4.Tables["location"];

                cn.Close();
                comboBox1.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

            hr = 8;
            min = 30;
            sec = 0;

            String query1 = "select Lecturer1,Lecturer2,SubjectName,SubjectCode,GroupID,Tag,RoomName,'1' from session_Room where ID LIKE '%" + comboBox1.Text + "%'";

            MySqlCommand cm = new MySqlCommand(query1, cn);
            cn.Open();
            DataTable dt = new DataTable();
            MySqlDataReader dr = cm.ExecuteReader();
            dt.Load(dr);


            cn.Close();

            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Time";
            dataGridView1.Columns[1].Name = "Monday";
            dataGridView1.Columns[2].Name = "Tuesday";
            dataGridView1.Columns[3].Name = "Wednesday";
            dataGridView1.Columns[4].Name = "Thursday";
            dataGridView1.Columns[5].Name = "Friday";
            dataGridView1.Columns[6].Name = "Saturday";
            dataGridView1.Columns[7].Name = "Sunday";

            System.IO.StringWriter sw;
            string output;
            int xCount = 1;
            int yCount = 0;
            string[,] Tablero = new string[5, 8];


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    Tablero[k, l] = " --- ";
                }
            }

            // Loop through each row in the table.
            foreach (DataRow row in dt.Rows)
            {
                sw = new System.IO.StringWriter();

                // Loop through each column.
                foreach (DataColumn col in dt.Columns)
                {
                    // Output the value of each column's data.
                    sw.Write(row[col].ToString() + "\n");
                }

                output = sw.ToString();

                // Trim off the trailing ", ", so the output looks correct.
                if (output.Length > 2)
                    output = output.Substring(0, output.Length - 2);


                if (yCount == 5)
                {
                    yCount = 0;
                    xCount++;
                }
                try
                {

                    Tablero[yCount, xCount] = output;
                    yCount++;
                }
                catch (Exception ex)
                {
                }
            }

            do
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    try
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (dataGridView1.Rows.Count > 1);


            for (int k = 0; k < Tablero.GetLength(0); k++)
            {
                var arlist1 = new ArrayList();

                for (int l = 0; l < Tablero.GetLength(1); l++)
                {
                    arlist1.Add(Tablero[k, l]);
                }

                string srrr = (string)arlist1[1];
                string srrr2 = srrr.Substring(srrr.Length - 2);

                string[] row = new string[] {
                    hr + "." + min,
                    (string) arlist1[1],
                    (string) arlist1[2],
                    (string) arlist1[3],
                    (string) arlist1[4],
                    (string) arlist1[5],
                    (string) arlist1[6],
                    (string) arlist1[7]
                };

                try
                {
                    timeCalc(int.Parse(srrr2.Trim()), 0, 0);
                }
                catch (Exception ex)
                {

                }

                dataGridView1.Rows.Add(row);
            }
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timeCalc(int hr1, int min1, int sec1)
        {
            sec += sec1;

            if (sec > 60)
            {
                min++;
                sec -= 60;
            }

            min += min1;

            if (min > 60)
            {
                hr++;
                min -= 60;
            }

            hr += hr1;
        }







        private void GenerateTimetable_Load(object sender, EventArgs e)
        {



            this.comboBox1.DataSource = null;
            comboBox1.Items.Clear();

            string query4 = "select RoomName FROM session_Room";
            MySqlDataAdapter da4 = new MySqlDataAdapter(query4, cn);
            cn.Open();
            DataSet ds4 = new DataSet();
            da4.Fill(ds4, "session_Room");

            comboBox1.DisplayMember = "RoomName";
            comboBox1.ValueMember = "RoomName";
            comboBox1.DataSource = ds4.Tables["session_Room"];

            cn.Close();
            comboBox1.SelectedIndex = -1;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
