using System.Windows.Controls;
using GameClient.Source.ViewModel.monopoly;

namespace GameClient.Source.Modules.monopoly {
    public partial class TradeOutcome : Page {
        public TradeOutcome() {
            InitializeComponent();
            DataContext = new TradeOutcomeVM();
        }
    }
}