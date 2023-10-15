using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
         : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Departments Table
            modelBuilder.Entity<Department>().HasData(
              new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
               new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
               new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
               new Department { DepartmentId = 4, DepartmentName = "Admin" });



            //Seed Employee Table

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hastings",
                Email = "Mutaigilly02@gmail.com",
                DateOfBirth = new DateTime(2002, 02, 07),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "/Images/JohnJameson.jpg"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "John",
                LastName = "Hastings",
                Email = "Mutaigilly02@gmail.com",
                DateOfBirth = new DateTime(2002, 02, 07),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "/Images/JennyMarks.jpg"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "John",
                LastName = "Hastings",
                Email = "Mutaigilly02@gmail.com",
                DateOfBirth = new DateTime(2002, 02, 07),
                Gender = Gender.Male,
                DepartmentId = 3,
                PhotoPath = "/Images/MaleDefault.jpg"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "John",
                LastName = "Hastings",
                Email = "Mutaigilly02@gmail.com",
                DateOfBirth = new DateTime(2002, 02, 07),
                Gender = Gender.Male,
                DepartmentId = 4,
                PhotoPath = "/Images/NoahRobinson.jpg"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 5,
                FirstName = "John",
                LastName = "Hastings",
                Email = "Mutaigilly02@gmail.com",
                DateOfBirth = new DateTime(2002, 02, 07),
                Gender = Gender.Male,
                DepartmentId = 5,
                PhotoPath = "/Images/OliviaMills.jpg"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 6,
                FirstName = "John",
                LastName = "Hastings",
                Email = "Mutaigilly02@gmail.com",
                DateOfBirth = new DateTime(2002, 02, 07),
                Gender = Gender.Male,
                DepartmentId = 6,
                PhotoPath = "/Images/Profile5_Woman.jpg"
            });
        }
    }
}
