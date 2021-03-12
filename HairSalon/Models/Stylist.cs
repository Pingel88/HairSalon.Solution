using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Category
  {
    public Category()
    {
      this.Clients = new HashSet<Client>();
    }

    public int StylistId { get; set; }
    public string Name { get; set; }
    public string HireDate { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}