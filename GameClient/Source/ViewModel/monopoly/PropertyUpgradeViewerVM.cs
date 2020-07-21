using System.Windows.Input;
using GameClient.Source.ViewModel.Base;

namespace GameClient.Source.ViewModel.monopoly {
    public class PropertyUpgradeViewerVM : BaseViewModel {
        private string _houseAvailableText, _hotelAvailableText, _imageHotelVisibility1, _imageHotelVisibility2, _imageHotelVisibility3, _imageHotelVisibility4,
            _imageHotelVisibility5, _imageHotelVisibility6, _imageHotelVisibility7, _imageHotelVisibility8, _imageHotelVisibility9, _imageHotelVisibility10,
            _imageHotelVisibility11, _imageHotelVisibility12, _imageHouseVisibility1, _imageHouseVisibility2, _imageHouseVisibility3, _imageHouseVisibility4,
            _imageHouseVisibility5, _imageHouseVisibility6, _imageHouseVisibility7, _imageHouseVisibility8, _imageHouseVisibility9, _imageHouseVisibility10,
            _imageHouseVisibility11, _imageHouseVisibility12, _imageHouseVisibility13, _imageHouseVisibility14, _imageHouseVisibility15, _imageHouseVisibility16,
            _imageHouseVisibility17, _imageHouseVisibility18, _imageHouseVisibility19, _imageHouseVisibility20, _imageHouseVisibility21, _imageHouseVisibility22,
            _imageHouseVisibility23, _imageHouseVisibility24, _imageHouseVisibility25, _imageHouseVisibility26, _imageHouseVisibility27, _imageHouseVisibility28,
            _imageHouseVisibility29, _imageHouseVisibility30, _imageHouseVisibility31, _imageHouseVisibility32;

        private readonly int availableHouse;
        private readonly int availableHotel;

        public PropertyUpgradeViewerVM() {
            availableHouse = 32;
            availableHotel = 12;
            HouseAvailableText = availableHouse + " / 32";
            HotelAvailableText = availableHotel + " / 12";

            SetIconDisplay();
        }

        public ICommand ButtonCommand => new DelegateCommand(ButtonCommandLogic, true);

        private void ButtonCommandLogic(object param) {
            switch (param) {
            case "exit":
                break;
            }
        }

