using System;
using GameClient.Source.Reference;
using GameClient.Source.ViewModel.Base;

namespace GameClient.Source.ViewModel {
    public class MainWindowVM : BaseViewModel {
        private string _iconImage, _currentModule;

        public MainWindowVM() {
            /* Settings */
            ConfigFile configFile = new ConfigFile();
            configFile.GetSettings_OneTime();

            IconImage = "../../Resources/icons/icon_main.png";
            CurrentModule = "Source/Modules/monopoly/PropertyUpgradeViewer.xaml";
            //CurrentModule = "Source/Modules/Menu.xaml";

            CrossViewMessenger simpleMessenger = CrossViewMessenger.Instance;
            simpleMessenger.MessageValueChanged += OnSimpleMessengerValueChanged;
        }

        public string IconImage {
            get => _iconImage;
            set {
                _iconImage = value;
                RaisePropertyChangedEvent("IconImage");
            }
        }

        public string CurrentModule {
            get => _currentModule;
            set {
                _currentModule = value;
                ReferenceValues.CurrentModule = value;
                RaisePropertyChangedEvent("CurrentModule");
            }
        }

        private void OnSimpleMessengerValueChanged(object sender, MessageValueChangedEventArgs e) {
            /* Switch current module if requested */
            if (e.PropertyName == "SwitchCurrentModule") {
                Console.WriteLine(@"Switching from " + CurrentModule + @" to " + ReferenceValues.CurrentModule);
                CurrentModule = ReferenceValues.CurrentModule;
            }
        }
    }
}