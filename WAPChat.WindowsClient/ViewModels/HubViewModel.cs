using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;
using Telerik.Windows.Controls;

namespace WAPChat.WindowsClient.ViewModels
{
    public class HubViewModel : ViewModelBase
    {
        protected IHubProxy Proxy { get; set; }

        protected string url = "http://wapchat.sietsmadevelopment.com";

        protected HubConnection Connection { get; set; }

        public HubViewModel()
        {
            {
                this.Connection = new HubConnection(url);

                this.Proxy = Connection.CreateHubProxy("SampleHub");

                this.Connection.Start().Wait();
            }
        }
    }
}
