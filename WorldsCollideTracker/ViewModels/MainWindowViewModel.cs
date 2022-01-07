using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WorldsCollideTracker.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        public MainWindowViewModel()
        {
            Checks.Add(new CheckViewModel() {Name = "Celes"});
            Checks.Add(new CheckViewModel() {Name = "Cyan"});
        }
        
        public ObservableCollection<CheckViewModel> Checks { get; } = new();
    }
}