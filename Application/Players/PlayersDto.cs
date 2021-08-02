using System;
using System.Collections.Generic;
using Application.Teams;

namespace Application.Players
{
    public class PlayersDto
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Notes { get; set; }
        public int YearInducted { get; set; }
        public string YearsActive { get; set; }
        public ICollection<TeamsDto> Teams { get; set; }

    }
}