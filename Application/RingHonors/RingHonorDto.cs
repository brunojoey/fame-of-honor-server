using System.Collections.Generic;
using Application.Players;
using Application.Teams;

namespace Application.RingHonors
{
    public class RingHonorDto
    {
        // Data Transfer Object to move data between networks
        // Similar to the initial class Created for each Class of a DTO
        public string History { get; set; } // Ring of Honor history
        public ICollection<PlayersDto> Players { get; set; }
        public ICollection<TeamsDto> Teams { get; set; }

    }
}