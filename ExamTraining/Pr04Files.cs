using System.Linq;

namespace Pr04Files
{
    using System;
    using System.Collections.Generic;
    
    public class Pr04Files
    {
        public static void Main()
        {
          
            var filesCount = int.Parse(Console.ReadLine());
           
            var files = new List<File>();

            for (int i = 0; i < filesCount; i++)
            {
                var filesInput = Console.ReadLine().Split(new string[] {@"\"}, StringSplitOptions.None).ToList();
                
                File file = new File();
                
                file.Root = filesInput[0];

                var fileParameters = filesInput.Last().Split(';');
                
                var fileName = files.FirstOrDefault(f => f.Name.Equals(fileParameters[0]));
                
                file.Name = fileParameters[0];
                file.Size = long.Parse(fileParameters[1]);
            
                files.Add(file);
            }

            var queryString = Console.ReadLine().Split();
            var queryRoot = queryString[2];
            var queryExtension = queryString[0];

            var result = new Dictionary<string, long>();
            
            foreach (var file in files)
            {
                if (file.Root.Equals(queryRoot) && file.Name.EndsWith(queryExtension))
                {
                    result[file.Name] = file.Size;
                }
              
            }
            
            if (result.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var file in result.OrderByDescending(s => s.Value).ThenBy(n => n.Key))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }
        }
    }

    public class File
    {
        public string Root { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
    }
}