        private void SetIconDisplay() {
            ImageHouseVisibility1 = "HIDDEN";
            ImageHouseVisibility2 = "HIDDEN";
            ImageHouseVisibility3 = "HIDDEN";
            ImageHouseVisibility4 = "HIDDEN";
            ImageHouseVisibility5 = "HIDDEN";
            ImageHouseVisibility6 = "HIDDEN";
            ImageHouseVisibility7 = "HIDDEN";
            ImageHouseVisibility8 = "HIDDEN";
            ImageHouseVisibility9 = "HIDDEN";
            ImageHouseVisibility10 = "HIDDEN";
            ImageHouseVisibility11 = "HIDDEN";
            ImageHouseVisibility12 = "HIDDEN";
            ImageHouseVisibility13 = "HIDDEN";
            ImageHouseVisibility14 = "HIDDEN";
            ImageHouseVisibility15 = "HIDDEN";
            ImageHouseVisibility16 = "HIDDEN";
            ImageHouseVisibility17 = "HIDDEN";
            ImageHouseVisibility18 = "HIDDEN";
            ImageHouseVisibility19 = "HIDDEN";
            ImageHouseVisibility20 = "HIDDEN";
            ImageHouseVisibility21 = "HIDDEN";
            ImageHouseVisibility22 = "HIDDEN";
            ImageHouseVisibility23 = "HIDDEN";
            ImageHouseVisibility24 = "HIDDEN";
            ImageHouseVisibility25 = "HIDDEN";
            ImageHouseVisibility26 = "HIDDEN";
            ImageHouseVisibility27 = "HIDDEN";
            ImageHouseVisibility28 = "HIDDEN";
            ImageHouseVisibility29 = "HIDDEN";
            ImageHouseVisibility30 = "HIDDEN";
            ImageHouseVisibility31 = "HIDDEN";
            ImageHouseVisibility32 = "HIDDEN";
            ImageHotelVisibility1 = "HIDDEN";
            ImageHotelVisibility2 = "HIDDEN";
            ImageHotelVisibility3 = "HIDDEN";
            ImageHotelVisibility4 = "HIDDEN";
            ImageHotelVisibility5 = "HIDDEN";
            ImageHotelVisibility6 = "HIDDEN";
            ImageHotelVisibility7 = "HIDDEN";
            ImageHotelVisibility8 = "HIDDEN";
            ImageHotelVisibility9 = "HIDDEN";
            ImageHotelVisibility10 = "HIDDEN";
            ImageHotelVisibility11 = "HIDDEN";
            ImageHotelVisibility12 = "HIDDEN";

            switch (availableHouse) {
            case 1:
                ImageHouseVisibility1 = "VISIBLE";
                break;
            case 2:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                break;
            case 3:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                break;
            case 4:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                break;
            case 5:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                break;
            case 6:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                break;
            case 7:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                break;
            case 8:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                break;
            case 9:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                break;
            case 10:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                break;
            case 11:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                break;
            case 12:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                break;
            case 13:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                ImageHouseVisibility13 = "VISIBLE";
                break;
            case 14:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                ImageHouseVisibility13 = "VISIBLE";
                ImageHouseVisibility14 = "VISIBLE";
                break;
            case 15:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                ImageHouseVisibility13 = "VISIBLE";
                ImageHouseVisibility14 = "VISIBLE";
                ImageHouseVisibility15 = "VISIBLE";
                break;
            case 16:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                ImageHouseVisibility13 = "VISIBLE";
                ImageHouseVisibility14 = "VISIBLE";
                ImageHouseVisibility15 = "VISIBLE";
                ImageHouseVisibility16 = "VISIBLE";
                break;
            case 17:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                ImageHouseVisibility13 = "VISIBLE";
                ImageHouseVisibility14 = "VISIBLE";
                ImageHouseVisibility15 = "VISIBLE";
                ImageHouseVisibility16 = "VISIBLE";
                ImageHouseVisibility17 = "VISIBLE";
                break;
            case 18:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                ImageHouseVisibility13 = "VISIBLE";
                ImageHouseVisibility14 = "VISIBLE";
                ImageHouseVisibility15 = "VISIBLE";
                ImageHouseVisibility16 = "VISIBLE";
                ImageHouseVisibility17 = "VISIBLE";
                ImageHouseVisibility18 = "VISIBLE";
                break;
            case 19:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                ImageHouseVisibility13 = "VISIBLE";
                ImageHouseVisibility14 = "VISIBLE";
                ImageHouseVisibility15 = "VISIBLE";
                ImageHouseVisibility16 = "VISIBLE";
                ImageHouseVisibility17 = "VISIBLE";
                ImageHouseVisibility18 = "VISIBLE";
                ImageHouseVisibility19 = "VISIBLE";
                break;
            case 20:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                ImageHouseVisibility13 = "VISIBLE";
                ImageHouseVisibility14 = "VISIBLE";
                ImageHouseVisibility15 = "VISIBLE";
                ImageHouseVisibility16 = "VISIBLE";
                ImageHouseVisibility17 = "VISIBLE";
                ImageHouseVisibility18 = "VISIBLE";
                ImageHouseVisibility19 = "VISIBLE";
                ImageHouseVisibility20 = "VISIBLE";
                break;
            case 21:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                ImageHouseVisibility13 = "VISIBLE";
                ImageHouseVisibility14 = "VISIBLE";
                ImageHouseVisibility15 = "VISIBLE";
                ImageHouseVisibility16 = "VISIBLE";
                ImageHouseVisibility17 = "VISIBLE";
                ImageHouseVisibility18 = "VISIBLE";
                ImageHouseVisibility19 = "VISIBLE";
                ImageHouseVisibility20 = "VISIBLE";
                ImageHouseVisibility21 = "VISIBLE";
                break;
            case 22:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                ImageHouseVisibility13 = "VISIBLE";
                ImageHouseVisibility14 = "VISIBLE";
                ImageHouseVisibility15 = "VISIBLE";
                ImageHouseVisibility16 = "VISIBLE";
                ImageHouseVisibility17 = "VISIBLE";
                ImageHouseVisibility18 = "VISIBLE";
                ImageHouseVisibility19 = "VISIBLE";
                ImageHouseVisibility20 = "VISIBLE";
                ImageHouseVisibility21 = "VISIBLE";
                ImageHouseVisibility22 = "VISIBLE";
                break;
            case 23:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                ImageHouseVisibility13 = "VISIBLE";
                ImageHouseVisibility14 = "VISIBLE";
                ImageHouseVisibility15 = "VISIBLE";
                ImageHouseVisibility16 = "VISIBLE";
                ImageHouseVisibility17 = "VISIBLE";
                ImageHouseVisibility18 = "VISIBLE";
                ImageHouseVisibility19 = "VISIBLE";
                ImageHouseVisibility20 = "VISIBLE";
                ImageHouseVisibility21 = "VISIBLE";
                ImageHouseVisibility22 = "VISIBLE";
                ImageHouseVisibility23 = "VISIBLE";
                break;
            case 24:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                ImageHouseVisibility13 = "VISIBLE";
                ImageHouseVisibility14 = "VISIBLE";
                ImageHouseVisibility15 = "VISIBLE";
                ImageHouseVisibility16 = "VISIBLE";
                ImageHouseVisibility17 = "VISIBLE";
                ImageHouseVisibility18 = "VISIBLE";
                ImageHouseVisibility19 = "VISIBLE";
                ImageHouseVisibility20 = "VISIBLE";
                ImageHouseVisibility21 = "VISIBLE";
                ImageHouseVisibility22 = "VISIBLE";
                ImageHouseVisibility23 = "VISIBLE";
                ImageHouseVisibility24 = "VISIBLE";
                break;
            case 25:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                ImageHouseVisibility13 = "VISIBLE";
                ImageHouseVisibility14 = "VISIBLE";
                ImageHouseVisibility15 = "VISIBLE";
                ImageHouseVisibility16 = "VISIBLE";
                ImageHouseVisibility17 = "VISIBLE";
                ImageHouseVisibility18 = "VISIBLE";
                ImageHouseVisibility19 = "VISIBLE";
                ImageHouseVisibility20 = "VISIBLE";
                ImageHouseVisibility21 = "VISIBLE";
                ImageHouseVisibility22 = "VISIBLE";
                ImageHouseVisibility23 = "VISIBLE";
                ImageHouseVisibility24 = "VISIBLE";
                ImageHouseVisibility25 = "VISIBLE";
                break;
            case 26:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                ImageHouseVisibility13 = "VISIBLE";
                ImageHouseVisibility14 = "VISIBLE";
                ImageHouseVisibility15 = "VISIBLE";
                ImageHouseVisibility16 = "VISIBLE";
                ImageHouseVisibility17 = "VISIBLE";
                ImageHouseVisibility18 = "VISIBLE";
                ImageHouseVisibility19 = "VISIBLE";
                ImageHouseVisibility20 = "VISIBLE";
                ImageHouseVisibility21 = "VISIBLE";
                ImageHouseVisibility22 = "VISIBLE";
                ImageHouseVisibility23 = "VISIBLE";
                ImageHouseVisibility24 = "VISIBLE";
                ImageHouseVisibility25 = "VISIBLE";
                ImageHouseVisibility26 = "VISIBLE";
                break;
            case 27:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                ImageHouseVisibility13 = "VISIBLE";
                ImageHouseVisibility14 = "VISIBLE";
                ImageHouseVisibility15 = "VISIBLE";
                ImageHouseVisibility16 = "VISIBLE";
                ImageHouseVisibility17 = "VISIBLE";
                ImageHouseVisibility18 = "VISIBLE";
                ImageHouseVisibility19 = "VISIBLE";
                ImageHouseVisibility20 = "VISIBLE";
                ImageHouseVisibility21 = "VISIBLE";
                ImageHouseVisibility22 = "VISIBLE";
                ImageHouseVisibility23 = "VISIBLE";
                ImageHouseVisibility24 = "VISIBLE";
                ImageHouseVisibility25 = "VISIBLE";
                ImageHouseVisibility26 = "VISIBLE";
                ImageHouseVisibility27 = "VISIBLE";
                break;
            case 28:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                ImageHouseVisibility13 = "VISIBLE";
                ImageHouseVisibility14 = "VISIBLE";
                ImageHouseVisibility15 = "VISIBLE";
                ImageHouseVisibility16 = "VISIBLE";
                ImageHouseVisibility17 = "VISIBLE";
                ImageHouseVisibility18 = "VISIBLE";
                ImageHouseVisibility19 = "VISIBLE";
                ImageHouseVisibility20 = "VISIBLE";
                ImageHouseVisibility21 = "VISIBLE";
                ImageHouseVisibility22 = "VISIBLE";
                ImageHouseVisibility23 = "VISIBLE";
                ImageHouseVisibility24 = "VISIBLE";
                ImageHouseVisibility25 = "VISIBLE";
                ImageHouseVisibility26 = "VISIBLE";
                ImageHouseVisibility27 = "VISIBLE";
                ImageHouseVisibility28 = "VISIBLE";
                break;
            case 29:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                ImageHouseVisibility13 = "VISIBLE";
                ImageHouseVisibility14 = "VISIBLE";
                ImageHouseVisibility15 = "VISIBLE";
                ImageHouseVisibility16 = "VISIBLE";
                ImageHouseVisibility17 = "VISIBLE";
                ImageHouseVisibility18 = "VISIBLE";
                ImageHouseVisibility19 = "VISIBLE";
                ImageHouseVisibility20 = "VISIBLE";
                ImageHouseVisibility21 = "VISIBLE";
                ImageHouseVisibility22 = "VISIBLE";
                ImageHouseVisibility23 = "VISIBLE";
                ImageHouseVisibility24 = "VISIBLE";
                ImageHouseVisibility25 = "VISIBLE";
                ImageHouseVisibility26 = "VISIBLE";
                ImageHouseVisibility27 = "VISIBLE";
                ImageHouseVisibility28 = "VISIBLE";
                ImageHouseVisibility29 = "VISIBLE";
                break;
            case 30:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                ImageHouseVisibility13 = "VISIBLE";
                ImageHouseVisibility14 = "VISIBLE";
                ImageHouseVisibility15 = "VISIBLE";
                ImageHouseVisibility16 = "VISIBLE";
                ImageHouseVisibility17 = "VISIBLE";
                ImageHouseVisibility18 = "VISIBLE";
                ImageHouseVisibility19 = "VISIBLE";
                ImageHouseVisibility20 = "VISIBLE";
                ImageHouseVisibility21 = "VISIBLE";
                ImageHouseVisibility22 = "VISIBLE";
                ImageHouseVisibility23 = "VISIBLE";
                ImageHouseVisibility24 = "VISIBLE";
                ImageHouseVisibility25 = "VISIBLE";
                ImageHouseVisibility26 = "VISIBLE";
                ImageHouseVisibility27 = "VISIBLE";
                ImageHouseVisibility28 = "VISIBLE";
                ImageHouseVisibility29 = "VISIBLE";
                ImageHouseVisibility30 = "VISIBLE";
                break;
            case 31:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                ImageHouseVisibility13 = "VISIBLE";
                ImageHouseVisibility14 = "VISIBLE";
                ImageHouseVisibility15 = "VISIBLE";
                ImageHouseVisibility16 = "VISIBLE";
                ImageHouseVisibility17 = "VISIBLE";
                ImageHouseVisibility18 = "VISIBLE";
                ImageHouseVisibility19 = "VISIBLE";
                ImageHouseVisibility20 = "VISIBLE";
                ImageHouseVisibility21 = "VISIBLE";
                ImageHouseVisibility22 = "VISIBLE";
                ImageHouseVisibility23 = "VISIBLE";
                ImageHouseVisibility24 = "VISIBLE";
                ImageHouseVisibility25 = "VISIBLE";
                ImageHouseVisibility26 = "VISIBLE";
                ImageHouseVisibility27 = "VISIBLE";
                ImageHouseVisibility28 = "VISIBLE";
                ImageHouseVisibility29 = "VISIBLE";
                ImageHouseVisibility30 = "VISIBLE";
                ImageHouseVisibility31 = "VISIBLE";
                break;
            case 32:
                ImageHouseVisibility1 = "VISIBLE";
                ImageHouseVisibility2 = "VISIBLE";
                ImageHouseVisibility3 = "VISIBLE";
                ImageHouseVisibility4 = "VISIBLE";
                ImageHouseVisibility5 = "VISIBLE";
                ImageHouseVisibility6 = "VISIBLE";
                ImageHouseVisibility7 = "VISIBLE";
                ImageHouseVisibility8 = "VISIBLE";
                ImageHouseVisibility9 = "VISIBLE";
                ImageHouseVisibility10 = "VISIBLE";
                ImageHouseVisibility11 = "VISIBLE";
                ImageHouseVisibility12 = "VISIBLE";
                ImageHouseVisibility13 = "VISIBLE";
                ImageHouseVisibility14 = "VISIBLE";
                ImageHouseVisibility15 = "VISIBLE";
                ImageHouseVisibility16 = "VISIBLE";
                ImageHouseVisibility17 = "VISIBLE";
                ImageHouseVisibility18 = "VISIBLE";
                ImageHouseVisibility19 = "VISIBLE";
                ImageHouseVisibility20 = "VISIBLE";
                ImageHouseVisibility21 = "VISIBLE";
                ImageHouseVisibility22 = "VISIBLE";
                ImageHouseVisibility23 = "VISIBLE";
                ImageHouseVisibility24 = "VISIBLE";
                ImageHouseVisibility25 = "VISIBLE";
                ImageHouseVisibility26 = "VISIBLE";
                ImageHouseVisibility27 = "VISIBLE";
                ImageHouseVisibility28 = "VISIBLE";
                ImageHouseVisibility29 = "VISIBLE";
                ImageHouseVisibility30 = "VISIBLE";
                ImageHouseVisibility31 = "VISIBLE";
                ImageHouseVisibility32 = "VISIBLE";
                break;
            }

            switch (availableHotel) {
            case 1:
                ImageHotelVisibility1 = "VISIBLE";
                break;
            case 2:
                ImageHotelVisibility1 = "VISIBLE";
                ImageHotelVisibility2 = "VISIBLE";
                break;
            case 3:
                ImageHotelVisibility1 = "VISIBLE";
                ImageHotelVisibility2 = "VISIBLE";
                ImageHotelVisibility3 = "VISIBLE";
                break;
            case 4:
                ImageHotelVisibility1 = "VISIBLE";
                ImageHotelVisibility2 = "VISIBLE";
                ImageHotelVisibility3 = "VISIBLE";
                ImageHotelVisibility4 = "VISIBLE";
                break;
            case 5:
                ImageHotelVisibility1 = "VISIBLE";
                ImageHotelVisibility2 = "VISIBLE";
                ImageHotelVisibility3 = "VISIBLE";
                ImageHotelVisibility4 = "VISIBLE";
                ImageHotelVisibility5 = "VISIBLE";
                break;
            case 6:
                ImageHotelVisibility1 = "VISIBLE";
                ImageHotelVisibility2 = "VISIBLE";
                ImageHotelVisibility3 = "VISIBLE";
                ImageHotelVisibility4 = "VISIBLE";
                ImageHotelVisibility5 = "VISIBLE";
                ImageHotelVisibility6 = "VISIBLE";
                break;
            case 7:
                ImageHotelVisibility1 = "VISIBLE";
                ImageHotelVisibility2 = "VISIBLE";
                ImageHotelVisibility3 = "VISIBLE";
                ImageHotelVisibility4 = "VISIBLE";
                ImageHotelVisibility5 = "VISIBLE";
                ImageHotelVisibility6 = "VISIBLE";
                ImageHotelVisibility7 = "VISIBLE";
                break;
            case 8:
                ImageHotelVisibility1 = "VISIBLE";
                ImageHotelVisibility2 = "VISIBLE";
                ImageHotelVisibility3 = "VISIBLE";
                ImageHotelVisibility4 = "VISIBLE";
                ImageHotelVisibility5 = "VISIBLE";
                ImageHotelVisibility6 = "VISIBLE";
                ImageHotelVisibility7 = "VISIBLE";
                ImageHotelVisibility8 = "VISIBLE";
                break;
            case 9:
                ImageHotelVisibility1 = "VISIBLE";
                ImageHotelVisibility2 = "VISIBLE";
                ImageHotelVisibility3 = "VISIBLE";
                ImageHotelVisibility4 = "VISIBLE";
                ImageHotelVisibility5 = "VISIBLE";
                ImageHotelVisibility6 = "VISIBLE";
                ImageHotelVisibility7 = "VISIBLE";
                ImageHotelVisibility8 = "VISIBLE";
                ImageHotelVisibility9 = "VISIBLE";
                break;
            case 10:
                ImageHotelVisibility1 = "VISIBLE";
                ImageHotelVisibility2 = "VISIBLE";
                ImageHotelVisibility3 = "VISIBLE";
                ImageHotelVisibility4 = "VISIBLE";
                ImageHotelVisibility5 = "VISIBLE";
                ImageHotelVisibility6 = "VISIBLE";
                ImageHotelVisibility7 = "VISIBLE";
                ImageHotelVisibility8 = "VISIBLE";
                ImageHotelVisibility9 = "VISIBLE";
                ImageHotelVisibility10 = "VISIBLE";
                break;
            case 11:
                ImageHotelVisibility1 = "VISIBLE";
                ImageHotelVisibility2 = "VISIBLE";
                ImageHotelVisibility3 = "VISIBLE";
                ImageHotelVisibility4 = "VISIBLE";
                ImageHotelVisibility5 = "VISIBLE";
                ImageHotelVisibility6 = "VISIBLE";
                ImageHotelVisibility7 = "VISIBLE";
                ImageHotelVisibility8 = "VISIBLE";
                ImageHotelVisibility9 = "VISIBLE";
                ImageHotelVisibility10 = "VISIBLE";
                ImageHotelVisibility11 = "VISIBLE";
                break;
            case 12:
                ImageHotelVisibility1 = "VISIBLE";
                ImageHotelVisibility2 = "VISIBLE";
                ImageHotelVisibility3 = "VISIBLE";
                ImageHotelVisibility4 = "VISIBLE";
                ImageHotelVisibility5 = "VISIBLE";
                ImageHotelVisibility6 = "VISIBLE";
                ImageHotelVisibility7 = "VISIBLE";
                ImageHotelVisibility8 = "VISIBLE";
                ImageHotelVisibility9 = "VISIBLE";
                ImageHotelVisibility10 = "VISIBLE";
                ImageHotelVisibility11 = "VISIBLE";
                ImageHotelVisibility12 = "VISIBLE";
                break;
            }
        }

