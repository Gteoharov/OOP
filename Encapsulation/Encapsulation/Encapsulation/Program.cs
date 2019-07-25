namespace Encapsulation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainClass
    {
        public static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var peoples = new List<Person>();
            var newPlayer = new Person("Daniel", "Gerdjikov", 31, 4000);
            var newPlayer2 = new Person("Daniel", "Gerdjikov", 31, 4000);
            var newPlayer3 = new Person("Daniel", "Gerdjikov", 31, 4000);
            var newPlayer4 = new Person("Daniel", "Gerdjikov", 31, 4000);
            var newPlayer5 = new Person("Daniel", "Gerdjikov", 31, 4000);
            var team = new Team("Daniels Team");

            team.AddPlayer(newPlayer);
            team.AddPlayer(newPlayer2);




            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var firstName = cmdArgs[0];
                var lastName = cmdArgs[1];
                var age = int.Parse(cmdArgs[2]);
                var salary = decimal.Parse(cmdArgs[3]);

                var person = new Person(firstName, lastName, age, salary);
                peoples.Add(person);
            }

            var sorted = peoples.OrderBy(x => x.FirstName).ThenBy(x => x.Age).ToList();

            for (int i = 0; i < sorted.Count; i++)
            {
                Console.WriteLine(sorted[i]);
            }
        }
    }
}
