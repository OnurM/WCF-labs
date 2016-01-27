using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployerService.svc or EmployerService.svc.cs at the Solution Explorer and start debugging.
    public class EmployerService : IEmployerService
    {
        public MyEmployee GetEmployeeInfoByEmployeeId(int employeeId)
        {
            using (var db = new theDB())
            {

                if (!db.Employees.Any(e => e.EmployeeID == employeeId))
                    return new MyEmployee() {FirstName = "There is no employee with given EmployeeID"};

                return (from e in db.Employees
                        where e.EmployeeID == employeeId
                        select new MyEmployee()
                        {
                            Address = e.Address,
                            BirthDate = e.BirthDate,
                            City = e.City,
                            Country = e.Country,
                            Extension = e.Extension,
                            EmployeeId = e.EmployeeID,
                            FirstName = e.FirstName,
                            HireDate = e.HireDate,
                            HomePhone = e.HomePhone,
                            LastName = e.LastName,
                            Notes = e.Notes,
                            PostalCode = e.PostalCode,
                            Region = e.Region,
                            ReportsTo = e.ReportsTo,
                            Title = e.Title,
                            TitleOfCourtesy = e.TitleOfCourtesy
                        }).FirstOrDefault();
            }
        }

        public string UpdateEmployeeInfo(MyEmployee employee)
        {
            DateTime x;
            using (var db = new theDB())
            {
                var theEmployee = (from e in db.Employees
                                   where e.EmployeeID == employee.EmployeeId
                                   select e).FirstOrDefault();

                if (theEmployee == null)
                    return @"There is no employee with given EmployeeID";
                
                theEmployee.FirstName = employee.FirstName;
                theEmployee.LastName = employee.LastName;
                theEmployee.Address = employee.Address;
                theEmployee.PostalCode = employee.PostalCode;
                theEmployee.Region = employee.Region;
                theEmployee.Title = employee.Title;
                theEmployee.TitleOfCourtesy = employee.TitleOfCourtesy;
                theEmployee.BirthDate = employee.BirthDate;
                theEmployee.City = employee.City;
                theEmployee.Country = employee.Country;
                theEmployee.Notes = employee.Notes;
                theEmployee.Extension = employee.Extension;
                theEmployee.HireDate = employee.HireDate;
                theEmployee.HomePhone = employee.HomePhone;
                theEmployee.ReportsTo = employee.ReportsTo;

                db.SaveChanges();
            }
            return "The Employee was updated successfully";
        }
    }
}

