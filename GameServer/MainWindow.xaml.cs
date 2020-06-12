using GameServer.Source.ViewModel;

namespace GameServer {
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();
            DataContext = new MainWindowVM();
        }
    }
}