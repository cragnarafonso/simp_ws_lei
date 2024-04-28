using simp_ws_lei.Forms;
using simp_ws_lei.Records;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Diagnostics;

namespace simp_ws_lei.MVC.Views
{
    public class MainView
    {
        public delegate void ActionTriggeredEventHandler();
        public event ActionTriggeredEventHandler CloseFormTriggered;

        public delegate void ApiTriggeredEventHandler(string json);
        public event ApiTriggeredEventHandler RequestApiTriggered;

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
            RequestApiTriggered?.Invoke(json);
        }

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

            this.homeForm = new HomeForm
            {
                TopLevel = false,
                AutoScroll = true,
                Location = new System.Drawing.Point(5, 42),
                Anchor = System.Windows.Forms.AnchorStyles.None,
                MainView = this
            };
            this.mainForm.MainBodyPanel.Controls.Add(homeForm);
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

        internal void LoadOrderDistrictsIslandsTriggered(ref IDistrictsIslandsIdentifiers districtsIslandsIdentifiers)
        {
            this.identifiers = districtsIslandsIdentifiers;
            this.homeForm.HomeCmbBox.DataSource = this.identifiers.GetIdNameRegions();
            this.homeForm.HomeCmbBox.DisplayMember = "Value";
            this.homeForm.HomeCmbBox.ValueMember = "Id";
            this.homeForm.Show();
        }
    }
}
