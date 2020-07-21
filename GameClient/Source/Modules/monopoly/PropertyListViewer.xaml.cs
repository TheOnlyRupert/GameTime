using System.Windows.Controls;
using GameClient.Source.ViewModel.monopoly;

namespace GameClient.Source.Modules.monopoly {
    public partial class PropertyListViewer : Page {
        public PropertyListViewer() {
            InitializeComponent();
            DataContext = new PropertyListViewerVM();
        }
    }
}