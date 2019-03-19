using System.Windows.Input;
using Xamarin.Forms;

namespace EventToCommand.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand EntryFocusedCommand { get; private set; }
        public ICommand EntryTextChangedCommand { get; private set; }

        public MainViewModel()
        {
            EntryFocusedCommand = new Command(FocusedAlert);
            EntryTextChangedCommand = new Command(TextChangedAlert);
        }


        private void FocusedAlert()
        {
            MessagingCenter.Send(this, "Focused");
        }

        private void TextChangedAlert()
        {
            MessagingCenter.Send(this, "TextChanged");
        }
    }
}
