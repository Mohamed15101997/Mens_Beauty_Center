using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mens_Beauty_Center
{
    public partial class ThePriceOfTheServicesToTheCustomer : Form
    {
        Dictionary<int, Tuple<int, int>> dicforservices = new Dictionary<int, Tuple<int, int>>();
        Mens_Beauty_Center_DBEntities context = new Mens_Beauty_Center_DBEntities();
        public ThePriceOfTheServicesToTheCustomer()
        {
            InitializeComponent();

            // the services in the checck list box
            fillTheServices();
            // *******************************************************************************************

            // the comboBox of the employee
            var items = new List<object>();
            // LINQ query to get the names of employees who recorded attendance today
            var employeesAttendedToday = (from emp in context.Employees
                                         join att in context.Attendances
                                         on emp.NationalID equals att.NationalID
                                         where DbFunctions.TruncateTime(att.ArrivalTime) >= DbFunctions.TruncateTime(DateTime.Now) 
                                         //&& DbFunctions.TruncateTime(att.DepartureTime) <= DbFunctions.TruncateTime(DateTime.Now)
                                         select new { emp.NationalID, emp.FirstName, emp.LastName}).ToList();
            if (employeesAttendedToday.Count() > 0)
            {
                foreach (var item in employeesAttendedToday)
                {
                    items.Add(new { ID = item.NationalID, Name = item.FirstName + ' ' + item.LastName });
                    MessageBox.Show(item.NationalID.ToString() + " " + item.FirstName + ' ' + item.LastName);
                }
                comboBoxEmployees.DataSource = items;
                comboBoxEmployees.DisplayMember = "Name";
                comboBoxEmployees.ValueMember = "ID";
            }
            // *******************************************************************************************
        }

        private void ThePriceOfTheServicesToTheCustomer_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillTheServices()
        {
            dicforservices.Clear();
            var _Services = context.Services.ToList();
            for (int i = 0; i < _Services.Count; i++)
            {
                dicforservices[i] = Tuple.Create(_Services[i].ID, _Services[i].Price);
                checkedListBoxForServices.Items.Add($"{_Services[i].ServiceName} => {_Services[i].Price}");
            }
        }

        private void CalculateThePRiceForTheCustomer_Click(object sender, EventArgs e)
        {
            int thePriceOfTheTakenServices = 0;
            foreach (int checkedidx in checkedListBoxForServices.CheckedIndices)
                thePriceOfTheTakenServices += dicforservices[checkedidx].Item2;

            string pattern = @"^01[0125]\d{8}$";
            if (!(Regex.IsMatch(textBoxCustomerPhone.Text, pattern)))
            {
                MessageBox.Show("رقم الموبايل يجب ان يبدء ب 010 او 011 او 012 او 015", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var customerID = context.Customers.FirstOrDefault(x => x.PhoneNumber == textBoxCustomerPhone.Text);
                if (customerID is null)
                {
                    MessageBox.Show($"هذا العميل اول مره يزورنا و هذا هو حسابه: {thePriceOfTheTakenServices} ج", "حساب العميل");
                    return;
                }
            }
           


            DialogResult result = MessageBox.Show($"حساب العميل: {thePriceOfTheTakenServices} جنية \nاترغب في انت تحتفظ بتلك البيانات؟", "حساب العميل", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (int checkedidx in checkedListBoxForServices.CheckedIndices)
                {
                    string theNationalId = comboBoxEmployees.SelectedValue.ToString();
                    int customerID = context.Customers.Where(x => x.PhoneNumber == textBoxCustomerPhone.Text).Select(x => x.Code).ToList()[0];
                    int serviceId = dicforservices[checkedidx].Item1;
                    DateTime dateTime = DateTime.Now;
                    context.SP_AddEmployeeServesCustomer(theNationalId, customerID, serviceId, dateTime);
                }
                checkedListBoxForServices.Items.Clear();
                textBoxCustomerPhone.Text = string.Empty;
                fillTheServices();
            }
        }
    }
}
