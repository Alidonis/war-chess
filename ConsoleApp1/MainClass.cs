using ConsoleApp1;
using System;

namespace ConsoleApp1
{
    internal class MainClass
    {
        private bool ShouldRun = true;
        public MainClass() {
            ReadUserInput();
        }
        public void ReadUserInput()
        {
            while (ShouldRun)
            {
                Console.Write("> ");
                var input = Console.ReadLine();
                HandleUserCommand(input);
            }
        }
        void HandleUserCommand(string? input)
        {
            if (input == "") { return; }
            switch (input)
            {
                case "local pvp":
                    break;
                case "exit":
                    ShouldRun = false;
                    break;
                default:
                    break;
            }
        }
    }
}

