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
    public partial class TestCaseForm : Form
    {
        //create events
        public TestCaseForm()
        {
            InitializeComponent();
        }
        //Aircraft Landing
        #region Test Case 1: Aircraft Landing
        public void TestCaseOneButton_Click_1(object sender, EventArgs testCaseOneStart)
        {
            //run the first test scenario
            Program.mainWindow.testCaseOne();
            //show the second test case after the first has finished
            this.TestCaseTwoButton.Visible = true;
        }
        #endregion

        #region Test Case 2: Aircraft Taking off
        private void TestCaseTwoButton_Click(object sender, EventArgs e)
        {
            Program.mainWindow.testCaseTwo();
            this.TestCaseThreeButton.Visible = true;
        }

        #endregion
        #region Test Case 3: Aircraft Collision Avoidance
        private void TestCaseThreeButton_Click(object sender, EventArgs e)
        {
            Program.mainWindow.testCaseThree();
            this.TestCaseFourButton.Visible = true;
        }
        #endregion
        #region Test Case 4: Aircraft Collision
        private void TestCaseFourButton_Click(object sender, EventArgs e)
        {
            Program.mainWindow.testCaseFour();
        }
        #endregion
    }
}
    

