using System;

namespace StudentSystemCatalog.Data
{
    public class ConsoleDataReader : IDataReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
