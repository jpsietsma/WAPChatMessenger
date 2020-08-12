using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WAPChat.WindowsClient.Screens;
using WAPChat.WindowsClient.ViewModels;

namespace WAPChat.WindowsClient
{
    /// <summary>
    /// Interaction logic for OnlineUsersWindow.xaml
    /// </summary>
    public partial class OnlineUsersWindow : Window
    {
        private List<UserListItemViewModel> AllUsers;

        public OnlineUsersWindow()
        {
            InitializeComponent();

            AllUsers = new List<UserListItemViewModel> {
                new UserListItemViewModel
                {
                    UserName = "Amy Faulkner",
                    UserAvailabilityStatus = UserListItemViewModel.UserAvailability.AWAY,
                    UserProfileThumb = "~/Images/Users/John.jpg"
                },
                new UserListItemViewModel
                {
                    UserName = "Ben Green",
                    UserAvailabilityStatus = UserListItemViewModel.UserAvailability.BUSY,
                    UserProfileThumb = "~/Images/Users/BenGreen.jpg"
                },
                new UserListItemViewModel
                {
                    UserName = "Ben Hendee",
                    UserAvailabilityStatus = UserListItemViewModel.UserAvailability.AVAILABLE,
                    UserProfileThumb = "~/Images/Users/BenHendee.jpg"
                },
                new UserListItemViewModel
                {
                    UserName = "Craig Cashman",
                    UserAvailabilityStatus = UserListItemViewModel.UserAvailability.AVAILABLE,
                    UserProfileThumb = "~/Images/Users/CraigCashman.jpg"
                },
                new UserListItemViewModel
                {
                    UserName = "John Jackson",
                    UserAvailabilityStatus = UserListItemViewModel.UserAvailability.AVAILABLE,
                    UserProfileThumb = "~/Images/Users/JohnJackson.jpg"
                },
                new UserListItemViewModel
                {
                    UserName = "Nadine Trahan",
                    UserAvailabilityStatus = UserListItemViewModel.UserAvailability.AVAILABLE,
                    UserProfileThumb = "~/Images/Users/NadineTrahan.jpg"
                },
                new UserListItemViewModel
                {
                    UserName = "Nate Townsend",
                    UserAvailabilityStatus = UserListItemViewModel.UserAvailability.AVAILABLE,
                    UserProfileThumb = "~/Images/Users/NateTownsend.jpg"
                },
                new UserListItemViewModel
                {
                    UserName = "Pete Steenland",
                    UserAvailabilityStatus = UserListItemViewModel.UserAvailability.AVAILABLE,
                    UserProfileThumb = "~/Images/Users/PeteSteenland.jpg"
                },
                new UserListItemViewModel
                {
                    UserName = "Rich Toby",
                    UserAvailabilityStatus = UserListItemViewModel.UserAvailability.AVAILABLE,
                    UserProfileThumb = "~/Images/Users/RichToby.jpg"
                },
                new UserListItemViewModel
                {
                    UserName = "Suzie Seymour",
                    UserAvailabilityStatus = UserListItemViewModel.UserAvailability.AVAILABLE,
                    UserProfileThumb = "~/Images/Users/SuzieSeymour.jpg"
                }
            };

            OnlineUsers_Listbox.ItemsSource = AllUsers;
        }

        private void Logout_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void NewMessage_Button_Click(object sender, RoutedEventArgs e)
        {
            Window newMessage = new ChatMessageWindow("John Jackson");
            newMessage.Activate();
        }

        private void FileTransfer_Button_Click(object sender, RoutedEventArgs e)
        {
            Window newFileTransfer = new FileTransferWindow();
            newFileTransfer.Activate();
        }
    }
}
