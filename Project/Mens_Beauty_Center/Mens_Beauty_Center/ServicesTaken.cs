
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mens_Beauty_Center
{
    public partial class ServicesTaken : Form
    {
        DateTime DateFrom, DateTo, testDateTime;
        Mens_Beauty_Center_DBEntities context = new Mens_Beauty_Center_DBEntities();
        public ServicesTaken()
        {
            InitializeComponent();
            fillTheComboBox();
        }
        private void ServicesTaken_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewForTheWorkOfTheEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxTheEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkBoxPackage_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxService_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ServicesTaken_Load_1(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            DateFrom = dateTimePickerFrom.Value;
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            DateTo = dateTimePickerTo.Value;

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            if (DateFrom == testDateTime) { DateFrom = DateTime.Now; }
            if (DateTo == testDateTime) { DateTo = DateTime.Now; }
            if (DateFrom > DateTo)
            {
                MessageBox.Show("رجاءا كتابة التاريخ من إلي بشكل صحيح");
                return;
            }
            var selectedEmployee = comboBoxTheEmployees.SelectedValue;
            if (selectedEmployee == "0")
            {
                if (checkBoxService.Checked) fillServices();
                if (checkBoxPackage.Checked) fillPackages();
                if (checkBoxService.Checked && checkBoxPackage.Checked) {
                    fillServices();
                    var employeesPackageCustomer = context.SP_GetCustomerPackage(DateFrom, DateTo);
                    foreach (var service in employeesPackageCustomer)
                    {
                        dataGridViewForTheWorkOfTheEmployees.Rows.Add(service.EmployeeName, service.CustomerName, service.PackageName, service.PackagePrice);
                    }
                }
            }
            else
            {
                if (checkBoxService.Checked) fillServicesOfEmployee();
                if (checkBoxPackage.Checked) fillPackagesOfEmployee();
                if (checkBoxService.Checked && checkBoxPackage.Checked)
                {
                    fillServicesOfEmployee();
                    var employeesPackageCustomer = context.SP_GetCustomerPackageEmployee(DateFrom, DateTo, comboBoxTheEmployees.SelectedValue.ToString());
                    foreach (var service in employeesPackageCustomer)
                    {
                        dataGridViewForTheWorkOfTheEmployees.Rows.Add(service.EmployeeName, service.CustomerName, service.PackageName, service.PackagePrice);
                    }
                }
            }

        }

        private void fillTheComboBox()
        {
            var items = new List<object>() { new { ID = "0", Name = "All The Employees" } };

            var allEmployees = context.Employees.ToList();
            foreach (var item in allEmployees) {
                items.Add(new { ID = item.NationalID, Name = item.FirstName + ' ' + item.LastName });
            }

            comboBoxTheEmployees.DataSource = items;
            comboBoxTheEmployees.DisplayMember = "Name";
            comboBoxTheEmployees.ValueMember = "ID";
        }

        private void fillServices()
        {
            var employeesServeCustomer = context.PS_GetCustomerService(DateFrom, DateTo);
            dataGridViewForTheWorkOfTheEmployees.Rows.Clear();
            foreach (var service in employeesServeCustomer)
            {
                dataGridViewForTheWorkOfTheEmployees.Rows.Add(service.EmployeeName, service.CustomerName, service.ServiceName, service.ServicePrice);
            }
        }
        private void fillPackages()
        {
            var employeesPackageCustomer = context.SP_GetCustomerPackage(DateFrom, DateTo);
            dataGridViewForTheWorkOfTheEmployees.Rows.Clear();
            foreach (var service in employeesPackageCustomer)
            {
                dataGridViewForTheWorkOfTheEmployees.Rows.Add(service.EmployeeName, service.CustomerName, service.PackageName, service.PackagePrice);
            }
        }

        private void fillServicesOfEmployee()
        {
            var employeesServeCustomer = context.PS_GetCustomerServiceEmployee(DateFrom, DateTo, comboBoxTheEmployees.SelectedValue.ToString());
            dataGridViewForTheWorkOfTheEmployees.Rows.Clear();
            foreach (var service in employeesServeCustomer)
            {
                dataGridViewForTheWorkOfTheEmployees.Rows.Add(service.EmployeeName, service.CustomerName, service.ServiceName, service.ServicePrice);
            }
        }
        private void fillPackagesOfEmployee()
        {
            var employeesPackageCustomer = context.SP_GetCustomerPackageEmployee(DateFrom, DateTo, comboBoxTheEmployees.SelectedValue.ToString());
            dataGridViewForTheWorkOfTheEmployees.Rows.Clear();
            foreach (var service in employeesPackageCustomer)
            {
                dataGridViewForTheWorkOfTheEmployees.Rows.Add(service.EmployeeName, service.CustomerName, service.PackageName, service.PackagePrice);
            }
        }
    }
}
