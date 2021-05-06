using DevicePanel.DAL.DomainModels.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevicePanel.DAL.DomainModels
{
	public static class DataContext
	{
		public static List<Device> LodedDevices { get; set; } = new List<Device>();
		public static List<Device> RegisteredDevices { get; set; } = new List<Device>();

	}
}
