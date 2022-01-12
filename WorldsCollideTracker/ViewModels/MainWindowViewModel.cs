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
            var Kefka = new Check("Kefka", true);
            Checks.Add(new CheckViewModel(Kefka));
        }
        
        public ObservableCollection<CheckViewModel> Checks { get; } = new();
    }
}