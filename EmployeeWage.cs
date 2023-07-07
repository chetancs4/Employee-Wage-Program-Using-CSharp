namespace EmployeeWageProgram
{
    public class EmployeeWage
    {
        public void CalculateEmployeeWage()
        {
            Random random = new Random();
            int attendance = random.Next(0, 2);

            int Salary = 0;

            //Constant variables
            const byte FULL_DAY_HOUR = 8;
            const byte WAGE_PER_HOUR = 20;

            //Calculate Employee Present Salary and Absent Salary.
            if (attendance == 1)
            {
                Salary = FULL_DAY_HOUR * WAGE_PER_HOUR;
                Console.WriteLine("Employee is Present for Full time and the Salary is Rs: " + Salary);
            }
            else
            {
                Console.WriteLine("Employee is Absent and the Salary is Rs: " + Salary);
            }
            Console.ReadLine();

        }
    }
}