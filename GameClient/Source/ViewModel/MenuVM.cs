using System;
using System.Net;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Input;
using GameClient.Source.Reference;
using GameClient.Source.ViewModel.Base;

namespace GameClient.Source.ViewModel {
    public class MenuVM : BaseViewModel {
        private readonly CrossViewMessenger _crossViewMessenger;
        private string _username, _password, _localIp, _publicIp, _clientName, _serverIp;

        public MenuVM() {
            ClientName = Dns.GetHostName() + '_' + Environment.UserName;
            LocalIp = GetLocalIPAddress();
            PublicIp = GetPublicIPAddress();

            _crossViewMessenger = CrossViewMessenger.Instance;
            ReferenceValues.IS_ALLOWED_CONNECT = true;
        }

        public string Username {
            get => _username;
            set {
                _username = value;
                RaisePropertyChangedEvent("Username");
            }
        }

        public string Password {
            get => _password;
            set {
                _password = value;
                RaisePropertyChangedEvent("Password");
            }
        }

        public string ClientName {
            get => _clientName;
            set {
                _clientName = value;
                RaisePropertyChangedEvent("ClientName");
            }
        }


        public string LocalIp {
            get => _localIp;
            set {
                _localIp = value;
                RaisePropertyChangedEvent("LocalIp");
            }
        }

        public string PublicIp {
            get => _publicIp;
            set {
                _publicIp = value;
                RaisePropertyChangedEvent("PublicIp");
            }
        }

        public string ServerIp {
            get => _serverIp;
            set {
                _serverIp = value;
                RaisePropertyChangedEvent("ServerIp");
            }
        }

        public ICommand ButtonCommand => new DelegateCommand(ButtonCommandLogic, true);

        private static string GetLocalIPAddress() {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList) {
                if (ip.AddressFamily == AddressFamily.InterNetwork) {
                    return ip.ToString();
                }
            }

            return null;
        }

        private static string GetPublicIPAddress() {
            try {
                string ip = new WebClient().DownloadString("http://ipv4.icanhazip.com/");
                return ip.Remove(ip.Length - 1);
            } catch (Exception) {
                return "NULL";
            }
        }

        private void ButtonCommandLogic(object param) {
            switch (param) {
            case "connect":
                if (ReferenceValues.IS_ALLOWED_CONNECT) {
                    bool isConnecting = ReferenceValues.ConnectToServer();
                    if (isConnecting) {
                        ReferenceValues.IS_ALLOWED_CONNECT = false;
                        ReferenceValues.CurrentModule = "Source/Modules/GameLobby.xaml";
                        _crossViewMessenger.PushMessage("SwitchCurrentModule", null);
                    } else {
                        ReferenceValues.IS_ALLOWED_CONNECT = true;
                        MessageBox.Show("Cannot connect to the server", "Unable to connect",
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }

                break;
            }
        }
    }
}