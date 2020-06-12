using System;
using System.Text;
using RedCorona.Net;

namespace GameClient.Source.Reference {
    internal class SimpleClient {
        public void Start(string ip) {
            ClientInfo ci = new ClientInfo(Sockets.CreateTCPSocket(ip, 1234), false) {
                EncryptionType = EncryptionType.ServerRSAClientKey, MessageType = MessageType.CodeAndLength
            };
            ci.OnReadMessage += ReadMessage;
            ci.BeginReceive();

            string s;
            while ((s = Console.ReadLine()) != "exit") {
                ci.SendMessage(0xABCDEF01, Encoding.UTF8.GetBytes(s), 0);
            }

            ci.Close();
        }

        private static void ReadMessage(ClientInfo ci, uint code, byte[] buf, int len) {
            Console.WriteLine("Message, code " + code.ToString("X8") + ", content:");
            byte[] ba = new byte[len];
            Array.Copy(buf, ba, len);
            Console.WriteLine("  " + ByteBuilder.FormatParameter(new Parameter(ba, ParameterType.Byte)));
        }
    }
}