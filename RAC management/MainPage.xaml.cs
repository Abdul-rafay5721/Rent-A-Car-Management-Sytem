using Newtonsoft.Json;
using RAC_management.contentDialogue;
using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace RAC_management
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static bool data_loaded=false;
        public MainPage()
        {
            this.InitializeComponent();
            if (!data_loaded)
            {
                load_cars();
                load_orders();
                data_loaded = true;
            }
            
        }
        public void load_cars()
        {
            HttpResponseMessage response = Helper.client.GetAsync("carInfo.php").Result;
            string result = response.Content.ReadAsStringAsync().Result;
            List<Car> res = JsonConvert.DeserializeObject<List<Car>>(result);
            foreach (Car item in res) Admin.car_list.addCar(item);
        }

        public void load_orders()
        {
            HttpResponseMessage response = Helper.client.GetAsync("orders.php").Result;
            string result = response.Content.ReadAsStringAsync().Result;
            List<CustomerData> res = JsonConvert.DeserializeObject<List<CustomerData>>(result);
            foreach (CustomerData item in res) customer.q1.enqueue(item);
        }


        private async void adminBtn_Click(object sender, RoutedEventArgs e)
        {
            adminLogin adminLogin = new adminLogin(this);
            await adminLogin.ShowAsync();
        }

        private async void customerBtn_Click(object sender, RoutedEventArgs e)

        {
            purchaseReturn dialogue = new purchaseReturn(this);
            await dialogue.ShowAsync();
            //this.Frame.Navigate(typeof(customer));
        }

        private async void developer_Click(object sender, RoutedEventArgs e)
        {
            developBy x = new developBy();
            await x.ShowAsync();

        }

        
    }
}
