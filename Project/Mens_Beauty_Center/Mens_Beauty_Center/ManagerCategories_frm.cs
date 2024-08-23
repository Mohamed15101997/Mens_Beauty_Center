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
    public partial class ManagerCategories_frm : Form
    {
        Mens_Beauty_Center_DBEntities my_context = new Mens_Beauty_Center_DBEntities();

        public ManagerCategories_frm()
        {
            InitializeComponent();
        }

        private void lbl_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من تسجيل الخروج", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                return;
            }
            else if (result == DialogResult.Yes)
            {
                //my_context.SP_UpdateLeavingTime(/*AttendanceID */);/* من فارس على حسب ما يعرفه*/
                Application.Exit(); 
            }
        }

        private void btn_Logout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من تسجيل الخروج", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.No)
            {
                return;
            }
            else if (result == DialogResult.Yes)
            {
                //my_context.SP_UpdateLeavingTime(/*AttendanceID */);/* من فارس على حسب ما يعرفه*/

                // ضع هنا كود تسجيل الخروج.
                Application.Exit(); // أو أية عملية تريد تنفيذها عند تسجيل الخروج.
            }
        }

        private void PB_AddCustomer_Click(object sender, EventArgs e)
        {
            AddCoustomer_frm addCustomer = new AddCoustomer_frm();
            addCustomer.Show();
        }

        private void lbl_AddCustomer_Click(object sender, EventArgs e)
        {
            AddCoustomer_frm addCustomer = new AddCoustomer_frm();
            addCustomer.Show();
        }
    }
}
