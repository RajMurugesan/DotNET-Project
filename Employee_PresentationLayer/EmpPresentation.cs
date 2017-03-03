using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_BusinessLogicLayer;
using System.Web;
using EmployeeWebService;
using Employee_DatabaseLayer;

namespace Employee_PresentationLayer
{
    public class EmpPresentation
    {
        static void Main(string[] args)
        {
            EmpBusiness EmpBus = new EmpBusiness();
            EmpBus.readEmpCSV();
            EmployeeServiceReference.EmployeeWebService obj = new EmployeeServiceReference.EmployeeWebService();
            var employees = obj.GetEmployee();
            foreach (var emp in employees)
            {
                Console.WriteLine("FirstName:" + emp);
            }
        }
    }
}
