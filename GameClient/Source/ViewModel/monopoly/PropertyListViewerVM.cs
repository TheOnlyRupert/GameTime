using System.Windows.Input;
using GameClient.Source.ViewModel.Base;

namespace GameClient.Source.ViewModel.monopoly {
    public class PropertyListViewerVM : BaseViewModel {
        private string _propStateMediterranean, _propOwnerMediterranean, _propStateBaltic, _propOwnerBaltic, _propStateOriental, _propOwnerOriental, _propStateVermont,
            _propOwnerVermont, _propStateConnecticut, _propOwnerConnecticut, _propStateStcharles, _propOwnerStcharles, _propStateStates, _propOwnerStates, _propStateVirginia,
            _propOwnerVirginia, _propStateStjames, _propOwnerStjames, _propStateTennessee, _propOwnerTennessee, _propStateNewyork, _propOwnerNewyork, _propStateKentucky,
            _propOwnerKentucky, _propStateIndiana, _propOwnerIndiana, _propStateIllinois, _propOwnerIllinois, _propStateAtlantic, _propOwnerAtlantic, _propStateVentnor,
            _propOwnerVentnor, _propStateMarvingardens, _propOwnerMarvingardens, _propStatePacific, _propOwnerPacific, _propStateNorthcarolina, _propOwnerNorthcarolina,
            _propStatePennsylvania, _propOwnerPennsylvania, _propStateParkplace, _propOwnerParkplace, _propStateBoardwalk, _propOwnerBoardwalk, _propStateRailroadread,
            _propOwnerRailroadread, _propStateRailroadpenn, _propOwnerRailroadpenn, _propStateRailroadbo, _propOwnerRailroadbo, _propStateRailroadshor, _propOwnerRailroadshor,
            _propStateElectriccomp, _propOwnerElectriccomp, _propStateWaterworks, _propOwnerWaterworks;

        public PropertyListViewerVM() {
            PropStateMediterranean = "Available $60.";
            PropOwnerMediterranean = "Owner: Bank";
            PropStateBaltic = "Available $60.";
            PropOwnerBaltic = "Owner: Bank";
            PropStateOriental = "Available $100.";
            PropOwnerOriental = "Owner: Bank";
            PropStateVermont = "Available $100.";
            PropOwnerVermont = "Owner: Bank";
            PropStateConnecticut = "Available $120.";
            PropOwnerConnecticut = "Owner: Bank";
            PropStateStcharles = "Available $140.";
            PropOwnerStcharles = "Owner: Bank";
            PropStateStates = "Available $140.";
            PropOwnerStates = "Owner: Bank";
            PropStateVirginia = "Available $160.";
            PropOwnerVirginia = "Owner: Bank";
            PropStateStjames = "Available $180.";
            PropOwnerStjames = "Owner: Bank";
            PropStateTennessee = "Available $180.";
            PropOwnerTennessee = "Owner: Bank";
            PropStateNewyork = "Available $200.";
            PropOwnerNewyork = "Owner: Bank";
            PropStateKentucky = "Available $220.";
            PropOwnerKentucky = "Owner: Bank";
            PropStateIndiana = "Available $220.";
            PropOwnerIndiana = "Owner: Bank";
            PropStateIllinois = "Available $240.";
            PropOwnerIllinois = "Owner: Bank";
            PropStateAtlantic = "Available $260.";
            PropOwnerAtlantic = "Owner: Bank";
            PropStateVentnor = "Available $260.";
            PropOwnerVentnor = "Owner: Bank";
            PropStateMarvingardens = "Available $280.";
            PropOwnerMarvingardens = "Owner: Bank";
            PropStatePacific = "Available $300.";
            PropOwnerPacific = "Owner: Bank";
            PropStateNorthcarolina = "Available $300.";
            PropOwnerNorthcarolina = "Owner: Bank";
            PropStatePennsylvania = "Available $320.";
            PropOwnerPennsylvania = "Owner: Bank";
            PropStateParkplace = "Available $350.";
            PropOwnerParkplace = "Owner: Bank";
            PropStateBoardwalk = "Available $400.";
            PropOwnerBoardwalk = "Owner: Bank";
            PropStateRailroadread = "Available $200.";
            PropOwnerRailroadread = "Owner: Bank";
            PropStateRailroadpenn = "Available $200.";
            PropOwnerRailroadpenn = "Owner: Bank";
            PropStateRailroadbo = "Available $200.";
            PropOwnerRailroadbo = "Owner: Bank";
            PropStateRailroadshor = "Available $200.";
            PropOwnerRailroadshor = "Owner: Bank";
            PropStateElectriccomp = "Available $150.";
            PropOwnerElectriccomp = "Owner: Bank";
            PropStateWaterworks = "Available $150.";
            PropOwnerWaterworks = "Owner: Bank";
        }


