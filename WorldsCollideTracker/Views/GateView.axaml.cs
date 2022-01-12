using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace WorldsCollideTracker.Views
{
    public class GateView : UserControl
    {
        public GateView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}