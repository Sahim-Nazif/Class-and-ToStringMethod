using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Comp123
{
/* Student Name: Nazif Sahim
 * Student ID: 300886750
 * Professor: Mr.Syed Yamin
 * Course: COMP123
 */
    class Employee
    {
        //instance variables
        private int empID;
        private  String empName;
        private  double empSalary;
        

        public Employee()
        {

        }
       public Employee(int empID)
        {
            this.empID = empID;
            
        }
        public Employee( string empName, double empSalary)
        {
            this.empName = empName;
            this.empSalary = empSalary;
        }
        public Employee(int empID, string empName, double empSalary)
        {
            this.empID = empID;
            this.empName = empName;
            this.empSalary = empSalary;
        }
        public string EmpAddress
        {
            get;
            set;
        }
       
        //the set methods
        public void  SetEmpId(int empID)
        {
            this.empID = empID;
        }
        public void SetEmpName(string empName)
        {
            this.empName = empName;
        }
        public void SetEmpSalary(double empSalary)
        {
            this.empSalary = empSalary;
        }
        //one method to set all three arguments
        public void SetEmployee(int empID, string empName, double empSalary)
        {
            this.empID = empID;
            this.empName = empName;
            this.empSalary = empSalary;

        }
        public int GetEmpId()
        {
            return empID;
        }
        public string GetEmpName()
        {
            return empName;
        }
        public double GetEmpSalary()
        {
            return empSalary;
        }
        public override string ToString()
        {
            return "\nEmployee ID: " + empID + "\n Employee Name : "+ empName + "\nEmployee Salary" + empSalary + "\nEmployee Address" + EmpAddress;
        }

        static void Main(string[] args)
        {
           Employee employee1 = new Employee();
            employee1.empID = 775002;
            employee1.empName = ("John Smith");
            employee1.empSalary= (60000);
            employee1.EmpAddress = ("33 Wolfcreek road, Markham, ON");
            Console.WriteLine(employee1 );
            Console.ReadKey();
        }
    }
}
