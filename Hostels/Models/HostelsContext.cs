using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Hostels.DataObjects;

namespace Hostels.Models
{
    public class HostelsContext : DbContext
    {
        private static readonly string HostelsConnectionString = ConfigurationManager.ConnectionStrings["HostelsConn"].ConnectionString;
        public HostelsContext():base(HostelsConnectionString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Student> Students { get; set; }
        public  DbSet<Damage> Damages { get; set; }
        public DbSet<EmployeePayment> EmployeePayments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<StudentPayment> StudentPayments { get; set; }
    }
}