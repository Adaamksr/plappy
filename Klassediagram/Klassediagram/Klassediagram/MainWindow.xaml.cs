using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MySql.Data.MySqlClient;

namespace CRUD_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string ConnectionString = @"Server=81.164.178.157;Port=3307;Database=Plappy;Uid=Plappy;Pwd=SyntaDB!2020!;connect timeout=3600;";
        int BookID;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection MySqlCon = new MySqlConnection(ConnectionString))
            {
                MySqlCon.Open();

                MySqlCommand MysqlCmd = new MySqlCommand("BookAddOrEdit", MySqlCon);
                MysqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                MysqlCmd.Parameters.AddWithValue("_BookID", BookID);
                MysqlCmd.Parameters.AddWithValue("_BookName", txtBookName.Text.Trim());
                MysqlCmd.Parameters.AddWithValue("_Author", txtAuthor.Text.Trim());
                MysqlCmd.Parameters.AddWithValue("_Description", txtDescription.Text.Trim());

                MysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted succesfully");
                Clear();
                GridFill();
            }
        }

        void GridFill()
        {
            using (MySqlConnection MySqlCon = new MySqlConnection(ConnectionString))
            {
                MySqlCon.Open();
                MySqlDataAdapter SqlDa = new MySqlDataAdapter("BookViewAll", MySqlCon);
                SqlDa.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                DataTable dtblBook = new DataTable();
                SqlDa.Fill(dtblBook);
                dgvBook.ItemsSource = dtblBook.DefaultView;
                dgvBook.Columns[0].Visibility = Visibility.Collapsed;
            }
        }

        private void Window1_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }

        void Clear()
        {
            txtBookName.Text = txtAuthor.Text = txtDescription.Text = txtSearch.Text = "";
            BookID = 0;
            btnSave.Content = "Save";
            btnDelete.IsEnabled = false;
        }

        private void dgvBook_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            DataGrid gd = (DataGrid)sender;
            DataRowView row_selected = gd.SelectedItem as DataRowView;
            if (row_selected != null)
            {
                txtBookName.Text = row_selected[1].ToString();
                txtAuthor.Text = row_selected[2].ToString();
                txtDescription.Text = row_selected[3].ToString();
                BookID = Convert.ToInt32(row_selected[0].ToString());
            }
            btnSave.Content = "update";
            btnDelete.IsEnabled = true;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection MySqlCon = new MySqlConnection(ConnectionString))
            {
                MySqlCon.Open();
                MySqlDataAdapter SqlDa = new MySqlDataAdapter("BookSearchByValues", MySqlCon);
                SqlDa.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                DataTable dtblBook = new DataTable();
                SqlDa.Fill(dtblBook);
                dgvBook.ItemsSource = dtblBook.DefaultView;
                dgvBook.Columns[0].Visibility = Visibility.Collapsed;
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            using (MySqlConnection MySqlCon = new MySqlConnection(ConnectionString))
            {
                MySqlCon.Open();

                MySqlCommand MysqlCmd = new MySqlCommand("BookDeleteById", MySqlCon);
                MysqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
                MysqlCmd.Parameters.AddWithValue("_BookID", BookID);

                MysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Deleted succesfully");
                Clear();
                GridFill();
            }
        }
    }
}
