using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    public class DisplayEmployeeBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<Employee> Employee { get; set; }

        [Parameter]
        public bool ShowFooter { get; set; }
    }
}
