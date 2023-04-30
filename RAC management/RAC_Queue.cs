using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Windows.UI.Xaml.Automation.Peers;

namespace RAC_management
{
    public static class Helper
    {
        public static HttpClient client = new HttpClient()
        {
            BaseAddress= new Uri("http://127.0.0.1/RAC/")
        };
    }
    public class CustomerData
    {
        public string carName,customerName, customerNo, CNIC;
        public bool withDriver;
        public int Tdays;
        public string startDate, endDate;
        public CustomerData() { 
        }
        public CustomerData(string cName, string name, bool driver, string no, string cnic, int day, string sDate, string eDate)
        {
            carName = cName;
            customerName = name;
            Tdays = day;
            withDriver = driver;
            CNIC = cnic;
            customerNo = no;
            startDate = sDate;
            endDate = eDate;
        }
    }
    public class RAC_Queue
    {
        int front,rear,size,count;
        List<CustomerData> data;

        public RAC_Queue()
        {
            front = count = 0;
            rear = -1;
            data = new List<CustomerData>();
        }

        public void enqueue(CustomerData d)
        {
            rear += 1;
            count++;
            data.Add(d);
            data = data.OrderBy(x => DateTime.Parse(x.endDate)).ToList();
        }
        public CustomerData dequeue()
        {
            count--;
            CustomerData res = data.ElementAt(front);
            data.RemoveAt(front);
            front += 1;
            return res;
        }
        public CustomerData searchByCnic(string cnic)
        {
            CustomerData toSearch = data.Where<CustomerData>(x => x.CNIC == cnic)?.First();
            if (toSearch != null)
            {
                return toSearch;
            }
            return  null;
        }
         
        public CustomerData returnByCnic(string returnCnic)
        {
            CustomerData toSearch = data.Where<CustomerData>(x => x.CNIC == returnCnic)?.First();
            if (toSearch != null)
            {
                return toSearch;
            }
            return null;
        }

    }
}
