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

namespace Mens_Beauty_Center
{
    public partial class LoginForm : Form
    {
     

            public static int AttendanceIDNow { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }
        #region ClosePage
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        #endregion

        private (bool isValid, string employeeID) ValidateUser(string username, string password)
        {
            using (var context = new Mens_Beauty_Center_DBEntities())
            {
                var account = context.Accounts
                    .Where(a => a.UserName == username && a.UserPassword == password)
                    .Select(a => new { a.EmployeeID })
                    .FirstOrDefault();

                if (account != null)
                {
                    return (true, account.EmployeeID);
                }
                else
                {
                    return (false, null);
                }
            }
        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = Password.Text;
            var (isValid, employeeID) = ValidateUser(username, password);

            if (isValid)
            {
                if (!string.IsNullOrEmpty(employeeID))
                {
                    #region Insert AttendceID
                    using (var context = new Mens_Beauty_Center_DBEntities())
                    {
                        context.SP_InsertArrivalTime(employeeID);
                        var currentDate = DateTime.Now.Date;
                        var NationalID = context.Employees.Where(emp => emp.NationalID == employeeID)
                                                          .Select(emp => emp.NationalID)
                                                          .FirstOrDefault();

                        AttendanceIDNow = context.Attendances
                            .Where(attend => (attend.NationalID == NationalID) &&
                                             (DbFunctions.TruncateTime(attend.ArrivalTime) == currentDate))
                            .Select(attend => attend.AttendanceID)
                            .FirstOrDefault();
                    }
                    #endregion
                    ManagerCategories_frm Managercategories = new ManagerCategories_frm();
                    Managercategories.FormClosed += (s, args) => this.Close(); 
                    MessageBox.Show("تم الدخول ككاشير بنجاح");
                    //MessageBox.Show($"{AttendanceIDNow}");
                    Managercategories.Show();
                    this.Hide();
                }
                else
                {
                    //MessageBox.Show("Owner");
                    Categories categories = new Categories();
                    categories.FormClosed += (s, args) => this.Close(); // Close Login form when Categories is closed
                    MessageBox.Show("تم الدخول كمالك بنجاح");
                    categories.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

    }
}
