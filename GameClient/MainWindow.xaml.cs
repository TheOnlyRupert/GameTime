using GameClient.Source.ViewModel;

namespace GameClient {
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();
            DataContext = new MainWindowVM();
        }
    }
}