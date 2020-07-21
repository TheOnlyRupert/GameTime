using System.Windows.Controls;
using GameClient.Source.ViewModel.monopoly;

namespace GameClient.Source.Modules.monopoly {
    public partial class RentPayment : Page {
        public RentPayment() {
            InitializeComponent();
            DataContext = new RentPaymentVM();
        }
    }
}