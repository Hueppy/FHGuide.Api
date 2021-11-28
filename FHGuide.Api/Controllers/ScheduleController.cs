using Microsoft.AspNetCore.Mvc;
using FHGuide.Shared.Models;
using FHGuide.Shared.Contexts;

namespace FHGuide.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ScheduleController : ControllerBase
{
	private readonly FHGuideContext DbContext;

    public ScheduleController(FHGuideContext dbContext)
    {
		this.DbContext = dbContext;
    }

	/// <summary>
	/// Get all schedules
	/// </summary>
	[HttpGet]
	public IEnumerable<Schedule> Get()
	{
		// TODO: Implement this
		return Enumerable.Empty<Schedule>();
	}

	/// <summary>
	/// Create a new schedule
	/// </summary>
	[HttpPost]
	public void Post(Schedule schedule)
	{
		// TODO: Implement this
	}

	/// <summary>
	/// Update schedule with specified id
	/// </summary>
	[HttpPatch("{id}")]
	public void Patch(int id, Schedule schedule)
	{
		// TODO: Implement this
	}

	/// <summary>
	/// Delete schedule with specified id
	/// </summary>
	[HttpDelete("{id}")]
	public void Delete(int id)
	{
		// TODO: Implement this
	}
}
