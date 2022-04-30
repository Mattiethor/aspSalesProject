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

        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees;
            using (var db = _dbContext)
            {
                employees = db.Employees.ToList();

            }
            return employees;
        }
    }
    }
   