        #region Fields

        public string HouseAvailableText {
            get => _houseAvailableText;
            set {
                _houseAvailableText = value;
                RaisePropertyChangedEvent("HouseAvailableText");
            }
        }

        public string HotelAvailableText {
            get => _hotelAvailableText;
            set {
                _hotelAvailableText = value;
                RaisePropertyChangedEvent("HotelAvailableText");
            }
        }

        public string ImageHouseVisibility1 {
            get => _imageHouseVisibility1;
            set {
                _imageHouseVisibility1 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility1");
            }
        }

        public string ImageHouseVisibility2 {
            get => _imageHouseVisibility2;
            set {
                _imageHouseVisibility2 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility2");
            }
        }

        public string ImageHouseVisibility3 {
            get => _imageHouseVisibility3;
            set {
                _imageHouseVisibility3 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility3");
            }
        }

        public string ImageHouseVisibility4 {
            get => _imageHouseVisibility4;
            set {
                _imageHouseVisibility4 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility4");
            }
        }

        public string ImageHouseVisibility5 {
            get => _imageHouseVisibility5;
            set {
                _imageHouseVisibility5 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility5");
            }
        }

        public string ImageHouseVisibility6 {
            get => _imageHouseVisibility6;
            set {
                _imageHouseVisibility6 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility6");
            }
        }

