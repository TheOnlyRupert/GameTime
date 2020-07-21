using System.Windows.Controls;
using GameClient.Source.ViewModel.monopoly;

namespace GameClient.Source.Modules.monopoly {
    public partial class InJail : Page {
        public InJail() {
            InitializeComponent();
            DataContext = new InJailVM();
        }
    }
}