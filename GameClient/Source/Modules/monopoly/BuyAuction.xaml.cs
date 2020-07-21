using System.Windows.Controls;
using GameClient.Source.ViewModel.monopoly;

namespace GameClient.Source.Modules.monopoly {
    public partial class BuyAuction : Page {
        public BuyAuction() {
            InitializeComponent();
            DataContext = new BuyAuctionVM();
        }
    }
}