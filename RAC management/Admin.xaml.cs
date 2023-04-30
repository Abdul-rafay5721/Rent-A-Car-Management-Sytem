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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace RAC_management
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Admin : Page
    {
        public static RAC_List car_list= new RAC_List();
        //public static RAC_Queue q1= new RAC_Queue();
        public static Car carData;
        public Admin()
        {
            this.InitializeComponent();
        }

        private void searchCarBtn_click(object sender, RoutedEventArgs e)
        {
            searchCars.Visibility = Visibility.Visible;
            addCars.Visibility = Visibility.Collapsed;
            searchOrdersByCnic.Visibility = Visibility.Collapsed;
        }

        private void addCarBtn_click(object sender, RoutedEventArgs e)
        {
            carData=new Car();

            //Visibility section
            addCars.Visibility = Visibility.Visible;
            searchCars.Visibility = Visibility.Collapsed;
            searchOrdersByCnic.Visibility = Visibility.Collapsed;
        }
        

        private void OrdersBtn_click(object sender, RoutedEventArgs e)
        {
            searchCars.Visibility = Visibility.Collapsed;
            addCars.Visibility= Visibility.Collapsed;
            searchOrdersByCnic.Visibility = Visibility.Collapsed;

        }

        private void searchOrderIdBtn_click(object sender, RoutedEventArgs e)
        {
            searchCars.Visibility = Visibility.Collapsed;
            addCars.Visibility = Visibility.Collapsed;
            searchOrdersByCnic.Visibility = Visibility.Collapsed;
        }

        private void searchOrderCnicBtn_click(object sender, RoutedEventArgs e)
        {
            searchCars.Visibility = Visibility.Collapsed;
            addCars.Visibility = Visibility.Collapsed;
            searchOrdersByCnic.Visibility = Visibility.Visible;
        }

        private void searchSubmit_Click(object sender, RoutedEventArgs e)
        {
            string name = searchValue.Text;
            Car temp = car_list.searchCar(name);
            if (temp != null)
            {
                resultShow.Visibility= Visibility.Visible;
                showResult.Text = "Car found !. Here is Info.";
                searchResultName.Text = "Name : "+temp.carName;
                searchResultModel.Text = "Model : " + temp.carModel.ToString();
                searchResultPlate.Text = "Number Plate : " + temp.carNumberPlate;
            }
            else
            {
                showResult.Text = "Sorry! No car found.";
            }

        }

        private void addCarSubmit_Click(object sender, RoutedEventArgs e)
        {
            //data structure implementation
            carData = new Car();
            if (model.Text != "" && price.Text != "")
            {
                carData.carModel = int.Parse(model.Text);
                carData.oneDayPrice = double.Parse(price.Text);

            }
            carData.carName = name.Text;
            carData.carNumberPlate = plate.Text;

            car_list.addCar(carData);
            add_car_in_db();
            if (carData != null)
            {
                addCarResult.Text = "Car added successfully! ! !";
            }
        }
        
        private async void add_car_in_db()
        {
            var values = new Dictionary<string, string>
            {
               { "carName", carData.carName },
               { "carModel", carData.carModel.ToString() },
               { "carRegNo", carData.carNumberPlate },
               { "carPrice", carData.oneDayPrice.ToString() },
            };
            HttpContent content = new FormUrlEncodedContent(values);
            HttpResponseMessage response = await Helper.client.PostAsync("carInfo.php", content);
            string result = await response.Content.ReadAsStringAsync();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            App.TryGoBack();
        }

        private void searchCnicSubmit_Click(object sender, RoutedEventArgs e )
        {
            CustomerData temp= new CustomerData();

            temp = customer.q1.searchByCnic(cnicToSearch.Text);
            if (temp != null)
            {
                var result = $"Data Found !!!\nCustomer Name : {temp.customerName}\nCustomer Contact : {temp.customerNo}\nCustomer CNIC : {temp.CNIC}\nCustomer car : {temp.carName}\nDays : {temp.Tdays}\nFrom Date : {temp.startDate}\nTo Date : {temp.endDate}";
                resultvisibility.Visibility = Visibility.Visible;
                cnicSearchResult.Text = result;

            }


        }

    }
}
