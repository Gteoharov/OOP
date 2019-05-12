namespace StudentSystemCatalog
{
    using StudentSystemCatalog.Commands;
    using StudentSystemCatalog.Data;
    using StudentSystemCatalog.Students;

    public class Startup
    {
        public static void Main()
        {
            var commandParser = new CommandParser();
            var studentSystem = new StudentSystem();
            var dataReader = new ConsoleDataReader();
            var dataWriter = new ConsoleDataWriter();
            var engine = new Engine(commandParser, studentSystem, dataReader, dataWriter);

            engine.Run();
        }
    }
}
