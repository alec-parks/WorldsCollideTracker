using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace WorldsCollideTracker.Views
{
    public class CheckView : UserControl
    {
        public CheckView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}