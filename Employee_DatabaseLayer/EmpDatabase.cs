using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_DatabaseLayer
{
    public class EmpModel
    {
        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; }
    }
    public class EmpDatabase
    {
        public List<EmpModel> GetEmployee() 
        {
            var empList = new List<EmpModel>();
            try
            {
                string rplceComma = ",";
                string CSVfile = "C:/Users/nithyanraj/Desktop/EmployeeDetails.csv";
                StreamReader sr = new StreamReader(CSVfile);
                string allData = sr.ReadToEnd();
                string[] rows = allData.Split("\r\n".ToCharArray());
                
                for (int t = 1; t < rows.Length; t++)
                {
                    var str = rows[t];
                    string[] items = str.Split(rplceComma.ToCharArray());
                    if (items.Length > 2)
                    {
                        var emp = new EmpModel
                        {
                            EmployeeID = items[0],
                            FirstName = items[1],
                            LastName = items[2],
                            Salary = items[3]
                        };
                        empList.Add(emp);
                    }
                }
                /*
                foreach (var val in empList)
                {
                    Console.WriteLine("Employee Details : {0} {1} {2} {3}", val.EmployeeID, val.FirstName, val.LastName, val.Salary);
                    Console.ReadLine();
                }**/
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return empList;
        }
    }
}
