using simp_ws_lei.Forms;
using simp_ws_lei.Records;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Diagnostics;
using System.Windows.Forms;

namespace simp_ws_lei.MVC.Views
{
    public class MainView
    {
        public delegate void ActionTriggeredEventHandler();
        public event ActionTriggeredEventHandler CloseFormTriggered;

        public delegate void ApiTriggeredEventHandler(string json);
        public event ApiTriggeredEventHandler RequestDistrictsIslandsIdentifiersTriggered;

        //ADICIONADO POR MIGUEL -------
        public event ApiTriggeredEventHandler RequestDailyMeteorologyByLocationIdTriggered;
        //ADICIONADO POR MIGUEL -------

        public delegate void GeolocationTriggeredEventHandler(ref ICoordinates coordinates);
        public event GeolocationTriggeredEventHandler GeolocationTriggered;

        private readonly IPMARequest request;
        private ICoordinates coordinates;
        private IDistrictsIslandsIdentifiers identifiers;

        private MainForm mainForm;
        private HomeForm homeForm;

        public MainView()
        {
            this.request = new IPMARequest(new RestSharpCaller());
        }

        public virtual void OnCloseFormTriggered()
        {
            CloseFormTriggered?.Invoke();
        }
        protected virtual void OnRequestDistrictsIslandsIdentifiersTriggered(string json)
        {
            RequestDistrictsIslandsIdentifiersTriggered?.Invoke(json);
        }


        //ADICIONADO POR MIGUEL -------
        protected virtual void OnRequestDailyMeteorologyByLocationIdTriggered(string json)
        {
            RequestDailyMeteorologyByLocationIdTriggered?.Invoke(json);
        }
        //ADICIONADO POR MIGUEL -------



        protected virtual void OnGeolocationTriggered(ref ICoordinates coordinates)
        {
            GeolocationTriggered?.Invoke(ref coordinates);
        }

        public void LoadInterface()
        {
            this.mainForm = new MainForm
            {
                MainView = this
            };
            this.mainForm.ShowDialog();
        }

        public void OnFormLoad()
        {
            try
            {
                string result = this.request.GetDistrictsIslandsIdentifiers();
                OnRequestDistrictsIslandsIdentifiersTriggered(result);                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                OnDisplayFailureMessage("Não foi possível aceder as dados!");
            }
        }

        public void OnDisplayFailureMessage(string message)
        {
            ErrorForm errorForm = new ErrorForm
            {
                TopLevel = false,
                AutoScroll = true,
                Location = new System.Drawing.Point(74, 171),
                Anchor = System.Windows.Forms.AnchorStyles.None,
                MainView = this
            };
            errorForm.ErrorMsgLabel.Text = message;
            this.mainForm.MainBodyPanel.Controls.Add(errorForm);
            errorForm.Show();
        }
        public void GetDeviceGeolocation()
        {
            this.coordinates = null;
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

            // Do not suppress prompt, and wait 1000 milliseconds to start.
            watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

            GeoCoordinate coord = watcher.Position.Location;

            if (coord.IsUnknown != true)
            {
                this.coordinates = new DeviceCoordinates(coord.Latitude.ToString(), coord.Longitude.ToString());
            }
            OnGeolocationTriggered(ref coordinates);
        }



        //ADICIONADO POR MIGUEL -------
        public void GetDailyMeteorology(string globalIdLocal)
        {
            try
            {
                string resultDailyMeteorology = this.request.GetDailyMeteorologyByLocationId(globalIdLocal);
                OnRequestDailyMeteorologyByLocationIdTriggered(resultDailyMeteorology);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                OnDisplayFailureMessage("Não foi possível aceder à meteorologia!");
            }
            
        }

        public void LoadDailyMeteorology(ref IDailyMeteorologyByLocationId dailyMeteorologyByLocationId)
        {
            //EM FALTA CARREGAR DADOS NA FORM
        }
        //ADICIONADO POR MIGUEL -------



        public void LoadHomeForm(ref IDistrictsIslandsIdentifiers districtsIslandsIdentifiers)
        {
            this.identifiers = districtsIslandsIdentifiers;

            //ADICIONADO POR MIGUEL -------
            //LOAD DEFAULT DAILY METEOROLOGY FROM FIRST LOCAL ID
            string FirstGlobalLocalId = this.identifiers.Data[0].GlobalLocalId.ToString();
            this.GetDailyMeteorology(FirstGlobalLocalId);
            //ADICIONADO POR MIGUEL -------


            this.homeForm = new HomeForm
            {
                TopLevel = false,
                AutoScroll = true,
                Location = new System.Drawing.Point(5, 42),
                Anchor = System.Windows.Forms.AnchorStyles.None,
                MainView = this
            };
            this.homeForm.HomeCmbBox.DataSource = this.identifiers.GetIdNameRegions();
            this.homeForm.HomeCmbBox.DisplayMember = "Value";
            this.homeForm.HomeCmbBox.ValueMember = "Id";

            this.mainForm.MainBodyPanel.Controls.Add(homeForm);
            this.homeForm.Show();
        }
    }
}
