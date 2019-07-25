namespace Encapsulation
{
    using System;
    using System.Collections.Generic;

    public class Team
    {
        private List<Person> firstSquad;
        private List<Person> reserveSquad;

        public Team(string name)
        {
            this.Name = name;

            this.firstSquad = new List<Person>();
            this.reserveSquad = new List<Person>();
        }

        public string Name { get; private set; }

        public IReadOnlyList<Person> FirstTeam
        {
            get
            {
                return this.firstSquad.AsReadOnly();
            }
        }

        public IReadOnlyList<Person> ReserveSquad => this.reserveSquad.AsReadOnly();

        public void AddPlayer(Person player)
        {
            if (player == null)
            {
                throw new ArgumentException("Player is not found.");
            }

            if (player.Age < 40)
            {
                this.firstSquad.Add(player);
            }
            else
            {
                this.reserveSquad.Add(player);
            }
        }
    }
}
