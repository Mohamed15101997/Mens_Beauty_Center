using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mens_Beauty_Center
{
    public partial class AddAttendance : Form
    {
        Mens_Beauty_Center_DBEntities context = new Mens_Beauty_Center_DBEntities();
        DateTime currentDate = DateTime.Today;

        public AddAttendance()
        {        
            InitializeComponent();
            FillLeavingComboBox();
            FillExpenceComboBox();
            FillArrivingComboBox();

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من اغلاق الصفحة", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void AttendBtn_Click(object sender, EventArgs e)
        {
            var query = context.SP_InsertArrivalTime(AttendCB.SelectedValue.ToString());
            context.SaveChanges();
            MessageBox.Show("تمت اضافة حضور الموظف بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            FillLeavingComboBox();
            FillExpenceComboBox();
            FillArrivingComboBox();

        }

        private void LeaveBtn_Click(object sender, EventArgs e)
        {
            string NationID = LeaveCB.SelectedValue.ToString();
            var AttendanceID = context.Attendances.Where(attend => (attend.NationalID == NationID) && (DbFunctions.TruncateTime(attend.ArrivalTime) == currentDate)).Select(attend => attend.AttendanceID).FirstOrDefault();
            var query = context.SP_UpdateLeavingTime(AttendanceID);
            context.SaveChanges();
            MessageBox.Show("تمت اضافة مغادرة الموظف بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            FillLeavingComboBox();
            FillExpenceComboBox();
            FillArrivingComboBox();
        }
        private void FillLeavingComboBox() 
        {
            var leaveEmpID = context.Attendances.Where(attend => DbFunctions.TruncateTime(attend.ArrivalTime) == currentDate && attend.DepartureTime == null).Select(att => att);
            var query = context.Employees.Where(Emp => Emp.Type == false).Join(leaveEmpID,emp => emp.NationalID,att => att.NationalID,(emp,att)=> new { Name = emp.FirstName + " " + emp.LastName , ID = att.NationalID});
            LeaveCB.DataSource = query.ToList();
            LeaveCB.DisplayMember = "Name";
            LeaveCB.ValueMember = "ID";
        }
        private void FillExpenceComboBox()
        {
            var leaveEmpID = context.Attendances.Where(attend => DbFunctions.TruncateTime(attend.ArrivalTime) == currentDate && attend.DepartureTime == null).Select(att => att);
            var query = context.Employees.Where(Emp => Emp.Type == false).Join(leaveEmpID, emp => emp.NationalID, att => att.NationalID, (emp, att) => new { Name = emp.FirstName + " " + emp.LastName, ID = att.NationalID });
            ExpenceCB.DataSource = query.ToList();
            ExpenceCB.DisplayMember = "Name";
            ExpenceCB.ValueMember = "ID";
        }
        public void FillArrivingComboBox() 
        {
            var leaveEmpID = context.Attendances.Where(attend => DbFunctions.TruncateTime(attend.ArrivalTime) == currentDate).Select(att => att.NationalID);
            var EmpAttendIDs = context.Employees.Where(emp => emp.Type == false).Select(emp=>emp.NationalID).Except(leaveEmpID);
            var EmpAttendNames = context.Employees.Join(EmpAttendIDs, emp => emp.NationalID, e => e, (emp, e) => new { Name = emp.FirstName + " " + emp.LastName, ID = e }).ToList();
            AttendCB.DataSource = EmpAttendNames;
            AttendCB.DisplayMember = "Name";
            AttendCB.ValueMember = "ID";
        }

        private void ExpenceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ExpenceBtn_Click(object sender, EventArgs e)
        {
            string NationID = LeaveCB.SelectedValue.ToString();
            int attendanceID = context.Attendances.Where(attend => (attend.NationalID == NationID) && (DbFunctions.TruncateTime(attend.ArrivalTime) == currentDate)).Select(attend => attend.AttendanceID).FirstOrDefault();
            decimal fixedSalary = context.Employees.Where(emp => emp.NationalID == NationID).Select(emp => emp.FixedSalary).FirstOrDefault();
            var currentExpenceMoney = context.Attendances.Where(attend => attend.AttendanceID == attendanceID).Select(attend => attend.ExpenseMoney).FirstOrDefault();
            var remainedMoney = fixedSalary - currentExpenceMoney;
            var query = context.Attendances.SingleOrDefault(attend => attend.AttendanceID == attendanceID);
            if (ExpenceTxt.Text == "")
                MessageBox.Show("لا يمكن ترك الحقل فارغ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (remainedMoney >= decimal.Parse(ExpenceTxt.Text)) 
            {
                query.ExpenseMoney += decimal.Parse(ExpenceTxt.Text);
                context.SaveChanges();
                var remainedMoneyUpdate = remainedMoney - decimal.Parse(ExpenceTxt.Text);
                MessageBox.Show($"تمت اضافة سحب المصروفات وباقي لديك لسحبه {remainedMoneyUpdate} ", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ExpenceTxt.Text = "";
            }
            else 
                MessageBox.Show("لا يمكن سحب اكتر من اليومية الخاصة بك ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
