using Microsoft.AspNetCore.Mvc;
using FHGuide.Shared.Models;
using FHGuide.Shared.Contexts;

namespace FHGuide.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CourseController : ControllerBase
{
	private readonly FHGuideContext DbContext;

    public CourseController(FHGuideContext dbContext)
    {
		this.DbContext = dbContext;
    }

	/// <summary>
	/// Get all courses
	/// </summary>
	[HttpGet]
	public IEnumerable<Course> Get()
	{
		// TODO: Implement this
		return Enumerable.Empty<Course>();
	}

	/// <summary>
	/// Get all appointments of course
	/// </summary>
	[HttpGet("{id}/appointment")]
	public IEnumerable<Appointment> GetAppointment(string id)
	{
		// TODO: Implement this
		return Enumerable.Empty<Appointment>();
	}

	/// <summary>
	/// Get all roadmap items of course
	/// </summary>
	[HttpGet("{id}/roadmap")]
	public IEnumerable<RoadmapItem> GetRoadmap(string id)
	{
		// TODO: Implement this
		return Enumerable.Empty<RoadmapItem>();
	}

	/// <summary>
	/// Get all schedules of course
	/// </summary>
	[HttpGet("{id}/schedule")]
	public IEnumerable<Schedule> GetSchedule(string id)
	{
		// TODO: Implement this
		return Enumerable.Empty<Schedule>();
	}

	/// <summary>
	/// Get zoom link of course
	/// </summary>
	[HttpGet("{id}/zoom")]
	public Zoom? GetZoom(string id)
	{
		return null;
	}

	/// <summary>
	/// Create a new course
	/// </summary>	
	[HttpPost]
	public void Post(Course course)
	{
		// TODO: Implement this
	}

	/// <summary>
	/// Update course with specified id
	/// </summary>
	[HttpPatch("{id}")]
	public void Patch(int id, Course course)
	{
		// TODO: Implement this
	}

	/// <summary>
	/// Delete course with specified id
	/// </summary>
	[HttpDelete("{id}")]
	public void Delete(int id)
	{
		// TODO: Implement this
	}
}
