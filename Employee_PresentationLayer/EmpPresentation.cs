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
            /*
            EmpBusiness EmpBus = new EmpBusiness();
            EmpBus.readEmpCSV();
            **/
            EmployeeWebService.EmployeeWebService obj = new EmployeeWebService.EmployeeWebService();
            var employees = obj.GetEmployee();
            foreach(var emp in employees){
                Console.WriteLine("FirstName:" + emp.FirstName);
                Console.WriteLine("LastName:" + emp.LastName);
            }
        }
    }
}
