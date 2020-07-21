using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using GameClient.Source.ViewModel.Base;

namespace GameClient.Source.ViewModel.monopoly {
    public class TradeRequestVM : BaseViewModel {
        private ObservableCollection<string> _partnerAvailableInventory, _partnerTradeInventory, _yourAvailableInventory, _yourTradeInventory;
        private string _partnerInventoryText;
        private readonly string partnerName;
        private int _yourAvailableCash, _partnerAvailableCash, _yourOfferingCash, _partnerRequestCash;

        public TradeRequestVM() {
            _yourAvailableInventory = new ObservableCollection<string>();
            _partnerAvailableInventory = new ObservableCollection<string>();
            _yourTradeInventory = new ObservableCollection<string>();
            _partnerTradeInventory = new ObservableCollection<string>();

            /* test */
            partnerName = "TheOnlyCletus";
            PartnerInventoryText = partnerName + "'s Inventory";
            YourAvailableCash = 1500;
            PartnerAvailableCash = 1500;
            YourOfferingCash = 0;
            PartnerRequestCash = 0;
            YourAvailableInventory.Add("pizzahut");
        }

        public ICommand ButtonCommand => new DelegateCommand(ButtonCommandLogic, true);

        private void ButtonCommandLogic(object param) {
            switch (param) {
            case "youadd":
                YourOfferingCash += 1;
                if (YourOfferingCash > YourAvailableCash) {
                    YourOfferingCash = YourAvailableCash;
                }

                break;
            case "youadd10":
                YourOfferingCash += 10;
                if (YourOfferingCash > YourAvailableCash) {
                    YourOfferingCash = YourAvailableCash;
                }

                break;
            case "yousub":
                YourOfferingCash -= 1;
                if (YourOfferingCash < 0) {
                    YourOfferingCash = 0;
                }

                break;
            case "yousub10":
                YourOfferingCash -= 10;
                if (YourOfferingCash < 0) {
                    YourOfferingCash = 0;
                }

                break;
            case "partneradd":
                PartnerRequestCash += 1;
                if (PartnerRequestCash > PartnerAvailableCash) {
                    PartnerRequestCash = PartnerAvailableCash;
                }

                break;
            case "partneradd10":
                PartnerRequestCash += 10;
                if (PartnerRequestCash > PartnerAvailableCash) {
                    PartnerRequestCash = PartnerAvailableCash;
                }

                break;
            case "partnersub":
                PartnerRequestCash -= 1;
                if (PartnerRequestCash < 0) {
                    PartnerRequestCash = 0;
                }

                break;
            case "partnersub10":
                PartnerRequestCash -= 10;
                if (PartnerRequestCash < 0) {
                    PartnerRequestCash = 0;
                }

                break;
            case "additemyour":
                break;
            case "additempartner":
                break;
            case "removeitemyour":
                break;
            case "removeitempartner":
                break;
            case "sendtrade":
                if (YourOfferingCash == 0 && YourTradeInventory.Count == 0) {
                    MessageBox.Show("You must include something to trade from your inventory\n(Item or cash).", "Unable to Send Request", MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                    break;
                }

                if (PartnerRequestCash == 0 && PartnerTradeInventory.Count == 0) {
                    MessageBox.Show("You must include something to trade from " + partnerName + "'s inventory\n(Item or cash)", "Unable to Send Request", MessageBoxButton.OK,
                        MessageBoxImage.Warning);
                    break;
                }

                if (YourTradeInventory.Count == 0 && PartnerTradeInventory.Count == 0) {
                    MessageBox.Show("You must add an item to be traded (Not just cash).", "Unable to Send Request", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

                break;
            }
        }

        #region Fields

        public int YourOfferingCash {
            get => _yourOfferingCash;
            set {
                _yourOfferingCash = value;
                RaisePropertyChangedEvent("YourOfferingCash");
            }
        }

        public int PartnerRequestCash {
            get => _partnerRequestCash;
            set {
                _partnerRequestCash = value;
                RaisePropertyChangedEvent("PartnerRequestCash");
            }
        }


        public int YourAvailableCash {
            get => _yourAvailableCash;
            set {
                _yourAvailableCash = value;
                RaisePropertyChangedEvent("AvailableCash");
            }
        }

        public int PartnerAvailableCash {
            get => _partnerAvailableCash;
            set {
                _partnerAvailableCash = value;
                RaisePropertyChangedEvent("PartnerAvailableCash");
            }
        }

        public ObservableCollection<string> YourAvailableInventory {
            get => _yourAvailableInventory;
            set {
                _yourAvailableInventory = value;
                RaisePropertyChangedEvent("YourAvailableInventory");
            }
        }

        public ObservableCollection<string> PartnerAvailableInventory {
            get => _partnerAvailableInventory;
            set {
                _partnerAvailableInventory = value;
                RaisePropertyChangedEvent("PartnerAvailableInventory");
            }
        }

        public ObservableCollection<string> YourTradeInventory {
            get => _yourTradeInventory;
            set {
                _yourTradeInventory = value;
                RaisePropertyChangedEvent("YourTradeInventory");
            }
        }

        public ObservableCollection<string> PartnerTradeInventory {
            get => _partnerTradeInventory;
            set {
                _partnerTradeInventory = value;
                RaisePropertyChangedEvent("PartnerTradeInventory");
            }
        }

        public string PartnerInventoryText {
            get => _partnerInventoryText;
            set {
                _partnerInventoryText = value;
                RaisePropertyChangedEvent("PartnerInventoryText");
            }
        }

        #endregion
    }
}