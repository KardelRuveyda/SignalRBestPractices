﻿using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRExample.Hubs
{
    public class MyHub:Hub
    {
        public async Task SendMessageAsync(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
