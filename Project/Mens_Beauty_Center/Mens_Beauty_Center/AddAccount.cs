using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mens_Beauty_Center
{
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }
        private void AddAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من غلق هذه الصفحه؟", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #region load Data
        private void LoadData()
        {
            try
            {
                using (var context = new Mens_Beauty_Center_DBEntities()) // Replace with your actual DbContext
                {
                    var employees = context.Employees
                                           .Where(emp => emp.Type == true) // Filter where Type is true
                                           .Select(emp => new
                                           {
                                               EmployeeID = emp.NationalID, // Assuming NationalID is the unique ID
                                               EmployeeName = emp.FirstName + " " + emp.LastName
                                           })
                                           .ToList();

                    comboBox1.DataSource = employees;
                    comboBox1.DisplayMember = "EmployeeName"; // Display full name
                    comboBox1.ValueMember = "EmployeeID";     // Store NationalID
                    comboBox1.SelectedIndex = -1; // Optionally, set it to no selection
                }
                // show data in grid view  
                using (var context = new Mens_Beauty_Center_DBEntities()) // Replace with your actual DbContext
                {
                    var accounts = (from acc in context.Accounts
                                    join emp in context.Employees
                                    on acc.EmployeeID equals emp.NationalID
                                    where acc.EmployeeID != null
                                    select new
                                    {
                                        acc.UserName,
                                        EmployeeName = emp.FirstName + " " + emp.LastName // Assuming 'Name' is the property in the Employee table
                                    }).ToList();

                    dataGridView1.Rows.Clear();
                    foreach (var account in accounts)
                    {
                        dataGridView1.Rows.Add(account.UserName, account.EmployeeName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading employees: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void AddAccount_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion

        #region Add Account
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = NameManagerTxt.Text;
            string userPassword = PasswordManagerTxt.Text;
            var selectedEmployeeId = comboBox1.SelectedValue?.ToString(); 

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userPassword) || string.IsNullOrEmpty(selectedEmployeeId))
            {
                MessageBox.Show("قم باملاء البيانات .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var context = new Mens_Beauty_Center_DBEntities()) 
                {
                    var existingAccount = context.Accounts
                                        .FirstOrDefault(emp => emp.EmployeeID == selectedEmployeeId);

                    if (existingAccount != null)
                    {
                        MessageBox.Show("هذا الاكونت موجود بالفعل لهذا المدير", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        NameManagerTxt.Clear();
                        PasswordManagerTxt.Clear();
                        return;
                    }

                    // If the account does not exist, proceed to add it
                    int result = context.SP_CreateManagerAccount(userName, userPassword, selectedEmployeeId);

                    if (result > 0)
                    {
                        MessageBox.Show("تمت اضافه الاكونت بنجاح.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NameManagerTxt.Clear();
                        PasswordManagerTxt.Clear();
                        LoadData();

                    }
                    else
                    {
                        MessageBox.Show("Failed to add manager account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region DeleteAccount
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("يرجى تحديد صف لحذفه.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string userName = selectedRow.Cells["UserName"].Value.ToString();


            DialogResult result = MessageBox.Show("هل أنت متأكد من حذف هذا الحساب؟", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                using (var context = new Mens_Beauty_Center_DBEntities())
                {
                    int affectedRows = context.SP_DeleteManagerAccount(userName);

                    if (affectedRows > 0)
                    {
                        dataGridView1.Rows.Remove(selectedRow);
                        MessageBox.Show("تم حذف الحساب بنجاح.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("فشل حذف الحساب.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
