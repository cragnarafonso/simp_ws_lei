using simp_ws_lei.Records;
using System;
using System.Diagnostics;

namespace simp_ws_lei.MVC.Models
{
    public class MainModel
    {
        private ICoordinates coordinates;
        private IDistrictsIslandsIdentifiers districtsIslandsIdentifiers;

        //ADICIONADO POR MIGUEL -------
        private IDailyMeteorologyByLocationId dailyMeteorologyByLocationId;
        //ADICIONADO POR MIGUEL -------

        //ADICIONADO POR Paulo -------
        private IDailyWarningByLocationId dailyWarningByLocationId;
        //ADICIONADO POR Paulo -------

        public delegate void NotificationMessageTriggeredEventHandler(string message);
        public event NotificationMessageTriggeredEventHandler NotificationMessageTriggered;

        public delegate void NotificationTriggeredEventHandler();
        public event NotificationTriggeredEventHandler NotificationTriggered;

        public delegate void DistrictsIslandsIdentifiersTriggeredEventHandler(ref IDistrictsIslandsIdentifiers districtsIslandsIdentifiers);
        public event DistrictsIslandsIdentifiersTriggeredEventHandler DistrictsIslandsIdentifiersTriggered;

        //ADICIONADO POR MIGUEL -------
        public delegate void DailyMeteorologyByLocationIdTriggeredEventHandler(ref IDailyMeteorologyByLocationId dailyMeteorologyByLocationId);
        public event DailyMeteorologyByLocationIdTriggeredEventHandler DailyMeteorologyByLocationIdTriggered;
        //ADICIONADO POR MIGUEL -------

        //ADICIONADO POR Paulo -------
        public delegate void DailyWarningByLocationIdTriggeredEventHandler(ref IDailyWarningByLocationId dailyWarningByLocationId);
        public event DailyWarningByLocationIdTriggeredEventHandler DailyWarningByLocationIdTriggered;
        //ADICIONADO POR Paulo -------

        public MainModel()
        {
            this.districtsIslandsIdentifiers = new DistrictsIslandsIdentifiers();

            //ADICIONADO POR MIGUEL -------
            this.dailyMeteorologyByLocationId = new DailyMeteorologyByLocationId();
            //ADICIONADO POR MIGUEL -------

            //ADICIONADO POR Paulo -------
            this.dailyWarningByLocationId = new DailyWarningByLocationId();
            //ADICIONADO POR Paulo -------
        }

        protected virtual void OnNotificationFailureTriggered(string message)
        {
            NotificationMessageTriggered?.Invoke(message);
        }

        protected virtual void OnNotificationDeserializeDistrictsIslandsTriggered()
        {
            NotificationTriggered?.Invoke();
        }

        //ADICIONADO POR MIGUEL -------
        protected virtual void OnNotificationDeserializeDailyMeteorologyByLocationIdTriggered()
        {
            DailyMeteorologyByLocationIdTriggered?.Invoke(ref dailyMeteorologyByLocationId);
        }
        //ADICIONADO POR MIGUEL -------

        //ADICIONADO POR Paulo -------
        protected virtual void OnNotificationDeserializeWarningByLocationIdTriggered()
        {
            DailyWarningByLocationIdTriggered?.Invoke(ref dailyWarningByLocationId);
        }
        //ADICIONADO POR Paulo -------

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

        //ADICIONADO POR MIGUEL -------
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
        //ADICIONADO POR MIGUEL -------

        //ADICIONADO POR Paulo -------
        public void DeserializeDailyWarningByLocationId(string json)
        {
            try
            {
                this.dailyWarningByLocationId = DailyWarningByLocationId.FromJson(json);
                this.OnNotificationDeserializeWarningByLocationIdTriggered();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                this.OnNotificationFailureTriggered("Não foi possível tratar os dados dos avisos meteorológicos!");
            }
        }
        //ADICIONADO POR Paulo -------

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
