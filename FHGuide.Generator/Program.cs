using FHGuide.Shared.Contexts;
using FHGuide.Shared.Models;

using GenFu;
using Microsoft.EntityFrameworkCore;

var random = new Random();
var context = new FHGuideContext();

void Generate<T>(DbSet<T> set, int count = 25)
	where T : class, new()
{
	var list = A.ListOf<T>(count);
	set.AddRange(list);
}

GenFu.GenFu.Configure<Account>()
	.Fill(x => x.AccountId, 0);
GenFu.GenFu.Configure<Module>()
	.Fill(x => x.ModuleId, 0);

Generate(context.Accounts);
Generate(context.Modules);

context.SaveChanges();

var accountIds = new List<int>(context.Accounts.Select(x => x.AccountId));
var moduleIds = new List<int>(context.Modules.Select(x => x.ModuleId));

GenFu.GenFu.Configure<Faq>()
	.Fill(x => x.FaqId, 0)
	.Fill(x => x.AccountId).WithRandom(accountIds)
	.Fill(x => x.ModuleId).WithRandom(moduleIds);

GenFu.GenFu.Configure<Rating>()
	.Fill(x => x.RatingId, 0)
	.Fill(x => x.AccountId).WithRandom(accountIds)
	.Fill(x => x.ModuleId).WithRandom(moduleIds);

GenFu.GenFu.Configure<Course>()
	.Fill(x => x.CourseId, 0)
	.Fill(x => x.ModuleId).WithRandom(moduleIds)
    .Fill(x => x.ZoomId, (int?)null)
	.Fill(x => x.Room, () => random.Next(0, 9999).ToString());

GenFu.GenFu.Configure<Schedule>()
	.Fill(x => x.ScheduleId, 0)
	.Fill(x => x.AccountId).WithRandom(accountIds);

Generate(context.Faqs, 50);
Generate(context.Ratings, 50);
Generate(context.Courses, 10);
Generate(context.Schedules, 50);

context.SaveChanges();

var ratingIds = new List<int>(context.Ratings.Select(x => x.RatingId));
var courseIds = new List<int>(context.Courses.Select(x => x.CourseId));
var scheduleIds = new List<int>(context.Schedules.Select(x => x.ScheduleId));

GenFu.GenFu.Configure<ScheduleCourse>()
	.Fill(x => x.CourseId).WithRandom(courseIds)
	.Fill(x => x.ScheduleId).WithRandom(scheduleIds);
GenFu.GenFu.Configure<Zoom>()
	.Fill(x => x.ZoomId, 0)
	.Fill(x => x.CourseId).WithRandom(courseIds);
GenFu.GenFu.Configure<Appointment>()
	.Fill(x => x.Appointmentid, 0)
	.Fill(x => x.CourseId).WithRandom(courseIds)
	.Fill(x => x.Day).WithRandom(new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" })
	.Fill(x => x.Start, () => $"{random.Next(0, 23)}:{random.Next(0, 59)}")
	.Fill(x => x.End, () => $"{random.Next(0, 23)}:{random.Next(0, 59)}");
GenFu.GenFu.Configure<RoadmapItem>()
	.Fill(x => x.RoadmapItemId, 0)
	.Fill(x => x.CourseId).WithRandom(courseIds)
	.Fill(x => x.Week, () => $"KW{random.Next(0, 52)}")
	.Fill(x => x.Style).WithRandom(new string[] {"Online", "Hybrid", "Präsenz"});
GenFu.GenFu.Configure<RatingValue>()
	.Fill(x => x.RatingValueId, 0)
	.Fill(x => x.RatingId).WithRandom(ratingIds);

//Generate(context.ScheduleCourses, 250);
Generate(context.Zooms, 100);
Generate(context.Appointments, 200);
Generate(context.Roadmapitems, 100);
Generate(context.Ratingvalues, 250);

context.SaveChanges();
