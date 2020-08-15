using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WAPChat.Server.Hubs
{
    public class PresenceHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}