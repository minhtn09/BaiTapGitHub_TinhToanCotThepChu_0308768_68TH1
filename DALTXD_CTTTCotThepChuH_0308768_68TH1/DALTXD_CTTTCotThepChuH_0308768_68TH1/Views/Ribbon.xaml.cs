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
using DALTXD_CTTTCotThepChuH_0308768_68TH1.Views.POPUP;
namespace DALTXD_CTTTCotThepChuH_0308768_68TH1.Views
{
    /// <summary>
    /// Interaction logic for Ribbon.xaml
    /// </summary>
    public partial class Ribbon : UserControl
    {
        public Window Owner { get; private set; }

        public Ribbon()
        {
            InitializeComponent();
        }
        private void BtnVatLieu_Click(object sender, RoutedEventArgs e)
        {
            VatLieu w = new VatLieu();
            w.Owner = Window.GetWindow(this);
            w.ShowDialog();
        }
        private void BtnthongsoDauvao_Click(object sender, RoutedEventArgs e)
        {
            var win = new thongsodauvao();
            win.Owner = Application.Current.MainWindow;
            win.ShowDialog();
        }
        private void Btnthongsothietke_Click(object sender, RoutedEventArgs e)
        {
            var win = new thongsothietke();
            win.Owner = Application.Current.MainWindow;
            win.ShowDialog();
        }
    }
}
