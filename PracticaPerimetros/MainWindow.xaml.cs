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

namespace PracticaPerimetros
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmbFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ctrlPeriCir.Visibility = Visibility.Collapsed;
            ctrlPeriCua.Visibility = Visibility.Collapsed;
            ctrlPeriRec.Visibility = Visibility.Collapsed;
            ctrlPeriTra.Visibility = Visibility.Collapsed;

            switch (cmbFigura.SelectedIndex)
            {
                case 0: //Cir
                    ctrlPeriCir.Visibility = Visibility.Visible;
                    break;
                case 1: //Cua
                    ctrlPeriCua.Visibility = Visibility.Visible;
                    break;
                case 2: //Rec
                    ctrlPeriRec.Visibility = Visibility.Visible;
                    break;
                case 3: //Tra
                    ctrlPeriTra.Visibility = Visibility.Visible;
                    break;
                default:
                    break;
            }
        }

        private void btnCal_Click(object sender, RoutedEventArgs e)
        {
            float peri = 0.0f;

            switch (cmbFigura.SelectedIndex)
            {
                case 0: //cir
                    float radio =
                    float.Parse(ctrlPeriCir.txtRadio.Text);
                    peri = 2 * radio * 3.14159f;
                    break;
                case 1: //cua
                    float lado =
                    float.Parse(ctrlPeriCua.txtLado.Text);
                    peri = lado * 4;
                    break;
                case 2: //rec
                    float largo =
                    float.Parse(ctrlPeriRec.txtLargo.Text);
                    float ancho =
                    float.Parse(ctrlPeriRec.txtAncho.Text);
                    peri = (largo * 2) + (ancho * 2);
                    break;
                case 3: //tra
                    float ladoMay =
                    float.Parse(ctrlPeriTra.txtLadoMay.Text);
                    float ladoMen =
                    float.Parse(ctrlPeriTra.txtLadoMen.Text);
                    float diaIzq =
                    float.Parse(ctrlPeriTra.txtDiaIzq.Text);
                    float diaDer =
                    float.Parse(ctrlPeriTra.txtDiaDer.Text);
                    peri = ladoMay + ladoMen + diaIzq + diaDer;
                    break;
                default:
                    break;
            }
            lblRes.Text = peri.ToString();
        }
    }
}
