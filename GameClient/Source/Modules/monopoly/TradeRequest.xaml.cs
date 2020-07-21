using System.Windows.Controls;
using GameClient.Source.ViewModel.monopoly;

namespace GameClient.Source.Modules.monopoly {
    public partial class TradeRequest : Page {
        public TradeRequest() {
            InitializeComponent();
            DataContext = new TradeRequestVM();
        }
    }
}