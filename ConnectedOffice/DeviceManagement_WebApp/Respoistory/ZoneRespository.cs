using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Respoistory
{
	public class ZoneRespository : BaseRepository<Zone>
	{
		public ZoneRespository(ConnectedOfficeContext ctx) : base(ctx)
		{
		}
	}
}
