using System.Windows;
using System.Windows.Input;
using GameClient.Source.Reference;
using GameClient.Source.ViewModel.Base;

namespace GameClient.Source.ViewModel.monopoly {
    public class RentPaymentVM : BaseViewModel {
        private string _paymentReasonText, _propertyImage;
        private int _yourAvailableCash;
        private readonly int propertyAmount;

        public RentPaymentVM() {
            propertyAmount = 450;
            PaymentReasonText = "You owe TheOnlyCletus  $" + propertyAmount + "  for rent.";
            YourAvailableCash = 100;
            PropertyImage = ReferenceValues.MonopolyPropertyImageFromId(3);
        }

        public ICommand ButtonCommand => new DelegateCommand(ButtonCommandLogic, true);

        private void ButtonCommandLogic(object param) {
            switch (param) {
            case "pay":
                if (YourAvailableCash < propertyAmount) {
                    MessageBox.Show("You are unable to afford this payment at this time.\nPlease come back later once you aren't so poor.",
                        "Unable to Afford", MessageBoxButton.OK);
                }

                break;
            case "exit":
                break;
            }
        }

        #region Fields

        public string PaymentReasonText {
            get => _paymentReasonText;
            set {
                _paymentReasonText = value;
                RaisePropertyChangedEvent("PaymentReasonText");
            }
        }

        public string PropertyImage {
            get => _propertyImage;
            set {
                _propertyImage = value;
                RaisePropertyChangedEvent("PropertyImage");
            }
        }

        public int YourAvailableCash {
            get => _yourAvailableCash;
            set {
                _yourAvailableCash = value;
                RaisePropertyChangedEvent("YourAvailableCash");
            }
        }

        #endregion
    }
}