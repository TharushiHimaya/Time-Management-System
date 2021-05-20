﻿using System;
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
    public partial class AddSessionRooms : Form
    {
        MySqlConnection cn;
        MySqlCommand cm;
        MySqlDataReader dr;
        DB clscon = new DB();
        ManageSessions ms;
        public AddSessionRooms(ManageSessions manageSession)
        {
            InitializeComponent();

            cn = new MySqlConnection(clscon.dbconnect());
            fillcomboxrooms2();
            ms = manageSession;
        }

        public void fillcomboxrooms2()
        {
            cm = new MySqlCommand("SELECT ID from session", cn);

            try
            {
                cn.Open();

                dr = cm.ExecuteReader();


                while (dr.Read())
                {
                    String sid = dr.GetString(dr.GetOrdinal("ID"));
                    comboBox1.Items.Add(sid);


                }

                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string con = "server=localhost;user id=root;password=;database=tms";

            try
            {
                cn.Open();
                cm = new MySqlCommand("SELECT * from session where ID =" + comboBox1.Text, cn);
                dr = cm.ExecuteReader();

                if (dr.Read())
                {

                    textBox1.Text = (dr[1].ToString());
                    textBox2.Text = (dr[2].ToString());
                    textBox3.Text = (dr[3].ToString());
                    textBox4.Text = (dr[4].ToString());
                    textBox5.Text = (dr[5].ToString());
                    textBox6.Text = (dr[6].ToString());
                    textBox7.Text = (dr[7].ToString());
                    textBox8.Text = (dr[8].ToString());


                }
                dr.Close();
                cn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new MySqlCommand("insert into session_Room(ID,Lecturer1,Lecturer2,SubjectCode,SubjectName,GroupID,Tag,StudentCount,Duration,RoomName) values('" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + comboBox2.Text + "')", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully saved.", "Location Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                ms.LoadRecords();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Warning:" + ex.Message, "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new MySqlCommand("update session_Room set RoomName ='" + comboBox2.Text + "'where ID like '" + comboBox1.Text + "'", cn);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record has been successfully updated.", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ms.LoadRecords();
                this.Dispose();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show("Warning:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


    }
}

