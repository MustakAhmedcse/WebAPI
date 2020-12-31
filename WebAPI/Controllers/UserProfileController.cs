using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class UserProfileController : ControllerBase
    {
        [HttpGet]

        [Route("ForAll")]
        public string GetForAll()
        {
            return "Web Method for All";
        }
        [HttpGet]
        [Authorize(Roles = Role.Admin)]
        [Route("ForAdmin")]
        public string GetForAdmin()
        {
            return "Web Method for Admin";
        }
        [HttpGet]
        [Authorize(Roles = Role.Customer)]
        [Route("ForCustomer")]
        public string GetForCustomer()
        {
            return "Web Method for Customer";
        }
        [HttpGet]
        [Authorize(Roles = Role.AdminCustomer)]
        [Route("ForAdminorCustomer")]
        public string GetForAdminorCustomer()
        {
            return "Web Method for Admin or Customer";
        }
    }
}
