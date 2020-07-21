using GameClient.Source.ViewModel.Base;

namespace GameClient.Source.ViewModel.monopoly {
    public class SpecialCardsVM : BaseViewModel {
        private string _specialCardBackgroundImage, _specialCardText, _freeJailCardVisibility;

        public SpecialCardsVM() {
            FreeJailCardVisibility = "HIDDEN";
            ImageLogic(true, 6);
        }

        /* starts with chance than chest */
        private void ImageLogic(bool isChanceCard, int id) {
            if (isChanceCard) {
                SpecialCardBackgroundImage = "../../../Resources/monopoly/cards/chance.PNG";

                switch (id) {
                case 0:
                    SpecialCardText = "Advance to GO (Collect $200).";
                    break;
                case 1:
                    SpecialCardText = "Advance to Illinois Ave.";
                    break;
                case 2:
                    SpecialCardText = "Advance to St. Charles Place.";
                    break;
                case 3:
                    SpecialCardText =
                        "Advance to nearest Utility;\nIf unowned, you may buy it from the bank;\nIf owned, throw dice and pay owner a total of ten times the amount thrown.";
                    break;
                case 4:
                    /* THERE ARE TWO OF THESE! -- as shown at #16 */
                    SpecialCardText =
                        "Advance to nearest Railroad;\nIf unowned, you may buy it from the bank;\nIf owned, pay owner twice the rental to which they are otherwise entitled.";
                    break;
                case 5:
                    SpecialCardText = "Your stocks mature;\nCollect $50 from the bank.";
                    break;
                case 6:
                    SpecialCardText = "Get out of Jail Free;\nThis card may be kept until needed, traded, or sold.";
                    FreeJailCardVisibility = "VISIBLE";
                    break;
                case 7:
                    SpecialCardText = "Go Back Three Spaces.";
                    break;
                case 8:
                    SpecialCardText = "Go to Jail;\nGo directly to Jail;\nDo not pass GO, do not collect $200.";
                    break;
                case 9:
                    SpecialCardText = "Make general repairs on all your properties;\nFor each house pay $25, For each hotel pay $100.";
                    break;
                case 10:
                    SpecialCardText = "Speeding fine;\nPay $15.";
                    break;
                case 11:
                    SpecialCardText = "Take a ride on the Reading Railroad;\nAdvance to Reading Railroad.";
                    break;
                case 12:
                    SpecialCardText = "Take a walk on the Boardwalk;\nAdvance to Boardwalk.";
                    break;
                case 13:
                    SpecialCardText = "Get Rekt;\nPay each player $50.";
                    break;
                case 14:
                    SpecialCardText = "Your building and loan matures;\nCollect $150 from the bank.";
                    break;
                case 15:
                    SpecialCardText = "You have won a crossword competition;\nCollect $100 from the bank.";
                    break;
                case 16:
                    /* THIS IS DUPED ON PURPOSE */
                    SpecialCardText =
                        "Advance to nearest Railroad;\nIf unowned, you may buy it from the bank;\nIf owned, pay owner twice the rental to which they are otherwise entitled.";
                    break;
                }
            } else {
                SpecialCardBackgroundImage = "../../../Resources/monopoly/cards/chest.PNG";

                switch (id) {
                case 0:
                    SpecialCardText = "Advance to GO (Collect $200).";
                    break;
                case 1:
                    SpecialCardText = "Bank error in your favor;\nCollect $200 from the bank.";
                    break;
                case 2:
                    SpecialCardText = "Doctor's fees;\nPay $50.";
                    break;
                case 3:
                    SpecialCardText = "From sale of stock;\nCollect $50 from the bank.";
                    break;
                case 4:
                    SpecialCardText = "Get out of Jail Free;\nThis card may be kept until needed, traded, or sold.";
                    FreeJailCardVisibility = "VISIBLE";
                    break;
                case 5:
                    SpecialCardText = "Go to Jail;\nGo directly to Jail;\nDo not pass GO, do not collect $200.";
                    break;
                case 6:
                    SpecialCardText = "Grand Opera Night;\nCollect $50 from every player.";
                    break;
                case 7:
                    SpecialCardText = "Holiday fund matures;\nCollect $100 from the bank.";
                    break;
                case 8:
                    SpecialCardText = "Income tax refund;\nCollect $20 from the bank.";
                    break;
                case 9:
                    SpecialCardText = "It's your birthday;\nCollect $10 from every player.";
                    break;
                case 10:
                    SpecialCardText = "Life insurance matures;\nCollect $100 from the bank.";
                    break;
                case 11:
                    SpecialCardText = "Hospital fees;\nPay $50.";
                    break;
                case 12:
                    SpecialCardText = "School fees;\nPay $50.";
                    break;
                case 13:
                    SpecialCardText = "Consultancy service fee;\nCollect $25 from the bank.";
                    break;
                case 14:
                    SpecialCardText = "You are assessed for street repairs;\nFor each house pay $40, For each hotel pay $115.";
                    break;
                case 15:
                    SpecialCardText = "You have won second prize in a beauty contest;\nCollect $10 from the bank.";
                    break;
                case 16:
                    SpecialCardText = "Inheritance;\nCollect $100 from the bank.";
                    break;
                }
            }
        }

        #region Fields

        public string SpecialCardBackgroundImage {
            get => _specialCardBackgroundImage;
            set {
                _specialCardBackgroundImage = value;
                RaisePropertyChangedEvent("SpecialCardBackgroundImage");
            }
        }

        public string SpecialCardText {
            get => _specialCardText;
            set {
                _specialCardText = value;
                RaisePropertyChangedEvent("SpecialCardText");
            }
        }

        public string FreeJailCardVisibility {
            get => _freeJailCardVisibility;
            set {
                _freeJailCardVisibility = value;
                RaisePropertyChangedEvent("FreeJailCardVisibility");
            }
        }

        #endregion
    }
}