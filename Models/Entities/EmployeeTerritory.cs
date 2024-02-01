using System.ComponentModel.DataAnnotations;

namespace Models.Entities;
public class EmployeeTerritory
{
    [Key]
    public int EmployeeId { get; set; }
    public string TerritoryId { get; set; }
    public Employee Employee { get; set; }
    public Territory Territory { get; set; }
}