        public ICommand ButtonCommand => new DelegateCommand(ButtonCommandLogic, true);

        private void ButtonCommandLogic(object param) {
            switch (param) {
            case "exit":
                break;
            }
        }

        #region Fields

        public string PropStateMediterranean {
            get => _propStateMediterranean;
            set {
                _propStateMediterranean = value;
                RaisePropertyChangedEvent("PropStateMediterranean");
            }
        }

        public string PropOwnerMediterranean {
            get => _propOwnerMediterranean;
            set {
                _propOwnerMediterranean = value;
                RaisePropertyChangedEvent("PropOwnerMediterranean");
            }
        }

        public string PropStateBaltic {
            get => _propStateBaltic;
            set {
                _propStateBaltic = value;
                RaisePropertyChangedEvent("PropStateBaltic");
            }
        }

        public string PropOwnerBaltic {
            get => _propOwnerBaltic;
            set {
                _propOwnerBaltic = value;
                RaisePropertyChangedEvent("PropOwnerBaltic");
            }
        }

        public string PropStateOriental {
            get => _propStateOriental;
            set {
                _propStateOriental = value;
                RaisePropertyChangedEvent("PropStateOriental");
            }
        }

        public string PropOwnerOriental {
            get => _propOwnerOriental;
            set {
                _propOwnerOriental = value;
                RaisePropertyChangedEvent("PropOwnerOriental");
            }
        }

        public string PropStateVermont {
            get => _propStateVermont;
            set {
                _propStateVermont = value;
                RaisePropertyChangedEvent("PropStateVermont");
            }
        }

        public string PropOwnerVermont {
            get => _propOwnerVermont;
            set {
                _propOwnerVermont = value;
                RaisePropertyChangedEvent("PropOwnerVermont");
            }
        }

        public string PropStateConnecticut {
            get => _propStateConnecticut;
            set {
                _propStateConnecticut = value;
                RaisePropertyChangedEvent("PropStateConnecticut");
            }
        }

        public string PropOwnerConnecticut {
            get => _propOwnerConnecticut;
            set {
                _propOwnerConnecticut = value;
                RaisePropertyChangedEvent("PropOwnerConnecticut");
            }
        }

        public string PropStateStcharles {
            get => _propStateStcharles;
            set {
                _propStateStcharles = value;
                RaisePropertyChangedEvent("PropStateStcharles");
            }
        }

        public string PropOwnerStcharles {
            get => _propOwnerStcharles;
            set {
                _propOwnerStcharles = value;
                RaisePropertyChangedEvent("PropOwnerStcharles");
            }
        }

        public string PropStateStates {
            get => _propStateStates;
            set {
                _propStateStates = value;
                RaisePropertyChangedEvent("PropStateStates");
            }
        }

        public string PropOwnerStates {
            get => _propOwnerStates;
            set {
                _propOwnerStates = value;
                RaisePropertyChangedEvent("PropOwnerStates");
            }
        }

        public string PropStateVirginia {
            get => _propStateVirginia;
            set {
                _propStateVirginia = value;
                RaisePropertyChangedEvent("PropStateVirginia");
            }
        }

        public string PropOwnerVirginia {
            get => _propOwnerVirginia;
            set {
                _propOwnerVirginia = value;
                RaisePropertyChangedEvent("PropOwnerVirginia");
            }
        }

