namespace MtgApi.DTO;

public class LinkDTO
{
  public LinkDTO(string href, string rel, string type)
  {
    HRef = href;
    Rel = rel;
    Type = type;
  }
  public string HRef { get; private set; }
  public string Rel { get; private set; }
  public string Type { get; private set; }
}