using System;
using System.Text;
using System.Windows.Input;
using ReactiveUI;
using WorldsCollideTracker.Models;

namespace WorldsCollideTracker.ViewModels
{
    public class CheckViewModel : ViewModelBase
    {
        private Check _check;
        private bool _isAvailable;
        private bool _isDone;

        public ICommand Click { get; }

        public CheckViewModel(Check check)
        {
            _check = check;
            _isAvailable = check.IsAvailable;
            _isDone = check.IsDone;
            Click = ReactiveCommand.Create(() => IsDone = !IsDone);
        }

        public string Name => _check.Name;

        public bool IsAvailable
        {
            get => _isAvailable;
            set
            {
                this.RaiseAndSetIfChanged(ref _isAvailable, value);
                this.RaisePropertyChanged(nameof(ImageSource));
            }
        }

        public bool IsDone
        {
            get => _isDone;
            set
            {
                
                this.RaiseAndSetIfChanged(ref _isDone, value); 
                this.RaisePropertyChanged(nameof(ImageSource));
            }
        }

        public string ImageSource {
            get
            {
                var sb = new StringBuilder();
                sb.Append($"avares://WorldsCollideTracker/Assets/Images/Checks/{Name.ToLower()}");
                var variant = Convert.ToInt32(IsAvailable) + Convert.ToInt32(IsDone);
                sb.Append($"{variant}.png");
                return sb.ToString();
            }
        }
    }
}