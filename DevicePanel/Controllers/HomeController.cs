using DevicePanel.DAL.DomainModels.Entities;
using DevicePanel.DAL.Interfaces;
using DevicePanel.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DevicePanel.Controllers
{
	public class HomeController : Controller
	{
		private readonly IDataRepository _dataRepository;

		public HomeController(IDataRepository dataRepository)
		{
			_dataRepository = dataRepository;
		}

		public ActionResult Index()
		{
			var loadedDevices = _dataRepository.LoadDevices();

			var veiewModel = new HomePageViewModel { Devices = loadedDevices };
			return View(veiewModel);
		}
	}
}