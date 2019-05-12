namespace StudentSystemCatalog
{
    using System;
    using StudentSystemCatalog.Commands;
    using StudentSystemCatalog.Students;

    public class Startup
    {
        public static void Main()
        {
            var commandParser = new CommandParser();
            var studentSystem = new StudentSystem();
            var engine = new Engine(commandParser, studentSystem, Console.ReadLine);

            engine.Run();
        }
    }
}
