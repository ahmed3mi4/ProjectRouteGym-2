namespace ProjectRouteGym.Models.Plans;

public class Plan
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public int DurationDays { get; set; }
    public string Description { get; set; } = null!;

    public bool IsActive { get; set; }    
    public DateTime? CreatedAt { get; set; } 
}
