using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogOfLegends.Models
{
  public class Game
  {
    public int Id { get; set; }
    public int Rank { get; set; }
    public int LP { get; set; }
    public string Score { get; set; }
    public string Result { get; set; }
    public string Champion { get; set; }
    public string Role { get; set; }
    public string Description { get; set; }

  }
}