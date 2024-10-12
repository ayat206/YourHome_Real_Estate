using System.ComponentModel.DataAnnotations;

namespace Domain_Models;

public partial class Choise
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string Choise1 { get; set; } = null!;


    public virtual ICollection<Property> Properties { get; set; } = new List<Property>();
}
