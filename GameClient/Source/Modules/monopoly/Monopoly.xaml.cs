using System.Windows.Controls;
using GameClient.Source.ViewModel.monopoly;

namespace GameClient.Source.Modules.monopoly {
    public partial class Monopoly : Page {
        public Monopoly() {
            InitializeComponent();
            DataContext = new MonopolyVM();
        }
    }
}