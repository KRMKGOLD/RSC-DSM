using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace APP {
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
        }

        private async void startButtonClicked(object sender, EventArgs e)
        {
            // Application.Current.MainPage = new NavigationPage(new GamePage());
            await Navigation.PushAsync(new GamePage());
        }

        private async void explainButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoPage());
        }

        private void exitButtonClicked(object sender, EventArgs e)
        {
            OnAlertYesNoClicked(sender, e);
        }

        async void OnAlertYesNoClicked(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("게임 종료?", "게임을 종료하시겠습니까?", "예", "아니오");
            if(answer == true)
            {
                Console.WriteLine("Exit");
                System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
            }
        }
    }
}
