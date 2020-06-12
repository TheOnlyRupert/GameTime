using System;
using System.Text;
using GameServer.Source.Reference;
using RedCorona.Net;

namespace GameServer.Source {
    public class SimpleServer {
        public void Start() {
            ReferenceValues.SERVER = new Server(10000) {
                DefaultEncryptionType = EncryptionType.None
            };

            ReferenceValues.SERVER.ClientReady += ClientConnect;
        }

        private static bool ClientConnect(Server serv, ClientInfo new_client) {
            new_client.MessageType = MessageType.Unmessaged;
            new_client.OnReadBytes += ReadData;
            return true;
        }

        private static void ReadData(ClientInfo ci, byte[] data, int len) {
            string message = Encoding.UTF8.GetString(data, 0, len);
            Console.WriteLine("Received " + len + " bytes: " + message);

            if (message.StartsWith("[GAMESTATE]")) {
                Console.WriteLine("updating console state");
            }
        }
    }
}