using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mens_Beauty_Center
{
    public partial class PackageForm : Form
    {
        public PackageForm()
        {
            InitializeComponent();
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متاكد من غلق هذه الصفحه؟", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        Mens_Beauty_Center_DBEntities context = new Mens_Beauty_Center_DBEntities();

        #region load data
        private void LoadPackages()
        {
            try
            {
                var packages = context.Packages.Select(p => new
                {
                    p.ID,
                    p.Name,
                    p.Description,
                    p.TotalAmount
                }).ToList();

                dataGridView1.Rows.Clear();
                foreach (var package in packages)
                {
                    dataGridView1.Rows.Add(package.ID, package.Name, package.Description, package.TotalAmount);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the packages: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PackageForm_Load(object sender, EventArgs e)
        {
            LoadPackages();
        }
        #endregion

        #region add Package
        private void AddBtn_Click(object sender, EventArgs e)
        {
            string packageName = PackageNameTxt.Text;
            string description = DescriptionTxt.Text;
            decimal price;
            if (decimal.TryParse(PriceTxt.Text, out price))
            {
                try
                {
                    var result = context.SP_AddPackage(packageName, description, price);
                    if (result > 0)
                    {
                        LoadPackages(); // Reload the DataGridView

                        PackageNameTxt.Clear();
                        DescriptionTxt.Clear();
                        PriceTxt.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add the package. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadPackages2()
        {
            dataGridView1.Rows.Clear();
            var packages = context.Packages.ToList(); // Assuming 'Packages' is the table name

            foreach (var package in packages)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = package.Name;
                row.Cells[1].Value = package.Description;
                row.Cells[2].Value = package.TotalAmount.ToString("C2");
                dataGridView1.Rows.Add(row);
            }
        }

        #endregion

        #region delete Package
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult confirmResult = MessageBox.Show("هل انت متاكد من مسح هذه البكج؟",
                                                             "Confirm Delete",
                                                             MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    int packageId = Convert.ToInt32(selectedRow.Cells["Package_ID"].Value);

                    using (var context = new Mens_Beauty_Center_DBEntities())
                    {
                        var result = context.SP_DeletePackage(packageId);

                        if (result != null)
                        {
                            dataGridView1.Rows.Remove(selectedRow);

                            MessageBox.Show("تم المسح بنجاح");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the package.");
                        }
                    }
                }
                // If the user canceled the deletion
                else
                {
                    MessageBox.Show("Deletion canceled.");
                }
            }
            else
            {
                MessageBox.Show("Please select a package to delete.");
            }
        }
        #endregion

        #region Update Package
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int packageId = Convert.ToInt32(selectedRow.Cells["Package_ID"].Value);
                string currentName = selectedRow.Cells["Package_Name"].Value.ToString();
                string currentDescription = selectedRow.Cells["PackageDescription"].Value.ToString();
                decimal currentTotalAmount = Convert.ToDecimal(selectedRow.Cells["PackagePrice"].Value);
                PackageNameTxt.Text = currentName;
                DescriptionTxt.Text = currentDescription;
                PriceTxt.Text = currentTotalAmount.ToString("F2");
                DialogResult confirmResult = MessageBox.Show("هل انت متاكد من تحديث هذه البكج؟",
                                                             "Confirm Update",
                                                             MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    string newName = PackageNameTxt.Text;
                    string newDescription = DescriptionTxt.Text;
                    decimal newTotalAmount;

                    if (decimal.TryParse(PriceTxt.Text, out newTotalAmount))
                    {
                        try
                        {
                            using (var context = new Mens_Beauty_Center_DBEntities())
                            {
                                var result = context.SP_UpdatePackage(packageId, newName, newDescription, newTotalAmount);

                                if (result != null && result.Any())
                                {
                                    selectedRow.Cells["Package_Name"].Value = newName;
                                    selectedRow.Cells["PackageDescription"].Value = newDescription;
                                    selectedRow.Cells["PackagePrice"].Value = newTotalAmount.ToString("C2");

                                    MessageBox.Show("تم التحديث بنجاح");

                                    PackageNameTxt.Clear();
                                    DescriptionTxt.Clear();
                                    PriceTxt.Clear();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update the package.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid price.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a package to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

    }
}
