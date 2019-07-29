namespace PizzaCalories
{
    using System;

    public enum Question
    {
        Role = 2,
        ProjectFunding = 3,
        TotalEmployee = 4,
        NumberOfServers = 5,
        TopBusinessConcern = 6
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            string something = (string)Question.Role;
            Console.WriteLine(something);
        }
    }
}
