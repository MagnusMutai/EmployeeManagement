using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Pages
{
    public class DataBindingDemoBase : ComponentBase
    {
        protected string Name { get; set; } = "Tom";
        protected string Gender { get; set; } = "Male";

        //protected void OnText_Input(ChangeEventArgs e)
        //{
        //    Name = e.Value.ToString();
        //}
    }
}
