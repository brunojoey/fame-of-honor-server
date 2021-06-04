using System;

namespace Domain
{
  public class Players
  {
    public string Name { get; set; }
    public string Position { get; set; }
    public string? Notes { get; set; }
    public DateTime YearInducted { get; set; }
    public DateTime YearsActive { get; set; }
    public virtual? Teams Team { get; set; }
  }
}