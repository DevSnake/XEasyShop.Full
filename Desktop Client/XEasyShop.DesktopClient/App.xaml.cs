using System.Windows;
using XEasyShop.DesktopClient.ViewModels;
using XEasyShop.DesktopClient.Views;

namespace XEasyShop.DesktopClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow window = new MainWindow()
            {
                DataContext = new CustomerViewModel()
            };
            window.ShowDialog();
        }
    }
}
