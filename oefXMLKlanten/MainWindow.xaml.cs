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
using System.Data.Odbc;
using System.Xml;

namespace oefXMLKlanten
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMaakXML_Click(object sender, RoutedEventArgs e)
        {
            XmlDocument xmlKlanten = new XmlDocument();

            String pad = Environment.CurrentDirectory + @"\klanten.xml";
            XmlWriter writer = XmlWriter.Create(pad);

            writer.WriteStartElement("Klanten");    

            foreach (Klanten klant in Datamanager.getAllKlanten())
            {
                writer.WriteStartElement("klant");
                writer.WriteAttributeString("ID", klant.Klantnummer);
                writer.WriteElementString("naam", klant.Bedrijf);
                writer.WriteElementString("adres", klant.Adres);
                writer.WriteStartElement("gemeente");
                writer.WriteAttributeString("postcode", klant.Postcode);
                writer.WriteString(klant.Plaats);
                writer.WriteEndElement();

                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            wbKlanten.Navigate(pad);
        }
    }
}
