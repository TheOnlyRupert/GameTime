using System.Windows.Controls;
using GameClient.Source.ViewModel;

namespace GameClient.Source.Modules {
    public partial class Menu : Page {
        public Menu() {
            InitializeComponent();
            DataContext = new MenuVM();
        }
    }
}