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

namespace Kalkulacka
{
        public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void vypocitejButton_Click(object sender, RoutedEventArgs e)
        {
            // příprava proměnných 
            string operace = operaceComboBox.Text;
            //double uhel=15 ;
                        double sila;
            var isDouble = double.TryParse(this.txtNumber4.Text, out sila);
            double vysledek = 0;
            double tlak = 0;
            double krut = 0;

            // výpočet
            if (operace == "Tr 16 x 4")
            {
                vysledek = Math.Round(((((sila * 14) / 2) * ((4 * 0.966 + 3.14 * 0.18 * 14) / (3.14 * 14 * 0.966 - 0.18 * 4))) / 1000), 0);
                tlak = Math.Round((4 * sila) / (3.14 * 12 * 12), 1);
                krut = Math.Round(1000 * vysledek / (3.14 * 12 * 12 * 12 / 16), 1);
            }
           
            else if (operace == "Tr 20 x 4")
            {
                 vysledek = Math.Round(((((sila * 18) / 2) * ((4 * 0.966 + 3.14 * 0.18 * 18) / (3.14 * 18 * 0.966 - 0.18 * 4))) / 1000), 0);
                 tlak = Math.Round((4 * sila) / (3.14 * 16 * 16),1);
                 krut = Math.Round(1000*vysledek / (3.14 * 16 * 16 * 16 / 16), 1);
            }
            else if (operace == "Tr 24 x 5")
            {
                 vysledek = Math.Round(((((sila * 21.5) / 2) * ((5 * 0.966 + 3.14 * 0.18 * 21.5) / (3.14 * 21.5 * 0.966 - 0.18 * 5))) / 1000), 0);
                 tlak = Math.Round((4 * sila) / (3.14 * 19 * 19),1);
                 krut = Math.Round(1000* vysledek / (3.14 * 19 * 19 * 19 / 16), 1);
            }
            else if (operace == "Tr 28 x 5")
            {
                 vysledek = Math.Round(((((sila * 25.5) / 2) * ((5 * 0.966 + 3.14 * 0.18 * 25.5) / (3.14 * 25.5 * 0.966 - 0.18 * 5))) / 1000), 0);
                 tlak = Math.Round((4 * sila) / (3.14 * 23 * 23),1);
                 krut = Math.Round(1000* vysledek / (3.14 * 23 * 23 * 23 / 16), 1);
            }
            else if (operace == "Tr 30 x 6")
            {
                 vysledek = Math.Round(((((sila * 27) / 2) * ((6 * 0.966 + 3.14 * 0.18 * 27) / (3.14 * 27 * 0.966 - 0.18 * 6))) / 1000), 0);
                 tlak = Math.Round((4 * sila) / (3.14 * 24 * 24),1);
                 krut = Math.Round(1000 * vysledek / (3.14 * 24 * 24 * 24 / 16), 1);
            }
            else if (operace == "Tr 32 x 6")
            {
                 vysledek = Math.Round(((((sila * 29) / 2) * ((6 * 0.966 + 3.14 * 0.18 * 29) / (3.14 * 29 * 0.966 - 0.18 * 6))) / 1000), 0);
                 tlak = Math.Round((4 * sila) / (3.14 * 29 * 29),1);
                 krut = Math.Round(1000* vysledek / (3.14 * 29 * 29 * 29 / 16), 1);
            }
            else if (operace == "Tr 36 x 6")
            {
                 vysledek = Math.Round(((((sila * 33) / 2) * ((6 * 0.966 + 3.14 * 0.18 * 33) / (3.14 * 33 * 0.966 - 0.18 * 6))) / 1000), 0);
                 tlak = Math.Round((4 * sila) / (3.14 * 30 * 30),1);
                 krut = Math.Round(1000*vysledek / (3.14 * 30 * 30 * 30 / 16), 1);
            }
            else if (operace == "Tr 40 x 7")
            {
                 vysledek = Math.Round(((((sila * 36.5) / 2) * ((7 * 0.966 + 3.14 * 0.18 * 36.5) / (3.14 * 36.5 * 0.966 - 0.18 * 7)))/1000),0);
                 tlak = Math.Round((4 * sila) / (3.14 * 33 * 33),1);
                 krut = Math.Round(1000* vysledek / (3.14 * 33 * 33 * 33 / 16), 1);
            }
            else if (operace == "Tr 44 x 7")
            {
                vysledek = Math.Round(((((sila * 40.5) / 2) * ((7 * 0.966 + 3.14 * 0.18 * 40.5) / (3.14 * 40.5 * 0.966 - 0.18 * 7))) / 1000), 0);
                tlak = Math.Round((4 * sila) / (3.14 * 37 * 37),1);
                 krut = Math.Round(1000* vysledek / (3.14 * 37 * 37 * 37 / 16), 1);
            }
            else if (operace == "Tr 50 x 8")
            {
                vysledek = Math.Round(((((sila * 46) / 2) * ((8 * 0.966 + 3.14 * 0.18 * 46) / (3.14 * 46 * 0.966 - 0.18 * 8))) / 1000), 0);
                tlak = Math.Round((4 * sila) / (3.14 * 42 * 42),1);
                 krut = Math.Round(1000* vysledek / (3.14 * 42 * 42 * 42 / 16), 1);
            }
            else if (operace == "Tr 55 x 9")
            {
                vysledek = Math.Round(((((sila * 50.5) / 2) * ((9 * 0.966 + 3.14 * 0.18 * 50.5) / (3.14 * 50.5 * 0.966 - 0.18 * 9))) / 1000), 0);
                tlak = Math.Round((4 * sila) / (3.14 * 46 * 46),1);
                 krut = Math.Round(1000* vysledek / (3.14 * 46 * 46 * 46 / 16), 1);
            }
            else if (operace == "Tr 60 x 9")
            {
                vysledek = Math.Round(((((sila * 55.5) / 2) * ((9 * 0.966 + 3.14 * 0.18 * 55.5) / (3.14 * 55.5 * 0.966 - 0.18 * 9))) / 1000), 0);
                tlak = Math.Round((4 * sila) / (3.14 * 51 * 51),1);
                 krut = Math.Round(1000* vysledek / (3.14 * 51 * 51 * 51 / 16), 1);
            }


            vysledekTextBlock.Text = vysledek.ToString();

            vysledekTextBlock_tlak.Text = tlak.ToString();
            vysledekTextBlock_krut.Text = krut.ToString();


                  }
        private void OnSquareRootClick(object sender, RoutedEventArgs e)
        {
            double number;
            double number2;
            var isDouble = double.TryParse(this.txtNumber.Text, out number);
            var isDouble2 = double.TryParse(this.txtNumber2.Text, out number2);
            if (isDouble && isDouble2)
            {
                this.vysledekTextBlock_prumer.Text =
                    string.Format(
                       "{1}",
                      
                        this.txtNumber.Text,
                        Math.Round(2.3*Math.Sqrt(4*(number/(0.6*number2))/3.141592), 0));
            }
                    }
        private void AboutClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ve výsledku Předběžný Ø šroubu je již započítáno namáhání od točivého momentu pohonu. \n" +
                "Výsledek Potřebný moment platí pro: bronzovou matici / ocelový šroub. Mazání: slabé nebo vůbec žádné. Při správném mazání je výsledek" +
                " již předimenzovaný. Při nemazaném, špinavém šroubu je potřeba výsledek předimenzovat. \n\n" +
                "Mez kluzu v tahu pro:\n" +
                "11373 = 200 - 250 MPa \n" +
                "11600 = 300 - 340 MPa\n" +
                "11523 = 275 - 340 MPa\n" +
                "17240 = 190 - 230 MPa ");
        }
    }
  }
