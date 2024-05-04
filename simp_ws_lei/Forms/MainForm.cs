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
    }
}
