using simp_ws_lei.Records;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace simp_ws_lei.MVC.Models
{
    public class MainModel
    {
        private ICoordinates coordinates;
        private IDistrictsIslandsIdentifiers districtsIslandsIdentifiers;

        // ADICIONADO POR MIGUEL -------
        private IDailyMeteorologyByLocationId dailyMeteorologyByLocationId;
        // ADICIONADO POR MIGUEL -------

        // ADICIONADO POR DAVID
        private IDailySeaForecast dailySeaForecast;
        // ADICIONADO POR DAVID

        public delegate void NotificationMessageTriggeredEventHandler(string message);
        public event NotificationMessageTriggeredEventHandler NotificationMessageTriggered;

        public delegate void NotificationTriggeredEventHandler();
        public event NotificationTriggeredEventHandler NotificationTriggered;

        public delegate void DistrictsIslandsIdentifiersTriggeredEventHandler(ref IDistrictsIslandsIdentifiers districtsIslandsIdentifiers);
        public event DistrictsIslandsIdentifiersTriggeredEventHandler DistrictsIslandsIdentifiersTriggered;

        // ADICIONADO POR MIGUEL -------
        public delegate void DailyMeteorologyByLocationIdTriggeredEventHandler(ref IDailyMeteorologyByLocationId dailyMeteorologyByLocationId);
        public event DailyMeteorologyByLocationIdTriggeredEventHandler DailyMeteorologyByLocationIdTriggered;
        // ADICIONADO POR MIGUEL -------

        // ADICIONADO POR DAVID
        public delegate void DailySeaForecastTriggeredEventHandler(ref IDailySeaForecast dailySeaForecast);
        public event DailySeaForecastTriggeredEventHandler DailySeaForecastTriggered;
        // ADICIONADO POR DAVID

        public MainModel()
        {
            this.districtsIslandsIdentifiers = new DistrictsIslandsIdentifiers();

            // ADICIONADO POR MIGUEL -------
            this.dailyMeteorologyByLocationId = new DailyMeteorologyByLocationId();
            // ADICIONADO POR MIGUEL -------

            // ADICIONADO POR DAVID
            this.dailySeaForecast = new DailySeaForecast();
            // ADICIONADO POR DAVID
        }

        protected virtual void OnNotificationFailureTriggered(string message)
        {
            NotificationMessageTriggered?.Invoke(message);
        }
        protected virtual void OnNotificationDeserializeDistrictsIslandsTriggered()
        {
            NotificationTriggered?.Invoke();
        }

        // ADICIONADO POR MIGUEL -------
        protected virtual void OnNotificationDeserializeDailyMeteorologyByLocationIdTriggered()
        {
            DailyMeteorologyByLocationIdTriggered?.Invoke(ref dailyMeteorologyByLocationId);
        }
        // ADICIONADO POR MIGUEL -------

        // ADICIONADO POR DAVID
        protected virtual void OnNotificationDeserializeDailySeaForecastTriggered()
        {
            DailySeaForecastTriggered?.Invoke(ref dailySeaForecast);
        }
        // ADICIONADO POR DAVID

        protected virtual void OnNotificationOrderedDistrictsIslandsTriggered(ref IDistrictsIslandsIdentifiers districtsIslandsIdentifiers)
        {
            DistrictsIslandsIdentifiersTriggered?.Invoke(ref districtsIslandsIdentifiers);
        }

        public void DeserializeDistrictsIslandsIdentifiers(string json)
        {
            try
            {
                this.districtsIslandsIdentifiers = DistrictsIslandsIdentifiers.FromJson(json);
                this.OnNotificationDeserializeDistrictsIslandsTriggered();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                this.OnNotificationFailureTriggered("Não foi possível tratar os dados!");
            }
        }

        // ADICIONADO POR MIGUEL -------
        public void DeserializeDailyMeteorologyByLocationId(string json)
        {
            try
            {
                this.dailyMeteorologyByLocationId = DailyMeteorologyByLocationId.FromJson(json);
                this.OnNotificationDeserializeDailyMeteorologyByLocationIdTriggered();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                this.OnNotificationFailureTriggered("Não foi possível tratar os dados de meteorologia!");
            }
        }
        // ADICIONADO POR MIGUEL -------

        // ADICIONADO POR DAVID
        public async Task FetchDailySeaForecast(int day)
        {
            try
            {
                string url = $"https://api.ipma.pt/open-data/forecast/oceanography/daily/hp-daily-sea-forecast-day{day}.json";
                using (HttpClient client = new HttpClient())
                {
                    string result = await client.GetStringAsync(url);
                    this.dailySeaForecast = DailySeaForecast.FromJson(result);
                    this.OnNotificationDeserializeDailySeaForecastTriggered();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                this.OnNotificationFailureTriggered("Não foi possível tratar os dados do estado do mar!");
            }
        }
        // ADICIONADO POR DAVID

        public void OrderDistrictsIslandsTriggered(ref ICoordinates refCoordinates)
        {
            try
            {
                if (refCoordinates != null)
                {
                    this.coordinates = new DeviceCoordinates(refCoordinates.Latitude, refCoordinates.Longitude);
                    DistrictsIslands targetRegion = this.districtsIslandsIdentifiers.Data.Find(item => this.coordinates.Latitude.Equals(item.Latitude) && this.coordinates.Longitude.Equals(item.Longitude));
                    if (targetRegion != null)
                    {
                        this.districtsIslandsIdentifiers.Data.Remove(targetRegion);
                        this.districtsIslandsIdentifiers.Data.Insert(0, targetRegion);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
            this.OnNotificationOrderedDistrictsIslandsTriggered(ref this.districtsIslandsIdentifiers);
        }
    }
}
