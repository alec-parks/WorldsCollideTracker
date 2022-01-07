using System;
using System.Windows.Input;
using ReactiveUI;

namespace WorldsCollideTracker.ViewModels
{
    public class CheckViewModel : ViewModelBase
    {

        private bool _available;
        private string _name;

        public ICommand Click { get; }

        public CheckViewModel()
        {
            Click = ReactiveCommand.Create(() => Available = !Available);
        }

        public string Name
        {
            get => _name;
            set => this.RaiseAndSetIfChanged(ref _name, value);
        }
        public bool Available
        {
            get => _available;
            set
            {
                this.RaiseAndSetIfChanged(ref _available, value);
                this.RaisePropertyChanged("ImageSource");
            }
        }

        public string ImageSource => $"avares://WorldsCollideTracker/Assets/Images/Characters/{Name.ToLower()}{Convert.ToInt32(Available)}.png";
    }
}