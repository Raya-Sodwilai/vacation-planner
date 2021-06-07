using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vacation.Models
{
  public class Event
  {
    // public Event()
    // {
    //   this.JoinEntities = new HashSet<EventCity>();
    // }
    public int ID { get; set; }
    [StringLength(450)]
    public string Location { get; set; }
    public int CityID { get; set; }
    public City city { get; set; }
  }
}