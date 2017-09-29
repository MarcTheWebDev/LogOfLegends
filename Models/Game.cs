using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogOfLegends.Models
{
  public class Game
  {
    public int Id { get; set; }
    [Required]
    public string League { get; set; }
    public string Division { get; set; }
    [Range(-100,100)]
    public int LP { get; set; }
    [Required]
    public string Score { get; set; }
    [Required]
    public bool wasWin { get; set; }
    [Required]
    public string Champion { get; set; }
    [Required]
    public string Role { get; set; }
    [StringLength(500)]
    [Required]
    public string Description { get; set; }
    public DateTime DateEntered { get; set; }

  }
}