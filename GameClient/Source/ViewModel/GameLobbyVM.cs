using System.Collections.ObjectModel;
using System.Windows.Input;
using GameClient.Source.Reference;
using GameClient.Source.ViewModel.Base;

namespace GameClient.Source.ViewModel {
    public class GameLobbyVM : BaseViewModel {
        private static ObservableCollection<string> _lobbyClientList, _localClientList, _gameList;

        private string consoleInput, _chatHintVisibility, _clientNameText, _clientLevelText, _clientWinLossText, _localAmountText, _localMinMaxText, _lobbyTotalText,
            _gameSelected, _leaveGameButtonText, _playGameButtonText, _areSettingsUnlocked;

        public GameLobbyVM() {
            ConsoleOutputList = new ObservableCollection<string> {"Copyright © 2020 Robert Higgins... v1.0.0-dev"};
            LobbyClientList = new ObservableCollection<string>();
            LocalClientList = new ObservableCollection<string>();
            ChatHintVisibility = "Visible";
            LobbyTotalText = "Clients Connected: " + LobbyClientList.Count + "/16";
            PlayGameButtonText = "Create Lobby";
            LeaveGameButtonText = "Create Lobby";
            ConsoleInput = "";

            GameList = new ObservableCollection<string>();
            foreach (string VARIABLE in ReferenceValues.GAME_LIST) {
                GameList.Add(VARIABLE);
            }

            GameSelected = "0";
            AreSettingsUnlocked = "True";
        }

        public ICommand ButtonCommand => new DelegateCommand(ButtonCommandLogic, true);

        private void ButtonCommandLogic(object param) {
            switch (param) {
            case "play":
                if (ReferenceValues.CURRENT_GAME_STATE == ReferenceValues.GAME_STATES.LOBBY_AVAILABLE) {
                    ReferenceValues.CURRENT_GAME_STATE = ReferenceValues.GAME_STATES.LOBBY_HOSTING;
                    PlayGameButtonText = "Start Game";
                    LeaveGameButtonText = "Leave Game";
                    AreSettingsUnlocked = "True";
                } else if (ReferenceValues.CURRENT_GAME_STATE == ReferenceValues.GAME_STATES.LOBBY_HOSTING && AreSettingsUnlocked == "True") { }

                break;
            case "leave":
                if (ReferenceValues.CURRENT_GAME_STATE == ReferenceValues.GAME_STATES.LOBBY_JOINING ||
                    ReferenceValues.CURRENT_GAME_STATE == ReferenceValues.GAME_STATES.LOBBY_HOSTING) {
                    ReferenceValues.CURRENT_GAME_STATE = ReferenceValues.GAME_STATES.LOBBY_AVAILABLE;
                    PlayGameButtonText = "Create Lobby";
                    LeaveGameButtonText = "Create Lobby";
                    AreSettingsUnlocked = "True";
                }

                break;
            case "join":
                if (ReferenceValues.CURRENT_GAME_STATE == ReferenceValues.GAME_STATES.LOBBY_AVAILABLE) {
                    ReferenceValues.CURRENT_GAME_STATE = ReferenceValues.GAME_STATES.LOBBY_JOINING;
                    PlayGameButtonText = "Play Game";
                    LeaveGameButtonText = "Leave Game";
                    AreSettingsUnlocked = "False";
                }

                break;
            case "invite":
                if (ReferenceValues.CURRENT_GAME_STATE == ReferenceValues.GAME_STATES.LOBBY_HOSTING ||
                    ReferenceValues.CURRENT_GAME_STATE == ReferenceValues.GAME_STATES.LOBBY_JOINING) { }

                break;
            case "console":
                if (ConsoleInput.Length > 0) {
                    ReferenceValues.CLIENT_INFO.Send("[CONSOLE]" + ConsoleInput);
                }

                break;
            }
        }

        #region Fields

        public string ConsoleInput {
            get => consoleInput;
            set {
                consoleInput = value;
                RaisePropertyChangedEvent("ConsoleInput");
            }
        }

        public ObservableCollection<string> ConsoleOutputList {
            get => ReferenceValues.CONSOLE_LOG;
            set {
                ReferenceValues.CONSOLE_LOG = value;
                RaisePropertyChangedEvent("ConsoleOutput");
            }
        }

        public ObservableCollection<string> LocalClientList {
            get => _localClientList;
            set {
                _localClientList = value;
                RaisePropertyChangedEvent("LocalClientList");
            }
        }

        public ObservableCollection<string> LobbyClientList {
            get => _lobbyClientList;
            set {
                _lobbyClientList = value;
                RaisePropertyChangedEvent("LobbyClientList");
            }
        }

        public string ClientNameText {
            get => _clientNameText;
            set {
                _clientNameText = value;
                RaisePropertyChangedEvent("ClientNameText");
            }
        }

        public string ClientLevelText {
            get => _clientLevelText;
            set {
                _clientLevelText = value;
                RaisePropertyChangedEvent("ClientLevelText");
            }
        }

        public string ClientWinLossText {
            get => _clientWinLossText;
            set {
                _clientWinLossText = value;
                RaisePropertyChangedEvent("ClientWinLossText");
            }
        }

        public string LocalMinMaxText {
            get => _localMinMaxText;
            set {
                _localMinMaxText = value;
                RaisePropertyChangedEvent("LocalMinMaxText");
            }
        }

        public string LocalAmountText {
            get => _localAmountText;
            set {
                _localAmountText = value;
                RaisePropertyChangedEvent("LocalAmountText");
            }
        }

        public string ChatHintVisibility {
            get => _chatHintVisibility;
            set {
                _chatHintVisibility = value;
                RaisePropertyChangedEvent("ChatHintVisibility");
            }
        }

        public string LobbyTotalText {
            get => _lobbyTotalText;
            set {
                _lobbyTotalText = value;
                RaisePropertyChangedEvent("LobbyTotalText");
            }
        }

        public string PlayGameButtonText {
            get => _playGameButtonText;
            set {
                _playGameButtonText = value;
                RaisePropertyChangedEvent("PlayGameButtonText");
            }
        }

        public string LeaveGameButtonText {
            get => _leaveGameButtonText;
            set {
                _leaveGameButtonText = value;
                RaisePropertyChangedEvent("LeaveGameButtonText");
            }
        }

        public string AreSettingsUnlocked {
            get => _areSettingsUnlocked;
            set {
                _areSettingsUnlocked = value;
                RaisePropertyChangedEvent("AreSettingsUnlocked");
            }
        }

        public ObservableCollection<string> GameList {
            get => _gameList;
            set {
                _gameList = value;
                RaisePropertyChangedEvent("GameList");
            }
        }

        public string GameSelected {
            get => _gameSelected;
            set {
                _gameSelected = value;

                switch (value) {
                case "0":
                case "1":
                case "2":
                case "4":
                case "5":
                    LocalMinMaxText = "Min/Max: 2/2";
                    LocalAmountText = "Current: " + LobbyClientList.Count + "/2";
                    break;
                case "3":
                case "6":
                    LocalMinMaxText = "Min/Max: 2/16";
                    LocalAmountText = "Current: " + LobbyClientList.Count + "/16";
                    break;
                }

                RaisePropertyChangedEvent("GameSelected");
            }
        }

        #endregion
    }
}