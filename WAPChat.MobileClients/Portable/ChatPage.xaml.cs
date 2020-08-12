using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAPChat.MobileClients.Portable.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WAPChat.MobileClients.Portable
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatPage : ContentPage
    {
        public ChatViewModel ViewModel { get; }

        public ChatPage()
        {
        }

        public ChatPage(string UserName)
        {
            InitializeComponent();
            this.ViewModel = new ChatViewModel(UserName);
            this.BindingContext = this.ViewModel;
        }

        private void chat_SendMessage(object sender, EventArgs e)
        {
            this.ViewModel.CurrentMessage = chat.Message.ToString();

            this.ViewModel.SendCurrentMessage();
        }
    }
}