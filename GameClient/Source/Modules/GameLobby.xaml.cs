using System.Windows.Controls;
using GameClient.Source.ViewModel;

namespace GameClient.Source.Modules {
    public partial class GameLobby : Page {
        public GameLobby() {
            InitializeComponent();
            DataContext = new GameLobbyVM();
        }
    }
}