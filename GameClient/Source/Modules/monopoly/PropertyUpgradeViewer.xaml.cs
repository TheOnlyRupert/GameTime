using System.Windows.Controls;
using GameClient.Source.ViewModel.monopoly;

namespace GameClient.Source.Modules.monopoly {
    public partial class PropertyUpgradeViewer : Page {
        public PropertyUpgradeViewer() {
            InitializeComponent();
            DataContext = new PropertyUpgradeViewerVM();
        }
    }
}