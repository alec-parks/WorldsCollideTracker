using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Windows.Input;
using ReactiveUI;
using WorldsCollideTracker.Models;

namespace WorldsCollideTracker.ViewModels
{
    public class GateViewModel : ViewModelBase
    {
        private readonly Character _character;
        private readonly List<CheckViewModel> _checks;
        private bool _isFound;

        private const string ImageLocation = "avares://WorldsCollideTracker/Assets/Images/Characters";
        private readonly ObservableAsPropertyHelper<string> _imageSource;
        
        public ICommand Click { get; }

        public GateViewModel(Character character)
        {
            _character = character;
            _isFound = character.IsFound;
            _checks = _character.Checks.Select(ch => new CheckViewModel(ch)).ToList();
            Click = ReactiveCommand.Create(() => IsFound = !IsFound);
            _imageSource = this.WhenAnyValue(x => x.IsFound)
                .Select(x =>
                    $"{ImageLocation}/{Name.ToLower()}{Convert.ToInt32(x)}.png")
                .ToProperty(this, nameof(ImageSource));
        }

        public string Name => _character.Name;

        public IEnumerable<CheckViewModel> Checks => _checks;

        public string ImageSource => _imageSource.Value;

        public bool IsFound
        {
            get => _isFound;
            set
            {
                _character.IsFound = value;
                _checks.ForEach(ch => ch.IsAvailable = value);
                this.RaiseAndSetIfChanged(ref _isFound, value);
            }
        }
    }
}