        public string ImageHouseVisibility7 {
            get => _imageHouseVisibility7;
            set {
                _imageHouseVisibility7 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility7");
            }
        }

        public string ImageHouseVisibility8 {
            get => _imageHouseVisibility8;
            set {
                _imageHouseVisibility8 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility8");
            }
        }

        public string ImageHouseVisibility9 {
            get => _imageHouseVisibility9;
            set {
                _imageHouseVisibility9 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility9");
            }
        }

        public string ImageHouseVisibility10 {
            get => _imageHouseVisibility10;
            set {
                _imageHouseVisibility10 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility10");
            }
        }

        public string ImageHouseVisibility11 {
            get => _imageHouseVisibility11;
            set {
                _imageHouseVisibility11 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility11");
            }
        }

        public string ImageHouseVisibility12 {
            get => _imageHouseVisibility12;
            set {
                _imageHouseVisibility12 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility12");
            }
        }

        public string ImageHouseVisibility13 {
            get => _imageHouseVisibility13;
            set {
                _imageHouseVisibility13 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility13");
            }
        }

        public string ImageHouseVisibility14 {
            get => _imageHouseVisibility14;
            set {
                _imageHouseVisibility14 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility14");
            }
        }

        public string ImageHouseVisibility15 {
            get => _imageHouseVisibility15;
            set {
                _imageHouseVisibility15 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility15");
            }
        }

