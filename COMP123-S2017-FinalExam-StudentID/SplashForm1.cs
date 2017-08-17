using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Nguyen Thi Kim Ngan
 * Date: July 25, 2017
 * Description: This is the splashform
 * Version: 0.1 - Create the splashform
 */
namespace COMP123_S2017_FinalExam_StudentID
{
    public partial class SplashForm1Timer : Form
    {
        // public properties
        public PickHighestCardForm HighestCardForm
        {
            get
            {
                return Program.HighestCardForm;
            }
        }
           

        /// <summary>
        /// this is the main constructor of Splashform
        /// </summary>
        public SplashForm1Timer()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is event handler for the "Tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.HighestCardForm.Show();
            this.Hide();
            
        }

        private void titletextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
