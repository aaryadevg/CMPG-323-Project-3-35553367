using DeviceManagement_WebApp.Models;
using System;

namespace DeviceManagement_WebApp.Respoistory
{
	public interface IDeviceRepository : IBaseRepository<Device>
	{
		Device GetDetails(Guid id);
	}
}
