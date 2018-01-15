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
            OdbcConnection con = new OdbcConnection(Properties.Settings.Default.ConnectionString);

            con.Open();

            OdbcCommand command = new OdbcCommand("Select * from tblKlanten",con);

            OdbcDataReader reader = command.ExecuteReader();

            XmlDocument xmlKlanten = new XmlDocument();

            while (reader.Read())
            {
                //TODO: logica om alle gegevens in XML te zetten

            }

            con.Close();
        }
    }
}
