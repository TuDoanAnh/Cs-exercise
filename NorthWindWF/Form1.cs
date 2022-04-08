using NorthWindWF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthWindWF.Logics;

namespace NorthWindWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            LoadEmployee();
            LoadShipper();
            LoadCountries();
        }

        private void LoadCustomer()
        {
            CustomerLogic customerLogic = new CustomerLogic();
            List<Customer> customers = customerLogic.getAllCustomer();
            Customer customer = new Customer();
            customer.ContactName = "All Customers";
            customers.Insert(0, customer);
            cbCustomer.DisplayMember = "ContactName";
            cbCustomer.ValueMember = "CustactId";
            cbCustomer.DataSource = customers;
        }

        private void LoadEmployee()
        {
            EmployeeLogic employeeLogic = new EmployeeLogic();
            List<Employee> employees = employeeLogic.getAllEmployees();
            Employee emp = new Employee();
            emp.FirstName = "All";
            emp.LastName = "Employees";
            employees = employeeLogic.getAllEmployees();
            employees.Insert(0, emp);
            cbEmployees.DisplayMember = "fullName";
            cbEmployees.ValueMember = "EmployeeId";
            cbEmployees.DataSource = employees;
        }

        private void LoadShipper()
        {
            ShipViaLogic shipViaLogic = new ShipViaLogic();
            List<Shipper> shippers = shipViaLogic.getAllShippers();
            Shipper shipper = new Shipper();
            shipper.CompanyName = "All Shippers";
            shippers.Insert(0, shipper);
            cbShipVia.DisplayMember = "CompanyName";
            cbShipVia.ValueMember = "ShipperID";
            cbShipVia.DataSource = shippers;
        }

        private void LoadCountries()
        {
            CountryLogic countryLogic = new CountryLogic();
            List<String> countries = countryLogic.getAllCountries();
            String country = "All Countries";
            countries.Insert(0, country);

            cbCountry.DataSource = countries;
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            string customer =   cbCustomer.Text;
            string employee =   cbEmployees.Text;
            DateTime fromDate = dtpFrom.Value;
            DateTime toDate = dtpTo.Value;
            string shipVia = cbShipVia.Text;
            string shipName = tbShipName.Text;
            string country = cbCountry.Text;
            
            using(var context = new NorthwindContext())
            {
                var results = context.Orders.Select(o => new
                {
                    OrderID = o.OrderId,
                    CustomerName = o.Customer.ContactName,
                    EmployeeName = o.Employee.fullName,
                    OrderDate = o.OrderDate,
                    RequireDate = o.RequiredDate,
                    ShippedDate = o.ShippedDate,
                    ShipVia = o.ShipViaNavigation.CompanyName,
                    Freight = o.Freight,
                    ShipName = o.ShipName,
                    ShipAddress = o.ShipAddress,
                    ShipCity = o.ShipCity,
                    ShipRegion = o.ShipRegion,
                    ShipPostalCode = o.ShipPostalCode,
                    ShipCountry = o.ShipCountry,
                }).ToList();
                if (!customer.Equals("All Customers"))
                {
                   results = results.Where(o => o.CustomerName.Equals(customer)).ToList();
                }

                if(!employee.Equals("All Employees"))
                {
                    results = results.Where(o => o.EmployeeName.Equals(employee)).ToList();
                }
                if(!shipVia.Equals("All Shippers"))
                {
                    results = results.Where(o => o.ShipVia.Equals(shipVia)).ToList();
                }
                if(!country.Equals("All Countries"))
                {
                    results = results.Where(o => o.ShipCountry.Equals(country)).ToList();
                }
                if (!shipName.Equals(""))
                {
                    results = results.Where(o => o.ShipName.Contains(shipName)).ToList();
                }
                results = results.Where(o => fromDate < o.OrderDate && o.OrderDate < toDate).ToList();
                dataGridView1.DataSource = results.Take(100).ToList();
                lbTotal.Text = results.Count.ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("OrderID"))
            {
                string orderID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                lbOrderID.Text = orderID;
                using(var context = new NorthwindContext())
                {
                    var orderDeatails = context.OrderDetails.Where(o => o.OrderId == Convert.ToInt32(orderID)).Select(o => new
                    {
                        ProductName = o.Product.ProductName,
                        UnitPrice = o.UnitPrice,
                        Quantity = o.Quantity,
                        Discount = o.Discount,
                    }).ToList();
                    dataGridView2.DataSource = orderDeatails;
                    dataGridView2.Columns[3].Visible = false;
                    float total=0;
                    foreach(var or in orderDeatails)
                    {
                        total += (1 - or.Discount) *(float)(or.UnitPrice * or.Quantity);
                    }
                    lbTotalPrice.Text = total.ToString();
                }
            }
        }

    }
}
