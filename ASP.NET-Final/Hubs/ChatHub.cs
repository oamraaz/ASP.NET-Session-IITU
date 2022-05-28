using ASP.NET_Final.Models;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ASP.NET_Final.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(Message message) => await Clients.All.SendAsync("receiveMessage", message);
    }
}
