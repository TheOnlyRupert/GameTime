using System.Windows.Input;
using GameClient.Source.Reference;
using GameClient.Source.ViewModel.Base;

namespace GameClient.Source.ViewModel.monopoly {
    public class PropertyManagerVM : BaseViewModel {
        private readonly bool isMortgaged;
        private readonly bool isUpgradable;
        private int _currentRent;
        private readonly int mortgagePrice;

        private string _propertyImage, _upgradeLevelText, _ownershipLevelText, _groupOwnerColor1, _groupOwnerColor2, _groupOwnerColor3, _groupOwnerColor4, _upgradeVisibility1,
            _upgradeVisibility2, _upgradeVisibility3, _upgradeVisibility4, _upgradeVisibility5, _mortgageVisibility, _upgradeMasterVisibility, _mortgageButtonText;

        public PropertyManagerVM() {
            PropertyImage = ReferenceValues.MonopolyPropertyImageFromId(3);
            isMortgaged = true;
            isUpgradable = true;
            mortgagePrice = 33;
            CurrentRent = 0;

            SetIconDisplay(1, new[] {2, 2}, 0);
        }

        public ICommand ButtonCommand => new DelegateCommand(ButtonCommandLogic, true);

        /* colorID list: 0 black, 1 darkPurple, 2 lightBlue, 3 pink, 4 orange, 5 red, 6 yellow, 7 green, 8 darkBlue
         * If upgradeAmount[0] == -1,  property is not able to be upgraded... Not needed */
        private void SetIconDisplay(int colorID, int[] ownedAmount, int upgradeAmount) {
            string color = "Black";

            /* set to defaults at start */
            GroupOwnerColor2 = "Transparent";
            GroupOwnerColor3 = "Transparent";
            GroupOwnerColor4 = "Transparent";
            UpgradeMasterVisibility = "COLLAPSED";
            UpgradeVisibility1 = "HIDDEN";
            UpgradeVisibility2 = "HIDDEN";
            UpgradeVisibility3 = "HIDDEN";
            UpgradeVisibility4 = "HIDDEN";
            UpgradeVisibility5 = "HIDDEN";

            OwnershipLevelText = ownedAmount[0] + "/" + ownedAmount[1];

            if (isUpgradable) {
                UpgradeMasterVisibility = "VISIBLE";
                UpgradeLevelText = upgradeAmount + "/5";
                switch (upgradeAmount) {
                case 1:
                    UpgradeVisibility1 = "VISIBLE";
                    break;
                case 2:
                    UpgradeVisibility1 = "VISIBLE";
                    UpgradeVisibility2 = "VISIBLE";
                    break;
                case 3:
                    UpgradeVisibility1 = "VISIBLE";
                    UpgradeVisibility2 = "VISIBLE";
                    UpgradeVisibility3 = "VISIBLE";
                    break;
                case 4:
                    UpgradeVisibility1 = "VISIBLE";
                    UpgradeVisibility2 = "VISIBLE";
                    UpgradeVisibility3 = "VISIBLE";
                    UpgradeVisibility4 = "VISIBLE";
                    break;
                case 5:
                    UpgradeVisibility1 = "VISIBLE";
                    UpgradeVisibility2 = "VISIBLE";
                    UpgradeVisibility3 = "VISIBLE";
                    UpgradeVisibility4 = "VISIBLE";
                    UpgradeVisibility5 = "VISIBLE";
                    break;
                }
            } else {
                UpgradeLevelText = "N/A";
            }

            switch (colorID) {
            case 1:
                color = "Purple";
                break;
            case 2:
                color = "CornflowerBlue";
                break;
            case 3:
                color = "HotPink";
                break;
            case 4:
                color = "Orange";
                break;
            case 5:
                color = "Red";
                break;
            case 6:
                color = "Yellow";
                break;
            case 7:
                color = "Green";
                break;
            case 8:
                color = "MediumBlue";
                break;
            }

            GroupOwnerColor1 = color;

            switch (ownedAmount[0]) {
            case 2:
                GroupOwnerColor2 = color;
                break;
            case 3:
                GroupOwnerColor2 = color;
                GroupOwnerColor3 = color;
                break;
            case 4:
                GroupOwnerColor2 = color;
                GroupOwnerColor3 = color;
                GroupOwnerColor4 = color;
                break;
            }

            MortgageVisibility = isMortgaged ? "VISIBLE" : "HIDDEN";

            if (isMortgaged) {
                MortgageVisibility = "VISIBLE";
                MortgageButtonText = "Un-mortgage (Cost $" + mortgagePrice + ")";
                CurrentRent = 0;
            } else {
                MortgageVisibility = "HIDDEN";
                MortgageButtonText = "Mortgage";
            }
        }

