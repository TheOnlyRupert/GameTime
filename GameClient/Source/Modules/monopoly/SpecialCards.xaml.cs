using System.Windows.Controls;
using GameClient.Source.ViewModel.monopoly;

namespace GameClient.Source.Modules.monopoly {
    public partial class SpecialCards : Page {
        public SpecialCards() {
            InitializeComponent();
            DataContext = new SpecialCardsVM();
        }
    }
}