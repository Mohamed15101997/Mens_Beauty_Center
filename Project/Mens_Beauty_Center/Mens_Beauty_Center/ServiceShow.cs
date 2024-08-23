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
    public partial class ServiceShow : Form
    {
        Mens_Beauty_Center_DBEntities context = new Mens_Beauty_Center_DBEntities();
        
        public ServiceShow()
        {
            InitializeComponent();
            fillTheDataGridView();
            dataGridViewService.Click += dataGridViewService_Click;
        }
        
        private void ServiceShow_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_btn_Click_1(object sender, EventArgs e)
        {
            string _servicename = textBoxServices.Text.ToString();
            if (_servicename.Length == 0)
            {
                MessageBox.Show("رجاءا اكتب اسم الخدمة اولاً");
                return;
            }
            if (!(int.TryParse(textBoxPrice.Text.ToString(), out int _price)))
            {
                MessageBox.Show("رجاءا اكتب سعر الخدمة علي هيئة رقم صحيح");
                return;
            }
            DialogResult result = MessageBox.Show(@"هل انت متأكد انك تريد إضافة هذه الخدمة؟", "تأكيد إضافة", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                context.SP_AddService(_servicename, _price);
                context.SaveChanges();
                fillTheDataGridView();
                textBoxPrice.Text = string.Empty;
                textBoxServices.Text = string.Empty;
            }
        }

        private void dataGridViewService_Click(object sender, EventArgs e)
        {
            int postion = dataGridViewService.CurrentRow.Index;
            textBoxServices.Text = dataGridViewService.Rows[postion].Cells[1].Value.ToString();
            textBoxPrice.Text = dataGridViewService.Rows[postion].Cells[0].Value.ToString();

        }

        private void Edite_btn_Click_1(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewService.SelectedRows[0];

            var id = (int)selectedRow.Cells[2].Value;
            var findId = context.Services.FirstOrDefault(x => x.ID == id);
            if (findId is null)
            {
                MessageBox.Show("رجاءا ادخل خدمة موجودة بالفعل");
                return;
            }
            string _servicename = textBoxServices.Text.ToString();
            if (_servicename.Length == 0)
            {
                MessageBox.Show("رجاءا اكتب اسم الخدمة اولاً");
                return;
            }
            if (!(int.TryParse(textBoxPrice.Text.ToString(), out int _price)))
            {
                MessageBox.Show("رجاءا اكتب سعر الخدمة علي هيئة رقم صحيح");
                return;
            }


            DialogResult result = MessageBox.Show($"هل انت متأكد انك تريد التعديل علي الخدمة رقم {id} ؟", "تأكيد تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                context.SP_UpdateService(id, _servicename, _price);
                //context.SaveChanges();
                fillTheDataGridView();
                textBoxPrice.Text = string.Empty;
                textBoxServices.Text = string.Empty;
            }
        }

        private void ServiceShow_Load_1(object sender, EventArgs e)
        {
            
        }
        private void ServiceShow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من اغلاق الصفحة", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void fillTheDataGridView()
        {
            var allServices = context.Services.ToList();
            dataGridViewService.Rows.Clear();
            foreach (var service in allServices) {
                dataGridViewService.Rows.Add(service.Price, service.ServiceName, service.ID);
            }
        }

        private void ServiceShow_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من اغلاق الصفحة", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}
