using DevicePanel.DAL.DomainModels.Entities;
using System.Collections.Generic;

namespace DevicePanel.DAL.Interfaces
{
	public interface IDataRepository
	{
		IEnumerable<Device> LoadDevices();
		IEnumerable<Device> RegisterDevice(string newDevice);
	}
}