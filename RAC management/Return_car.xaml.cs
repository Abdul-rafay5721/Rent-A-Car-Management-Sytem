using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class Return_car : Page
    {
        public Return_car()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dequeue_Click(object sender, RoutedEventArgs e)
        {
            CustomerData data = customer.q1.dequeue();
            if (data != null)
            {
                resultShow.Visibility= Visibility.Visible;
                var result = $"Return car Successfully\nCustomer Name : {data.customerName}\nCustomer CNIC : {data.CNIC}\nCustomer Phone : {data.customerNo}\nCustomer Car : {data.carName}";
                DequeueResultStatus.Text = result;
                customer_info_db(data);

            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            App.TryGoBack();
        }

        private void Return_btn_Click(object sender, RoutedEventArgs e)
        {
            string return_car = "";
            if (returnCnic.Text !=null)
            {
                return_car = returnCnic.Text;
            }
            CustomerData data = customer.q1.returnByCnic(return_car);
            resultShow.Visibility = Visibility.Visible;
            var result = $"Return car Successfully\nCustomer Name : {data.customerName}\nCustomer CNIC : {data.CNIC}\nCustomer Phone : {data.customerNo}\nCustomer Car : {data.carName}";
            DequeueResultStatus.Text = result;
            customer_info_db(data);
        }

        private async void customer_info_db(CustomerData d1)
        {
            var values = new Dictionary<string, string>
            {
               
               { "customerCnic", d1.CNIC },
               
            };
            HttpContent content = new FormUrlEncodedContent(values);
            HttpResponseMessage response = await Helper.client.PostAsync("deleteOrder.php", content);
            string result = await response.Content.ReadAsStringAsync();
            
        }
    }
}
