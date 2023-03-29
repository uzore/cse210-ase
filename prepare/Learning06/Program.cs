using System;



namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Employee> employees = new List<Employee>();
            employees.Add(hEmployee);
            employees.Add(sEmployee);

            foreach (Employee emp in employees)
            {
                float pay = emp GetPay();
            }

            HourlyEmployee hEmployee = new HourlyEmployee();
            hEmployee.SetName("Joseph");
            hEmployee.SetIdName("oh23098");
            hEmployee.SetPayRate(15);
            hEmployee.SetHoursWorked(120);

            SalaryEmployee sEmployee = new HourlyEmployee();
            sEmployee.SetName("Emilia");
            sEmployee.SetIdName("er87389");
            sEmployee.SetSalary("60,000");
        }
    }
}