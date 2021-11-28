namespace FHGuide.Shared.Models;

public partial class Schedule
{
    public int ScheduleId { get; set; }
    public DateOnly? ExpireDate { get; set; }
    public DateOnly CreateDate { get; set; }
    public int AccountId { get; set; }

    public virtual Account Account { get; set; } = null!;
}
