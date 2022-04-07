using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SofaAppen.ViewModels
{
    public class HistoryPageViewModel : BaseViewModel
    {

        public HistoryPageViewModel()
        {
            Title = "KBH Zoo Historie";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}