        public string PropStateStjames {
            get => _propStateStjames;
            set {
                _propStateStjames = value;
                RaisePropertyChangedEvent("PropStateStjames");
            }
        }

        public string PropOwnerStjames {
            get => _propOwnerStjames;
            set {
                _propOwnerStjames = value;
                RaisePropertyChangedEvent("PropOwnerStjames");
            }
        }

        public string PropStateTennessee {
            get => _propStateTennessee;
            set {
                _propStateTennessee = value;
                RaisePropertyChangedEvent("PropStateTennessee");
            }
        }

        public string PropOwnerTennessee {
            get => _propOwnerTennessee;
            set {
                _propOwnerTennessee = value;
                RaisePropertyChangedEvent("PropOwnerTennessee");
            }
        }

        public string PropStateNewyork {
            get => _propStateNewyork;
            set {
                _propStateNewyork = value;
                RaisePropertyChangedEvent("PropStateNewyork");
            }
        }

        public string PropOwnerNewyork {
            get => _propOwnerNewyork;
            set {
                _propOwnerNewyork = value;
                RaisePropertyChangedEvent("PropOwnerNewyork");
            }
        }

        public string PropStateKentucky {
            get => _propStateKentucky;
            set {
                _propStateKentucky = value;
                RaisePropertyChangedEvent("PropStateKentucky");
            }
        }

        public string PropOwnerKentucky {
            get => _propOwnerKentucky;
            set {
                _propOwnerKentucky = value;
                RaisePropertyChangedEvent("PropOwnerKentucky");
            }
        }

        public string PropStateIndiana {
            get => _propStateIndiana;
            set {
                _propStateIndiana = value;
                RaisePropertyChangedEvent("PropStateIndiana");
            }
        }

        public string PropOwnerIndiana {
            get => _propOwnerIndiana;
            set {
                _propOwnerIndiana = value;
                RaisePropertyChangedEvent("PropOwnerIndiana");
            }
        }

        public string PropStateIllinois {
            get => _propStateIllinois;
            set {
                _propStateIllinois = value;
                RaisePropertyChangedEvent("PropStateIllinois");
            }
        }

        public string PropOwnerIllinois {
            get => _propOwnerIllinois;
            set {
                _propOwnerIllinois = value;
                RaisePropertyChangedEvent("PropOwnerIllinois");
            }
        }

        public string PropStateAtlantic {
            get => _propStateAtlantic;
            set {
                _propStateAtlantic = value;
                RaisePropertyChangedEvent("PropStateAtlantic");
            }
        }

        public string PropOwnerAtlantic {
            get => _propOwnerAtlantic;
            set {
                _propOwnerAtlantic = value;
                RaisePropertyChangedEvent("PropOwnerAtlantic");
            }
        }

        public string PropStateVentnor {
            get => _propStateVentnor;
            set {
                _propStateVentnor = value;
                RaisePropertyChangedEvent("PropStateVentnor");
            }
        }

        public string PropOwnerVentnor {
            get => _propOwnerVentnor;
            set {
                _propOwnerVentnor = value;
                RaisePropertyChangedEvent("PropOwnerVentnor");
            }
        }

        public string PropStateMarvingardens {
            get => _propStateMarvingardens;
            set {
                _propStateMarvingardens = value;
                RaisePropertyChangedEvent("PropStateMarvingardens");
            }
        }

        public string PropOwnerMarvingardens {
            get => _propOwnerMarvingardens;
            set {
                _propOwnerMarvingardens = value;
                RaisePropertyChangedEvent("PropOwnerMarvingardens");
            }
        }

        public string PropStatePacific {
            get => _propStatePacific;
            set {
                _propStatePacific = value;
                RaisePropertyChangedEvent("PropStatePacific");
            }
        }

        public string PropOwnerPacific {
            get => _propOwnerPacific;
            set {
                _propOwnerPacific = value;
                RaisePropertyChangedEvent("PropOwnerPacific");
            }
        }

        public string PropStateNorthcarolina {
            get => _propStateNorthcarolina;
            set {
                _propStateNorthcarolina = value;
                RaisePropertyChangedEvent("PropStateNorthcarolina");
            }
        }

