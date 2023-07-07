namespace EmployeeWageProgram
{
    public class EmployeeWage
    {
        public void CalculateEmployeeWage()
        {
            //Using Switch Case
            Random random = new Random();
            int attendance = random.Next(0, 3);
            int Salary = 0, daily_hour = 0;

            //Constant variables
            const byte IS_PRESENT_FULL_TIME = 1;
            const byte IS_PRESENT_PART_TIME = 2;
            const byte WAGE_PER_HOUR = 20;

            switch (attendance)
            {
                case IS_PRESENT_FULL_TIME:
                    daily_hour = 8;
                    Console.WriteLine("Employee is Present for Full time.");
                    break;

                case IS_PRESENT_PART_TIME:
                    daily_hour = 4;
                    Console.WriteLine("Employee is Present for Part time.");
                    break;

                default:
                    Console.WriteLine("Employee is Absent.");
                    break;
            }
            Salary = daily_hour * WAGE_PER_HOUR;
            Console.WriteLine("Salary of the Employee is Rs: " + Salary);
            Console.ReadLine();

        }
    }
}