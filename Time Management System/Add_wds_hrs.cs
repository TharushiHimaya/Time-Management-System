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
    public partial class Add_wds_hrs : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();
        
        

        public Add_wds_hrs()
        {
            InitializeComponent();
            cn = new MySqlConnection(clscon.dbconnect());
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_wds_hrs manage_wds_hrs = new Manage_wds_hrs();
            this.Hide();
            manage_wds_hrs.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_time_slot add_time_slot = new Add_time_slot();
            this.Hide();
            add_time_slot.Show();
        }

      
        private  void button3_Click(object sender, EventArgs e)

        {
           

            try
            {
                string s = "";

                if (checkBox1.CheckState==CheckState.Checked)
                {
                    s += "Monday" + "  ,  ";
                }
                if (checkBox2.CheckState == CheckState.Checked)
                {
                    s += "Tuesday"+ "  ,  ";
                }
                if (checkBox3.CheckState == CheckState.Checked)
                {
                    s += "Wednesday"+"  ,  ";
                }
                if (checkBox4.CheckState == CheckState.Checked)
                {
                    s += "Thursday"+ "  ,  ";
                }
                if (checkBox5.CheckState == CheckState.Checked)
                {
                    s += "Friday" + "  ,  ";
                }
                if (checkBox6.CheckState == CheckState.Checked)
                {
                    s += "Saturday"+"  ,  ";
                }
                if (checkBox7.CheckState == CheckState.Checked)
                {
                    s += "Sunday" + "  ,  ";
                }

              

                if ((numericUpDown1.Text == string.Empty)  || (numericUpDown2.Text == string.Empty) || (numericUpDown3.Text == string.Empty))
                {
                    MessageBox.Show("Warning:Required empty field:!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                cn.Open();
               
                cm = new MySqlCommand("insert into working_ds_and_hrs_table(No_of_working_days,Working_days,Working_hrs_per_day,Working_Mins_per_day) values('" + numericUpDown1.Text + "' ,'" + s + "','" + numericUpDown2.Text + "','" + numericUpDown3.Text + "')", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully saved.", "Working days and hours Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Warning:" + ex.Message, "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox7_CheckedChanged_1(object sender, EventArgs e)
        {

        }
        public void clearAllFields()
        {
            numericUpDown1.Text = string.Empty;
            if (this.checkBox1.Checked)
                this.checkBox1.Checked = false;
            if (this.checkBox2.Checked)
                this.checkBox2.Checked = false;
            if (this.checkBox3.Checked)
                this.checkBox3.Checked = false;
            if (this.checkBox4.Checked)
                this.checkBox4.Checked = false;
            if (this.checkBox5.Checked)
                this.checkBox5.Checked = false;
            if (this.checkBox6.Checked)
                this.checkBox6.Checked = false;
            if (this.checkBox7.Checked)
                this.checkBox7.Checked = false;

            numericUpDown2.Text = string.Empty;
            numericUpDown3.Text = string.Empty;
            button4.Enabled = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            try
            {
                string s = "";

                if (checkBox1.CheckState == CheckState.Checked)
                {
                    s += "Monday" + " , ";
                }
                if (checkBox2.CheckState == CheckState.Checked)
                {
                    s += "Tuesday" + " , ";
                }
                if (checkBox3.CheckState == CheckState.Checked)
                {
                    s += "Wednesday" + " , ";
                }
                if (checkBox4.CheckState == CheckState.Checked)
                {
                    s += "Thursday" + " , ";
                }
                if (checkBox5.CheckState == CheckState.Checked)
                {
                    s += "Friday";
                }
                if (checkBox6.CheckState == CheckState.Checked)
                {
                    s += "Saturday" + " , ";
                }
                if (checkBox7.CheckState == CheckState.Checked)
                {
                    s += "Sunday";
                }



                if ((numericUpDown1.Text == string.Empty) || (numericUpDown2.Text == string.Empty) || (numericUpDown3.Text == string.Empty))
                {
                    MessageBox.Show("Warning:Required empty field:!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                cn.Open();

                cm = new MySqlCommand("update  working_ds_and_hrs_table set  No_of_working_days = '" + numericUpDown1.Text + "', Working_days ='" + s + "',Working_hrs_per_day='" + numericUpDown2.Text + "',Working_Mins_per_day='" + numericUpDown3.Text + "' ", cn);
                cn.Close();
                MessageBox.Show("Record has been successfully updated.", "Working days and hours Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {

                cn.Close();
                MessageBox.Show("Warning:" + ex.Message, "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

  


}



