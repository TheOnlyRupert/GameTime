using System.Collections.Generic;
using System.Windows.Input;
using GameClient.Source.ViewModel.Base;

namespace GameClient.Source.ViewModel.monopoly {
    public class RollDieVM : BaseViewModel {
        private string _imageDiceLeft, _imageDiceRight, _dieTotalText, _buttonText, _jailVisibility, _jailRollText;
        private bool hasRolled;
        private int jailRollAmount;

        public RollDieVM() {
            DieTotalText = "";
            ButtonText = "Postpone";
            JailRollText = "";
            JailVisibility = "HIDDEN";
            jailRollAmount = 0;
        }

        public ICommand ButtonCommand => new DelegateCommand(ButtonCommandLogic, true);

        public string ImageDiceLeft {
            get => _imageDiceLeft;
            set {
                _imageDiceLeft = value;
                RaisePropertyChangedEvent("ImageDiceLeft");
            }
        }

        public string ImageDiceRight {
            get => _imageDiceRight;
            set {
                _imageDiceRight = value;
                RaisePropertyChangedEvent("ImageDiceRight");
            }
        }

        public string DieTotalText {
            get => _dieTotalText;
            set {
                _dieTotalText = value;
                RaisePropertyChangedEvent("DieTotalText");
            }
        }

        public string ButtonText {
            get => _buttonText;
            set {
                _buttonText = value;
                RaisePropertyChangedEvent("ButtonText");
            }
        }

        public string JailRollText {
            get => _jailRollText;
            set {
                _jailRollText = value;
                RaisePropertyChangedEvent("JailRollText");
            }
        }

        public string JailVisibility {
            get => _jailVisibility;
            set {
                _jailVisibility = value;
                RaisePropertyChangedEvent("JailVisibility");
            }
        }

        private void RollToImage(IReadOnlyList<int> rollInput) {
            switch (rollInput[0]) {
            case 1:
                ImageDiceLeft = "../../../Resources/monopoly/die/l1.png";
                break;
            case 2:
                ImageDiceLeft = "../../../Resources/monopoly/die/l2.png";
                break;
            case 3:
                ImageDiceLeft = "../../../Resources/monopoly/die/l3.png";
                break;
            case 4:
                ImageDiceLeft = "../../../Resources/monopoly/die/l4.png";
                break;
            case 5:
                ImageDiceLeft = "../../../Resources/monopoly/die/l5.png";
                break;
            case 6:
                ImageDiceLeft = "../../../Resources/monopoly/die/l6.png";
                break;
            }

            switch (rollInput[1]) {
            case 1:
                ImageDiceRight = "../../../Resources/monopoly/die/r1.png";
                break;
            case 2:
                ImageDiceRight = "../../../Resources/monopoly/die/r2.png";
                break;
            case 3:
                ImageDiceRight = "../../../Resources/monopoly/die/r3.png";
                break;
            case 4:
                ImageDiceRight = "../../../Resources/monopoly/die/r4.png";
                break;
            case 5:
                ImageDiceRight = "../../../Resources/monopoly/die/r5.png";
                break;
            case 6:
                ImageDiceRight = "../../../Resources/monopoly/die/r6.png";
                break;
            }

            if (rollInput[0] == rollInput[1]) {
                jailRollAmount++;
            }

            switch (jailRollAmount) {
            case 1:
                JailRollText = "Rolled Doubles! (Chance 1/3)";
                break;
            case 2:
                JailRollText = "Rolled Doubles! (Chance 2/3)";
                break;
            case 3:
                DieTotalText = "";
                JailRollText = "Get Rekt";
                JailVisibility = "VISIBLE";
                break;
            }
        }

        private void ButtonCommandLogic(object param) {
            switch (param) {
            case "roll":
                if (!hasRolled) {
                    /* testing */
                    int[] rollInput = {6, 1};
                    DieTotalText = (rollInput[0] + rollInput[1]).ToString();
                    hasRolled = true;
                    ButtonText = "Continue";

                    RollToImage(rollInput);
                }

                break;
            case "cont_exit":
                break;
            }
        }
    }
}