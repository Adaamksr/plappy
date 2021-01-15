using MySql.Data.MySqlClient;
using System.Data;
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

namespace CRUD_test2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string connectionString = @"Server=81.164.178.157;Port=3307;Database=Plappy;Uid=Plappy;Pwd=SyntaDB!2020!;connect timeout=3600;";
        int bookID = 0;
        public MainWindow()
        {
            InitializeComponent();
            Clear();
            GridFill();
            
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("BookAddOrEdit", mySqlConnection); // op basis van stored procedure
                mySqlCommand.CommandType = CommandType.StoredProcedure;
                mySqlCommand.Parameters.AddWithValue("_BookID", bookID); // parameternaam + toe te voegen waarde
                mySqlCommand.Parameters.AddWithValue("_BookName", txb_name.Text.Trim()); // parameternaam + toe te voegen waarde
                mySqlCommand.Parameters.AddWithValue("_Author", txb_author.Text.Trim()); // parameternaam + toe te voegen waarde
                mySqlCommand.Parameters.AddWithValue("_Description", txb_description.Text.Trim()); // parameternaam + toe te voegen waarde
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Submitted successfully!");
                mySqlConnection.Close();
                Clear();
                GridFill();

            }
        }

        private void GridFill()
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("BookViewAll", mySqlConnection);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblBook = new DataTable();
                sqlDa.Fill(dtblBook);
                dataGrid.ItemsSource = dtblBook.DefaultView;
                //dataGrid.Columns[0].Visibility = Visibility.Collapsed; // todo: error op deze lijn: index out of bounds
                mySqlConnection.Close();
            }
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                mySqlConnection.Open();
                
                mySqlConnection.Close();
            }
        }

        private void Clear()
        {
            txb_name.Text = txb_author.Text = txb_description.Text = txb_search.Text = "";
            bookID = 0;
            btn_save.Content = "Save";
        }
        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

    }
}
