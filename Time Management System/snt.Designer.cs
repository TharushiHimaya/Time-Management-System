
namespace Time_Management_System
{
    partial class snt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkbox1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lec1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lec2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 380);
            this.panel1.TabIndex = 6;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(198)))));
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(835, 331);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 35);
            this.button7.TabIndex = 8;
            this.button7.Text = "View";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox1,
            this.id,
            this.lec1,
            this.lec2,
            this.subcode,
            this.subn,
            this.gid,
            this.tag,
            this.stno,
            this.duration});
            this.dataGridView1.Location = new System.Drawing.Point(12, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(915, 294);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // checkbox1
            // 
            this.checkbox1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.checkbox1.HeaderText = "";
            this.checkbox1.MinimumWidth = 6;
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Width = 24;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // lec1
            // 
            this.lec1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lec1.HeaderText = "Lecturer1";
            this.lec1.MinimumWidth = 6;
            this.lec1.Name = "lec1";
            this.lec1.Width = 98;
            // 
            // lec2
            // 
            this.lec2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lec2.HeaderText = "Lecturer2";
            this.lec2.MinimumWidth = 6;
            this.lec2.Name = "lec2";
            this.lec2.Width = 98;
            // 
            // subcode
            // 
            this.subcode.HeaderText = "Subject Code";
            this.subcode.MinimumWidth = 6;
            this.subcode.Name = "subcode";
            this.subcode.Width = 125;
            // 
            // subn
            // 
            this.subn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.subn.HeaderText = "SubjectName";
            this.subn.MinimumWidth = 6;
            this.subn.Name = "subn";
            this.subn.Width = 121;
            // 
            // gid
            // 
            this.gid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gid.HeaderText = "GroupID";
            this.gid.MinimumWidth = 6;
            this.gid.Name = "gid";
            this.gid.Width = 90;
            // 
            // tag
            // 
            this.tag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tag.HeaderText = "Tag";
            this.tag.MinimumWidth = 6;
            this.tag.Name = "tag";
            this.tag.Width = 62;
            // 
            // stno
            // 
            this.stno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stno.HeaderText = "StudentNo";
            this.stno.MinimumWidth = 6;
            this.stno.Name = "stno";
            this.stno.Width = 104;
            // 
            // duration
            // 
            this.duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.duration.HeaderText = "Duration";
            this.duration.MinimumWidth = 6;
            this.duration.Name = "duration";
            this.duration.Width = 91;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(56)))), ((int)(((byte)(198)))));
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(655, 331);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add Session";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // snt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 376);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "snt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sessions and Not Available Time Allocations";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lec1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lec2;
        private System.Windows.Forms.DataGridViewTextBoxColumn subcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn subn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn stno;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.Button button2;
    }
}