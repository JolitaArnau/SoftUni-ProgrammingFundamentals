namespace Pr04AverageGrades
{
    using System.Collections.Generic;
    using System.Linq;

    class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double AverageGrade

        { get { return Grades.Average(); } }
    }
}
