using System.Reactive;
using System.Text;
using Avalonia.Input;
using ReactiveUI;

namespace WorldsCollideTracker.ViewModels
{
    public class CheckViewModel : ViewModelBase
    {

        private int _available;
        
        public ReactiveCommand<PointerReleasedEventArgs, Unit> HandleClick { get; }

        public CheckViewModel()
        {
            HandleClick = ReactiveCommand.Create<PointerReleasedEventArgs>(HandleClickImpl);
        }
        
        public int Available
        {
            get => _available;
            set => this.RaiseAndSetIfChanged(ref _available, value);
        }

        public string ImageSource
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append("avares://WorldsCollideTracker/Assets/Images/Characters/");

                sb.Append("Celes");

                sb.Append(Available);
                sb.Append(".png");
                return sb.ToString();
            }
        }

        private void HandleClickImpl(PointerReleasedEventArgs e)
        {
            Available = e.InitialPressMouseButton switch
            {
                MouseButton.Left => 1,
                MouseButton.Right => 0,
                _ => Available
            };
        }
    }
}