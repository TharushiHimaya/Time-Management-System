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
    public partial class StatisticalTable : Form
    {
        public StatisticalTable()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            chart1.Hide();
            chart2.Hide();
            chart3.Hide();
            chart4.Hide();
            chart5.Hide();
            chart6.Hide();
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Hide();
            chart5.Hide();
            chart3.Hide();
            chart6.Hide();
            groupBox4.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            chart2.Show();
            chart4.Show();
            groupBox1.Show();





            this.chart2.Series["No of Students"].Points.AddXY("Computing Faculty", "9400");
            this.chart2.Series["No of Students"].Points.AddXY("Engineering Faculty", "6000");
            this.chart2.Series["No of Students"].Points.AddXY("Business Faculty", "4800");

            this.chart4.Series["Females"].Points.AddXY("Computing Faculty", "4400");
            this.chart4.Series["Males"].Points.AddXY("Computing Faculty", "5000");

            this.chart4.Series["Females"].Points.AddXY("Engineering Faculty", "1000");
            this.chart4.Series["Males"].Points.AddXY("Engineering Faculty", "5000");


            this.chart4.Series["Females"].Points.AddXY("Business Faculty", "2800");
            this.chart4.Series["Males"].Points.AddXY("Business Faculty", "2000");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart5.Hide();
            chart3.Hide();
            chart6.Hide();
            chart2.Hide();
            chart4.Hide();
            groupBox4.Hide();
            groupBox3.Hide();
            groupBox1.Hide();
            chart1.Show();
            groupBox2.Show();


            this.chart1.Series["Senior Lecturers"].Points.AddXY("Computing Faculty", 50);
            this.chart1.Series["Lecturers"].Points.AddXY("Computing Faculty", 20);
            this.chart1.Series["Instructors"].Points.AddXY("Computing Faculty", 70);


            this.chart1.Series["Senior Lecturers"].Points.AddXY("Engineering Faculty", 30);
            this.chart1.Series["Lecturers"].Points.AddXY("Engineering Faculty", 20);
            this.chart1.Series["Instructors"].Points.AddXY("Engineering Faculty", 50);


            this.chart1.Series["Senior Lecturers"].Points.AddXY("Business Faculty", 20);
            this.chart1.Series["Lecturers"].Points.AddXY("Business Faculty", 20);
            this.chart1.Series["Instructors"].Points.AddXY("Business Faculty", 30);




        }

        private void button3_Click(object sender, EventArgs e)
        {

            chart2.Hide();
            chart4.Hide();
            chart3.Hide();
            chart1.Hide();
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox4.Hide();
            chart6.Show();
            chart5.Show();
            groupBox3.Show();


            this.chart6.Series["1st Year"].Points.AddXY("Computing Faculty", 9);
            this.chart6.Series["2nd Year"].Points.AddXY("Computing Faculty", 11);
            this.chart6.Series["3rd Year"].Points.AddXY("Computing Faculty", 12);
            this.chart6.Series["4th Year"].Points.AddXY("Computing Faculty", 14);


            this.chart6.Series["1st Year"].Points.AddXY("Engineering Faculty", 10);
            this.chart6.Series["2nd Year"].Points.AddXY("Engineering Faculty", 10);
            this.chart6.Series["3rd Year"].Points.AddXY("Engineering Faculty", 12);
            this.chart6.Series["4th Year"].Points.AddXY("Engineering Faculty", 10);


            this.chart6.Series["1st Year"].Points.AddXY("Business Faculty", 9);
            this.chart6.Series["2nd Year"].Points.AddXY("Business Faculty", 9);
            this.chart6.Series["3rd Year"].Points.AddXY("Business Faculty", 9);

            this.chart5.Series["Department1"].Points.AddXY("No of modules(IT)", 40);
            this.chart5.Series["Department2"].Points.AddXY("No of modules(IT)", 48);
            this.chart5.Series["Department3"].Points.AddXY("No of modules(IT)", 36);
            this.chart5.Series["Department4"].Points.AddXY("No of modules(IT)", 40);
            this.chart5.Series["Department5"].Points.AddXY("No of modules(IT)", 48);


            this.chart5.Series["Department1"].Points.AddXY("No of modules(EN)", 40);
            this.chart5.Series["Department2"].Points.AddXY("No of modules(EN)", 36);
            this.chart5.Series["Department3"].Points.AddXY("No of modules(EN)", 40);
            this.chart5.Series["Department4"].Points.AddXY("No of modules(EN)", 40);
            this.chart5.Series["Department5"].Points.AddXY("No of modules(EN)", 35);



            this.chart5.Series["Department1"].Points.AddXY("No of modules(BM)", 40);
            this.chart5.Series["Department2"].Points.AddXY("No of modules(BM)", 40);
            this.chart5.Series["Department3"].Points.AddXY("No of modules(BM)", 36);
            this.chart5.Series["Department4"].Points.AddXY("No of modules(BM)", 40);
            this.chart5.Series["Department5"].Points.AddXY("No of modules(BM)", 40);



        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart1.Hide();
            chart2.Hide();
            chart4.Hide();
            chart6.Hide();
            chart5.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox1.Hide();
            chart3.Show();
            groupBox4.Show();

            this.chart3.Series["Lecture Halls"].Points.AddXY("Computing Faculty", 15);
            this.chart3.Series["Laborotaries"].Points.AddXY("Computing Faculty", 20);
            this.chart3.Series["Tute Rooms"].Points.AddXY("Computing Faculty", 10);
            this.chart3.Series["Studying Rooms"].Points.AddXY("Computing Faculty", 4);


            this.chart3.Series["Lecture Halls"].Points.AddXY("Business Faculty", 10);
            this.chart3.Series["Laborotaries"].Points.AddXY("Business Faculty", 0);
            this.chart3.Series["Tute Rooms"].Points.AddXY("Business Faculty", 10);
            this.chart3.Series["Studying Rooms"].Points.AddXY("Business Faculty", 2);


            this.chart3.Series["Lecture Halls"].Points.AddXY("Engineering Faculty", 15);
            this.chart3.Series["Laborotaries"].Points.AddXY("Engineering Faculty", 30);
            this.chart3.Series["Tute Rooms"].Points.AddXY("Enginering Faculty", 10);
            this.chart3.Series["Studying Rooms"].Points.AddXY("Engineering Faculty", 3);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart6_Click(object sender, EventArgs e)
        {

        }
    }
}
