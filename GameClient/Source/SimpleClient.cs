using System;
using System.Text;
using System.Windows;
using GameClient.Source.Reference;
using RedCorona.Net;

namespace GameClient.Source {
    public class SimpleClient {
        public void Start(string ip) {
            ReferenceValues.CLIENT_INFO = new ClientInfo(Sockets.CreateTCPSocket(ip, 10000), false) {
                EncryptionType = EncryptionType.None, MessageType = MessageType.Unmessaged
            };

            ReferenceValues.CURRENT_GAME_STATE = ReferenceValues.GAME_STATES.LOBBY_AVAILABLE;

            //ReferenceValues.CLIENT_INFO.Send("");
            ReferenceValues.CLIENT_INFO.OnReadBytes += ReadData;
            ReferenceValues.CLIENT_INFO.BeginReceive();
        }

        private static void ReadData(ClientInfo ci, byte[] data, int len) {
            string message = Encoding.UTF8.GetString(data, 0, len);
            Console.WriteLine("Received " + len + " bytes: " + message);

            if (message.StartsWith("[CONSOLE]")) {
                Application.Current.Dispatcher.Invoke(delegate {
                    ReferenceValues.CONSOLE_LOG.Add(message.Substring(9, message.Length - 9));
                });
            }
        }
    }
}