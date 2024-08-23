using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mens_Beauty_Center
{
    public partial class AddCoustomer_frm : Form
    {
        Mens_Beauty_Center_DBEntities my_context = new Mens_Beauty_Center_DBEntities();
        public AddCoustomer_frm()
        {
            InitializeComponent();
        }

        private void fillDGV()
        {

            try
            {
                var customerData = my_context.Customers
                                             .Select(c => new
                                             {
                                                 c.Name,
                                                 c.PhoneNumber
                                             })
                                             .ToList();

                dataGridView1.DataSource = customerData;

                // تسمية الأعمدة
                dataGridView1.Columns["Name"].HeaderText = "الاسم";
                dataGridView1.Columns["PhoneNumber"].HeaderText = "رقم الهاتف";

                //تغيير حجم الأعمدة ليناسب حجم DGV
                dataGridView1.Columns["Name"].Width = 180;
                dataGridView1.Columns["PhoneNumber"].Width = 180;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string phone = txt_phone.Text;
            if (phone.StartsWith("011") || phone.StartsWith("012") || phone.StartsWith("010") || phone.StartsWith("015"))
            {
                my_context.SP_AddCustomer(name, phone);
                my_context.SaveChanges();

                MessageBox.Show("تم إضافة العميل بنجاح!", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);

                fillDGV();

                txt_name.Clear();
                txt_phone.Clear();
                btn_save.Enabled = false;
            }
            else
            {
                MessageBox.Show("رقم الهاتف يجب أن يبدأ بـ 011 أو 012 أو 010 أو 015", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddCoustomer_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من اغلاق الصفحة", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void AddCoustomer_frm_Load(object sender, EventArgs e)
        {
            fillDGV();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // استخراج البيانات من الصف المحدد
                string name = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
                string phone = dataGridView1.CurrentRow.Cells["PhoneNumber"].Value.ToString();
               
                // تعبئة الحقول بناءً على القيم المستخرجة

                txt_name.Text = name;
                txt_phone.Text = phone;
                btn_save.Enabled = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txt_name.Text;
                string phone = txt_phone.Text;

                if (phone.StartsWith("011") || phone.StartsWith("012") || phone.StartsWith("010") || phone.StartsWith("015"))
                {
                    int selectedIndex = dataGridView1.CurrentRow.Index;
                    if (selectedIndex != -1)
                    {
                        string selectedPhone = dataGridView1.Rows[selectedIndex].Cells["PhoneNumber"].Value.ToString();

                        var customer = my_context.Customers.FirstOrDefault(c => c.PhoneNumber == selectedPhone);

                        if (customer != null)
                        {
                            customer.Name = name;
                            customer.PhoneNumber = phone;

                            my_context.SaveChanges();

                            MessageBox.Show("تم تحديث بيانات العميل بنجاح!", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            fillDGV();

                            txt_name.Clear();
                            txt_phone.Clear();
                            btn_save.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("لم يتم العثور على العميل في قاعدة البيانات.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("رقم الهاتف يجب أن يبدأ بـ 011 أو 012 أو 010 أو 015", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
