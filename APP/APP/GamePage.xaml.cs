using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace APP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePage : ContentPage
    {
        string[] rcs = new string[3] { "sci", "rock", "paper" };
        string cpuRes = null;
        int cpuIndex = 0;

        public GamePage ()
		{
			InitializeComponent ();
            setCpuIndex();
        }

        private void setCpuIndex()
        {
            Random r = new Random();
            cpuIndex = r.Next(0, 2);
            cpuRes = rcs[cpuIndex];
        }

        private void scissorsButtonClicked(object sender, EventArgs e)
        {
            if (cpuRes == "sci")
            {
                cpuImg.Source = "scissors.png";
                checkResultLabel.Text = "Draw.";
                // Draw
            }
            else if(cpuRes == "rock")
            {
                cpuImg.Source = "rock.png";
                checkResultLabel.Text = "Lose...";
                // Lose
            }
            else if(cpuRes == "paper")
            {
                cpuImg.Source = "paper.png";
                checkResultLabel.Text = "Win!";
                // Win
            }

            gotomainButton.IsVisible = true;
            regameButton.IsVisible = true;
            scissorsButton.IsVisible = false;
            rockButton.IsVisible = false;
            paperButton.IsVisible = false;

        }

        private void rockButtonClicked(object sender, EventArgs e)
        {
            if (cpuRes == "sci")
            {
                checkResultLabel.Text = "Win!";
                cpuImg.Source = "scissors.png";
                // Win
            }
            else if (cpuRes == "rock")
            {
                cpuImg.Source = "rock.png";
                checkResultLabel.Text = "Draw.";
                // Draw
            }
            else if (cpuRes == "paper")
            {
                cpuImg.Source = "paper.png";
                checkResultLabel.Text = "Lose...";
                // Lose
            }

            gotomainButton.IsVisible = true;
            regameButton.IsVisible = true;
            scissorsButton.IsVisible = false;
            rockButton.IsVisible = false;
            paperButton.IsVisible = false;

        }

        private void paperButtonClicked(object sender, EventArgs e)
        {
            if (cpuRes == "sci")
            {
                checkResultLabel.Text = "Lose...";
                cpuImg.Source = "scissors.png";
                // Lose
            }
            else if (cpuRes == "rock")
            {
                cpuImg.Source = "rock.png";
                checkResultLabel.Text = "Win!";
                // Win
            }
            else if (cpuRes == "paper")
            {
                cpuImg.Source = "paper.png";
                checkResultLabel.Text = "Draw.";
                // Draw
            }

            gotomainButton.IsVisible = true;
            regameButton.IsVisible = true;
            scissorsButton.IsVisible = false;
            rockButton.IsVisible = false;
            paperButton.IsVisible = false;

        }

        private async void gotomainButtonClicked(object sender, EventArgs e)
        {
            cpuIndex = 0;
            cpuRes = null;
            await Navigation.PushAsync(new MainPage());
            
        }

        private async void regameButtonClicked(object sender, EventArgs e)
        {
            cpuIndex = 0;
            cpuRes = null;
            await Navigation.PushAsync(new GamePage());
        }
    }
}