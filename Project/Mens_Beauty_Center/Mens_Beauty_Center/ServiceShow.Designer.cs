
using System.Drawing;
using System.Windows.Forms;

namespace Mens_Beauty_Center
{
    partial class ServiceShow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewService = new System.Windows.Forms.DataGridView();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxServices = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Edite_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "الخدمات المتوفرة";
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.AllowUserToAddRows = false;
            this.dataGridViewService.AllowUserToDeleteRows = false;
            this.dataGridViewService.AllowUserToResizeColumns = false;
            this.dataGridViewService.AllowUserToResizeRows = false;
            this.dataGridViewService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPrice,
            this.ColumnService,
            this.ColumnNumber});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewService.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewService.Location = new System.Drawing.Point(386, 76);
            this.dataGridViewService.MultiSelect = false;
            this.dataGridViewService.Name = "dataGridViewService";
            this.dataGridViewService.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewService.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewService.RowHeadersVisible = false;
            this.dataGridViewService.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewService.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewService.RowTemplate.Height = 24;
            this.dataGridViewService.RowTemplate.ReadOnly = true;
            this.dataGridViewService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewService.Size = new System.Drawing.Size(483, 239);
            this.dataGridViewService.TabIndex = 1;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "سعر الخدمة";
            this.ColumnPrice.MinimumWidth = 6;
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            // 
            // ColumnService
            // 
            this.ColumnService.HeaderText = "الخدمة";
            this.ColumnService.MinimumWidth = 6;
            this.ColumnService.Name = "ColumnService";
            this.ColumnService.ReadOnly = true;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.HeaderText = "رقم الخدمة";
            this.ColumnNumber.MinimumWidth = 6;
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "الخدمة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "سعر الخدمة";
            // 
            // textBoxServices
            // 
            this.textBoxServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxServices.Location = new System.Drawing.Point(6, 33);
            this.textBoxServices.Name = "textBoxServices";
            this.textBoxServices.Size = new System.Drawing.Size(206, 36);
            this.textBoxServices.TabIndex = 3;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(6, 82);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(206, 36);
            this.textBoxPrice.TabIndex = 3;
            // 
            // Add_btn
            // 
            this.Add_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.Location = new System.Drawing.Point(194, 144);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(151, 43);
            this.Add_btn.TabIndex = 4;
            this.Add_btn.Text = "إضافة";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxServices);
            this.groupBox1.Controls.Add(this.Edite_btn);
            this.groupBox1.Controls.Add(this.Add_btn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxPrice);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 215);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Edite_btn
            // 
            this.Edite_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Edite_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edite_btn.Location = new System.Drawing.Point(6, 144);
            this.Edite_btn.Name = "Edite_btn";
            this.Edite_btn.Size = new System.Drawing.Size(152, 43);
            this.Edite_btn.TabIndex = 4;
            this.Edite_btn.Text = "تعديل";
            this.Edite_btn.UseVisualStyleBackColor = true;
            this.Edite_btn.Click += new System.EventHandler(this.Edite_btn_Click_1);
            // 
            // ServiceShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 335);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewService);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ServiceShow";
            this.Text = "ServiceShow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServiceShow_FormClosing_1);
            this.Load += new System.EventHandler(this.ServiceShow_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxServices;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private DataGridViewTextBoxColumn ColumnPrice;
        private DataGridViewTextBoxColumn ColumnService;
        private DataGridViewTextBoxColumn ColumnNumber;
        private Button Edite_btn;
    }
}