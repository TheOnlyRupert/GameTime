using System.Windows.Controls;
using GameClient.Source.ViewModel.monopoly;

namespace GameClient.Source.Modules.monopoly {
    public partial class PropertyManager : Page {
        public PropertyManager() {
            InitializeComponent();
            DataContext = new PropertyManagerVM();
        }
    }
}