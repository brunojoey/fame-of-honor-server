using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MediatR;
using AutoMapper;
using Persistence;

namespace Application.Players
{
  public class List
  {
    public class PlayerEnvelope
    {
      public static List<PlayersDto> Players { get; set; }
    }

    public class Query : IRequest<PlayerEnvelope>
    {
      public Query(int? limit, int? offset, string name, string position, int yearInducted, string yearsActive, string team, string notes, string ringHonorHistory)
      {
        Limit = limit;
        Offset = offset;
        Name = name;
        Position = position;
        YearInducted = yearInducted;
        YearsActive = yearsActive;
        Team = team;
        Notes = notes;
        RingHonorHistory = ringHonorHistory;
      }

      public int? Limit { get; set; }
      public int? Offset { get; set; }
      public string Name { get; set; }
      public string Position { get; set; }
      public int YearInducted { get; set; }
      public string YearsActive { get; set; }
      public string Team { get; set; }
      public string Notes { get; set; }
      public string RingHonorHistory { get; set; }
    }
    public class Handler : IRequestHandler<Query, PlayerEnvelope>
    {
      private readonly DataContext _context;
      private readonly IMapper _mapper;

      public Handler(DataContext context, IMapper mapper)
      {
        _mapper = mapper;
        _context = context;
      }

      public async Task<PlayerEnvelope> Handle(Query request, CancellationToken cancellationToken)
      {
        var queryable = _context.Players
          .Where(x => x.PlayerTeam == request.Team)
          .OrderBy(x => x.PlayerTeam)
          .AsQueryable();

        var players = await queryable
            .Skip(request.Offset ?? 0)
            .Take(request.Limit ?? 3).ToListAsync();

        return new PlayerEnvelope
        {
          Players = _mapper.Map<List<Domain.Players>, List<PlayersDto>>(players)
        };
      }
    }
  }
}