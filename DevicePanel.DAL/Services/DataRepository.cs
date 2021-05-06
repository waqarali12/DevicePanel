using DevicePanel.DAL.DomainModels;
using DevicePanel.DAL.DomainModels.Entities;
using DevicePanel.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevicePanel.DAL.Services
{
	public class DataRepository : IDataRepository
	{
		public IEnumerable<Device> RegisterDevice(string newDevice)
		{
			if (!string.IsNullOrEmpty(newDevice))
			{
				//TODO: filter for duplicates
				DataContext.RegisteredDevices.Add(MapToDeviceModel(newDevice));
			}

			return DataContext.RegisteredDevices;
		}

		public IEnumerable<Device> LoadDevices()
		{
			if (DataContext.RegisteredDevices.Any())
			{
				DataContext.LodedDevices.AddRange(DataContext.RegisteredDevices);
				DataContext.RegisteredDevices = new List<Device>();
			}

			return DataContext.LodedDevices;
		}

		private Device MapToDeviceModel(string device) => new Device { Name = device, Added = DateTime.Now };
	}
}
