using Microsoft.AspNetCore.Mvc;
using MtgApi.DTO;

namespace MtgApi.Controllers;

[ApiController]
[Route("/[controller]")]
public class CardsController : ControllerBase
{
  private readonly List<Card> CurrentCards = new() {
    new() {
      CardName = "Atraxa",
      CardType = "Creature",
      ColorIdentity ="Black",
      SubType ="Phyrexian"
    },
    new() {
      CardName = "Brago, The Ethernal",
      CardType = "Creature",
      ColorIdentity = "Blue",
      SubType = "Spirit"
    }
  };

  [HttpGet(Name = "GetCurrentCards")]
  public RestDTO<List<Card>> Get()
  {
    return new()
    {
      Links = new(){
        new( "href", "self", "GET" ),
        new( "href", "self", "POST" ),
        new( "href", "self", "PUT" ),
        new( "href", "self", "DELETE" ),
      },
      Data = CurrentCards
    };
  }
}