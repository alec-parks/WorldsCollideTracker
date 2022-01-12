using System;
using System.Collections.Generic;
using System.Linq;
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
        
        public ICommand Click { get; }

        public GateViewModel(Character character)
        {
            _character = character;
            _isFound = character.IsFound;
            _checks = _character.Checks.Select(ch => new CheckViewModel(ch)).ToList();
            Click = ReactiveCommand.Create(() => IsFound = !IsFound);
        }

        public string Name => _character.Name;

        public IEnumerable<CheckViewModel> Checks => _checks;

        public bool IsFound
        {
            get => _isFound;
            set
            {
                _checks.ForEach(ch => ch.IsAvailable = true);
                this.RaiseAndSetIfChanged(ref _isFound, value);
                this.RaisePropertyChanged(nameof(ImageSource));
            }
        }

        public string ImageSource => $"avares://WorldsCollideTracker/Assets/Images/Characters/{Name.ToLower()}{Convert.ToInt32(IsFound)}.png";
    }
}