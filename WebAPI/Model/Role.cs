using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class Role
    {
        public const string Admin = "Admin";
        public const string Customer = "Customer";
        public const string AdminCustomer = Admin + "," + Customer;
    }
}
