using System.Runtime.CompilerServices;

namespace Helpers
{
	public class Logger
	{
        private readonly string _name;

        public Logger([CallerMemberName] string testName = "")
        {
            _name = testName;
            Print($"Test {_name} is started");
        }

        private void Print(string message)
        {
            Console.WriteLine($"{message}");
        }

        public void PrintStep([CallerMemberName] string operationName = "")
        {
            DateTime time = DateTime.Now;

            Print($"{time.Hour}:{time.Minute}:{time.Second}:{time.Millisecond} - {operationName} by {_name}");
        }

        public void PrintResponseCode(HttpResponseMessage response, [CallerMemberName] string operationName = "")
        {
            Print($"Response Code for {operationName} request is: {response.StatusCode} (test: {_name})");
        }
    }
}