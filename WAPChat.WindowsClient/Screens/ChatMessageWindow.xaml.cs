using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.ConversationalUI;
using WAPChat.WindowsClient.ViewModels;

namespace WAPChat.WindowsClient.Screens
{
    /// <summary>
    /// Interaction logic for ChatMessageWindow.xaml
    /// </summary>
    public partial class ChatMessageWindow : Window
    {
        public ChatViewModel ViewModel { get; set; }

        public ChatMessageWindow()
        {
            InitializeComponent();

            Title = $@"Announcement from {ViewModel.CurrentAuthor} | WAPChat Global Message";
        }

        public ChatMessageWindow(string recipient)
        {
            InitializeComponent();

            Title = $@"{ViewModel.CurrentRecipient} | WAPChat Private Instant Message";
            this.ViewModel.CurrentRecipient = new Author(recipient);
        }

        private void OnPromptClosed(object sender, WindowClosedEventArgs e)
        {
            if (e.PromptResult != null && e.PromptResult != string.Empty)
            {
                this.ViewModel = new ChatViewModel(e.PromptResult);
                this.DataContext = this.ViewModel;
                this.myChat.CurrentAuthor = this.ViewModel.CurrentAuthor;
            }
            else
            {
                throw new Exception("Username cannot be empty");
            }

        }

        private void RadChat_SendMessage(object sender, SendMessageEventArgs e)
        {
            var vm = this.ViewModel;

            vm.CurrentMessage = e.Message as TextMessage;

            //Only send the message to the intended recipient if provided, otherwise globally broadcast it
            if (vm.CurrentRecipient.Name == null)
            {
                vm.SendCurrentMessage();
            }
            else
            {
                vm.SendCurrentMessage(vm.CurrentRecipient.Name);
            }
        }
    }
}
