using System.Windows.Input;
using GameClient.Source.ViewModel.Base;

namespace GameClient.Source.ViewModel.monopoly {
    public class MonopolyVM : BaseViewModel {
        private string _chanceVisibility, _chestVisibility, _specialCardText;
        private int _player1LocationX, _player1LocationY;

        public MonopolyVM() {
            ChanceVisibility = "HIDDEN";
            ChestVisibility = "HIDDEN";
            SpecialCardText = "";

            MoveGamePieceHelper(0, 0);
        }

        public ICommand ButtonCommand => new DelegateCommand(ButtonCommandLogic, true);

        /* Tile starts at GO (id 0) ends at boardwalk (id 39)
         * Abstracts out the inconsistencies with the game board */
        private void MoveGamePieceHelper(int player, int tile) {
            int[] location = new int[2];

            switch (tile) {
            // GO
            case 0:
                location[0] = 475;
                location[1] = 475;

                break;
            // mediterranean
            case 1:
                location[0] = 350;
                location[1] = 475;

                break;
            // chest bottom
            case 2:
                location[0] = 265;
                location[1] = 475;

                break;
            // baltic
            case 3:
                location[0] = 178;
                location[1] = 475;

                break;
            // income tax
            case 4:
                location[0] = 90;
                location[1] = 475;

                break;
            // railroad reading
            case 5:
                location[0] = 3;
                location[1] = 475;

                break;
            // oriental
            case 6:
                location[0] = -85;
                location[1] = 475;

                break;
            // chance bottom
            case 7:
                location[0] = -173;
                location[1] = 475;

                break;
            // vermont
            case 8:
                location[0] = -260;
                location[1] = 475;

                break;
            // connecticut
            case 9:
                location[0] = -350;
                location[1] = 475;

                break;
            case 10:
                location[0] = -475;
                location[1] = 475;
                break;
            case 11:
                location[0] = -475;
                location[1] = 475;
                break;
            }

            switch (player) {
            case 0:
                Player1LocationX = location[0];
                Player1LocationY = location[1];
                break;
            }
        }

        private void ButtonCommandLogic(object param) {
            switch (param) {
            case "board_freeparking":
                break;
            case "board_kentucky":
                break;
            case "board_chancetop":
                break;
            case "board_indiana":
                break;
            case "board_illinois":
                break;
            case "board_railroadtop":
                break;
            case "board_atlantic":
                break;
            case "board_ventnor":
                break;
            case "board_waterworks":
                break;
            case "board_marvingardens":
                break;
            case "board_gotojail":
                break;
            case "board_newyork":
                break;
            case "board_tennessee":
                break;
            case "board_chestleft":
                break;
            case "board_stjamesplace":
                break;
            case "board_railroadleft":
                break;
            case "board_virginia":
                break;
            case "board_states":
                break;
            case "board_electriccompany":
                break;
            case "board_stcharlesplace":
                break;
            case "board_pacific":
                break;
            case "board_northcarolina":
                break;
            case "board_chestright":
                break;
            case "board_pennsylvania":
                break;
            case "board_railroadright":
                break;
            case "board_chanceright":
                break;
            case "board_parkplace":
                break;
            case "board_luxurytax":
                break;
            case "board_boardwalk":
                break;
            case "board_jail":
                break;
            case "board_connecticut":
                break;
            case "board_vermont":
                break;
            case "board_chancebottom":
                break;
            case "board_oriental":
                break;
            case "board_railroadbottom":
                break;
            case "board_incometax":
                break;
            case "board_baltic":
                break;
            case "board_chestbottom":
                break;
            case "board_mediterranean":
                break;
            case "board_go":
                break;
            }
        }

        #region Fields

        public string ChanceVisibility {
            get => _chanceVisibility;
            set {
                _chanceVisibility = value;
                RaisePropertyChangedEvent("ChanceVisibility");
            }
        }

        public string ChestVisibility {
            get => _chestVisibility;
            set {
                _chestVisibility = value;
                RaisePropertyChangedEvent("ChestVisibility");
            }
        }

        public string SpecialCardText {
            get => _specialCardText;
            set {
                _specialCardText = value;
                RaisePropertyChangedEvent("SpecialCardText");
            }
        }

        public int Player1LocationX {
            get => _player1LocationX;
            set {
                _player1LocationX = value;
                RaisePropertyChangedEvent("Player1LocationX");
            }
        }

        public int Player1LocationY {
            get => _player1LocationY;
            set {
                _player1LocationY = value;
                RaisePropertyChangedEvent("Player1LocationY");
            }
        }

        #endregion
    }
}