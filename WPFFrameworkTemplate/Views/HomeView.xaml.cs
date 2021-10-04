using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;
using WPFDesktopGUI.Core.ViewModels;

namespace WPFFrameworkTemplate.Views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    [MvxViewFor(typeof(HomeViewModel))]
    public partial class HomeView : MvxWpfView
    {
        public HomeView()
        {
            InitializeComponent();
        }
    }
}
