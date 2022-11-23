using Microsoft.AspNetCore.SignalR;

namespace BlazorChatSignalR.Server.Hubs
{
    public class ChatHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await SendMessageAsync("", "User connected!");
            await base.OnConnectedAsync();
        }

        public async Task SendMessageAsync(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
