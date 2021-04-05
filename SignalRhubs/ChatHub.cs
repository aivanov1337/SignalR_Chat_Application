using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalR_Chat_Application.SignalRhubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
