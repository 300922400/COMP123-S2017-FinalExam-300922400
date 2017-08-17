using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Nguyen Thi Kim Ngan
 * Date: July 25, 2017
 * Description: This is the ScordBoard class
 * Version: 0.1 - Create the ScordBoard class
 */
namespace COMP123_S2017_FinalExam_StudentID
{
    class ScoreBoard
    {
        // private instance variables
        private TextBox _finalscoreTextbox;
        private int Score;
        private TextBox _scoreTextbox;
        private int time;
        private TextBox _timeTextbox;

        // public properties
        public TextBox Finalscoretextbox
        {
            get
            {
                return this._finalscoreTextbox;
            }
            set
            {
                this._finalscoreTextbox = value;
            }
        }

    }
}
