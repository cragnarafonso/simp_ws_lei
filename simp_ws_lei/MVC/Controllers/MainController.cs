using simp_ws_lei.MVC.Models;
using simp_ws_lei.MVC.Views;
using System;
using System.Threading.Tasks;

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
            this.mainView.RequestDistrictsIslandsIdentifiersTriggered += this.mainModel.DeserializeDistrictsIslandsIdentifiers;

            // ADICIONADO POR MIGUEL -------
            this.mainView.RequestDailyMeteorologyByLocationIdTriggered += this.mainModel.DeserializeDailyMeteorologyByLocationId;
            // ADICIONADO POR MIGUEL -------

            // ADICIONADO POR DAVID
            this.mainView.RequestSeaForecastTriggered += async (day) => await this.mainModel.FetchDailySeaForecast(day);
            // ADICIONADO POR DAVID

            this.mainView.GeolocationTriggered += this.mainModel.OrderDistrictsIslandsTriggered;

            this.mainModel.NotificationMessageTriggered += this.mainView.OnDisplayFailureMessage;
            this.mainModel.NotificationTriggered += this.mainView.GetDeviceGeolocation;
            this.mainModel.DistrictsIslandsIdentifiersTriggered += this.mainView.LoadHomeForm;

            // ADICIONADO POR MIGUEL -------
            this.mainModel.DailyMeteorologyByLocationIdTriggered += this.mainView.LoadDailyMeteorology;
            // ADICIONADO POR MIGUEL -------

            // ADICIONADO POR DAVID
            this.mainModel.DailySeaForecastTriggered += this.mainView.LoadDailySeaForecast;
            // ADICIONADO POR DAVID
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
