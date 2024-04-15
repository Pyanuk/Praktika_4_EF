using System;
using System.Windows;
using System.Windows.Controls;
using System.Linq;


namespace Praktika_1_EF
{
    public partial class FourPage : Page
    {
        private COFFEE_HOUSEEntities con = new COFFEE_HOUSEEntities();
        private int tempNameCoffeeId;
        private int tempClientId;
        private int tempOrderCoffeeId;

        public FourPage()
        {
            InitializeComponent();
            CUSTOMER_ORDERDataGrid.ItemsSource = con.CUSTOMER_ORDER.ToList();
            CUSTOMER_ORDERComboBox.ItemsSource = con.NAME_COFFEE.ToList();
            CUSTOMER_ORDERComboBox.DisplayMemberPath = "ID_NAME_COFFEE_HOUSE";

            CUSTOMER_ORDERComboBox1.ItemsSource = con.CLIENT.ToList();
            CUSTOMER_ORDERComboBox1.DisplayMemberPath = "ID_CLIENT";

            CUSTOMER_ORDERComboBox2.ItemsSource = con.ORDER_COFFEE.ToList();
            CUSTOMER_ORDERComboBox2.DisplayMemberPath = "ID_ORDER_COFFEE";
        }

        private void insert_Click(object sender, RoutedEventArgs e)
        {
            if (CUSTOMER_ORDERComboBox.SelectedItem != null &&
                CUSTOMER_ORDERComboBox1.SelectedItem != null &&
                CUSTOMER_ORDERComboBox2.SelectedItem != null)
            {
                NAME_COFFEE nameCoffee = CUSTOMER_ORDERComboBox.SelectedItem as NAME_COFFEE;
                CLIENT client = CUSTOMER_ORDERComboBox1.SelectedItem as CLIENT;
                ORDER_COFFEE orderCoffee = CUSTOMER_ORDERComboBox2.SelectedItem as ORDER_COFFEE;

                CUSTOMER_ORDER order = new CUSTOMER_ORDER
                {
                    NAME_COFFEE_ID = nameCoffee.ID_NAME_COFFEE_HOUSE,
                    CLIENT_ID = client.ID_CLIENT,
                    ORDER_COFFEE_ID = orderCoffee.ID_ORDER_COFFEE
                };

                con.CUSTOMER_ORDER.Add(order);
                con.SaveChanges();
                CUSTOMER_ORDERDataGrid.ItemsSource = con.CUSTOMER_ORDER.ToList();
            }
        }

        private void delete_Click1(object sender, RoutedEventArgs e)
        {
            if (CUSTOMER_ORDERDataGrid.SelectedItem != null)
            {
                CUSTOMER_ORDER selectedOrder = CUSTOMER_ORDERDataGrid.SelectedItem as CUSTOMER_ORDER;
                con.CUSTOMER_ORDER.Remove(selectedOrder);
                con.SaveChanges();
                CUSTOMER_ORDERDataGrid.ItemsSource = con.CUSTOMER_ORDER.ToList();
            }
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            if (CUSTOMER_ORDERDataGrid.SelectedItem != null)
            {
                CUSTOMER_ORDER selectedOrder = CUSTOMER_ORDERDataGrid.SelectedItem as CUSTOMER_ORDER;
                selectedOrder.NAME_COFFEE_ID = tempNameCoffeeId;
                selectedOrder.CLIENT_ID = tempClientId;
                selectedOrder.ORDER_COFFEE_ID = tempOrderCoffeeId;

                con.SaveChanges();
                CUSTOMER_ORDERDataGrid.Items.Refresh();
            }
        }

        private void CUSTOMER_ORDERComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CUSTOMER_ORDERComboBox.SelectedItem != null)
            {
                NAME_COFFEE nameCoffee = CUSTOMER_ORDERComboBox.SelectedItem as NAME_COFFEE;
                tempNameCoffeeId = nameCoffee.ID_NAME_COFFEE_HOUSE;
            }
        }





        private void CUSTOMER_ORDERDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CUSTOMER_ORDERDataGrid.SelectedItem != null)
            {
                CUSTOMER_ORDER selectedOrder = CUSTOMER_ORDERDataGrid.SelectedItem as CUSTOMER_ORDER;
                tempNameCoffeeId = selectedOrder.NAME_COFFEE_ID;
                tempClientId = selectedOrder.CLIENT_ID;
                tempOrderCoffeeId = selectedOrder.ORDER_COFFEE_ID;

                CUSTOMER_ORDERComboBox.SelectedItem = con.NAME_COFFEE.FirstOrDefault(n => n.ID_NAME_COFFEE_HOUSE == tempNameCoffeeId);
                CUSTOMER_ORDERComboBox1.SelectedItem = con.CLIENT.FirstOrDefault(c => c.ID_CLIENT == tempClientId);
                CUSTOMER_ORDERComboBox2.SelectedItem = con.ORDER_COFFEE.FirstOrDefault(o => o.ID_ORDER_COFFEE == tempOrderCoffeeId);
            }
        }

        private void CUSTOMER_ORDERComboBox_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
            if (CUSTOMER_ORDERComboBox1.SelectedItem != null)
            {
                CLIENT client = CUSTOMER_ORDERComboBox1.SelectedItem as CLIENT;
                tempClientId = client.ID_CLIENT;
            }
        }

        private void CUSTOMER_ORDERComboBox_SelectionChanged2(object sender, SelectionChangedEventArgs e)
        {
            if (CUSTOMER_ORDERComboBox2.SelectedItem != null)
            {
                ORDER_COFFEE orderCoffee = CUSTOMER_ORDERComboBox2.SelectedItem as ORDER_COFFEE;
                tempOrderCoffeeId = orderCoffee.ID_ORDER_COFFEE;
            }
        }
    }
}
