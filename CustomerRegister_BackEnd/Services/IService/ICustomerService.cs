using CustomerRegister_BackEnd.Models;

namespace CustomerRegister_BackEnd.Services.IService
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetCustomers();
        Task<Customer> CreateCustomer(Customer customer);

        Task<Customer?> GetCustomerByID(int id);

        Task<string> DeleteCustomerByID(int id);

    }
}

