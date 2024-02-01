namespace Models.Entities;
public class Territory
{
    public Territory()
    {
        EmployeeTerritories = new HashSet<EmployeeTerritory>();
    }
    public string TerritoryID { get; set; }
    public string TerritoryDescription { get; set; }
    public int RegionId { get; set; }

    public Region Region { get; set; }
    public ICollection<EmployeeTerritory> EmployeeTerritories { get; private set; }
}
