using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracelFeeSimulation
{
    class Application
    {
        static Application application = null;
        private List<City> cities = null;
        private Application()
        {
            cities = new List<City>();
        }

        public static Application GetInstance()
        {
            if(application == null)
            {
                application = new Application();
            }
            return application;
        }
        internal void Run()
        {
            application.Init();
            application.Simulation();
        }

        private void Init()
        {
            cities.Add(new City("부산", 0));
            cities.Add(new City("대구", 105.84));
            cities.Add(new City("대전", 259.24));
            cities.Add(new City("서울", 397.40));
        }

        private void Simulation()
        {
            City dep_city = SelectCity("도착 도시");
            if(dep_city == null)
            {
                Console.WriteLine("잘못 선택하였습니다.");
                return;
            }
            City arr_city = SelectCity("출발 도시");
            if (arr_city == null)
            {
                Console.WriteLine("잘못 선택하였습니다.");
                return;
            }
            Parcel parcel = MakeParcel();
            PrintDelivertFee(dep_city, arr_city, parcel);
        }
        internal City SelectCity(string msg)
        {
            Console.Write("{0}(", msg);
            for(int i = 0; i < cities.Count; i++)
            {
                Console.Write("{0}:{1} ", i, cities[i].Name);
            }
            Console.Write("):");
            int index = 0;
            if (int.TryParse(Console.ReadLine(), out index) == false)
            {
                return null;
            }

            if (index >= 0 && index < cities.Count)
            {
                return cities[index];
            }
            else
                return null;
        }
        internal Parcel MakeParcel()
        {
            Console.Write("무게 (Kg) : ");
            string temp = Console.ReadLine();
            double toDouble = 0;
            Parcel p = null ;
            if (double.TryParse(temp, out toDouble))
            {
                p = new Parcel(toDouble);
            }
            return p;
        }

        internal void PrintDelivertFee(City dep, City arrrv, Parcel par)
        {
            double distance = dep.CalculateDistance(arrrv);
            Console.WriteLine("{0}부터 {1}까지 택배요금 :{2}", dep.Name, arrrv.Name, par.CalculateFee(distance));
        }

    }
}
