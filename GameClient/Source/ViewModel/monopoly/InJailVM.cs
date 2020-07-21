using System.Windows;
using System.Windows.Input;
using GameClient.Source.ViewModel.Base;

namespace GameClient.Source.ViewModel.monopoly {
    public class InJailVM : BaseViewModel {
        private string _jailTurnText, _jailFreeChanceVisibility, _jailFreeChestVisibility;
        private readonly bool jailFreeCardChance;
        private readonly bool jailFreeCardChest;
        private readonly int turnAmount;
        private int _yourAvailableCash;

        public InJailVM() {
            turnAmount = 1;
            jailFreeCardChance = false;
            jailFreeCardChest = false;
            YourAvailableCash = 1500;

            SetIconDisplay();
        }

        public ICommand ButtonCommand => new DelegateCommand(ButtonCommandLogic, true);

        private void SetIconDisplay() {
            JailTurnText = "In Jail (Turn: " + turnAmount + "/3)";

            JailFreeChanceVisibility = "HIDDEN";
            JailFreeChestVisibility = "HIDDEN";

            if (jailFreeCardChance) {
                JailFreeChanceVisibility = "VISIBLE";
            }

            if (jailFreeCardChest) {
                JailFreeChestVisibility = "VISIBLE";
            }
        }

        private void ButtonCommandLogic(object param) {
            switch (param) {
            case "payfine":
                if (YourAvailableCash < 50) {
                    MessageBox.Show("You cannot afford to leave jail at this time.", "Cannot afford", MessageBoxButton.OK);
                }

                break;
            case "rolldie":
                break;
            case "usecard":
                if (!jailFreeCardChance && !jailFreeCardChest) {
                    MessageBox.Show("You do not have any 'Out of Jail Free' cards that can be used.", "No 'Out of Jail Free' Cards", MessageBoxButton.OK);
                }

                break;
            case "postpone":
                break;
            }
        }

        #region Fields

        public string JailTurnText {
            get => _jailTurnText;
            set {
                _jailTurnText = value;
                RaisePropertyChangedEvent("JailTurnText");
            }
        }

        public int YourAvailableCash {
            get => _yourAvailableCash;
            set {
                _yourAvailableCash = value;
                RaisePropertyChangedEvent("YourAvailableCash");
            }
        }

        public string JailFreeChanceVisibility {
            get => _jailFreeChanceVisibility;
            set {
                _jailFreeChanceVisibility = value;
                RaisePropertyChangedEvent("JailFreeChanceVisibility");
            }
        }

        public string JailFreeChestVisibility {
            get => _jailFreeChestVisibility;
            set {
                _jailFreeChestVisibility = value;
                RaisePropertyChangedEvent("JailFreeChestVisibility");
            }
        }

        #endregion
    }
}