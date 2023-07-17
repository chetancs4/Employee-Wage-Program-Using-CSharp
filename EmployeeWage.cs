namespace EmployeeWageProgram
{
    public class EmployeeWage
    {
        public void CalculateEmployeeWage()
        {

            //Working Hour Conditions Using While Loop
            Random random = new Random();
            int salary = 0, daily_hour = 0, total_working_hour = 0, monthly_salary = 0, day = 1;
            //Constant variables
            const byte IS_PRESENT_FULL_TIME = 1;
            const byte IS_PRESENT_PART_TIME = 2;
            const byte WAGE_PER_HOUR = 20;
            const byte TOTAL_WORKING_DAYS = 20;
            const byte MAX_WORKING_HOURS = 100;

            while (day <= TOTAL_WORKING_DAYS && total_working_hour <= MAX_WORKING_HOURS)
            {
                int attendance = random.Next(0, 3);
                switch (attendance)
                {
                    case IS_PRESENT_FULL_TIME:
                        daily_hour = 8;
                        Console.WriteLine("Employee is Present for Full time");
                        break;

                    case IS_PRESENT_PART_TIME:
                        daily_hour = 4;
                        Console.WriteLine("Employee is Present for Part time");
                        break;

                    default:
                        daily_hour = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                //Calculating salary of Employee
                salary = daily_hour * WAGE_PER_HOUR;
                Console.WriteLine("Salary of Employee is Rs." + salary);

                //Calculating total working hour of Employee
                total_working_hour = total_working_hour + daily_hour;
                Console.WriteLine("Total working hours : " + total_working_hour);
                day++;
            }
            Console.WriteLine("--------------------------------------------");
            //Calculating Monthly salary of Employee
            monthly_salary = total_working_hour * WAGE_PER_HOUR;
            Console.WriteLine("Monthly salary of Employee is Rs." + monthly_salary);

            Console.ReadLine();
        }
    }
}