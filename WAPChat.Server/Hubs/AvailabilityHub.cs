using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WAPChat.Server.Hubs
{
    public class AvailabilityHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
    }
}