        public string ImageHouseVisibility16 {
            get => _imageHouseVisibility16;
            set {
                _imageHouseVisibility16 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility16");
            }
        }

        public string ImageHouseVisibility17 {
            get => _imageHouseVisibility17;
            set {
                _imageHouseVisibility17 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility17");
            }
        }

        public string ImageHouseVisibility18 {
            get => _imageHouseVisibility18;
            set {
                _imageHouseVisibility18 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility18");
            }
        }

        public string ImageHouseVisibility19 {
            get => _imageHouseVisibility19;
            set {
                _imageHouseVisibility19 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility19");
            }
        }

        public string ImageHouseVisibility20 {
            get => _imageHouseVisibility20;
            set {
                _imageHouseVisibility20 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility20");
            }
        }

        public string ImageHouseVisibility21 {
            get => _imageHouseVisibility21;
            set {
                _imageHouseVisibility21 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility21");
            }
        }

        public string ImageHouseVisibility22 {
            get => _imageHouseVisibility22;
            set {
                _imageHouseVisibility22 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility22");
            }
        }

        public string ImageHouseVisibility23 {
            get => _imageHouseVisibility23;
            set {
                _imageHouseVisibility23 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility23");
            }
        }

        public string ImageHouseVisibility24 {
            get => _imageHouseVisibility24;
            set {
                _imageHouseVisibility24 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility24");
            }
        }

