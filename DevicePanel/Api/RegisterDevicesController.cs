using DevicePanel.DAL.Interfaces;
using System.Web.Http;

namespace DevicePanel.Api
{
	[RoutePrefix("api/register")]
	public class RegisterDevicesController : ApiController
	{
		private readonly IDataRepository _dataRepository;
		
		public RegisterDevicesController(IDataRepository dataRepository)
		{
			_dataRepository = dataRepository;
		}


		[HttpPost]
		[AllowAnonymous]
		[Route("")]
		public IHttpActionResult Add(string device)
		{
			if (!string.IsNullOrEmpty(device))
			{
				return Ok(_dataRepository.RegisterDevice(device));
			}
			
			return BadRequest();
		}

	}
}