using EventToCommand.ViewModels;
using Xamarin.Forms;

namespace EventToCommand
{
    public partial class MainPage : ContentPage
    {
        private MainViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new MainViewModel();
            RegisterMesssages();
        }

        private void RegisterMesssages()
        {
            MessagingCenter.Subscribe<MainViewModel>(this, "Focused", (m) =>
            {
                if (m != null)
                {
                    DisplayAlert("Bindable Event", "Entry Focused.", "OK");
                }
            });

            MessagingCenter.Subscribe<MainViewModel>(this, "TextChanged", (m) =>
            {
                if (m != null)
                {
                    DisplayAlert("Bindable Event", "Text Changed.", "OK");
                }
            });
        }


    }
}
