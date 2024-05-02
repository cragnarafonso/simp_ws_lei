using simp_ws_lei.MVC.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simp_ws_lei.Forms
{
    public partial class HomeForm : Form
    {
        public MainView MainView { get; set; }

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedGlobalIdLocation = HomeCmbBox.SelectedValue.ToString();

            //ignore change when first load
            if (SelectedGlobalIdLocation != "simp_ws_lei.Records.Item")
            {
                this.MainView.GetDailyMeteorology(ref SelectedGlobalIdLocation);
            }
        }
    }
}
