namespace Mens_Beauty_Center
{
    partial class AddAttendance
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LeaveBtn = new System.Windows.Forms.Button();
            this.LeaveCB = new System.Windows.Forms.ComboBox();
            this.AttendBtn = new System.Windows.Forms.Button();
            this.AttendCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ExpenceBtn = new System.Windows.Forms.Button();
            this.ExpenceTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpenceCB = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LeaveBtn);
            this.groupBox1.Controls.Add(this.LeaveCB);
            this.groupBox1.Controls.Add(this.AttendBtn);
            this.groupBox1.Controls.Add(this.AttendCB);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(76, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "حضور ومغادرة الموظف";
            // 
            // LeaveBtn
            // 
            this.LeaveBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveBtn.Location = new System.Drawing.Point(21, 165);
            this.LeaveBtn.Name = "LeaveBtn";
            this.LeaveBtn.Size = new System.Drawing.Size(197, 51);
            this.LeaveBtn.TabIndex = 3;
            this.LeaveBtn.Text = "مغادرة";
            this.LeaveBtn.UseVisualStyleBackColor = true;
            this.LeaveBtn.Click += new System.EventHandler(this.LeaveBtn_Click);
            // 
            // LeaveCB
            // 
            this.LeaveCB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaveCB.FormattingEnabled = true;
            this.LeaveCB.Items.AddRange(new object[] {
            "...."});
            this.LeaveCB.Location = new System.Drawing.Point(275, 173);
            this.LeaveCB.Name = "LeaveCB";
            this.LeaveCB.Size = new System.Drawing.Size(316, 38);
            this.LeaveCB.TabIndex = 2;
            // 
            // AttendBtn
            // 
            this.AttendBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendBtn.Location = new System.Drawing.Point(21, 65);
            this.AttendBtn.Name = "AttendBtn";
            this.AttendBtn.Size = new System.Drawing.Size(197, 51);
            this.AttendBtn.TabIndex = 1;
            this.AttendBtn.Text = "حضور";
            this.AttendBtn.UseVisualStyleBackColor = true;
            this.AttendBtn.Click += new System.EventHandler(this.AttendBtn_Click);
            // 
            // AttendCB
            // 
            this.AttendCB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendCB.FormattingEnabled = true;
            this.AttendCB.Location = new System.Drawing.Point(275, 73);
            this.AttendCB.Name = "AttendCB";
            this.AttendCB.Size = new System.Drawing.Size(316, 38);
            this.AttendCB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(68, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "حضور ومغادرة الموظفين والمصاريف اليومية";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ExpenceBtn);
            this.groupBox2.Controls.Add(this.ExpenceTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ExpenceCB);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(76, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 317);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "سحب المصروفات";
            // 
            // ExpenceBtn
            // 
            this.ExpenceBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenceBtn.Location = new System.Drawing.Point(182, 239);
            this.ExpenceBtn.Margin = new System.Windows.Forms.Padding(8);
            this.ExpenceBtn.Name = "ExpenceBtn";
            this.ExpenceBtn.Size = new System.Drawing.Size(197, 51);
            this.ExpenceBtn.TabIndex = 4;
            this.ExpenceBtn.Text = "سحب";
            this.ExpenceBtn.UseVisualStyleBackColor = true;
            this.ExpenceBtn.Click += new System.EventHandler(this.ExpenceBtn_Click);
            // 
            // ExpenceTxt
            // 
            this.ExpenceTxt.Location = new System.Drawing.Point(21, 173);
            this.ExpenceTxt.Name = "ExpenceTxt";
            this.ExpenceTxt.Size = new System.Drawing.Size(316, 35);
            this.ExpenceTxt.TabIndex = 7;
            this.ExpenceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExpenceTxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(398, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "المصروفات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(368, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "اسم الموظف";
            // 
            // ExpenceCB
            // 
            this.ExpenceCB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenceCB.FormattingEnabled = true;
            this.ExpenceCB.Location = new System.Drawing.Point(21, 75);
            this.ExpenceCB.Name = "ExpenceCB";
            this.ExpenceCB.Size = new System.Drawing.Size(316, 38);
            this.ExpenceCB.TabIndex = 0;
            // 
            // AddAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 818);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddAttendance";
            this.Text = "حضور الموظفين";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LeaveBtn;
        private System.Windows.Forms.ComboBox LeaveCB;
        private System.Windows.Forms.Button AttendBtn;
        private System.Windows.Forms.ComboBox AttendCB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ExpenceCB;
        private System.Windows.Forms.TextBox ExpenceTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExpenceBtn;
    }
}