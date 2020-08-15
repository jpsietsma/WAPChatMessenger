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
        public string CurrentUser { get; set; }

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

            ViewModel = new ChatViewModel(CurrentUser);

            Window buddylist = new OnlineUsersWindow(CurrentUser);
            buddylist.Activate();
            buddylist.Show();

        }

        private void OnPromptClosed(object sender, WindowClosedEventArgs e)
        {
            if (e.PromptResult != null && e.PromptResult != string.Empty)
            {
                this.ViewModel = new ChatViewModel(e.PromptResult);
                this.DataContext = this.ViewModel;
                CurrentUser = e.PromptResult;
            }

        }
    }
}
