using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Models
{
    public class EmployeeModelContext : DbContext
    {

        public EmployeeModelContext(DbContextOptions<EmployeeModelContext> options):base(options) 
        {}

        public DbSet<EmployeeModel> EmployeeDetails { get; set; }




    }
}
