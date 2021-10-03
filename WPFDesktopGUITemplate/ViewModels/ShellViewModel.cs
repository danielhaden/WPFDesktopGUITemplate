using Caliburn.Micro;
using System.Threading;

namespace WPFDesktopGUITemplate.ViewModels
{
    class ShellViewModel : Conductor<object>
    {

        public ShellViewModel()
        {
            ActivateItemAsync(IoC.Get<DemoViewModel>(), new CancellationToken());
        }

    }
}
