namespace Pr04AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Pr04AverageGrades
    {
        static void Main()
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            var students = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                var currentStudentData = Console.ReadLine().Split(' ').ToList();

                var student = new Student();

                student.Name = currentStudentData[0];

                currentStudentData.RemoveAt(0);

                student.Grades = currentStudentData.Select(double.Parse).ToList();

                students.Add(student);

            }

            var aboveAvarage = students.Where(a => a.AverageGrade >= 5.00).OrderBy(x => x.Name).ThenByDescending(g => g.AverageGrade);

            foreach (var studentGrade in aboveAvarage)
            {
                Console.WriteLine($"{studentGrade.Name} -> {studentGrade.AverageGrade:f2} ");
            }
        }
    }
}