using System;
using System.Collections.Generic;

namespace app.Models
{
    public class Card
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Team { get; set; }

        public Card(string n, string title, string team)
        {
            this.Name = n;
            this.Title = title;
            this.Team = team;
        }
    }
}