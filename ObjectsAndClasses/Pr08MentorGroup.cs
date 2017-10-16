using System.Globalization;
using System.Linq;

namespace Pr08MentorGroup
{
    using System;
    using System.Collections.Generic;

    public class Pr08MentorGroup
    {
        public static void Main()
        {
            var line = Console.ReadLine();

            var students = new List<Student>();

            List<string> comments = new List<string>();

            while (!line.Equals("end of dates"))
            {
                var userAndDates = line.Split();

                Student student = new Student();

                List<DateTime> attendancies = new List<DateTime>();

                student.Name = userAndDates[0];

                if (userAndDates.Length > 1)
                {
                    var datesAsString = userAndDates[1].Split(',').ToArray();

                    if (datesAsString.Length > 1)
                    {
                        foreach (var dateAsString in datesAsString)
                        {
                            DateTime parsedDate = DateTime
                                .ParseExact(dateAsString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                            attendancies.Add(parsedDate);

                            student.Dates = (attendancies);
                        }
                    }

                    else
                    {
                        var dateAsString = userAndDates[1];
                        DateTime parsedDate = DateTime
                            .ParseExact(dateAsString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                        attendancies.Add(parsedDate);

                        student.Dates = (attendancies);
                    }
                }

                students.Add(student);

                line = Console.ReadLine();
            }

            var secondLine = Console.ReadLine();

            while (!secondLine.Equals("end of comments"))
            {
                var userAndComment = secondLine.Split('-');

                var userName = userAndComment[0];

                if (userAndComment.Length > 1)
                {
                    var comment = userAndComment[1];  
                    
                    var user = students.FirstOrDefault(u => u.Name.Equals(userName));

                    if (user != null)
                    {
                        comments.Add(comment);
                        user.Comments = comments;
                    }

                }

              
                secondLine = Console.ReadLine();
            }

            var sortedUsers = students.OrderBy(u => u.Name);

            foreach (var student in sortedUsers)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");

                if (student.Comments != null)
                {
                    foreach (var comment in student.Comments)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }

                Console.WriteLine("Dates attended:");

                if (student.Dates != null)
                {
                    foreach (var date in student.Dates.OrderBy(d => d))
                    {
                        var formattedDate = date.ToString("dd/MM/yyyy");
                        Console.WriteLine($"-- {formattedDate}");
                    }
                }

            }
        }

        public class Student
        {
            public string Name { get; set; }
            public List<DateTime> Dates { get; set; }
            public List<string> Comments { get; set; }
        }
    }
}