        public string ImageHouseVisibility25 {
            get => _imageHouseVisibility25;
            set {
                _imageHouseVisibility25 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility25");
            }
        }

        public string ImageHouseVisibility26 {
            get => _imageHouseVisibility26;
            set {
                _imageHouseVisibility26 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility26");
            }
        }

        public string ImageHouseVisibility27 {
            get => _imageHouseVisibility27;
            set {
                _imageHouseVisibility27 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility27");
            }
        }

        public string ImageHouseVisibility28 {
            get => _imageHouseVisibility28;
            set {
                _imageHouseVisibility28 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility28");
            }
        }

        public string ImageHouseVisibility29 {
            get => _imageHouseVisibility29;
            set {
                _imageHouseVisibility29 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility29");
            }
        }

        public string ImageHouseVisibility30 {
            get => _imageHouseVisibility30;
            set {
                _imageHouseVisibility30 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility30");
            }
        }

        public string ImageHouseVisibility31 {
            get => _imageHouseVisibility31;
            set {
                _imageHouseVisibility31 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility31");
            }
        }

        public string ImageHouseVisibility32 {
            get => _imageHouseVisibility32;
            set {
                _imageHouseVisibility32 = value;
                RaisePropertyChangedEvent("ImageHouseVisibility32");
            }
        }

