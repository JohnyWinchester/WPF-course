using AndreyMatveewDZ01.View;
using AndreyMatveewDZ01.ViewModel;
using AndreyMatveewDZ01.Services;
using GalaSoft.MvvmLight;

namespace AndreyMatveewDZ01.Model
{
    /// <summary>
    ///  Класс OpenWindowService
    ///  вызывает окно в зависимости от View Model 
    /// </summary>
    public class OpenWindowService<T>: IWindowService where T: ViewModelBase,new()
    {
        public T ViewModel { get; set; }
        public bool WindowStatus;
        public OpenWindowService()
        {
            WindowStatus = false;
            ViewModel = new T();
        }
        public void Show()
        {
            if(ViewModel is EmailSaveViewModel)
            {
                new EmailSaveWindow().Show();
                WindowStatus = true;
            }

            if(ViewModel is EmailRedactorViewModel)
            {
                new EmailRedactorWindow().Show();
                WindowStatus = true;
            }

            if (ViewModel is SmtpSaveViewModel)
            {
                new SmtpSaveWindow().Show();
                WindowStatus = true;
            }

            if (ViewModel is SmtpRedactorViewModel)
            {
                new SmtpRedactorWindow().Show();
                WindowStatus = true;
            }
        }
    }
}
