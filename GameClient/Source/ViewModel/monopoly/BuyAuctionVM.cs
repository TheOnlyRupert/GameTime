using System.Windows;
using System.Windows.Input;
using GameClient.Source.Reference;
using GameClient.Source.ViewModel.Base;

namespace GameClient.Source.ViewModel.monopoly {
    public class BuyAuctionVM : BaseViewModel {
        private int _currentPrice, _bidPrice, _yourAvailableCash, _timerText;
        private string _propertyImage, _purchaseVisibility;
        private bool isAuction;

        public BuyAuctionVM() {
            YourAvailableCash = 1500;
            CurrentPrice = 60;
            BidPrice = CurrentPrice;
            PropertyImage = ReferenceValues.MonopolyPropertyImageFromId(3);
            isAuction = false;
            TimerText = 30;

            PurchaseVisibility = isAuction ? "HIDDEN" : "VISIBLE";
        }

        public ICommand ButtonCommand => new DelegateCommand(ButtonCommandLogic, true);

        private void ButtonCommandLogic(object param) {
            switch (param) {
            case "propbuy":
                if (!isAuction) { }

                break;
            case "propbid":
                if (!isAuction) {
                    MessageBoxResult result = MessageBox.Show("Are you sure you want to create an auction for this property?",
                        "Send to Auction", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes) {
                        isAuction = true;
                        PurchaseVisibility = "HIDDEN";
                    }
                }

                break;
            case "yousub":
                BidPrice -= 1;
                if (BidPrice < 1) {
                    BidPrice = 1;
                }

                break;
            case "yousub10":
                BidPrice -= 10;
                if (BidPrice < 1) {
                    BidPrice = 1;
                }

                break;
            case "youadd":
                BidPrice += 1;
                if (BidPrice > YourAvailableCash) {
                    BidPrice = YourAvailableCash;
                }

                break;
            case "youadd10":
                BidPrice += 10;
                if (BidPrice > YourAvailableCash) {
                    BidPrice = YourAvailableCash;
                }

                break;
            case "bidplace":
                if (isAuction) { }

                break;
            case "bidleave":
                if (isAuction) { }

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

        public int CurrentPrice {
            get => _currentPrice;
            set {
                _currentPrice = value;
                RaisePropertyChangedEvent("CurrentPrice");
            }
        }

        public int BidPrice {
            get => _bidPrice;
            set {
                _bidPrice = value;
                RaisePropertyChangedEvent("BidPrice");
            }
        }

        public int YourAvailableCash {
            get => _yourAvailableCash;
            set {
                _yourAvailableCash = value;
                RaisePropertyChangedEvent("YourAvailableCash");
            }
        }

        public int TimerText {
            get => _timerText;
            set {
                _timerText = value;
                RaisePropertyChangedEvent("TimerText");
            }
        }

        public string PurchaseVisibility {
            get => _purchaseVisibility;
            set {
                _purchaseVisibility = value;
                RaisePropertyChangedEvent("PurchaseVisibility");
            }
        }

        #endregion
    }
}