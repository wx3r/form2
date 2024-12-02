using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace form.ViewModel
{
    public partial class PersonViewModel : ObservableObject
    {
        [ObservableProperty]
        private string imieINazwisko;

        [ObservableProperty]
        private int wiek;

        [ObservableProperty]
        private string adres;

        [ObservableProperty]
        private string kontakt;

        public ICommand ZapiszCommand { get; }

        public PersonViewModel()
        {
            ZapiszCommand = new RelayCommand(Zapisz);
        }
    }
}
