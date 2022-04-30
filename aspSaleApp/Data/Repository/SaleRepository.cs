using aspSaleApp.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using ntv_database.Migrations;
using ntv_database.Models;

namespace aspSaleApp.Data {
        public class SaleRepository : IRepository
        {
        private SaleDbContext _dbContext;

        public SaleRepository() 
        {
            _dbContext = new SaleDbContext();
       
        }


        //Employee
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees;
            using (var db = _dbContext)
            {
                employees = db.Employees.ToList();

            }
            return employees;
        }

      

         public Employee GetEmployeeById(int id)
        {
            Employee employee;
            using (var db = _dbContext) 
            {
                employee = db.Employees.FirstOrDefault(e => e.Id == id);
            }

            return employee;
        }

        //Item
        public List<Item> GetAllItems()
        {
            List<Item> items;
            using (var db = _dbContext)
            {
                items = db.Items.ToList();

            }
            return items;
        }
        public Item GetItemById(int id)
        {
            Item item;
            using (var db = _dbContext)
            {
                item = db.Items.FirstOrDefault(i => i.Id == id);
            }

            return item;
        }

        public List<Customer> GetAllCustomer()
        {
           List<Customer> customers;
            using (var db = _dbContext)
            {
               customers = db.Customers.ToList();
            }

            return customers;
        }

        public Customer GetCustomerById(int id)
        {
            Customer customer;
            using(var db = _dbContext)
            {
                customer = db.Customers.FirstOrDefault(i => i.Id == id);
            }
            return customer;
        }
    }
    }
   

