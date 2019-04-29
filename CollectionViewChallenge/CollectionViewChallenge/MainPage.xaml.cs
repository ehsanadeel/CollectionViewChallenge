using CollectionViewChallenge.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace CollectionViewChallenge
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            this.BindingContext = new WorldViewModel();
        }


    }

}
