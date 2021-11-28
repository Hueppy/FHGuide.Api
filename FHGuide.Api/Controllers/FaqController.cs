using Microsoft.AspNetCore.Mvc;
using FHGuide.Shared.Models;
using FHGuide.Shared.Contexts;

namespace FHGuide.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class FaqController : ControllerBase
{
	private readonly FHGuideContext DbContext;

    public FaqController(FHGuideContext dbContext)
    {
		this.DbContext = dbContext;
    }

	/// <summary>
	/// Get all Faq
	/// </summary>
	[HttpGet]
	public IEnumerable<Faq> Get()
	{
		// TODO: Implement this
		return Enumerable.Empty<Faq>();
	}

	/// <summary>
	/// Add a question to Faq
	/// </summary>
	[HttpPost]
	public void Post(Faq faq)
	{
		// TODO: Implement this
	}

	/// <summary>
	/// Update question with specified id
	/// </summary>
	[HttpPatch("{id}")]
	public void Patch(int id, Faq faq)
	{
		// TODO: Implement this
	}

	/// <summary>
	/// Delete question with specified id
	/// </summary>
	[HttpDelete("{id}")]
	public void Delete(int id)
	{
		// TODO: Implement this
	}
}
