using EmployeeManagement.Models.CustomValidator;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required (ErrorMessage = "Please input First Name")]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        [EmailDomainValidator(AllowedDomain ="MagnusMq.com", ErrorMessage ="Error message validation")]
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; } 
        public string PhotoPath { get; set; }
        //navigation property
        public Department Department { get; set; }

        public static implicit operator Employee(HttpResponseMessage v)
        {
            throw new NotImplementedException();
        }
    }
}
