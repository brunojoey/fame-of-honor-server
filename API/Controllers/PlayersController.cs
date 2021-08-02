using Application.Players;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
  public class PlayersController
  {
    // get all Players
    [HttpGet]

    public async Task<ActionResult<List.PlayerEnvelope>> List(int? limit, int? offset, string name, string position, int yearInducted, string yearsActive, string team, string notes, string ringHonorHistory)
    {
      return await Mediator.Send(new List.Query(limit, offset, name, position, yearInducted, yearsActive, team, notes, ringHonorHistory));
    }
  }
}