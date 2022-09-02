using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace AndreyMatveewDZ01.ViewModel
{
    /// <summary>
    ///  View Model пользовательского элемента, 
    ///  который отвечает за переключение вкладок элемента TabControl
    /// </summary>
    public class TabSwitcherViewModel: ViewModelBase
    {
        private int positionTabControl;
        public int PositionTabControl
        {
            get => positionTabControl;
            set => Set(ref positionTabControl, value);
        }
        public RelayCommand PositionChangeRightButtonCommand { get; private set; }
        public RelayCommand PositionChangeLeftButtonCommand { get; private set; }
        public TabSwitcherViewModel()
        {
            PositionChangeLeftButtonCommand = new RelayCommand(() => PositionChangeLeftButtonCommandExecuted());
            PositionChangeRightButtonCommand = new RelayCommand(() => PositionChangeRightButtonCommandExecuted());
        }
        private void PositionChangeRightButtonCommandExecuted()
        {
            if (PositionTabControl + 1 == 3)
            {
                PositionTabControl = 0;
                return;
            }
            PositionTabControl++;
        }
        private void PositionChangeLeftButtonCommandExecuted()
        {
            if(PositionTabControl - 1 == -1)
            {
                PositionTabControl = 2;
                return;
            }
            PositionTabControl--;
        }
    }
}
