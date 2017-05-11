using Microsoft.AspNet.SignalR;

namespace API.GoodVibes.Hubs
{
	public class CrudHub : Hub
	{
		public void Send(string name, string message)
		{
			// Call the broadcastMessage method to update clients.
			Clients.All.broadcastMessage(name, message);
		}
	}
}