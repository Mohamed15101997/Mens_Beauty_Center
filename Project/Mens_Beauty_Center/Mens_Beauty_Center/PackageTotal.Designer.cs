namespace Mens_Beauty_Center
{
    partial class PackageTotal
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
            this.PackageCompleteDGView = new System.Windows.Forms.DataGridView();
            this.lblPackageTaken = new System.Windows.Forms.Label();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.ShowAllDataBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PackageCompleteDGView)).BeginInit();
            this.SuspendLayout();
            // 
            // PackageCompleteDGView
            // 
            this.PackageCompleteDGView.AllowUserToAddRows = false;
            this.PackageCompleteDGView.AllowUserToResizeColumns = false;
            this.PackageCompleteDGView.AllowUserToResizeRows = false;
            this.PackageCompleteDGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PackageCompleteDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PackageCompleteDGView.Location = new System.Drawing.Point(13, 195);
            this.PackageCompleteDGView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PackageCompleteDGView.Name = "PackageCompleteDGView";
            this.PackageCompleteDGView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PackageCompleteDGView.RowHeadersWidth = 62;
            this.PackageCompleteDGView.Size = new System.Drawing.Size(1192, 479);
            this.PackageCompleteDGView.TabIndex = 4;
            // 
            // lblPackageTaken
            // 
            this.lblPackageTaken.AutoSize = true;
            this.lblPackageTaken.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageTaken.Location = new System.Drawing.Point(500, 7);
            this.lblPackageTaken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPackageTaken.Name = "lblPackageTaken";
            this.lblPackageTaken.Size = new System.Drawing.Size(225, 48);
            this.lblPackageTaken.TabIndex = 3;
            this.lblPackageTaken.Text = "البكج المكتملة";
            // 
            // FromDate
            // 
            this.FromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDate.Location = new System.Drawing.Point(825, 71);
            this.FromDate.Margin = new System.Windows.Forms.Padding(4);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(271, 32);
            this.FromDate.TabIndex = 6;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(289, 67);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(130, 46);
            this.SearchBtn.TabIndex = 7;
            this.SearchBtn.Text = "بحث";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1104, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "من";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(752, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "الي";
            // 
            // ToDate
            // 
            this.ToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDate.Location = new System.Drawing.Point(452, 73);
            this.ToDate.Margin = new System.Windows.Forms.Padding(4);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(282, 32);
            this.ToDate.TabIndex = 11;
            // 
            // ShowAllDataBtn
            // 
            this.ShowAllDataBtn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAllDataBtn.Location = new System.Drawing.Point(858, 116);
            this.ShowAllDataBtn.Name = "ShowAllDataBtn";
            this.ShowAllDataBtn.Size = new System.Drawing.Size(305, 71);
            this.ShowAllDataBtn.TabIndex = 12;
            this.ShowAllDataBtn.Text = "عرض جميع البيانات";
            this.ShowAllDataBtn.UseVisualStyleBackColor = true;
            this.ShowAllDataBtn.Click += new System.EventHandler(this.ShowAllDataBtn_Click);
            // 
            // PackageTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1218, 688);
            this.Controls.Add(this.ShowAllDataBtn);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.PackageCompleteDGView);
            this.Controls.Add(this.lblPackageTaken);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PackageTotal";
            this.Text = "بيانات البكج المكتملة";
            ((System.ComponentModel.ISupportInitialize)(this.PackageCompleteDGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PackageCompleteDGView;
        private System.Windows.Forms.Label lblPackageTaken;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.Button ShowAllDataBtn;
    }
}