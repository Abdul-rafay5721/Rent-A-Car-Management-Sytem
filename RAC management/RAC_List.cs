using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;
using Windows.Devices.SmartCards;

namespace RAC_management
{
     public class Car
    {
        public string carName;
        public int carModel;
        public string carNumberPlate;
        public double oneDayPrice;  
    }

    public class RAC_List
    {
        public List<Car> cars;
        public RAC_List()
        {
            cars = new List<Car>();
        }

        public void addCar(Car car) 
        {
            cars.Add(car);
        }

        public void delteCar(string carNP)
        {
            Car to_delete = cars.Where<Car>(x => x.carNumberPlate == carNP).First();
            if (to_delete != null)
            {
                cars.Remove(to_delete);
            }
        }
        public Car searchCar(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                return cars.Where<Car>(x => x.carName == name)?.First();

            }
            return null;
        }

        public double getPrice(string carname)
        {
            if (!string.IsNullOrEmpty(carname))
            {
                 return (cars.Where<Car>(x => x.carName == carname).First().oneDayPrice);
            }
            return 0.0;
        }


    }
}
