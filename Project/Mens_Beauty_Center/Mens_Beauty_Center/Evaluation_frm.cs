using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mens_Beauty_Center
{
    public partial class Evaluation_frm : Form
    {
        Mens_Beauty_Center_DBEntities my_context = new Mens_Beauty_Center_DBEntities();
        Evaluation ev;

        public Evaluation_frm()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من اغلاق الصفحة", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void fillDGV()
        {
            // استعلام لربط جدول Evaluation مع Employee واسترجاع البيانات المطلوبة
            var q2 = from evv in my_context.Evaluations
                     join empp in my_context.Employees on evv.NationalID equals empp.NationalID
                     select new
                     {
                         ID = evv.NationalID,
                         Month = evv.Month,
                         TotalAmountOfMonth = evv.TotalAmountOfMonth,
                         ProfitPercentage = evv.ProfitPercentage,
                         Bonus = evv.Bonus,
                         FirstName = empp.FirstName
                     };

            // تعيين البيانات إلى DataGridView
            dataGridView1.DataSource = q2.ToList();

            // تخصيص أسماء الأعمدة المعروضة في DataGridView
            dataGridView1.Columns["ID"].HeaderText = "رقم العامل";
            dataGridView1.Columns["Month"].HeaderText = "الشهر";
            dataGridView1.Columns["TotalAmountOfMonth"].HeaderText = "إجمالي الشهر";
            dataGridView1.Columns["ProfitPercentage"].HeaderText = "النسبة";
            dataGridView1.Columns["Bonus"].HeaderText = "الإضافي";
            dataGridView1.Columns["FirstName"].HeaderText = "اسم العامل";
        }

        private void enable_txts()
        {
            txt_percent.Enabled = true;
        }

        private void clear_txts()
        {
            txt_percent.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(txt_percent.Text) > 10)
            {
                MessageBox.Show("النسبة المدخلة لا يمكن أن تكون أكثر من 10%", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM";

            // استخراج رقم الشهر فقط
            int selectedMonthNumber = dateTimePicker1.Value.Month;

            // تحويل رقم الشهر إلى نص بصيغة مكونة من خانتين
            string selectedMonthString = selectedMonthNumber.ToString("D2");

            my_context.SP_InsertEmployeeEvaluationWithPackages(selectedMonthString, decimal.Parse(txt_percent.Text));
            
            my_context.SaveChanges();

            MessageBox.Show("تم إضافة التقييم بنجاح!", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // تفريغ الحقول بعد الإضافة
            clear_txts();
            // تحديث بيانات DataGridView
            fillDGV();
        }

        private void btn_add_MouseEnter(object sender, EventArgs e)
        {
            btn_add.BackColor = Color.MidnightBlue;
        }

        private void btn_add_MouseLeave(object sender, EventArgs e)
        {
            btn_add.BackColor = Color.SteelBlue;
        }

        private void Evaluation_frm_Load(object sender, EventArgs e)
        {
            fillDGV();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // التحقق من أن هناك صف محدد
            if (dataGridView1.CurrentRow != null)
            {
                // استخراج البيانات من الصف المحدد
                string month = dataGridView1.CurrentRow.Cells["Month"].Value.ToString();
                string totalAmount = dataGridView1.CurrentRow.Cells["TotalAmountOfMonth"].Value.ToString();
                string profitPercentage = dataGridView1.CurrentRow.Cells["ProfitPercentage"].Value.ToString();
                string nationalID = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

                // تعبئة الحقول بناءً على القيم المستخرجة
                
                txt_percent.Text = profitPercentage;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (decimal.Parse(txt_percent.Text) > 10)
                {
                    MessageBox.Show("النسبة المدخلة لا يمكن أن تكون أكثر من 10%", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // الحصول على NationalID من الصف المحدد
                string nationalID = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                string month = dataGridView1.CurrentRow.Cells["Month"].Value.ToString();

                // البحث عن العنصر المحدد في قاعدة البيانات
                var evaluation = my_context.Evaluations.FirstOrDefault(ev => ev.NationalID == nationalID && ev.Month == month);

                if (evaluation != null)
                {
                    // تحديث القيم بالبيانات الجديدة من الحقول النصية
                    evaluation.ProfitPercentage = decimal.Parse(txt_percent.Text);
                    // حفظ التغييرات في قاعدة البيانات
                    my_context.SaveChanges();

                    // تحديث DataGridView بعد حفظ التغييرات
                    fillDGV();

                    MessageBox.Show("تم حفظ التعديلات بنجاح!", "تم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_save.Enabled = false;
                }
                else
                {
                    MessageBox.Show("لا يوجد عنصر محدد أو العنصر المحدد غير موجود!", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            enable_txts();
            btn_save.Enabled = true;
        }

        private void btn_enable_Click(object sender, EventArgs e)
        {
            enable_txts();
            clear_txts();
            btn_add.Enabled = true;
        }
    }
}
