using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using GameClient.Source.ViewModel.Base;
using GameServer.Source.Reference;

namespace GameServer.Source.ViewModel {
    public class MainWindowVM : BaseViewModel {
        private string _iconImage;

        public MainWindowVM() {
            ReferenceValues.SIMPLE_SERVER = new SimpleServer();
            ReferenceValues.SIMPLE_SERVER.Start();
            IconImage = "../../Resources/icons/icon_main.png";
            ConnectedClients = new ObservableCollection<ConnectedClientsStruct>();
        }

        public string IconImage {
            get => _iconImage;
            set {
                _iconImage = value;
                RaisePropertyChangedEvent("IconImage");
            }
        }

        public ICommand ButtonCommand => new DelegateCommand(ButtonCommandLogic, true);

        public ObservableCollection<ConnectedClientsStruct> ConnectedClients {
            get => ReferenceValues.CONNECTED_CLIENTS;
            set {
                ReferenceValues.CONNECTED_CLIENTS = value;
                RaisePropertyChangedEvent("ConnectedClients");
            }
        }

        private void ButtonCommandLogic(object param) {
            switch (param) {
            case "kick":
                ReferenceValues.SERVER.Broadcast(Encoding.UTF8.GetBytes("[CONSOLE]This is a simple test message"));
                break;
            case "banID":
                ReferenceValues.SERVER.Broadcast(Encoding.UTF8.GetBytes("[CONSOLE]This is another simple test message... this one is somewhat longer than the first one"));
                break;
            }
        }
    }

    public class ConnectedClientsStruct {
        public string ID { get; set; }
        public string Client { get; set; }
        public string Ping { get; set; }
        public ReferenceValues.GAME_STATES GameState { get; set; }
        public string GameDetails { get; set; }
        public string ErrorState { get; set; }
    }
}