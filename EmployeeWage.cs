namespace EmployeeWageProgram
{
    public class EmployeeWage
    {
        public void CalculateEmployeeWage()
        {
            //Random random = new Random();
            //int attendance = random.Next(0, 2);

            ////Checking if the Employee is Present or Absent.

            //if (attendance == 1)
            //{
            //    Console.WriteLine("Employee is Present.");
            //}
            //else
            //{
            //    Console.WriteLine("Employee is Absent.");
            //}


            /* Random random = new Random();
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
             }*/


            /*Random random = new Random();
            int attendance = random.Next(0, 3);

            int salary = 0;

            //Constant variables
            const byte IS_PRESENT_FULL_TIME = 1;
            const byte IS_PRESENT_PART_TIME = 2;
            const byte FULL_DAY_HOUR = 8;
            const byte PART_TIME_HOUR = 4;
            const byte WAGE_PER_HOUR = 20;

            //Checking if the Employee is Present or not
            if (attendance == IS_PRESENT_FULL_TIME)
            {
                //Calculating the salary for Full time Employee
                salary = FULL_DAY_HOUR * WAGE_PER_HOUR;
                Console.WriteLine("Employee is Present for Full time and the Salary is Rs." + salary);
            }
            else if (attendance == IS_PRESENT_PART_TIME)
            {
                //Calculating the salary for Part time Employee
                salary = PART_TIME_HOUR * WAGE_PER_HOUR;
                Console.WriteLine("Employee is Present for Part time and the Salary is Rs." + salary);
            }
            else
            {
                Console.WriteLine("Employee is Absent and the Salary is Rs." + salary);
            }*/

            /*   //Using Switch Case
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
               Console.WriteLine("Salary of the Employee is Rs: " + Salary);*/

            /*//Calculate Monthly Wages
            Random random = new Random();
            int Salary = 0, daily_hour = 0, total_working_hour = 0, monthly_salary = 0;   
            const byte IS_PRESENT_FULL_TIME = 1;
            const byte IS_PRESENT_PART_TIME = 2;
            const byte WAGE_PER_HOUR = 20;
            const byte TOTAL_WORKING_DAYS = 20;

            for (int day = 1; day <= TOTAL_WORKING_DAYS; day++)
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
                Salary = daily_hour * WAGE_PER_HOUR;
                Console.WriteLine("Salary of Employee is Rs." + Salary);

                //Calculating total working hour of Employee
                total_working_hour = total_working_hour + daily_hour;
                Console.WriteLine("Total working hours: " + total_working_hour);
            }
            Console.WriteLine("---------------------------------------------");
            //Calculating Monthly salary of Employee
            monthly_salary = total_working_hour * WAGE_PER_HOUR;
            Console.WriteLine("Monthly salary of Employee is Rs: " + monthly_salary);*/


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