        public string ImageHotelVisibility1 {
            get => _imageHotelVisibility1;
            set {
                _imageHotelVisibility1 = value;
                RaisePropertyChangedEvent("ImageHotelVisibility1");
            }
        }

        public string ImageHotelVisibility2 {
            get => _imageHotelVisibility2;
            set {
                _imageHotelVisibility2 = value;
                RaisePropertyChangedEvent("ImageHotelVisibility2");
            }
        }

        public string ImageHotelVisibility3 {
            get => _imageHotelVisibility3;
            set {
                _imageHotelVisibility3 = value;
                RaisePropertyChangedEvent("ImageHotelVisibility3");
            }
        }

        public string ImageHotelVisibility4 {
            get => _imageHotelVisibility4;
            set {
                _imageHotelVisibility4 = value;
                RaisePropertyChangedEvent("ImageHotelVisibility4");
            }
        }

        public string ImageHotelVisibility5 {
            get => _imageHotelVisibility5;
            set {
                _imageHotelVisibility5 = value;
                RaisePropertyChangedEvent("ImageHotelVisibility5");
            }
        }

        public string ImageHotelVisibility6 {
            get => _imageHotelVisibility6;
            set {
                _imageHotelVisibility6 = value;
                RaisePropertyChangedEvent("ImageHotelVisibility6");
            }
        }

