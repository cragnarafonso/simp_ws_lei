using simp_ws_lei.MVC.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simp_ws_lei.Forms
{
    public partial class ErrorForm : Form
    {
        public MainView MainView { get; set; }
        public ErrorForm()
        {
            InitializeComponent();
        }

        private void OKErrorBtt_Click(object sender, EventArgs e)
        {
            this.MainView.OnCloseFormTriggered();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.ipma.pt";

            try
            {
                Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel abrir o link. " + ex.Message);
            }
        }
    }
}
