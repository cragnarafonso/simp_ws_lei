using simp_ws_lei.MVC.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace simp_ws_lei
{
    public partial class MainForm : Form
    {
        public MainView MainView {  get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void HeaderCloseBtt_Click(object sender, EventArgs e)
        {
            this.MainView.OnCloseFormTriggered();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.MainView.OnFormLoad();
        }



        //Avisos Meteorológicos button
        private void footerWarningBtt_Click(object sender, EventArgs e)
        {

        }

        private void footerWarningBtt_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Avisos Meteorológicos", footerWarningBtt);
        }
        //


        //Home Button
        private void footerHomeBtt_Click(object sender, EventArgs e)
        {

        }

        private void footerHomeBtt_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Home", footerHomeBtt);
        }
        //


        //Estado do Mar Button
        private void footerSeaBtt_Click(object sender, EventArgs e)
        {

        }

        private void footerSeaBtt_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Estado do Mar", footerSeaBtt);
        }
        //


        //Interdições Button
        private void footerClamBtt_Click(object sender, EventArgs e)
        {

        }

        private void footerClamBtt_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Interdições", footerClamBtt);
        }
        //

        private void MainBodyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
