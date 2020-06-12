using System.Collections.ObjectModel;
using GameServer.Source.ViewModel;
using RedCorona.Net;

namespace GameServer.Source.Reference {
    public static class ReferenceValues {
        public enum GAME_STATES {
            LOBBY_AVAILABLE,
            LOBBY_HOSTING,
            LOBBY_JOINING,
            GAME_TICTACTOE,
            GAME_CHECKERS,
            GAME_CHESS,
            GAME_STRATEGO,
            GAME_BATTLESHIP,
            GAME_MONOPOLY,
            GAME_LIFE
        }

        public static ObservableCollection<ConnectedClientsStruct> CONNECTED_CLIENTS { get; set; }
        public static SimpleServer SIMPLE_SERVER { get; set; }
        public static Server SERVER { get; set; }
    }
}