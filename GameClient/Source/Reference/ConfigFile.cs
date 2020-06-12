using System;
using System.IO;
using System.Windows.Forms;

namespace GameClient.Source.Reference {
    public class ConfigFile {
        private readonly string _fileDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                                                 "/TheOnlyRupert/GameTime/";

        public ConfigFile() {
            try {
                Directory.CreateDirectory(_fileDirectory);

                if (!File.Exists(_fileDirectory + "settings.csv")) {
                    Console.WriteLine(@"settings.csv does not exist. Restoring default settings");
                    StreamWriter file = new StreamWriter(_fileDirectory + "settings.csv", true);
                    file.WriteLine("!KEY,VALUE\nUsername,\nPassword,\nServerIP,");
                    file.Close();
                }
            } catch (Exception) {
                MessageBox.Show("Error! Unable to create settings.csv file in documents directory.\n" +
                                "Using default settings with saving disabled.", "Error");
            }
        }

        public void GetSettings_OneTime() {
            /* Set default values first */
            ReferenceValues.USERNAME = "";
            ReferenceValues.PASSWORD = "";
            ReferenceValues.SERVER_IP = "";

            try {
                StreamReader streamReader = new StreamReader(_fileDirectory + "settings.csv");

                while (!streamReader.EndOfStream) {
                    string str = streamReader.ReadLine();

                    if (str != null && str[0] != '!') {
                        string[] strArray = str.Split(',');
                        switch (strArray[0]) {
                        case "Username":
                            ReferenceValues.USERNAME = strArray[1];
                            break;
                        case "Password":
                            ReferenceValues.PASSWORD = strArray[1];
                            break;
                        case "ServerIP":
                            ReferenceValues.SERVER_IP = strArray[1];
                            break;
                        }
                    }
                }

                Console.WriteLine(@"Username: " + ReferenceValues.USERNAME);
                Console.WriteLine(@"Password: " + ReferenceValues.PASSWORD);
                Console.WriteLine(@"ServerIP: " + ReferenceValues.SERVER_IP);
            } catch (Exception) {
                Console.WriteLine(@"Error! settings.csv file read error.");
            }
        }

        public void SetSettingFromString(string key) { }
    }
}