using simp_ws_lei.Records;
using System;
using System.Diagnostics;

namespace simp_ws_lei.MVC.Models
{
    public class MainModel
    {
        private ICoordinates coordinates;
        private IDistrictsIslandsIdentifiers districtsIslandsIdentifiers;

        public delegate void NotificationMessageTriggeredEventHandler(string message);
        public event NotificationMessageTriggeredEventHandler NotificationMessageTriggered;

        public delegate void NotificationTriggeredEventHandler();
        public event NotificationTriggeredEventHandler NotificationTriggered;

        public delegate void DistrictsIslandsIdentifiersTriggeredEventHandler(ref IDistrictsIslandsIdentifiers districtsIslandsIdentifiers);
        public event DistrictsIslandsIdentifiersTriggeredEventHandler DistrictsIslandsIdentifiersTriggered;

        public MainModel()
        {
            this.districtsIslandsIdentifiers = new DistrictsIslandsIdentifiers();
        }

        protected virtual void OnNotificationFailureTriggered(string message)
        {
            NotificationMessageTriggered?.Invoke(message);
        }
        protected virtual void OnNotificationDeserializeDistrictsIslandsTriggered()
        {
            NotificationTriggered?.Invoke();
        }
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

        public void OrderDistrictsIslandsTriggered(ref ICoordinates refCoordinates)
        {
            try
            {
                if(refCoordinates != null)
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

