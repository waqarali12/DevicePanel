using DevicePanel.DAL.DomainModels.Entities;
using System;
using System.Collections.Generic;

namespace DevicePanel.Models
{
	public class HomePageViewModel
	{
		public IEnumerable<Device> Devices { get; set; }
	}
}