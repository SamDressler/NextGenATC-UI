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
    public partial class QueueTabForm : Form
    {
        readonly string landingQueuelabelText = "Current Landing Queue Length: ";
        readonly string takeoffQueuelabelText = "Current Takeoff Queue Length: ";
        public QueueTabForm()
        {
            InitializeComponent();
        }
        #region Landing Queue Methods
        public void addToLandingQueue(string ID)
        {
            ListViewItem item = new ListViewItem();
            item.Text = ID;
            this.landingQueueListView.Items.Add(item.Text);
            this.landingQueueLengthLabel.Text = landingQueuelabelText + this.landingQueueListView.Items.Count;
        }
        public void removeFromLandingQueue(string ID)
        {
            ListViewItem item = new ListViewItem();
            item = this.landingQueueListView.FindItemWithText(ID);
            this.landingQueueListView.Items.Remove(item);
            this.landingQueueLengthLabel.Text = landingQueuelabelText + this.landingQueueListView.Items.Count;
        }
        #endregion
        #region Takeoff Queue Methods
        public void addToTakeoffQueue(string ID)
        {
            ListViewItem item = new ListViewItem();
            item.Text = ID;
            this.takeoffQueueListView.Items.Add(item.Text);
            this.takeoffQueueLengthLabel.Text = takeoffQueuelabelText + this.takeoffQueueListView.Items.Count;
        }
        public void removeFromTakeoffQueue(string ID)
        {
            ListViewItem item = new ListViewItem();
            item = this.takeoffQueueListView.FindItemWithText(ID);
            this.takeoffQueueListView.Items.Remove(item);
            this.takeoffQueueLengthLabel.Text = takeoffQueuelabelText + this.takeoffQueueListView.Items.Count;
        }
        #endregion
    }
}
