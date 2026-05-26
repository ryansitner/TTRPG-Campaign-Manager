namespace TTRPGManager
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);

            // Set the absolute minimum size the window can be squished to
            window.MinimumWidth = 650; 
            window.MinimumHeight = 550;

            // Set the app to open at a specific size at launch
            window.Width = 1024;
            window.Height = 768;

            return window;
        }
    }
}