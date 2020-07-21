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

        public static string MonopolyPropertyImageFromId(int id) {
            switch (id) {
            // GO
            case 0:
                return "";
            case 1:
                return "../../../Resources/monopoly/properties/mediterranean.PNG";
            // community chest (bottom)
            case 2:
                return "";
            case 3:
                return "../../../Resources/monopoly/properties/baltic.PNG";
            // income tax
            case 4:
                return "";
            case 5:
                return "../../../Resources/monopoly/properties/railroadread.PNG";
            case 6:
                return "../../../Resources/monopoly/properties/oriental.PNG";
            // chance (bottom)
            case 7:
                return "";
            case 8:
                return "../../../Resources/monopoly/properties/vermont.PNG";
            case 9:
                return "../../../Resources/monopoly/properties/connecticut.PNG";
            // visiting jail
            case 10:
                return "";
            case 11:
                return "../../../Resources/monopoly/properties/stcharles.PNG";
            case 12:
                return "../../../Resources/monopoly/properties/electriccomp.PNG";
            case 13:
                return "../../../Resources/monopoly/properties/states.PNG";
            case 14:
                return "../../../Resources/monopoly/properties/virginia.PNG";
            case 15:
                return "../../../Resources/monopoly/properties/railroadpenn.PNG";
            case 16:
                return "../../../Resources/monopoly/properties/stjames.PNG";
            // community chest (left)
            case 17:
                return "";
            case 18:
                return "../../../Resources/monopoly/properties/tennessee.PNG";
            case 19:
                return "../../../Resources/monopoly/properties/newyork.PNG";
            // free parking
            case 20:
                return "";
            case 21:
                return "../../../Resources/monopoly/properties/kentucky.PNG";
            // chance (top)
            case 22:
                return "";
            case 23:
                return "../../../Resources/monopoly/properties/indiana.PNG";
            case 24:
                return "../../../Resources/monopoly/properties/illinois.PNG";
            case 25:
                return "../../../Resources/monopoly/properties/railroadbo.PNG";
            case 26:
                return "../../../Resources/monopoly/properties/atlantic.PNG";
            case 27:
                return "../../../Resources/monopoly/properties/ventnor.PNG";
            case 28:
                return "../../../Resources/monopoly/properties/waterworks.PNG";
            case 29:
                return "../../../Resources/monopoly/properties/marvingardens.PNG";
            // go to jail
            case 30:
                return "";
            case 31:
                return "../../../Resources/monopoly/properties/pacific.PNG";
            case 32:
                return "../../../Resources/monopoly/properties/northcarolina.PNG";
            // community chest (right)
            case 33:
                return "";
            case 34:
                return "../../../Resources/monopoly/properties/pennsylvania.PNG";
            case 35:
                return "../../../Resources/monopoly/properties/railroadshort.PNG";
            // chance (right)
            case 36:
                return "";
            case 37:
                return "../../../Resources/monopoly/properties/parkplace.PNG";
            // luxury tax
            case 38:
                return "";
            case 39:
                return "../../../Resources/monopoly/properties/boardwalk.PNG";
            // in jail
            case 40:
                return "../../../Resources/monopoly/jail.png";
            default:
                return "";
            }
        }
    }
}