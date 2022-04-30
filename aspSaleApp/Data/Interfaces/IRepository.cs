using ntv_database.Models;

namespace aspSaleApp.Data.Interfaces
{
    public interface IRepository
    {
        List<Employee> GetAllEmployees();

        Employee GetEmployeeById(int id);

        List<Item> GetAllItems();

        Item GetItemById(int id);

        List<Customer> GetAllCustomer();

        Customer GetCustomerById(int id);


    }
}
