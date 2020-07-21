using System.Windows.Controls;
using GameClient.Source.ViewModel.monopoly;

namespace GameClient.Source.Modules.monopoly {
    public partial class RollDie : Page {
        public RollDie() {
            InitializeComponent();
            DataContext = new RollDieVM();
        }
    }
}