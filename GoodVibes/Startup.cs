using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoodVibes.Startup))]
namespace GoodVibes
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.MapSignalR();
		}
	}
}
