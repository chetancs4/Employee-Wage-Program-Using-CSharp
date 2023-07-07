namespace EmployeeWageProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Wage Computation Program");
            Console.WriteLine("--------------------------------------------");

            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.CalculateEmployeeWage();
        }
    }
}