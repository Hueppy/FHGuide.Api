using Microsoft.AspNetCore.Mvc;
using FHGuide.Shared.Models;
using FHGuide.Shared.Contexts;

namespace FHGuide.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
	private readonly FHGuideContext dbContext;

    public AccountController(FHGuideContext dbContext)
    {
		this.dbContext = dbContext;
    }

	/// <summary>
	/// Get all accounts
	/// </summary>
	[HttpGet]
	public IEnumerable<Account> Get()
	{
		return this.dbContext.Accounts;
	}

	/// <summary>
	/// Get account with specified id
	/// </summary>
	/// <response code="404">Account could not be found</response>
	[HttpGet("{id}")]
	public async Task<ActionResult<Account>> Get(int id)
	{
		var item = await this.dbContext.Accounts.FindAsync(id);

		if (item == null)
		{
			return NotFound();
		}

		return item;
	}

	/// <summary>
	/// Get schedule for account
	/// </summary>
	/// <response code="404">Account could not be found</response>
	[HttpGet("{id}/schedule")]
	public async Task<ActionResult<IEnumerable<Schedule>>> GetSchedule(int id)
	{
		var item = await this.dbContext.Accounts.FindAsync(id);

		if (item == null)
		{
			return NotFound();
		}

		return Ok(this.dbContext.Schedules.Where((x) => x.AccountId == id));
	}

	/// <summary>
	/// Create new account
	/// </summary>
	[HttpPost]
	public async Task Post(Account account)
	{
		await this.dbContext.Accounts.AddAsync(account);
		await this.dbContext.SaveChangesAsync();
	}

	/// <summary>
	/// Update account with specified id
	/// </summary>
	[HttpPatch("{id}")]
	public async Task Patch(int id, Account account)
	{
		account.AccountId = id;
		this.dbContext.Accounts.Update(account);
		await this.dbContext.SaveChangesAsync();
	}

	/// <summary>
	/// Deletes account with specified id
	/// </summary>
	[HttpDelete("{id}")]
	public async Task<ActionResult> Delete(int id)
	{
		var item = await this.dbContext.Accounts.FindAsync(id);

		if (item == null)
		{
			return NotFound();
		}

		this.dbContext.Accounts.Remove(item);
        await this.dbContext.SaveChangesAsync();
		return Ok();
	}
}
