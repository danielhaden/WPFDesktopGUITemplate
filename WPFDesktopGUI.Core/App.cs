using MvvmCross.IoC;
using MvvmCross.ViewModels;


namespace WPFDesktopGUI.Core
{
    public class App : MvxApplication
    {
        /// <summary>
        /// Runs in background on application startup
        /// </summary>
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<ViewModels.HomeViewModel>();
        }
    }
}
