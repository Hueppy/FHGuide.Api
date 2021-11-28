using Microsoft.AspNetCore.Mvc;
using FHGuide.Shared.Models;
using FHGuide.Shared.Contexts;

namespace FHGuide.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
	private readonly FHGuideContext DbContext;

    public AccountController(FHGuideContext dbContext)
    {
		this.DbContext = dbContext;
    }

	/// <summary>
	/// Get all accounts
	/// </summary>
	[HttpGet]
	public IEnumerable<Account> Get()
	{
		// TODO: Implement this
		return Enumerable.Empty<Account>();
	}

	/// <summary>
	/// Get account with specified id
	/// </summary>
	[HttpGet("{id}")]
	public Account? Get(int id)
	{
		// TODO: Implement this
		return null;
	}

	/// <summary>
	/// Get schedule for account
	/// </summary>
	[HttpGet("{id}/schedule")]
	public IEnumerable<Schedule> GetSchedule(int id)
	{
		// TODO: Implement this
		return Enumerable.Empty<Schedule>();
	}

	/// <summary>
	/// Create new account
	/// </summary>
	[HttpPost]
	public void Post(Account account)
	{
		// TODO: Implement this
	}

	/// <summary>
	/// Update account with specified id
	/// </summary>
	[HttpPatch("{id}")]
	public void Patch(int id, Account account)
	{
		// TODO: Implement this
	}

	/// <summary>
	/// Deletes account with specified id
	/// </summary>
	[HttpDelete("{id}")]
	public void Delete(int id)
	{
		// TODO: Implement this
	}
}
