using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Login_Registration_ASP_NET_CORE_RAZOR.Model;

namespace Login_Registration_ASP_NET_CORE_RAZOR.Model
{
    public class AuthDbContext:IdentityDbContext
    {
        public AuthDbContext(DbContextOptions <AuthDbContext> options):base(options)
        {

        }
        public DbSet<Login_Registration_ASP_NET_CORE_RAZOR.Model.Staffs> Staffs { get; set; }
        
    }
}
