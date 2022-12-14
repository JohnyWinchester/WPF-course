/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:AndreyMatveewDZ01"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;

namespace AndreyMatveewDZ01.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            ////if (ViewModelBase.IsInDesignModeStatic)
            ////{
            ////    // Create design time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            ////}
            ////else
            ////{
            ////    // Create run time view services and models
            ////    SimpleIoc.Default.Register<IDataService, DataService>();
            ////}
            SimpleIoc.Default.Register<EmailSaveViewModel>();
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<TabSwitcherViewModel>();
            SimpleIoc.Default.Register<ErrorViewModel>();
            SimpleIoc.Default.Register<EmailRedactorViewModel>();
            SimpleIoc.Default.Register<SmtpSaveViewModel>();
            SimpleIoc.Default.Register<SmtpRedactorViewModel>();
        }
        public EmailSaveViewModel EmailSaveVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<EmailSaveViewModel>();
            }
        }
        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        public TabSwitcherViewModel TabSwitchVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<TabSwitcherViewModel>();
            }
        }
        public ErrorViewModel ErrorVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ErrorViewModel>();
            }
        }
        public EmailRedactorViewModel EmailRedactorVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<EmailRedactorViewModel>();
            }
        }
        public SmtpSaveViewModel SmtpSaveVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SmtpSaveViewModel>();
            }
        }
        public SmtpRedactorViewModel SmtpRedactorVM
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SmtpRedactorViewModel>();
            }
        }
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}