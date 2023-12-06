using EmployeeManagement.Models;
using EmployeeManagement.Models.CustomValidator;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Web.Models
{
    public class EditEmployeeModel
    {
        //Top level properties
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Please input First Name")]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        [EmailDomainValidator(AllowedDomain = "MagnusMq.com", ErrorMessage = "Error message validation")]
        public string Email { get; set; }

        [CompareProperty("Email", ErrorMessage = "Email doesn't match")]
        public string ConfirmEmail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }
        //navigation/complex property
        //[ValidateComplexType]
        //public Department Department { get; set; } = new Department();

    }
}
