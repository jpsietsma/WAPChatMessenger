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
        public string IconPath { 
            get {

                switch (UserAvailabilityStatus)
                {
                    case UserAvailability.AVAILABLE:
                        return @"/Images/OnlineUser_GreenCircle.png";
                    case UserAvailability.AWAY:
                        return @"/Images/AwayUser_YellowCircle.png";
                    case UserAvailability.BUSY:
                        return @"/Images/BusyUser_RedCircle.png";
                    default:
                        return null;
                }

            }
        }       

        public enum UserAvailability { AVAILABLE = 0, AWAY = 1, BUSY = 2, OFFLINE = 3 }
    }
}
