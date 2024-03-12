using CustomerRegister_BackEnd.DBContext;
using CustomerRegister_BackEnd.Models;
using CustomerRegister_BackEnd.Repositories.IRepository;
using CustomerRegister_BackEnd.Services.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Linq.Expressions;

namespace CustomerRegister_BackEnd.Repositories.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerContext _context;

        public CustomerRepository(CustomerContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            try
            {
                var customers = await _context.Customer.ToListAsync();
                return customers;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            try
            {
                if (customer.CustomerId != 0)
                {
                    _context.Customer.Update(customer);
                }
                else
                {
                    _context.Customer.Add(customer);
                }

                await _context.SaveChangesAsync();
                return customer;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Customer?> GetCustomerByID(int id)
        {
            try
            {
                var res = _context.Customer.Where(x => x.CustomerId == id).FirstOrDefault();

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> DeleteCustomerByID(int id)
        {
            try
            {
                var customer = await _context.Customer.Where(x => x.CustomerId == id).FirstOrDefaultAsync();
                if (customer == null)
                {
                    return "Requested ID not available";
                }
                _context.Customer.Remove(customer);
                await _context.SaveChangesAsync();
                return "Data Has Been Deleted Successfully!";
            }
            catch (Exception ex)
            {
                return $"An error occurred while deleting customer data: {ex.Message}";
            }
        }

    }
}
