using Microsoft.AspNetCore.Mvc;
using FHGuide.Shared.Models;
using FHGuide.Shared.Contexts;

namespace FHGuide.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ModuleController : ControllerBase
{
	private readonly FHGuideContext DbContext;

    public ModuleController(FHGuideContext dbContext)
    {
		this.DbContext = dbContext;
    }

	/// <summary>
	/// Get all modules
	/// </summary>
	[HttpGet]
	public IEnumerable<Module> Get()
	{
		// TODO: Implement this
		return Enumerable.Empty<Module>();
	}

	/// <summary>
	/// Get Faq of module
	/// </summary>
	[HttpGet("{id}/faq")]
	public IEnumerable<Faq> GetFaq(string id)
	{
		// TODO: Implement this
		return Enumerable.Empty<Faq>();		
	}

	/// <summary>
	/// Get ratings of module
	/// </summary>
	[HttpGet("{id}/rating")]
	public IEnumerable<Rating> GetRating(string id)
	{
		// TODO: Implement this
		return Enumerable.Empty<Rating>();		
	}

	/// <summary>
	/// Get courses of module
	/// </summary>
	[HttpGet("{id}/course")]
	public IEnumerable<Course> GetCourse(string id)
	{
		// TODO: Implement this
		return Enumerable.Empty<Course>();		
	}

	/// <summary>
	/// Create a new module
	/// </summary>
	[HttpPost]
	public void Post(Module module)
	{
		// TODO: Implement this
	}

	/// <summary>
	/// Update module with specified id
	/// </summary>
	[HttpPatch("{id}")]
	public void Patch(int id, Module module)
	{
		// TODO: Implement this
	}

	/// <summary>
	/// Delete module with specified id
	/// </summary>
	[HttpDelete("{id}")]
	public void Delete(int id)
	{
		// TODO: Implement this
	}
}
