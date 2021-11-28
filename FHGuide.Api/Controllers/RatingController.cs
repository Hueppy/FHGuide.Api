using Microsoft.AspNetCore.Mvc;
using FHGuide.Shared.Models;
using FHGuide.Shared.Contexts;

namespace FHGuide.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class RatingController : ControllerBase
{
	private readonly FHGuideContext DbContext;

    public RatingController(FHGuideContext dbContext)
    {
		this.DbContext = dbContext;
    }

	/// <summary>
	/// Get all ratings
	/// </summary>
	[HttpGet]
	public IEnumerable<Rating> Get()
	{
		// TODO: Implement this
		return Enumerable.Empty<Rating>();
	}

	/// <summary>
	/// Create new rating
	/// </summary>
	[HttpPost]
	public void Post(Rating rating)
	{
		// TODO: Implement this
	}

	/// <summary>
	/// Update rating with specified id
	/// </summary>
	[HttpPatch("{id}")]
	public void Patch(int id, Rating rating)
	{
		// TODO: Implement this
	}

	/// <summary>
	/// Delete rating with specified id
	/// </summary>
	[HttpDelete("{id}")]
	public void Delete(int id)
	{
		// TODO: Implement this
	}
}
