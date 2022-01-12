using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WorldsCollideTracker.Models;

namespace WorldsCollideTracker.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        public MainWindowViewModel()
        {
            var Kefka = new Check("Kefka");

            var character = new Character("Celes", new[] {Kefka});
            Gates.Add(new GateViewModel(character));
        }
        public ObservableCollection<GateViewModel> Gates { get; } = new();
    }
}