namespace Notifications
{
    using System;
    class Notificaitons
    {
        static void Main(string[] args)
        {
            var numberOfReports = int.Parse(Console.ReadLine());

            var result = string.Empty;
            var operation = string.Empty;
            var message = string.Empty;
            var reason = string.Empty;
            var code = 0;

            for (int i = 0; i < numberOfReports; i++)
            {
                result = Console.ReadLine();

                if (result.Equals("success"))
                {
                    operation = Console.ReadLine();
                    message = Console.ReadLine();

                    ShowSuccess(operation, message);
                }

                if (result.Equals("error"))
                {
                    operation = Console.ReadLine();
                    code = int.Parse(Console.ReadLine());

                    ShowError(operation, code, reason);
                }
            }


            Console.ReadKey();
        }

        static string ShowSuccess(string operation, string message)
        {
            var report = $"Successfully executed {operation}.\r\n==============================\r\nMessage: { message}.";

            Console.WriteLine(report);

            return report;
        }
        static string ShowError(string operation, int code, string reason)
        {
            if (code > 0)
            {
                reason = "Invalid Client Data";
            }

            else
            {
                reason = "Internal System Failure";
            }

            var report = $"Error: Failed to execute {operation}.\r\n==============================\r\nError Code: {code}.\r\nReason: {reason}.";

            Console.WriteLine(report);

            return report; 
        }
    }
}
