using AutoMapper;
using EmployeeManagement.Models;
using EmployeeManagement.Web.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    public class EditEmployeeBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService{ get; set; }

        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        [Inject]
        public IMapper Mapper { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        private Employee Employee { get; set; } = new Employee();

        public EditEmployeeModel EditEmployeeModel { get; set; } = new EditEmployeeModel();
        public List<Department> Departments { get; set; } = new List<Department>();

        [Parameter]
        public string Id { get; set; }


        protected override async Task OnInitializedAsync()
        {
            int.TryParse(Id, out int employeeId);
            
            if(employeeId != 0)
            {
                Employee = await EmployeeService.GetEmployee(int.Parse(Id));
            }
            else
            {
                Employee = new Employee
                {
                    DepartmentId = 1,
                    DateOfBirth = DateTime.Now,
                    PhotoPath = "images/nophoto.jpg"
                };
            }
           
            Departments = (await DepartmentService.GetDepartments()).ToList();
            Mapper.Map(Employee, EditEmployeeModel);
        }

        protected async Task HandleValidSubmit()
        {
            Mapper.Map(EditEmployeeModel, Employee);

            Employee result = null;
            
            if(Employee.EmployeeId != 0)
            {
              result = await EmployeeService.UpdateEmployee(Employee);
            }
            else
            {
                result = await EmployeeService.CreateEmployee(Employee);
            }

            if (result != null)
            {

                NavigationManager.NavigateTo("/");

            }
        }

    }
}
