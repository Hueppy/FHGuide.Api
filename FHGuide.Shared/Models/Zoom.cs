namespace FHGuide.Shared.Models;

public partial class Zoom
{
    public Zoom()
    {
        Courses = new HashSet<Course>();
    }

    public int ZoomId { get; set; }
    public string? Password { get; set; }
    public string? Link { get; set; }
    public int CourseId { get; set; }

    public virtual Course Course { get; set; } = null!;
    public virtual ICollection<Course> Courses { get; set; }
}
