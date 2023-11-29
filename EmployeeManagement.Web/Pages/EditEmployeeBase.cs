using EmployeeManagement.Models;
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

        public Employee Employee { get; set; } = new Employee();

        public List<Department> Departments { get; set; } = new List<Department>();

        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
            Departments = (await DepartmentService.GetDepartments()).ToList();
        }

    }
}
