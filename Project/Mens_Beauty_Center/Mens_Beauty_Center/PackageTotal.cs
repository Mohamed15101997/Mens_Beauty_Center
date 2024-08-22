using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mens_Beauty_Center
{
    public partial class PackageTotal : Form
    {
        Mens_Beauty_Center_DBEntities context = new Mens_Beauty_Center_DBEntities();


        public PackageTotal()
        {
            InitializeComponent();
            FillDataGridViewEmp();
        }
        private void FillDataGridViewEmp()
        {
            Employee emp = new Employee();
            Customer cut = new Customer();
            Package pkg = new Package();
            var queryEmp = context.Employees.Select(em => em);
            var queryCus = context.Customers.Select(cu => cu);
            var queryPkg = context.Packages.Select(pkgs => pkgs);
            var PkgCuDataSource = from pkgcu in context.PackageCustomers
                                  join emp1 in context.Employees on pkgcu.NationalID equals emp1.NationalID
                                  join cust in context.Customers on pkgcu.CustomerId equals cust.Code
                                  join pkg1 in context.Packages on pkgcu.PackageId equals pkg1.ID
                                  select new
                                  {
                                      اسم_العميل = cust.Name , 
                                      اسم_الموظف = emp1.FirstName + " " + emp1.LastName , 
                                      البكج = pkg1.Name ,
                                      محتويات_البكج = pkg1.Description , 
                                      المستلم_منه = pkgcu.Deposit , 
                                      تاريخ_الحجز = pkgcu.TakeDate
                                  };
            PackageCompleteDGView.DataSource = PkgCuDataSource.ToList();
        }

        private void ShowAllDataBtn_Click(object sender, EventArgs e)
        {
            FillDataGridViewEmp();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var query = context.PackageCustomers.Where(item => item.TakeDate >= FromDate.Value && item.TakeDate <= ToDate.Value).ToList();
            Employee emp = new Employee();
            Customer cut = new Customer();
            Package pkg = new Package();
            var queryEmp = context.Employees.Select(em => em);
            var queryCus = context.Customers.Select(cu => cu);
            var queryPkg = context.Packages.Select(pkgs => pkgs);
            var PkgCuDataSource = from q in query
                                  join emp1 in context.Employees on q.NationalID equals emp1.NationalID
                                  join cust in context.Customers on q.CustomerId equals cust.Code
                                  join pkg1 in context.Packages on q.PackageId equals pkg1.ID
                                  select new
                                  {
                                      اسم_العميل = cust.Name,
                                      اسم_الموظف = emp1.FirstName + " " + emp1.LastName,
                                      البكج = pkg1.Name,
                                      محتويات_البكج = pkg1.Description,
                                      المستلم_منه = q.Deposit,
                                      تاريخ_الحجز = q.TakeDate
                                  };
            PackageCompleteDGView.DataSource = PkgCuDataSource.ToList();
        }
    }
}

