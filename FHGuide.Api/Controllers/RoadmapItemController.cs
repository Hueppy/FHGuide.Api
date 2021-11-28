using Microsoft.AspNetCore.Mvc;
using FHGuide.Shared.Models;
using FHGuide.Shared.Contexts;

namespace FHGuide.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class RoadmapItemController : ControllerBase
{
	private readonly FHGuideContext DbContext;

    public RoadmapItemController(FHGuideContext dbContext)
    {
		this.DbContext = dbContext;
    }

	/// <summary>
	/// Get all roadmap items
	/// </summary>
	[HttpGet]
	public IEnumerable<RoadmapItem> Get()
	{
		// TODO: Implement this
		return Enumerable.Empty<RoadmapItem>();
	}

	/// <summary>
	/// Create a new roadmap item
	/// </summary>
	[HttpPost]
	public void Post(RoadmapItem roadmapItem)
	{
		// TODO: Implement this
	}

	/// <summary>
	/// Update roadmap item with specified id
	/// </summary>
	[HttpPatch("{id}")]
	public void Patch(int id, RoadmapItem roadmapItem)
	{
		// TODO: Implement this
	}

	/// <summary>
	/// Delete roadmap item with specified id
	/// </summary>
	[HttpDelete("{id}")]
	public void Delete(int id)
	{
		// TODO: Implement this
	}
}
