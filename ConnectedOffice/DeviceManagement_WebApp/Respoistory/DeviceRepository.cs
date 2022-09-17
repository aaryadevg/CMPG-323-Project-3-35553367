using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DeviceManagement_WebApp.Respoistory
{
	public class DeviceRepository : BaseRepository<Device>, IDeviceRepository
	{
		public DeviceRepository(ConnectedOfficeContext ctx) : base(ctx)
		{
		}

		public Device GetDetails(Guid id)
		{
			return _ctx.Device
				.Include(d => d.Category)
				.Include(d => d.Zone)
				.FirstOrDefault(m => m.DeviceId == id);
		}
	}
}
