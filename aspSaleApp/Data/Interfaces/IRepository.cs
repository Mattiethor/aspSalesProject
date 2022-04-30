using ntv_database.Models;

namespace aspSaleApp.Data.Interfaces
{
    public interface IRepository
    {
        List<Employee> GetAllEmployees();

        Employee GetEmployeeById(int id);
    }
}
