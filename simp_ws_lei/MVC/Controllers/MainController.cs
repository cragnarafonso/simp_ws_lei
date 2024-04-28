
using simp_ws_lei.MVC.Models;
using simp_ws_lei.MVC.Views;
using System;

namespace simp_ws_lei.MVC.Controllers
{
    public class MainController
    {
        private readonly MainView mainView;
        private readonly MainModel mainModel;

        public MainController()
        {
            this.mainView = new MainView();
            this.mainModel = new MainModel();

            this.mainView.CloseFormTriggered += this.CloseForm;
            this.mainView.RequestApiTriggered += this.mainModel.DeserializeDistrictsIslandsIdentifiers;
            this.mainView.GeolocationTriggered += this.mainModel.OrderDistrictsIslandsTriggered;

            this.mainModel.NotificationMessageTriggered += this.mainView.OnDisplayFailureMessage;
            this.mainModel.NotificationTriggered += this.mainView.GetDeviceGeolocation;
            this.mainModel.DistrictsIslandsIdentifiersTriggered += this.mainView.LoadOrderDistrictsIslandsTriggered;
        }

        public void CloseForm()
        { 
            Environment.Exit(1);
        }

        public void Run()
        {
            this.mainView.LoadInterface();
        }
    }
}