        public string PropOwnerNorthcarolina {
            get => _propOwnerNorthcarolina;
            set {
                _propOwnerNorthcarolina = value;
                RaisePropertyChangedEvent("PropOwnerNorthcarolina");
            }
        }

        public string PropStatePennsylvania {
            get => _propStatePennsylvania;
            set {
                _propStatePennsylvania = value;
                RaisePropertyChangedEvent("PropStatePennsylvania");
            }
        }

        public string PropOwnerPennsylvania {
            get => _propOwnerPennsylvania;
            set {
                _propOwnerPennsylvania = value;
                RaisePropertyChangedEvent("PropOwnerPennsylvania");
            }
        }

        public string PropStateParkplace {
            get => _propStateParkplace;
            set {
                _propStateParkplace = value;
                RaisePropertyChangedEvent("PropStateParkplace");
            }
        }

        public string PropOwnerParkplace {
            get => _propOwnerParkplace;
            set {
                _propOwnerParkplace = value;
                RaisePropertyChangedEvent("PropOwnerParkplace");
            }
        }

        public string PropStateBoardwalk {
            get => _propStateBoardwalk;
            set {
                _propStateBoardwalk = value;
                RaisePropertyChangedEvent("PropStateBoardwalk");
            }
        }

        public string PropOwnerBoardwalk {
            get => _propOwnerBoardwalk;
            set {
                _propOwnerBoardwalk = value;
                RaisePropertyChangedEvent("PropOwnerBoardwalk");
            }
        }

        public string PropStateRailroadread {
            get => _propStateRailroadread;
            set {
                _propStateRailroadread = value;
                RaisePropertyChangedEvent("PropStateRailroadread");
            }
        }

        public string PropOwnerRailroadread {
            get => _propOwnerRailroadread;
            set {
                _propOwnerRailroadread = value;
                RaisePropertyChangedEvent("PropOwnerRailroadread");
            }
        }

        public string PropStateRailroadpenn {
            get => _propStateRailroadpenn;
            set {
                _propStateRailroadpenn = value;
                RaisePropertyChangedEvent("PropStateRailroadpenn");
            }
        }

        public string PropOwnerRailroadpenn {
            get => _propOwnerRailroadpenn;
            set {
                _propOwnerRailroadpenn = value;
                RaisePropertyChangedEvent("PropOwnerRailroadpenn");
            }
        }

        public string PropStateRailroadbo {
            get => _propStateRailroadbo;
            set {
                _propStateRailroadbo = value;
                RaisePropertyChangedEvent("PropStateRailroadbo");
            }
        }

        public string PropOwnerRailroadbo {
            get => _propOwnerRailroadbo;
            set {
                _propOwnerRailroadbo = value;
                RaisePropertyChangedEvent("PropOwnerRailroadbo");
            }
        }

        public string PropStateRailroadshor {
            get => _propStateRailroadshor;
            set {
                _propStateRailroadshor = value;
                RaisePropertyChangedEvent("PropStateRailroadshor");
            }
        }

        public string PropOwnerRailroadshor {
            get => _propOwnerRailroadshor;
            set {
                _propOwnerRailroadshor = value;
                RaisePropertyChangedEvent("PropOwnerRailroadshor");
            }
        }

        public string PropStateElectriccomp {
            get => _propStateElectriccomp;
            set {
                _propStateElectriccomp = value;
                RaisePropertyChangedEvent("PropStateElectriccomp");
            }
        }

        public string PropOwnerElectriccomp {
            get => _propOwnerElectriccomp;
            set {
                _propOwnerElectriccomp = value;
                RaisePropertyChangedEvent("PropOwnerElectriccomp");
            }
        }

        public string PropStateWaterworks {
            get => _propStateWaterworks;
            set {
                _propStateWaterworks = value;
                RaisePropertyChangedEvent("PropStateWaterworks");
            }
        }

        public string PropOwnerWaterworks {
            get => _propOwnerWaterworks;
            set {
                _propOwnerWaterworks = value;
                RaisePropertyChangedEvent("PropOwnerWaterworks");
            }
        }

        #endregion
    }
}