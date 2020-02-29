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
    public partial class ApplicationWindow : Form
    {
        #region Initialize variables/Objects
        const int halfSecond = 500;
        const int oneSecond = 1000;
        const int twoSecond = 2000;
        const int fiveSecond = 5000;
        string currentPage = "Map Control";
        public string currentView = "Digital";
        string prevPage = String.Empty;
        QueueTabForm queueTab = new QueueTabForm();
        WeatherTab weatherTab = new WeatherTab();
        FlightLogTab logTab = new FlightLogTab();
        TestCaseForm testTab = new TestCaseForm();
        bool isAircraftSelected = false;
        bool weatherOverlayEnabled = false;
        #endregion
        public ApplicationWindow()
        {
            InitializeComponent();   
        }
        #region Load formats 
        private void ApplicationWindow_Load(object sender, EventArgs e)
        {
            loadScaleFormat();
        }
        #endregion
        #region Test Event 1 : Plane Landing
        public void testCaseOne()
        {
            //Aircraft will fly in from the north and land on the vertical runways
            //begin preparing for scenario
            //Set cursor to AppStarting since the user can not affect the system
            // while simulation is underway
            this.Cursor = Cursors.AppStarting;

            //set background of plane icon to be transparent
            Bitmap b = Properties.Resources.planeIcon_down;
            b = Properties.Resources.planeIcon_down;
            b.MakeTransparent(Color.Black);
            this.planeOne.Image = b;
            //make sure the aircraft ID is correct
            this.planeOneIDLabel.Text = "AA123";
            //set plane icon at starting location
            this.planeOneInfoPanel.Location = new Point(415, 0);
            this.planeOneControlLabel.Text = "A";
            this.planeOneSpeedLabel.Text = "210";
            this.planeOneInfoPanel.Visible = true;
            this.totalAircraftInAirspaceLabel.Text = "1";
            this.AircraftUnderATCControlLabel.Text = "1";
            string ID = this.planeOneIDLabel.Text;
            //add the plane ID to the queue for landing
            queueTab.addToLandingQueue(ID);
            showQueueForm();
            //after three seconds prepare begin plane movements
            wait(3000);// wait three seconds
            this.planeOneInfoPanel.Location = new Point(415, 50);
            this.planeOneAltitudeLabel.Text = "060";
            this.planeOneSpeedLabel.Text = "200";
            wait(3000);
            this.planeOneInfoPanel.Location = new Point(415, 100);
            this.planeOneAltitudeLabel.Text = "050";
            this.planeOneSpeedLabel.Text = "180";
            wait(3000);
            this.planeOneInfoPanel.Location = new Point(415, 150);
            this.planeOneAltitudeLabel.Text = "040";
            this.planeOneSpeedLabel.Text = "140";
            wait(3000);
            this.planeOneInfoPanel.Location = new Point(415, 200);
            this.planeOneAltitudeLabel.Text = "030";
            this.planeOneSpeedLabel.Text = "080";
            wait(3000);
            this.planeOneInfoPanel.Location = new Point(415, 225);
            this.planeOneAltitudeLabel.Text = "020";
            this.planeOneSpeedLabel.Text = "060";
            wait(3000);
            this.planeOneInfoPanel.Location = new Point(415, 256);
            this.planeOneAltitudeLabel.Text = "010";
            this.planeOneSpeedLabel.Text = "040"; 
            wait(3000);
            this.planeOneInfoPanel.Visible = false;

            //remove from landing queue once plane has landed
            queueTab.removeFromLandingQueue(ID);
            this.notificationLabel.Visible = true;
            this.notificationLabel.Text = "Aircraft " + ID + " Has Landed successfully";
            this.totalAircraftInAirspaceLabel.Text = "0";
            this.AircraftUnderATCControlLabel.Text = "0";
            //wait 4 seconds with notification label visible and queue tab empty before going back to test options
            wait(4000);
            this.notificationLabel.Visible = false;
            showTestForm();
            //reset cursor
            this.Cursor = Cursors.Default;
        }
        #endregion

        #region Test Event 2 : Plane Takeoff
        public void testCaseTwo()
        {
            //Set Cursor
            this.Cursor = Cursors.AppStarting;
            //Set Start Icon Orientation
            Bitmap b = Properties.Resources.planeIcon_down;
            b = Properties.Resources.planeIcon_down;
            b.MakeTransparent(Color.Black);
            this.planeTwo.Image = b;
            //make sure the aircraft ID is correct
            this.planeOneIDLabel.Text = "AA123";
           
            //Show the panel since it was not visible
            this.planeTwoInfoPanel.Visible = true;
            this.planeTwoControlLabel.Text = "D";
            
            //Set the counters 
            this.totalAircraftInAirspaceLabel.Text = "1";
            this.AircraftUnderATCControlLabel.Text = "1";


            //add the plane ID to the queue for landing
            string ID = this.planeTwoIDLabel.Text;
            queueTab.addToTakeoffQueue(ID);
            showQueueForm();

            //start location
            this.planeTwoInfoPanel.Location = new Point(415, 308);
            /*Start*/
            wait(3000);
            //Plane takes off
            this.planeTwoInfoPanel.Location = new Point(415, 340);
            this.notificationLabel.Visible = true;
            queueTab.removeFromTakeoffQueue(ID);
            this.notificationLabel.Text = "Aircraft " + ID + " Has Taken Off successfully";
            /*1*/
            wait(3000);
            this.planeTwoInfoPanel.Location = new Point(412, 360);
            /*2*/
            wait(3000);
            //Remove notification
            //aircraft heads down and left
            this.notificationLabel.Visible = false;
            b = Properties.Resources.planeIcon_downLeft;
            b.MakeTransparent(Color.Black);

            this.planeTwoInfoPanel.Location = new Point(370, 380);
            this.planeTwo.Image = b;
            this.planeTwoAltitudeLabel.Text = "002";
            this.planeTwoSpeedLabel.Text = "075";
            this.planeTwoHeadingLabel.Text = "230";
            /*3*/
            wait(3000);
            b = Properties.Resources.planeIcon_left;
            b.MakeTransparent(Color.Black);

            this.planeTwoInfoPanel.Location = new Point(340, 370);
            this.planeTwo.Image = b;
            this.planeTwoAltitudeLabel.Text = "010";
            this.planeTwoSpeedLabel.Text = "120";
            this.planeTwoHeadingLabel.Text = "180";
            /*4*/
            wait(3000);
            b = Properties.Resources.planeIcon_leftUp;
            b.MakeTransparent(Color.Black);

            this.planeTwoInfoPanel.Location = new Point(300, 340);
            this.planeTwo.Image = b;
            this.planeTwoAltitudeLabel.Text = "020";
            this.planeTwoSpeedLabel.Text = "140";
            this.planeTwoHeadingLabel.Text = "150";
            /*5*/
            wait(3000);
            b = Properties.Resources.planeIcon_left;
            b.MakeTransparent(Color.Black);

            this.planeTwoInfoPanel.Location = new Point(260, 310);
            this.planeTwo.Image = b;
            this.planeTwoAltitudeLabel.Text = "030";
            this.planeTwoSpeedLabel.Text = "145";
            this.planeTwoHeadingLabel.Text = "180";
            /*6*/
            wait(3000);
            this.planeTwoInfoPanel.Location = new Point(210, 310);
            this.planeTwoAltitudeLabel.Text = "040";
            this.planeTwoSpeedLabel.Text = "145";
/*7*/       wait(3000);
            this.planeTwoInfoPanel.Location = new Point(140, 310);
            this.planeTwoAltitudeLabel.Text = "045";
            this.planeTwoSpeedLabel.Text = "150";
/*8*/       wait(3000);
            this.notificationLabel.Visible = true;
            this.notificationLabel.Text = "Aircraft " + ID + " Has Left ATC control";
            this.AircraftUnderATCControlLabel.Text = "0";
            this.totalAircraftInAirspaceLabel.Text = "0";
            b = Properties.Resources.planeIcon_downLeft;
            b.MakeTransparent(Color.Black);

            this.planeTwoInfoPanel.Location = new Point(70, 340);
            this.planeTwo.Image = b;
            this.planeTwoAltitudeLabel.Text = "030";
            this.planeTwoSpeedLabel.Text = "145";
            this.planeTwoHeadingLabel.Text = "230";
            /*9*/
            wait(3000);
            this.notificationLabel.Visible = false;
            //Plane finished moving
            this.planeTwoInfoPanel.Visible = false;

            //reset the cursor back to its default
            this.Cursor = Cursors.Default;
            //show the test tab 
            this.showTestForm();
        }
        #endregion

        #region Test Event 3 : Plane Collsion Avoidance
        public void testCaseThree()
        {
            //Cursor change to app loading
            this.Cursor = Cursors.AppStarting;
            //Set the names of the collison Aircrafts and make them visible
            //plane 1 is SC342
            this.planeOneIDLabel.Text = "SC342";
            string ID1 = this.planeOneIDLabel.Text;
            this.planeOneDestLabel.Text = "LAX";
            this.planeOneInfoPanel.Visible = true;
            //plane 2 is BA947
            this.planeTwoIDLabel.Text = "BA947";
            string ID2 = this.planeTwoIDLabel.Text;
            this.planeTwoDestinationLabel.Text = "GFK";
            this.planeTwoInfoPanel.Visible = true;
            //Indicate the planes are both in the airspace
            this.totalAircraftInAirspaceLabel.Text = "2";
            this.AircraftUnderATCControlLabel.Text = "1";
            //Set GUI Settings
            //Plane 2 is going in; Plane 1 is going out
            queueTab.addToLandingQueue(ID2);
            showQueueForm();
            //Start location for plane 1
            Bitmap b1 = Properties.Resources.planeIcon_left;
            b1.MakeTransparent(Color.Black);
            this.planeOne.Image = b1;
            this.planeOneInfoPanel.Location = new Point(230, 308);
            this.planeOneAltitudeLabel.Text = "040";
            this.planeOneSpeedLabel.Text = "150";
            this.planeOneHeadingLabel.Text = "180";
            //Start location for plane 2
            Bitmap b2 = Properties.Resources.planeIcon_rightDown;
            b2.MakeTransparent(Color.Black);
            this.planeTwo.Image = b2;
            this.planeTwoInfoPanel.Location = new Point(36, 196);
            this.planeTwoAltitudeLabel.Text = "090";
            this.planeTwoSpeedLabel.Text = "210";
            this.planeTwoHeadingLabel.Text = "330";
            wait(3000);
            
            //Plane 1 first move
            this.planeOneInfoPanel.Location = new Point(207, 308);
            this.planeOneAltitudeLabel.Text = "060";
            this.planeOneSpeedLabel.Text = "170";
            this.planeOneHeadingLabel.Text = "180";
            //Plane 2 first move
            this.planeTwoInfoPanel.Location = new Point(85,249);
            this.planeTwoAltitudeLabel.Text = "090";
            this.planeTwoSpeedLabel.Text = "210";
            this.planeTwoHeadingLabel.Text = "330";
            wait(3000);
            
            //Plane 1 Second move
            this.planeOneInfoPanel.Location = new Point(162,308);
            this.planeOneAltitudeLabel.Text = "070";
            this.planeOneSpeedLabel.Text = "210";
            this.planeOneHeadingLabel.Text = "180";
            //Plane 2 Second move
            this.planeTwoInfoPanel.Location = new Point(128, 289);
            this.planeTwoAltitudeLabel.Text = "070";
            this.planeTwoSpeedLabel.Text = "200";
            this.planeTwoHeadingLabel.Text = "330";
            this.alertIcon.Visible = true;
            //Display Notificaiton telling ATC they need to take control of the aircraft
            this.notificationLabel.Text = "Collision Alert: ATC Action Required!";
            this.notificationLabel.Visible = true;

            //both aircraft are witin 60 miles of center
            this.AircraftUnderATCControlLabel.Text = "2";
           
            wait(3500);

            //Plane 1 Third move (Collision avoidance move)
            b1 = Properties.Resources.planeIcon_downLeft;
            b1.MakeTransparent(Color.Black);
            this.planeOne.Image = b1;
            this.planeOneInfoPanel.Location = new Point(100, 324);
            //Collision Avoidance Activates
            //Change heading of Aircraft 1 to SW and change altitude so that it avoids hitting the other aircraft
            this.planeOneAltitudeLabel.Text = "080";
            this.planeOneSpeedLabel.Text = "213";
            this.planeOneHeadingLabel.Text = "230";
            //Show this plane is being commanded in the ATC control
            this.currentlySelectedAircraftIDLabel.Text = ID1;
            this.altitudeMaskedText.Text = "080";
            this.speedMaskedText.Text = "213";
            this.headingMaskedText.Text = "230";
            this.notificationLabel.Text = "ATC Commands Sent to Aircraft " + ID1;
            isAircraftSelected = true;
            
            //Plane 2 Third move (Collision avoidance move)
            b2 = Properties.Resources.planeIcon_right;
            b2.MakeTransparent(Color.Black);
            this.planeTwo.Image = b2;
            this.planeTwoInfoPanel.Location = new Point(174, 308);
            this.alertIcon.Visible = false;
            wait(3000);
            this.notificationLabel.Text = "Collision Avoided";

            //One aircraft is witin 60 miles of center
            this.AircraftUnderATCControlLabel.Text = "1";

            wait(3500);
            this.notificationLabel.Visible = false;
            //deslect Aircraft since collision was avoided;
            deselectAircraft();
            //Plane 1 Fourth Move
            this.planeOneInfoPanel.Location = new Point(50, 340);
            
            //Plane 2 Fourth Move
            this.planeTwoInfoPanel.Location = new Point(260, 308);
            queueTab.removeFromLandingQueue(ID2);

            wait(3500);

            //Make planes no longer visible
            this.planeOneInfoPanel.Visible = false;
            this.planeTwoInfoPanel.Visible = false;
            //make cursor default 
            showTestForm();
            this.totalAircraftInAirspaceLabel.Text = "0";
            this.AircraftUnderATCControlLabel.Text = "0";
            this.Cursor = Cursors.Default;
        }
        #endregion

        #region Test Event 4 : Plane Collision
        public void testCaseFour()
        {
            //Cursor change to app loading
            this.Cursor = Cursors.AppStarting;
            //Set the names of the collison Aircrafts and make them visible
            //plane 1 is SC342
            this.planeOneIDLabel.Text = "SC342";
            string ID1 = this.planeOneIDLabel.Text;
            this.planeOneDestLabel.Text = "LAX";
            this.planeOneInfoPanel.Visible = true;
            //plane 2 is BA947
            this.planeTwoIDLabel.Text = "BA947";
            string ID2 = this.planeTwoIDLabel.Text;
            this.planeTwoDestinationLabel.Text = "GFK";
            this.planeTwoInfoPanel.Visible = true;
            //Indicate the planes are both in the airspace
            this.totalAircraftInAirspaceLabel.Text = "2";
            this.AircraftUnderATCControlLabel.Text = "1";
            //Set GUI Settings
            //Plane 2 is going in; Plane 1 is going out
            queueTab.addToLandingQueue(ID2);
            showQueueForm();
            //Start location for plane 1
            Bitmap b1 = Properties.Resources.planeIcon_left;
            b1.MakeTransparent(Color.Black);
            this.planeOne.Image = b1;
            this.planeOneInfoPanel.Location = new Point(230, 308);
            this.planeOneAltitudeLabel.Text = "040";
            this.planeOneSpeedLabel.Text = "150";
            this.planeOneHeadingLabel.Text = "180";
            //Start location for plane 2
            Bitmap b2 = Properties.Resources.planeIcon_rightDown;
            b2.MakeTransparent(Color.Black);
            this.planeTwo.Image = b2;
            this.planeTwoInfoPanel.Location = new Point(36, 196);
            this.planeTwoAltitudeLabel.Text = "090";
            this.planeTwoSpeedLabel.Text = "210";
            this.planeTwoHeadingLabel.Text = "330";
            wait(3000);

            //Plane 1 first move
            this.planeOneInfoPanel.Location = new Point(207, 308);
            this.planeOneAltitudeLabel.Text = "060";
            this.planeOneSpeedLabel.Text = "170";
            this.planeOneHeadingLabel.Text = "180";
            //Plane 2 first move
            this.planeTwoInfoPanel.Location = new Point(85, 249);
            this.planeTwoAltitudeLabel.Text = "090";
            this.planeTwoSpeedLabel.Text = "210";
            this.planeTwoHeadingLabel.Text = "330";
            wait(3000);
            //Plane 1 Second move
            this.planeOneInfoPanel.Location = new Point(142, 300);
            this.planeOneAltitudeLabel.Text = "070";
            this.planeOneSpeedLabel.Text = "210";
            this.planeOneHeadingLabel.Text = "180";
            //Plane 2 Second move
            this.planeTwoInfoPanel.Location = new Point(128, 295);
            this.planeTwoAltitudeLabel.Text = "070";
            this.planeTwoSpeedLabel.Text = "200";
            this.planeTwoHeadingLabel.Text = "330";
            this.alertIcon.Visible = true;
            //Display Notificaiton telling ATC they need to take control of the aircraft
            this.notificationLabel.Text = "Collision Alert: ATC Action Required!";
            this.notificationLabel.Visible = true;

            //both aircraft are witin 60 miles of center
            this.AircraftUnderATCControlLabel.Text = "2";

            wait(3000);
            queueTab.removeFromLandingQueue(ID2);
            this.planeOneInfoPanel.Visible = false;
            this.planeTwoInfoPanel.Visible = false;
            this.collisionIcon.Visible = true;
            this.alertIcon.Visible = true;
            this.notificationLabel.Text = ID1 +" and " +ID2 +" have collided!";


            wait(4000);
            this.collisionIcon.Visible = false;
            this.notificationLabel.Visible = false;
            this.alertIcon.Visible = false;
            this.showTestForm();
            this.Cursor = Cursors.Default;
        }
        #endregion

        #region draw the GUI 
        private void airspaceDisplayPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = airspaceDisplayPanel.CreateGraphics();
            Pen p = new Pen(Color.Red,2);
            short origin_x = 120;//x location in the center of the display
            short origin_y = 15;//y location in the center of the dispaly

            //draw the first circle of the display with a diameter of 600
            g.DrawEllipse(p, new Rectangle((origin_x + 0), (origin_y + 0), 600, 600));
            p = new Pen(Color.LimeGreen, (float)1.5);//change color to indicate that this is the range of the ATC tower(50miles)
            //draw the second circle of the display with a diameter of 500
            g.DrawEllipse(p, new Rectangle((origin_x + 50), (origin_y + 50), 500, 500));
            //draw the third circle of the display with a diameter of 400
            g.DrawEllipse(p, new Rectangle((origin_x + 100), (origin_y + 100), 400, 400));
            //draw the fourth circle of the display with a diameter of 300
            g.DrawEllipse(p, new Rectangle((origin_x + 150), (origin_y + 150), 300, 300));
            //draw the fifth circle of the display with a diameter of 200
            g.DrawEllipse(p, new Rectangle((origin_x + 200), (origin_y + 200), 200, 200));
            //draw the fifth circle of the display with a diameter of 200
            g.DrawEllipse(p, new Rectangle((origin_x + 250), (origin_y + 250), 100, 100));
            //draw crosshairs
            p = new Pen(Color.Gray);
            Point pt1 = new Point(422, 0);
            Point pt2 = new Point(422, 626);
            g.DrawLine(p, pt1, pt2);
            pt1 = new Point(0, 313);
            pt2 = new Point(881, 313);
            g.DrawLine(p, pt1, pt2);

            //draw airport
            //Draw the vertical parallel lines
            p = new Pen(Color.DarkOrange,2);
            pt1 = new Point(416, 326);
            pt2 = new Point(416, 312);
            g.DrawLine(p, pt1, pt2);
            pt1 = new Point(424, 326);
            pt2 = new Point(424, 312);
            g.DrawLine(p, pt1, pt2);
            //Draw the Top horizontal parralel lines
            pt1 = new Point(400, 312);
            pt2 = new Point(416, 312);
            g.DrawLine(p, pt1, pt2);
            pt1 = new Point(400, 304);
            pt2 = new Point(416, 304);
            g.DrawLine(p, pt1, pt2);

            //Draw the guide lines for incoming flights
            //double vertical guidelines
            p = new Pen(Color.White, (float).5);
            pt1 = new Point(422, 414);
            pt2 = new Point(422, 214);
            g.DrawLine(p, pt1, pt2);
            pt1 = new Point(418, 414);
            pt2 = new Point(418, 214);
            g.DrawLine(p, pt1, pt2);
            //double horizontal guidelines
            pt1 = new Point(318, 310);
            pt2 = new Point(518, 310);
            g.DrawLine(p, pt1, pt2);
            pt1 = new Point(318, 306);
            pt2 = new Point(518, 306);
            g.DrawLine(p, pt1, pt2);

            //return resources allocated to pen and graphics.
            g.Dispose();
            p.Dispose();
        }
        #endregion

        #region Map Control Button Action
        private void MapControlButton_Click(object sender, EventArgs e)
        {
            currentPage = "Map Control";
            if(prevPage != currentPage)
            {
                prevPage = "Map Control";
                this.guiSettingsBasePanel.Controls.Clear();
                this.guiSettingsBasePanel.Controls.Add(mapControlTLPanel);
                this.mapControlTLPanel.Visible = true;
            }
        }
        #endregion

        #region Show Queue Button Action
        private void ShowQueueButton_Click(object sender, EventArgs e)
        {
            showQueueForm();
        }
        private void showQueueForm()
        {
            currentPage = "Queue";
            if (prevPage != currentPage)
            {
                prevPage = "Queue";
                this.guiSettingsBasePanel.Controls.Clear();
                this.guiSettingsBasePanel.Controls.Add(queueTab.QbaseTLPanel);
            }
        }
        #endregion

        #region Show Weather Button Action
        private void ShowWeatherButton_Click(object sender, EventArgs e)
        {
            showWeatherForm();
        }
        private void showWeatherForm()
        {
            currentPage = "Weather";
            if (prevPage != currentPage)
            {
                prevPage = "Weather";
                this.guiSettingsBasePanel.Controls.Clear();
                this.guiSettingsBasePanel.Controls.Add(weatherTab.WeatherBaseTLPanel);
            }
        }
        #endregion

        #region Show Log Button Action
        private void ShowLogButton_Click(object sender, EventArgs e)
        {
            ShowLog();
        }
        private void ShowLog()
        {
            currentPage = "Log";
            if (prevPage != currentPage)
            {
                prevPage = "Log";
                this.guiSettingsBasePanel.Controls.Clear();
                this.guiSettingsBasePanel.Controls.Add(logTab.flightLogTLPanel);
            }
        }
        #endregion

        #region Show Test Cases Button
        private void TestCasesButton_Click(object sender, EventArgs e)
        {
            showTestForm();
        }
        private void showTestForm()
        {
            currentPage = "Test";
            if (prevPage != currentPage)
            {
                prevPage = "Test";
                this.guiSettingsBasePanel.Controls.Clear();
                this.guiSettingsBasePanel.Controls.Add(testTab.TestCaseTLPanel);
            }
        }
        #endregion

        #region Deselect Current Selected Aircraft Button Action
        private void DeselectCurrentaircraftButton_Click(object sender, EventArgs e)
        {
            deselectAircraft();
        }
        private void deselectAircraft()
        {
            if (isAircraftSelected == true)
            {
                //clear the selected aircraft in the selected aircraft panel
                currentlySelectedAircraftIDLabel.Text = "None";
                selectedAircraftControlLabel.Text = string.Empty;
                positionInQueueLabel.Text = "N/A";
                altitudeMaskedText.Text = string.Empty;
                speedMaskedText.Text = string.Empty;
                headingMaskedText.Text = "N/A";
                isAircraftSelected = false;
            }
        }
        #endregion

        #region User Defined Wait Function
        private void wait(int time)
        {
            //time to wait in Milliseconds
            Task.Delay(time).Wait();
        }
        #endregion

        #region Change what background image is being used.
        private void MapViewButton_Click(object sender, EventArgs e)
        {
            if (currentView == "Digital")
            {
                this.airspaceDisplayPanel.BackgroundImage = Properties.Resources.Satellite10Mile_v5;
                this.mapViewButton.Image = Properties.Resources.DigitalDisplay;
                this.mapViewButton.Text = "Digital";
                currentView = "Satellite";
            }
            else if (currentView == "Satellite")
            {
                this.airspaceDisplayPanel.BackgroundImage = Properties.Resources.DigitalDisplayBackV1;
                this.mapViewButton.Image =Properties.Resources.Satellite10Mile_v5;
                this.mapViewButton.Text = "Satellite";
                currentView = "Digital";
            }
        }
        public void showWeatherOverlay()
        {
            if (weatherOverlayEnabled)
            {
                if (currentView == "Satellite")
                {
                    this.airspaceDisplayPanel.BackgroundImage = Properties.Resources.Satellite10Mile_v5;
                }
                else if(currentView =="Digital")
                {
                    this.airspaceDisplayPanel.BackgroundImage = Properties.Resources.DigitalDisplayBackV1;
                }
                this.radarLegendPB.Visible = false;
                weatherOverlayEnabled = false;
            }
            else
            {
                this.airspaceDisplayPanel.BackgroundImage = Properties.Resources.weatherRadarWithoutCitiesV1;
                this.radarLegendPB.Visible = true;
                weatherOverlayEnabled = true;
            }
        }
        #endregion

        #region Design elements
        private void loadScaleFormat()
        {
            Bitmap b = Properties.Resources.scale;
            b.MakeTransparent(Color.Black);
            this.scalePictureBox.Image = b;
            this.scalePictureBox.Visible = true;
        }
        #endregion
    }
}
