using CustomerRegister_BackEnd.Repositories.IRepository;
using CustomerRegister_BackEnd.Services.IService;
using CustomerRegister_BackEnd.Models;
using CustomerRegister_BackEnd.Repositories.Repository;
using CustomerRegister_BackEnd.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CustomerRegister_BackEnd.Services.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            var res = await _customerRepository.GetCustomers();
            return res;
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            return await _customerRepository.CreateCustomer(customer);
        }

        public async Task<Customer?> GetCustomerByID(int id)
        {
            var res = await _customerRepository.GetCustomerByID(id);
            return res;
        }

        public async Task<string> DeleteCustomerByID(int id)
        {
            var res = await _customerRepository.DeleteCustomerByID(id);
            return res;
        }

    }
}


