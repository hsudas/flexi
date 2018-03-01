using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using Flexi.WebUI.Controllers;

using Flexi.WebUI.Models;


namespace Flexi.WebUI.Utility
{
    public static class DashboardData
    {
        #region < Private Variable Declaration >
        private static Timer _timer;
        private static readonly Random Random = new Random();
        public static double RandomNumberBetween(double minValue, double maxValue)
        {
            var next = Random.NextDouble();

            return minValue + (next * (maxValue - minValue));
        }

        private static int RandomIntNumberBetween(int minValue, int maxValue)
        {
            return Random.Next(minValue, maxValue); 
        }
        #endregion

        #region < Mock Data Repositories >
        private static Graph GetTokyoData()
        {
            var arr = new Graph();
           
            arr.name = "Costco";

            for (int i = 0; i < 12; i++)
            {
                arr.data.Add(RandomNumberBetween(1, 120));
            }
            return arr;
        }

        private static Graph GetLondonData()
        {
            var arr = new Graph();
            arr.name = "Sams";
            for (int i = 0; i < 12; i++)
            {

                //arr.data.Add(i*10);
                arr.data.Add(RandomNumberBetween(1, 120));
            }
            return arr;
        }
      
        private static Graph GetBerlinData()
        {
            var arr = new Graph();
        
            arr.name = "Toyzrus";
            for (int i = 0; i < 12; i++)
            {
                arr.data.Add(RandomNumberBetween(1, 120));
            }
            return arr;
        }

        private static Graph GetNewYorkData()
        {
            var arr = new Graph();
            arr.name = "New York";
          
           
            for (int i = 0; i < 12; i++)
            {
                arr.data.Add(RandomNumberBetween(1, 120));
            }
            return arr;
        }

        #endregion

        #region < Public Methods >

        public static GraphCollection GetChartDataForDashboard()
        {
            GraphCollection gc = new GraphCollection();
            var list = new List<Graph>();
            list.Add(GetTokyoData());
            list.Add(GetLondonData());
            list.Add(GetBerlinData());
            //list.Add(GetNewYorkData());
            gc.GraphList = list;
           
            return gc;
        }

        public static CustomerInformations GetCustomerInformations()
        {
            return new CustomerInformations()
            {
                NewlyRegistered = RandomIntNumberBetween(200, 5000).ToString(),
                SubscribedCustomers = RandomIntNumberBetween(200, 3000).ToString(),
                TopRatedCustomers = RandomIntNumberBetween(300, 1500).ToString(),
                PendingToApprove = RandomIntNumberBetween(10, 500).ToString(),
            };
        }
        #endregion
    }
}