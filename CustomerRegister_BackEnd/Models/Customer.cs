using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CustomerRegister_BackEnd.Models
{
    public class Customer
    {
            [Key]
            public int CustomerId { get; set; }
            public string? CusName { get; set; }
            public string? CusPhoneNumber { get; set; }
            public string? CusAddress { get; set; }
            public string? CusEmail { get; set; }

    }
}
