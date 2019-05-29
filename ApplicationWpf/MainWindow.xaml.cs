using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ApplicationWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void downloadButtonClick(object sender, RoutedEventArgs e)
        {
            
                var currentDomain = AppDomain.CurrentDomain;


            var downloadAppDomain = AppDomain.CreateDomain("ComplexCalculations");


            var downloadVeryBigFilePath = currentDomain.BaseDirectory + "DownloadVeryBigFile.exe";

            downloadAppDomain.ExecuteAssembly(downloadVeryBigFilePath);

            AppDomain.Unload(downloadAppDomain);

        }

        
       private async void ComplexCalculationsButtonClick(object sender, RoutedEventArgs e)
        {
            
            var currentDomain = AppDomain.CurrentDomain;


            var complexAppDomain = AppDomain.CreateDomain("ComplexCalculations");


            var complexCalculationsPath = currentDomain.BaseDirectory + "ComplexCalculations.exe";

            complexAppDomain.ExecuteAssembly(complexCalculationsPath);


            AppDomain.Unload(complexAppDomain);

        }

    }
}
