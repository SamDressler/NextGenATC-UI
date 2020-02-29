using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextGenATC_GUI
{
    public partial class WeatherTab : Form
    {
        public WeatherTab()
        {
            InitializeComponent();
        }

        private void ShowWeatherOverlayLabel_Click(object sender, EventArgs e)
        {
            //Call function to show the weather overlay on the display.
            Program.mainWindow.showWeatherOverlay();

        }
    }
}
