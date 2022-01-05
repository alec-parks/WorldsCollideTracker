using System.Text;
using ReactiveUI;

namespace WorldsCollideTracker.ViewModels
{
    public class CheckViewModel : ViewModelBase
    {

        public string ImageSource
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append("avares://WorldsCollideTracker/Assets/Images/Characters/");

                sb.Append("Celes");

                sb.Append(1);
                sb.Append(".png");
                return sb.ToString();
            }
        }
    }
}