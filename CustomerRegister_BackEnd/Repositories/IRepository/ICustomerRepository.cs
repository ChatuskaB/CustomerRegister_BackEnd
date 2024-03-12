using CustomerRegister_BackEnd.Models;

namespace CustomerRegister_BackEnd.Repositories.IRepository
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetCustomers();
        Task<Customer> CreateCustomer(Customer customer);

        Task<Customer?> GetCustomerByID(int id);

        Task<string> DeleteCustomerByID(int id);
    }
}
