using Microsoft.AspNetCore.Mvc;

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
  public List<Card> Get()
  {
    return CurrentCards;
  }
}