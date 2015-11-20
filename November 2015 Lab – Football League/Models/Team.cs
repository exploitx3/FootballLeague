using System;
using System.Collections.Generic;
using System.Linq;

namespace November_2015_Lab___Football_League.Models
{
    public class Team
    {
        private const int minimumFoundedYear = 1950;
        private string name;
        private string nickname;
        private DateTime dateFounded;
        private List<Player> players;

        private string CheckName(string name)
        {
            if (name.Length < 5)
            {
                throw new ArgumentException("Name and Nickname should have atleast 5 characters");
            }
            return name;
        }

        public string Name
        {
            get { return name; }
            set { name = CheckName(value); }
        }

        public string Nickname
        {
            get { return nickname; }
            set { nickname = CheckName(value); }
        }

        public DateTime DateFounded
        {
            get { return dateFounded; }
            set
            {
                if (value.Year.CompareTo(minimumFoundedYear) <= 0)
                {
                    throw new ArgumentException("The DateFounded’s year must be after " + minimumFoundedYear);
                }
                else
                {
                    this.dateFounded = value;
                }
            }
        }

        public List<Player> Players
        {
            get { return players; }
        }

        private bool CheckIfPlayerExists(Player player)
        {
            return this.players.Any(p => p.FirstName == player.FirstName && p.LastName == player.LastName);
        }
        public void AddPlayer(Player player)
        {
            if (CheckIfPlayerExists(player))
            {
                throw new InvalidOperationException("The Player already exists in the team.");
            }
            else
            {
                this.players.Add(player);
            }
        }
        public Team(string name, string nickname, DateTime dateFounded)
        {
            Name = name;
            Nickname = nickname;
            DateFounded = dateFounded;
            this.players = new List<Player>();
        }

        public override string ToString()
        {
            return this.name + "(" + this.nickname + ") - " + "Founded: " + this.dateFounded.ToShortDateString() +
                   "\nPlayers:\n" + String.Join("\n", this.players);
        }
    }
}