using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeWebService;
using Employee_DatabaseLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace EmployeeWebService.Tests
{
    [TestClass()]
    public class EmployeeWebServiceTests
    {
        [TestMethod()]
        public void GetEmployeeTest()
        { 
            var emp = new EmpDatabase();
            var actual = emp.GetEmployee()[0].FirstName;
            Assert.Fail();
        }
    }
}
