using System;

class Staff
{
    public string Name;
    public string Department;
    public string Designation;
    public int Experience;
    public double Salary;

    public void GetStaffDetails()
    {

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Department: ");
            Department = Console.ReadLine();
            Console.Write("Enter Designation: ");
            Designation = Console.ReadLine();
            Console.Write("Enter Experience: ");
            Experience = int.Parse(Console.ReadLine());
            Console.Write("Enter Salary: ");
            Salary = double.Parse(Console.ReadLine());

            if (Designation.ToLower() == "hod")
            {
                Console.WriteLine($"Name: {Name}\nSalary: {Salary}");
            }
        }
    }

