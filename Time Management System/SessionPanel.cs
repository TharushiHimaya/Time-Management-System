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
    public partial class SessionPanel : Form
    {
        public SessionPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageSessions manageSessions = new ManageSessions();
            manageSessions.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openContentForm(new Add_nat());

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

        private void button3_Click(object sender, EventArgs e)
        {

            openContentForm(new snt());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openContentForm(new ParallelSession());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openContentForm(new NonOverlapping());
        }
    }
}
