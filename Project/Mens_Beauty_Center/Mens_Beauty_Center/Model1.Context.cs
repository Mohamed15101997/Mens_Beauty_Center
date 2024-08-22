﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mens_Beauty_Center
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Mens_Beauty_Center_DBEntities : DbContext
    {
        public Mens_Beauty_Center_DBEntities()
            : base("name=Mens_Beauty_Center_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Evaluation> Evaluations { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<PackageCustomer> PackageCustomers { get; set; }
        public virtual DbSet<serve> serves { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<V_AllCustomers> V_AllCustomers { get; set; }
        public virtual DbSet<V_AllEmployees> V_AllEmployees { get; set; }
        public virtual DbSet<V_AttendanceWithEmployeeName> V_AttendanceWithEmployeeName { get; set; }
        public virtual DbSet<V_CoustomerVipDetails> V_CoustomerVipDetails { get; set; }
        public virtual DbSet<V_Package> V_Package { get; set; }
        public virtual DbSet<V_Service> V_Service { get; set; }
    
        public virtual int SP_AddCustomer(string c_Name, string c_Phone)
        {
            var c_NameParameter = c_Name != null ?
                new ObjectParameter("C_Name", c_Name) :
                new ObjectParameter("C_Name", typeof(string));
    
            var c_PhoneParameter = c_Phone != null ?
                new ObjectParameter("C_Phone", c_Phone) :
                new ObjectParameter("C_Phone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_AddCustomer", c_NameParameter, c_PhoneParameter);
        }
    
        public virtual int SP_AddEmployee(string firstName, string lastName, string nationalID, string phoneNumber, Nullable<decimal> fixedSalary, Nullable<bool> type)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var nationalIDParameter = nationalID != null ?
                new ObjectParameter("NationalID", nationalID) :
                new ObjectParameter("NationalID", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            var fixedSalaryParameter = fixedSalary.HasValue ?
                new ObjectParameter("FixedSalary", fixedSalary) :
                new ObjectParameter("FixedSalary", typeof(decimal));
    
            var typeParameter = type.HasValue ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_AddEmployee", firstNameParameter, lastNameParameter, nationalIDParameter, phoneNumberParameter, fixedSalaryParameter, typeParameter);
        }
    
        public virtual int SP_AddEmployeeServesCustomer(string p_NationalID, Nullable<int> p_CustomerCode, Nullable<int> p_ServiceID, Nullable<System.DateTime> p_ServDate)
        {
            var p_NationalIDParameter = p_NationalID != null ?
                new ObjectParameter("p_NationalID", p_NationalID) :
                new ObjectParameter("p_NationalID", typeof(string));
    
            var p_CustomerCodeParameter = p_CustomerCode.HasValue ?
                new ObjectParameter("p_CustomerCode", p_CustomerCode) :
                new ObjectParameter("p_CustomerCode", typeof(int));
    
            var p_ServiceIDParameter = p_ServiceID.HasValue ?
                new ObjectParameter("p_ServiceID", p_ServiceID) :
                new ObjectParameter("p_ServiceID", typeof(int));
    
            var p_ServDateParameter = p_ServDate.HasValue ?
                new ObjectParameter("P_ServDate", p_ServDate) :
                new ObjectParameter("P_ServDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_AddEmployeeServesCustomer", p_NationalIDParameter, p_CustomerCodeParameter, p_ServiceIDParameter, p_ServDateParameter);
        }
    
        public virtual int SP_AddPackage(string name, string description, Nullable<decimal> totalAmount)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var totalAmountParameter = totalAmount.HasValue ?
                new ObjectParameter("TotalAmount", totalAmount) :
                new ObjectParameter("TotalAmount", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_AddPackage", nameParameter, descriptionParameter, totalAmountParameter);
        }
    
        public virtual int SP_AddService(string serviceName, Nullable<int> price)
        {
            var serviceNameParameter = serviceName != null ?
                new ObjectParameter("ServiceName", serviceName) :
                new ObjectParameter("ServiceName", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_AddService", serviceNameParameter, priceParameter);
        }
    
        public virtual int SP_CreateManagerAccount(string userName, string userPassword, string employeeID)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var userPasswordParameter = userPassword != null ?
                new ObjectParameter("UserPassword", userPassword) :
                new ObjectParameter("UserPassword", typeof(string));
    
            var employeeIDParameter = employeeID != null ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CreateManagerAccount", userNameParameter, userPasswordParameter, employeeIDParameter);
        }
    
        public virtual int SP_DeleteManagerAccount(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DeleteManagerAccount", userNameParameter);
        }
    
        public virtual ObjectResult<string> SP_DeletePackage(Nullable<int> packageId)
        {
            var packageIdParameter = packageId.HasValue ?
                new ObjectParameter("PackageId", packageId) :
                new ObjectParameter("PackageId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SP_DeletePackage", packageIdParameter);
        }
    
        public virtual int SP_DeleteService(Nullable<int> serviceID)
        {
            var serviceIDParameter = serviceID.HasValue ?
                new ObjectParameter("ServiceID", serviceID) :
                new ObjectParameter("ServiceID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DeleteService", serviceIDParameter);
        }
    
        public virtual ObjectResult<SP_EmployeeReport_Result> SP_EmployeeReport(Nullable<int> employeeID, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_EmployeeReport_Result>("SP_EmployeeReport", employeeIDParameter, startDateParameter, endDateParameter);
        }
    
        public virtual ObjectResult<SP_GetCustomerByPhoneNumber_Result> SP_GetCustomerByPhoneNumber(string phoneNumber)
        {
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetCustomerByPhoneNumber_Result>("SP_GetCustomerByPhoneNumber", phoneNumberParameter);
        }
    
        public virtual ObjectResult<SP_GetCustomerPackagesByPhoneNumber_Result> SP_GetCustomerPackagesByPhoneNumber(string phoneNumber)
        {
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetCustomerPackagesByPhoneNumber_Result>("SP_GetCustomerPackagesByPhoneNumber", phoneNumberParameter);
        }
    
        public virtual ObjectResult<SP_GetCustomerServicesByPhoneNumber_Result> SP_GetCustomerServicesByPhoneNumber(string phoneNumber)
        {
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetCustomerServicesByPhoneNumber_Result>("SP_GetCustomerServicesByPhoneNumber", phoneNumberParameter);
        }
    
        public virtual int SP_InsertArrivalTime(string empID)
        {
            var empIDParameter = empID != null ?
                new ObjectParameter("EmpID", empID) :
                new ObjectParameter("EmpID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertArrivalTime", empIDParameter);
        }
    
        public virtual int SP_InsertEmployeeEvaluationWithPackages(string month, Nullable<decimal> profitPercentage)
        {
            var monthParameter = month != null ?
                new ObjectParameter("Month", month) :
                new ObjectParameter("Month", typeof(string));
    
            var profitPercentageParameter = profitPercentage.HasValue ?
                new ObjectParameter("ProfitPercentage", profitPercentage) :
                new ObjectParameter("ProfitPercentage", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertEmployeeEvaluationWithPackages", monthParameter, profitPercentageParameter);
        }
    
        public virtual int SP_UpdateEmployeeInfo(string firstName, string lastName, string nationalID, string phoneNumber, Nullable<decimal> fixedSalary, Nullable<bool> type)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var nationalIDParameter = nationalID != null ?
                new ObjectParameter("NationalID", nationalID) :
                new ObjectParameter("NationalID", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            var fixedSalaryParameter = fixedSalary.HasValue ?
                new ObjectParameter("FixedSalary", fixedSalary) :
                new ObjectParameter("FixedSalary", typeof(decimal));
    
            var typeParameter = type.HasValue ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateEmployeeInfo", firstNameParameter, lastNameParameter, nationalIDParameter, phoneNumberParameter, fixedSalaryParameter, typeParameter);
        }
    
        public virtual int SP_UpdateEmployeeSalary(string nationalID, Nullable<decimal> fixedSalary)
        {
            var nationalIDParameter = nationalID != null ?
                new ObjectParameter("NationalID", nationalID) :
                new ObjectParameter("NationalID", typeof(string));
    
            var fixedSalaryParameter = fixedSalary.HasValue ?
                new ObjectParameter("FixedSalary", fixedSalary) :
                new ObjectParameter("FixedSalary", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateEmployeeSalary", nationalIDParameter, fixedSalaryParameter);
        }
    
        public virtual ObjectResult<string> SP_UpdateExpenseMoney(Nullable<int> attendanceID, Nullable<decimal> expenseMoney)
        {
            var attendanceIDParameter = attendanceID.HasValue ?
                new ObjectParameter("AttendanceID", attendanceID) :
                new ObjectParameter("AttendanceID", typeof(int));
    
            var expenseMoneyParameter = expenseMoney.HasValue ?
                new ObjectParameter("ExpenseMoney", expenseMoney) :
                new ObjectParameter("ExpenseMoney", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SP_UpdateExpenseMoney", attendanceIDParameter, expenseMoneyParameter);
        }
    
        public virtual int SP_UpdateLeavingTime(Nullable<int> attendanceID)
        {
            var attendanceIDParameter = attendanceID.HasValue ?
                new ObjectParameter("AttendanceID", attendanceID) :
                new ObjectParameter("AttendanceID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateLeavingTime", attendanceIDParameter);
        }
    
        public virtual ObjectResult<string> SP_UpdatePackage(Nullable<int> packageId, string name, string description, Nullable<decimal> totalAmount)
        {
            var packageIdParameter = packageId.HasValue ?
                new ObjectParameter("PackageId", packageId) :
                new ObjectParameter("PackageId", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var totalAmountParameter = totalAmount.HasValue ?
                new ObjectParameter("TotalAmount", totalAmount) :
                new ObjectParameter("TotalAmount", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SP_UpdatePackage", packageIdParameter, nameParameter, descriptionParameter, totalAmountParameter);
        }
    
        public virtual int SP_UpdateService(Nullable<int> serviceId, string serviceName, Nullable<int> price)
        {
            var serviceIdParameter = serviceId.HasValue ?
                new ObjectParameter("ServiceId", serviceId) :
                new ObjectParameter("ServiceId", typeof(int));
    
            var serviceNameParameter = serviceName != null ?
                new ObjectParameter("ServiceName", serviceName) :
                new ObjectParameter("ServiceName", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateService", serviceIdParameter, serviceNameParameter, priceParameter);
        }
    
        public virtual ObjectResult<PS_GetCustomerService_Result> PS_GetCustomerService(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("ToDate", toDate) :
                new ObjectParameter("ToDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PS_GetCustomerService_Result>("PS_GetCustomerService", fromDateParameter, toDateParameter);
        }
    
        public virtual ObjectResult<PS_GetCustomerServiceEmployee_Result> PS_GetCustomerServiceEmployee(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate, string nationalID)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("ToDate", toDate) :
                new ObjectParameter("ToDate", typeof(System.DateTime));
    
            var nationalIDParameter = nationalID != null ?
                new ObjectParameter("NationalID", nationalID) :
                new ObjectParameter("NationalID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PS_GetCustomerServiceEmployee_Result>("PS_GetCustomerServiceEmployee", fromDateParameter, toDateParameter, nationalIDParameter);
        }
    
        public virtual ObjectResult<SP_GetCustomerPackage_Result> SP_GetCustomerPackage(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("ToDate", toDate) :
                new ObjectParameter("ToDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetCustomerPackage_Result>("SP_GetCustomerPackage", fromDateParameter, toDateParameter);
        }
    
        public virtual ObjectResult<SP_GetCustomerPackageEmployee_Result> SP_GetCustomerPackageEmployee(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate, string nationalID)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("FromDate", fromDate) :
                new ObjectParameter("FromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("ToDate", toDate) :
                new ObjectParameter("ToDate", typeof(System.DateTime));
    
            var nationalIDParameter = nationalID != null ?
                new ObjectParameter("NationalID", nationalID) :
                new ObjectParameter("NationalID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetCustomerPackageEmployee_Result>("SP_GetCustomerPackageEmployee", fromDateParameter, toDateParameter, nationalIDParameter);
        }
    }
}
