﻿using System;
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

namespace Praktika_1_EF
{
 
    public partial class FirstPage : Page
    {
        private COFFEE_HOUSEEntities con = new COFFEE_HOUSEEntities();
        public FirstPage()
        {
            InitializeComponent();
            NAME_COFFEEDataGrid.ItemsSource = con.NAME_COFFEE.ToList();

            filter_dan.ItemsSource = con.NAME_COFFEE.ToList();
            filter_dan.DisplayMemberPath = "ADDRESS_COFFEE_HOUSE";

        }

        private void insert_Click(object sender, RoutedEventArgs e)
        {
            NAME_COFFEE a = new NAME_COFFEE();
            a.TITLE = text.Text;
            a.ADDRESS_COFFEE_HOUSE = addressTextBox.Text;
            con.NAME_COFFEE.Add(a);
            con.SaveChanges();
            NAME_COFFEEDataGrid.ItemsSource = con.NAME_COFFEE.ToList();

        }

        private void delete_Click1(object sender, RoutedEventArgs e)
        {
            if(NAME_COFFEEDataGrid.SelectedItem != null)
            {
                con.NAME_COFFEE.Remove(NAME_COFFEEDataGrid.SelectedItem as NAME_COFFEE);
                con.SaveChanges();
                NAME_COFFEEDataGrid.ItemsSource = con.NAME_COFFEE.ToList();
            }
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            if (NAME_COFFEEDataGrid.SelectedItem != null)
            {
                con.SaveChanges();
            }
        }

        private void NAME_COFFEEDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(NAME_COFFEEDataGrid.SelectedItem != null)
            {
                var select = NAME_COFFEEDataGrid.SelectedItem as NAME_COFFEE;
                select.TITLE = text.Text;
                select.ADDRESS_COFFEE_HOUSE = addressTextBox.Text;
                con.SaveChanges();
                NAME_COFFEEDataGrid.ItemsSource = con.NAME_COFFEE.ToList();

            }
        }

        private void poick_dan_Click(object sender, RoutedEventArgs e)
        {
            NAME_COFFEEDataGrid.ItemsSource = con.NAME_COFFEE.ToList().Where(item => item.TITLE.Contains(poick.Text));
        }

        private void filter_dan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(filter_dan.SelectedItem != null)
            {
                var selected = filter_dan.SelectedItem as NAME_COFFEE;
                NAME_COFFEEDataGrid.ItemsSource = con.NAME_COFFEE.ToList().Where(item => item.ADDRESS_COFFEE_HOUSE == selected.ADDRESS_COFFEE_HOUSE);
            }
        }

        private void filter_dani_Click(object sender, RoutedEventArgs e)
        {
            filter_dan.SelectedItem = null;
            poick.Text = "";
            NAME_COFFEEDataGrid.ItemsSource = con.NAME_COFFEE.ToList();
        }

        
    }
}
