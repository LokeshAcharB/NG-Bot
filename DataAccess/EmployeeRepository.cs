using NLog;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace DataAccess
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private Employee employee = null;
        private readonly NgDbEntities NgDbcontext;
        public EmployeeRepository()
        {
            NgDbcontext = new NgDbEntities();
        }
        public bool AddEmployee(Employee employee, string ProjectName)
        {
            try
            {
                var Project = (from project in NgDbcontext.Projects
                               where project.ProjectName == ProjectName
                               select project).AsEnumerable().FirstOrDefault();
                employee.Projects = new List<Project> { Project };
                NgDbcontext.Employees.Add(employee);
                NgDbcontext.SaveChanges();
                return true;
            }
            catch (DbUpdateException ex)
            {
                LoggException(ex);
                return false;
            }
            catch (NullReferenceException ex)
            {
                LoggException(ex);
                return false;
            }
        }
        public Employee GetEmployeeProfile(string PUID)
        {
            try
            {
                employee = (from emp in NgDbcontext.Employees.Include("Projects")
                            where emp.PUID == PUID
                            select emp).AsEnumerable().FirstOrDefault();
                if (employee == null || employee.Projects.Count == 0)
                {
                    throw new ArgumentNullException("There is no such project under that team");
                }
                return employee;
            }
            catch (ArgumentNullException ex)
            {
                LoggException(ex);
                return employee;
            }
        }
        public bool ModifyEmployeeDetails(string OldPUID, Employee NewEmployee)
        {
            try
            {
                employee = (from emp in NgDbcontext.Employees
                            where emp.PUID == OldPUID
                            select emp).AsEnumerable().FirstOrDefault();
                employee.FullName = NewEmployee.FullName;
                employee.PUID = NewEmployee.PUID;
                employee.EmailID = "";
                NgDbcontext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                LoggException(ex);
                return false;
            }
        }
        public bool DeleteEmployee(string PUID)
        {
            try
            {
                employee = (from emp in NgDbcontext.Employees
                            where emp.PUID == PUID
                            select emp).AsEnumerable().FirstOrDefault();
                NgDbcontext.Employees.Remove(employee);
                NgDbcontext.SaveChanges();
                return true;
            }
            catch (ArgumentNullException ex)
            {
                LoggException(ex);
                return false;
            }
        }
        private void LoggException(Exception ex)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Error($"Something bad happened in employee site {ex}!");
        }
    }
}