        public string ImageHotelVisibility7 {
            get => _imageHotelVisibility7;
            set {
                _imageHotelVisibility7 = value;
                RaisePropertyChangedEvent("ImageHotelVisibility7");
            }
        }

        public string ImageHotelVisibility8 {
            get => _imageHotelVisibility8;
            set {
                _imageHotelVisibility8 = value;
                RaisePropertyChangedEvent("ImageHotelVisibility8");
            }
        }

        public string ImageHotelVisibility9 {
            get => _imageHotelVisibility9;
            set {
                _imageHotelVisibility9 = value;
                RaisePropertyChangedEvent("ImageHotelVisibility9");
            }
        }

        public string ImageHotelVisibility10 {
            get => _imageHotelVisibility10;
            set {
                _imageHotelVisibility10 = value;
                RaisePropertyChangedEvent("ImageHotelVisibility10");
            }
        }

        public string ImageHotelVisibility11 {
            get => _imageHotelVisibility11;
            set {
                _imageHotelVisibility11 = value;
                RaisePropertyChangedEvent("ImageHotelVisibility11");
            }
        }

        public string ImageHotelVisibility12 {
            get => _imageHotelVisibility12;
            set {
                _imageHotelVisibility12 = value;
                RaisePropertyChangedEvent("ImageHotelVisibility12");
            }
        }

        #endregion
    }
}