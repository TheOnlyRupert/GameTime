using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using RedCorona.Net;

namespace GameClient.Source.Reference {
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

        public const string COPYRIGHT = "Copyright © 2020  Robert Higgins";

        public const string VERSION = "1.0.0";

        public static readonly List<string> GAME_LIST = new List<string> {"Tic-Tac-Toe", "Chess", "Checkers", "Monopoly", "Stratego", "Battleship", "Life"};

        public static bool IS_ALLOWED_CONNECT;

        public static GAME_STATES CURRENT_GAME_STATE;

        public static string USERNAME;
        public static string PASSWORD;
        public static string SERVER_IP;

        public static string CurrentModule { get; set; }

        /* Lobby chat log */
        public static ObservableCollection<string> CONSOLE_LOG { get; set; }

        /* Call this to receive/send data */
        public static ClientInfo CLIENT_INFO { get; set; }

        public static bool ConnectToServer() {
            try {
                SimpleClient simpleClient = new SimpleClient();
                simpleClient.Start(SERVER_IP);
                return true;
            } catch (Exception) {
                return false;
            }
        }
    }
}