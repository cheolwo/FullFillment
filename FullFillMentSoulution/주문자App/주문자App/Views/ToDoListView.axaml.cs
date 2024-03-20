using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace 주문자App.Views
{
    public partial class ToDoListView : UserControl
    {
        public ToDoListView()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
