using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Respoistory
{
	public class CategoriesRespository : BaseRepository<Category>
	{
		public CategoriesRespository(ConnectedOfficeContext ctx) : base(ctx)
		{
		}
	}
}
