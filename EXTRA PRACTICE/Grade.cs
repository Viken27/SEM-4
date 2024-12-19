using System;

class StudentGrades
{

    public void abc()
    {
        int numOfStudents = 5;
        int[] marks = new int[numOfStudents];
        double percentage;
        char grade;

        for (int i = 0; i < numOfStudents; i++)
        {
            Console.WriteLine($"Enter marks for student {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numOfStudents; i++)
        {
            percentage = (double)marks[i] / 100 * 100;

            if (percentage >= 90)
                grade = 'A';
            else if (percentage >= 75)
                grade = 'B';
            else if (percentage >= 60)
                grade = 'C';
            else if (percentage >= 50)
                grade = 'D';
            else
                grade = 'F';

            Console.WriteLine($"Student {i + 1}: Percentage = {percentage}% , Grade = {grade}");
        }
    }
}
