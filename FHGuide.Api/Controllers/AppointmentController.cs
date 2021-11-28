using Microsoft.AspNetCore.Mvc;
using FHGuide.Shared.Models;

namespace FHGuide.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AppointmentController : ControllerBase
{
	/// <summary>
	/// Get all appointments
	/// </summary>
	[HttpGet]
	public IEnumerable<Appointment> Get()
	{
		// TODO: Implement this
		return Enumerable.Empty<Appointment>();
	}

	/// <summary>
	/// Create a new appointment
	/// </summary>
	[HttpPost]
	public void Post(Appointment appointment)
	{
		// TODO: Implement this
	}

	/// <summary>
	/// Update appointment with specified id
	/// </summary>
	[HttpPatch("{id}")]
	public void Patch(int id, Appointment appointment)
	{
		// TODO: Implement this
	}

	/// <summary>
	/// Delete appointment with specified id
	/// </summary>
	[HttpDelete("{id}")]
	public void Delete(int id)
	{
		// TODO: Implement this
	}
}