        private void ButtonCommandLogic(object param) {
            switch (param) {
            case "mortgage":
                break;
            case "upgrade":
                break;
            case "degrade":
                break;
            case "exit":
                break;
            }
        }

        #region Fields

        public string PropertyImage {
            get => _propertyImage;
            set {
                _propertyImage = value;
                RaisePropertyChangedEvent("PropertyImage");
            }
        }

        public string UpgradeLevelText {
            get => _upgradeLevelText;
            set {
                _upgradeLevelText = value;
                RaisePropertyChangedEvent("UpgradeLevelText");
            }
        }

        public string OwnershipLevelText {
            get => _ownershipLevelText;
            set {
                _ownershipLevelText = value;
                RaisePropertyChangedEvent("OwnershipLevelText");
            }
        }

        public int CurrentRent {
            get => _currentRent;
            set {
                _currentRent = value;
                RaisePropertyChangedEvent("CurrentRent");
            }
        }

        public string GroupOwnerColor1 {
            get => _groupOwnerColor1;
            set {
                _groupOwnerColor1 = value;
                RaisePropertyChangedEvent("GroupOwnerColor1");
            }
        }

        public string GroupOwnerColor2 {
            get => _groupOwnerColor2;
            set {
                _groupOwnerColor2 = value;
                RaisePropertyChangedEvent("GroupOwnerColor2");
            }
        }

        public string GroupOwnerColor3 {
            get => _groupOwnerColor3;
            set {
                _groupOwnerColor3 = value;
                RaisePropertyChangedEvent("GroupOwnerColor3");
            }
        }

        public string GroupOwnerColor4 {
            get => _groupOwnerColor4;
            set {
                _groupOwnerColor4 = value;
                RaisePropertyChangedEvent("GroupOwnerColor4");
            }
        }

        public string UpgradeMasterVisibility {
            get => _upgradeMasterVisibility;
            set {
                _upgradeMasterVisibility = value;
                RaisePropertyChangedEvent("UpgradeMasterVisibility");
            }
        }

        public string UpgradeVisibility1 {
            get => _upgradeVisibility1;
            set {
                _upgradeVisibility1 = value;
                RaisePropertyChangedEvent("UpgradeVisibility1");
            }
        }

        public string UpgradeVisibility2 {
            get => _upgradeVisibility2;
            set {
                _upgradeVisibility2 = value;
                RaisePropertyChangedEvent("UpgradeVisibility2");
            }
        }

        public string UpgradeVisibility3 {
            get => _upgradeVisibility3;
            set {
                _upgradeVisibility3 = value;
                RaisePropertyChangedEvent("UpgradeVisibility3");
            }
        }

        public string UpgradeVisibility4 {
            get => _upgradeVisibility4;
            set {
                _upgradeVisibility4 = value;
                RaisePropertyChangedEvent("UpgradeVisibility4");
            }
        }

        public string UpgradeVisibility5 {
            get => _upgradeVisibility5;
            set {
                _upgradeVisibility5 = value;
                RaisePropertyChangedEvent("UpgradeVisibility5");
            }
        }

        public string MortgageVisibility {
            get => _mortgageVisibility;
            set {
                _mortgageVisibility = value;
                RaisePropertyChangedEvent("MortgageVisibility");
            }
        }

        public string MortgageButtonText {
            get => _mortgageButtonText;
            set {
                _mortgageButtonText = value;
                RaisePropertyChangedEvent("MortgageButtonText");
            }
        }

        #endregion
    }
}