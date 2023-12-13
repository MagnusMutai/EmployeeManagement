using EmployeeManagement.Models;
using System.Net.Http.Json;

namespace EmployeeManagement.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Employee> CreateEmployee(Employee newEmployee)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("api/employees", newEmployee);
            response.EnsureSuccessStatusCode();

            //return URI of the created resource
            return newEmployee;
        }

        public async Task DeleteEmployee(int id)
        {
            await httpClient.DeleteAsync($"api/emeployees/{id}");
        }

        public async Task<Employee> GetEmployee(int id)
        {
            return await httpClient.GetFromJsonAsync<Employee>($"api/employees/{id}");
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await httpClient.GetFromJsonAsync<Employee[]>("api/employees");
        }

        public async Task<Employee> UpdateEmployee(Employee updatedEmployee)
        {

            HttpResponseMessage response = await httpClient.PutAsJsonAsync("api/employees", updatedEmployee);
            response.EnsureSuccessStatusCode();

            //Deserialize the updated product from the response body
            //updatedEmployee = await response.Content.ReadAsStringAsync<Employee>();
            return updatedEmployee;
        }
    }
}
