using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace RAC_management
{
   
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class customer : Page
    {
        CustomerData d1;
        public static RAC_Queue q1= new RAC_Queue();
        public customer()
        {
            this.InitializeComponent();
            car_selection.ItemsSource = convertion(Admin.car_list.cars);
        }

        public Array convertion(List<Car> lst)
        {
            return lst.Select(x => x.carName).ToArray();
        }

        private void calculatePrice_btn_Click(object sender, RoutedEventArgs e)
        {
            int CarOneDayprice;
            int d;
            int oneDayDriverPrice = 1000;


            CarOneDayprice = (int)(Admin.car_list.getPrice((string)car_selection.SelectedItem));
            if (!string.IsNullOrEmpty(days.Text) && CarOneDayprice !=0)
            {
                d = int.Parse(days.Text);
                calculatedPrice.Visibility = Visibility.Visible;
                if (string.IsNullOrEmpty(CarOneDayprice.ToString()))
                {
                    calculatedPrice.Text = "Error : Some place is empty !";
                }
                if (driver.IsChecked.Value)
                {
                    calculatedPrice.Foreground = new SolidColorBrush(Colors.Green);
                    calculatedPrice.Text = "Calculated Price : "+((oneDayDriverPrice * d) + (CarOneDayprice * d)).ToString();
                }
                else
                {
                    calculatedPrice.Foreground = new SolidColorBrush(Colors.Green);
                    calculatedPrice.Text = "Calculated Price : " +(CarOneDayprice * d).ToString();
                }

            }
            else
            {
                calculatedPrice.Visibility = Visibility.Visible;
                calculatedPrice.Foreground = new SolidColorBrush(Colors.Red);
                calculatedPrice.Text = "Sorry! Some field is empty.";
            }
            

        }

        private void sbmit_btn_Click(object sender, RoutedEventArgs e)
        {
            d1 = new CustomerData();
            if (!string.IsNullOrEmpty(days.Text))
            {
                d1.Tdays = int.Parse(days.Text);
            }
            d1.withDriver = driver.IsChecked.Value;
            d1.startDate = startDate.Date.Date.ToShortDateString();
            d1.endDate = endDate.Date.Date.ToShortDateString();
            d1.customerName = CName.Text;
            d1.customerNo = contact.Text;
            d1.CNIC = cnic.Text;
            d1.carName = (string)car_selection.SelectedItem;
            if (!string.IsNullOrEmpty(d1.carName) && !string.IsNullOrEmpty(d1.customerName) && !string.IsNullOrEmpty(d1.CNIC) && !string.IsNullOrEmpty(d1.endDate))
            {
                customerSubmitSuccess.Foreground= new SolidColorBrush(Colors.Green);
                customerSubmitSuccess.Text = "Data submit Successfully !";
                q1.enqueue(d1);
                post_order_in_db();
                save_customer_info_in_db(d1);
            }
            else
            {
                customerSubmitSuccess.Foreground = new SolidColorBrush(Colors.Red);
                customerSubmitSuccess.Text = "Sorry! Some field is empty";
            }

        }
        private async void post_order_in_db()
        {
            var values = new Dictionary<string, string>
            {
               { "customer_name", d1.customerName },
               { "customer_number", d1.customerNo },
               { "customer_cnic", d1.CNIC },
               { "car_name", d1.carName },
               { "car_reg", "change me!!!" },
               { "start_date", d1.startDate },
               { "end_date", d1.endDate },
               { "TotalDays", d1.Tdays.ToString()},
               { "withDriver", d1.withDriver.ToString()},
            };
            HttpContent content = new FormUrlEncodedContent(values);
            HttpResponseMessage response = await Helper.client.PostAsync("orders.php", content);
            string result = await response.Content.ReadAsStringAsync();
        }

        private async void save_customer_info_in_db(CustomerData d1)
        {
            var values = new Dictionary<string, string>
            {
               { "customer_name", d1.customerName },
               { "customer_number", d1.customerNo },
               { "customer_cnic", d1.CNIC },
               { "car_name", d1.carName },
            };
            HttpContent content = new FormUrlEncodedContent(values);
            HttpResponseMessage response = await Helper.client.PostAsync("customerInfo.php", content);
            string result = await response.Content.ReadAsStringAsync();
            if (result.ToLower().Contains("true"))
            {

            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            App.TryGoBack();
        }

        
    }
}
