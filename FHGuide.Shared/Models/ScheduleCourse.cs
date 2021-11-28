namespace FHGuide.Shared.Models;

public partial class ScheduleCourse
{
    public int ScheduleId { get; set; }
    public int CourseId { get; set; }

    public virtual Course Course { get; set; } = null!;
    public virtual Schedule Schedule { get; set; } = null!;
}
