using EmployeeManagement.Models;

namespace EmployeeManagement.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public Task<IEnumerable<Employee>> GetEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
