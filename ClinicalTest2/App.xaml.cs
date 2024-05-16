using ClinicalTest2.Pages;

namespace ClinicalTest2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
