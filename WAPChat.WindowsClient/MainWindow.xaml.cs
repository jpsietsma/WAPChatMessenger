using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.ConversationalUI;
using WAPChat.WindowsClient.ViewModels;

namespace WAPChat.WindowsClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ChatViewModel ViewModel { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            //TODO: Replace this with login logic later on
            RadWindow.Prompt(new DialogParameters
            {
                Content = "Enter a User Name:",
                Closed = new EventHandler<WindowClosedEventArgs>(OnPromptClosed)
            });

            Window buddylist = new OnlineUsersWindow();
            buddylist.Activate();
            buddylist.Show();

        }

        private void OnPromptClosed(object sender, WindowClosedEventArgs e)
        {
            if (e.PromptResult != null && e.PromptResult != string.Empty)
            {
                this.ViewModel = new ChatViewModel(e.PromptResult);
                this.DataContext = this.ViewModel;
                this.myChat.CurrentAuthor = this.ViewModel.CurrentAuthor;
            }

        }

        private void RadChat_SendMessage(object sender, SendMessageEventArgs e)
        {
            this.ViewModel.CurrentMessage = e.Message as TextMessage;

            this.ViewModel.SendCurrentMessage();
        }
    }
}
