namespace FilterBase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FilterBase
    {
        static void Main(string[] args)
        {
            var nameAndAge = new Dictionary<string, int>();
            var nameAndSalary = new Dictionary<string, double>();
            var nameAndPosition = new Dictionary<string, string>();

            var line = Console.ReadLine();

            var name = string.Empty;
            int age = 0;
            double salaray = 0;
            var position = string.Empty;

            while (!line.Equals("filter base"))
            {
                var employeeData = line
                    .Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);

                name = employeeData[0].Trim();

                if (int.TryParse(employeeData[1], out age))
                {
                    if (!nameAndAge.ContainsKey(name))
                    {
                        nameAndAge[name] = age;
                    }
                }

                else if (double.TryParse(employeeData[1], out salaray))
                {
                    if (!nameAndSalary.ContainsKey(name))
                    {
                        nameAndSalary[name] = salaray;
                    }
                }

                else
                {
                    position = employeeData[1];

                    if (!nameAndPosition.ContainsKey(name))
                    {
                        nameAndPosition[name] = position;
                    }
                }
                line = Console.ReadLine();
            }

            line = Console.ReadLine();

            if (line.Equals("Position"))
            {
                foreach (var kvp in nameAndPosition)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Position:{kvp.Value}");
                    Console.WriteLine("====================");
                }
            }

            if (line.Equals("Salary"))
            {
                foreach (var kvp in nameAndSalary)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Salary: {kvp.Value:F2}");
                    Console.WriteLine("====================");
                }
            }

            if (line.Equals("Age"))
            {
                foreach (var kvp in nameAndAge)
                {
                    Console.WriteLine($"Name: {kvp.Key}");
                    Console.WriteLine($"Age: {kvp.Value}");
                    Console.WriteLine("====================");
                }
            }

            //Console.ReadKey();
        }
    }
}
