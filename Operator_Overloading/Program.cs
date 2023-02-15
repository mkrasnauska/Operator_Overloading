using System;


namespace Operator_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Id = 382;
            employee1.FirstName = "James";
            employee1.LastName = "Dean";

            Employee employee2 = new Employee();
            employee2.Id = 485;
            employee2.FirstName = "Jessica";
            employee2.LastName = "Thorpe";
            if (employee1 == employee2)
            {
                Console.WriteLine("Employee 1 id is same as  employee 2");
            }
            else
            {
                Console.WriteLine("Employee 1 id is not the  same as  employee 2");
            }
            Console.ReadLine();
        }
        public class Employee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }



            public static bool operator ==(Employee employee1, Employee employee2)
            {
                if (employee1.Id.Equals(employee2.Id))
                {
                    return true;
                }
                return false;
            }


            public static bool operator !=(Employee employee1, Employee employee2)
            {
                if (!employee1.Id.Equals(employee2.Id))
                {
                    return true;
                }
                return false;
            }
            public override bool Equals(object obj)
            {
                Employee employee = obj as Employee;
                if (employee != null)
                {
                    return employee.Id.Equals(this.Id);
                }
                return false;
            }
            public override int GetHashCode()
            {
                return 0;
            }
        }
    }
}
