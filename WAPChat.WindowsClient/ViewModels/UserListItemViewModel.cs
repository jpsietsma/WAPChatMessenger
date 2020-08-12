using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAPChat.WindowsClient.ViewModels
{
    public class UserListItemViewModel
    {
        public string UserName { get; set; }
        public string UserProfileThumb { get; set; }
        public UserAvailability UserAvailabilityStatus { get; set; }
        public enum UserAvailability { AVAILABLE = 0, AWAY = 1, BUSY = 2, OFFLINE = 3 }
    }
}
