namespace DataAccess
{
    public interface IEmployeeRepository
    {
        bool AddEmployee(Employee employee, string ProjectName);
        Employee GetEmployeeProfile(string PUID);
        bool ModifyEmployeeDetails(string OldPUID, Employee NewEmployee);
        bool DeleteEmployee(string PUID);
    }
}
