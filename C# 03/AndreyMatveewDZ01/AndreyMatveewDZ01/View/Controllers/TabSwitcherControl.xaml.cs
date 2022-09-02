using System.Windows;
using System.Windows.Controls;

namespace AndreyMatveewDZ01.Controllers
{
    /// <summary>
    /// Логика взаимодействия для TabSwitcherControl.xaml
    /// </summary>
    public partial class TabSwitcherControl : UserControl
    {
        public TabSwitcherControl()
        {
            InitializeComponent();
        }
        public int Position
        {
            get { return (int)GetValue(PositionProperty); }
            set { SetValue(PositionProperty, value); }
        }

        public static readonly DependencyProperty PositionProperty =
            DependencyProperty.Register("Position", typeof(int), typeof(TabSwitcherControl));
    }
}
