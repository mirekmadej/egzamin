
namespace egzamin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            Window w = new Window();
            w.MaximumHeight = 800;
            w.MaximumWidth = 500;
            w.MinimumHeight = 800;
            w.MinimumWidth = 500;
            w.Title = "wykonał MM";
            w.Page = new AppShell();
            return w;
        }
    }
}
