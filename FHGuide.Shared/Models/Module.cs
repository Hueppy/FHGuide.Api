namespace FHGuide.Shared.Models;

public partial class Module
{
    public Module()
    {
        Courses = new HashSet<Course>();
        Faqs = new HashSet<Faq>();
        Ratings = new HashSet<Rating>();
    }

    public int ModuleId { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public sbyte Active { get; set; }
    public string? Dependencies { get; set; }
    public string? Tags { get; set; }

    public virtual ICollection<Course> Courses { get; set; }
    public virtual ICollection<Faq> Faqs { get; set; }
    public virtual ICollection<Rating> Ratings { get; set; }
}
