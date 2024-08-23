namespace Mens_Beauty_Center
{
    partial class ThePriceOfTheServicesToTheCustomer
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
            this.checkedListBoxForServices = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEmployees = new System.Windows.Forms.ComboBox();
            this.textBoxCustomerPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CalculateThePRiceForTheCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxForServices
            // 
            this.checkedListBoxForServices.CheckOnClick = true;
            this.checkedListBoxForServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxForServices.FormattingEnabled = true;
            this.checkedListBoxForServices.Location = new System.Drawing.Point(406, 94);
            this.checkedListBoxForServices.Name = "checkedListBoxForServices";
            this.checkedListBoxForServices.Size = new System.Drawing.Size(295, 254);
            this.checkedListBoxForServices.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "حساب العميل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "الموظف";
            // 
            // comboBoxEmployees
            // 
            this.comboBoxEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmployees.FormattingEnabled = true;
            this.comboBoxEmployees.Location = new System.Drawing.Point(37, 126);
            this.comboBoxEmployees.Name = "comboBoxEmployees";
            this.comboBoxEmployees.Size = new System.Drawing.Size(174, 33);
            this.comboBoxEmployees.TabIndex = 3;
            this.comboBoxEmployees.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxCustomerPhone
            // 
            this.textBoxCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerPhone.Location = new System.Drawing.Point(37, 185);
            this.textBoxCustomerPhone.Name = "textBoxCustomerPhone";
            this.textBoxCustomerPhone.Size = new System.Drawing.Size(174, 30);
            this.textBoxCustomerPhone.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "هاتف العميل";
            // 
            // CalculateThePRiceForTheCustomer
            // 
            this.CalculateThePRiceForTheCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateThePRiceForTheCustomer.Location = new System.Drawing.Point(37, 250);
            this.CalculateThePRiceForTheCustomer.Name = "CalculateThePRiceForTheCustomer";
            this.CalculateThePRiceForTheCustomer.Size = new System.Drawing.Size(313, 39);
            this.CalculateThePRiceForTheCustomer.TabIndex = 5;
            this.CalculateThePRiceForTheCustomer.Text = "حساب الخدمات";
            this.CalculateThePRiceForTheCustomer.UseVisualStyleBackColor = true;
            this.CalculateThePRiceForTheCustomer.Click += new System.EventHandler(this.CalculateThePRiceForTheCustomer_Click);
            // 
            // ThePriceOfTheServicesToTheCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 378);
            this.Controls.Add(this.CalculateThePRiceForTheCustomer);
            this.Controls.Add(this.textBoxCustomerPhone);
            this.Controls.Add(this.comboBoxEmployees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxForServices);
            this.MaximizeBox = false;
            this.Name = "ThePriceOfTheServicesToTheCustomer";
            this.Text = "حساب العميل";
            this.Load += new System.EventHandler(this.ThePriceOfTheServicesToTheCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxForServices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEmployees;
        private System.Windows.Forms.TextBox textBoxCustomerPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CalculateThePRiceForTheCustomer;
    }
}