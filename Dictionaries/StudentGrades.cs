namespace StudentGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentGrades
    {
        static void Main(string[] args)
        {
            var numberOfStudents = int.Parse(Console.ReadLine());
            var studentsRecord = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var namesAndGrades = Console.ReadLine().Split(' ');

                var name = namesAndGrades[0];
                var grade = double.Parse(namesAndGrades[1]);

                if (!studentsRecord.ContainsKey(name))
                {
                    studentsRecord[name] = new List<double>();
                }
                studentsRecord[name].Add(grade);
            }

            foreach (var pair in studentsRecord)
            {
                var name = pair.Key;
                var studentGrades = pair.Value;
                var average = studentGrades.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in studentGrades)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {average:f2})");
            }
            //Console.ReadKey();
        }
    }
}
