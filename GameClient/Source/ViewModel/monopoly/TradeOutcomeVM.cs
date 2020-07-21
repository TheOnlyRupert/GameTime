using System.Collections.ObjectModel;
using GameClient.Source.ViewModel.Base;

namespace GameClient.Source.ViewModel.monopoly {
    public class TradeOutcomeVM : BaseViewModel {
        private string _tradeText, _outcomeText, _outcomeBackgroundColor, _exitButtonText;
        private int _yourOfferingCash, _partnerRequestCash, _timerText;
        private ObservableCollection<string> _yourTradeInventory, _partnerTradeInventory;

        public TradeOutcomeVM() {
            _yourTradeInventory = new ObservableCollection<string>();
            _partnerTradeInventory = new ObservableCollection<string>();

            TradeText = "Your Trade Request With TheOnlyCletus";
            ExitButtonText = "Cancel Request";
            OutcomeText = "PENDING";
            OutcomeBackgroundColor = "Yellow";
            YourOfferingCash = 0;
            PartnerRequestCash = 0;
            TimerText = 30;
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

        public string TradeText {
            get => _tradeText;
            set {
                _tradeText = value;
                RaisePropertyChangedEvent("TradeText");
            }
        }

        public string OutcomeText {
            get => _outcomeText;
            set {
                _outcomeText = value;
                RaisePropertyChangedEvent("OutcomeText");
            }
        }

        public string OutcomeBackgroundColor {
            get => _outcomeBackgroundColor;
            set {
                _outcomeBackgroundColor = value;
                RaisePropertyChangedEvent("OutcomeBackgroundColor");
            }
        }

        public int TimerText {
            get => _timerText;
            set {
                _timerText = value;
                RaisePropertyChangedEvent("TimerText");
            }
        }

        public string ExitButtonText {
            get => _exitButtonText;
            set {
                _exitButtonText = value;
                RaisePropertyChangedEvent("ExitButtonText");
            }
        }

        #endregion
    }
}