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
        private const string ImageLocation = "avares://WorldsCollideTracker/Assets/Images/Checks";
        private readonly ObservableAsPropertyHelper<string> _imageSource;

        public ICommand Click { get; }

        public CheckViewModel(Check check)
        {
            _check = check;
            _isAvailable = check.IsAvailable;
            _isDone = check.IsDone;
            Click = ReactiveCommand.Create(() => IsDone = !IsDone);
            _imageSource = this.WhenAnyValue(x => x.IsAvailable, x => x.IsDone,
                    (x, y) => $"{ImageLocation}/{Name.ToLower()}{Convert.ToInt32(x)}{Convert.ToInt32(y)}.png")
                .ToProperty(this, nameof(ImageSource));
        }

        public string Name => _check.Name;

        public bool IsAvailable
        {
            get => _isAvailable;
            set
            {
                this.RaiseAndSetIfChanged(ref _isAvailable, value);
                _check.IsAvailable = value;
            }
        }

        public bool IsDone
        {
            get => _isDone;
            set
            {
                this.RaiseAndSetIfChanged(ref _isDone, value);
                _check.IsDone = value;
            }
        }

        public string ImageSource => _imageSource.Value;
    }
}