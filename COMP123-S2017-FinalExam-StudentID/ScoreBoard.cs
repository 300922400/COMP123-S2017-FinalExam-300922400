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
 * Version: 0.2 - Create the UpdateTime Method
 */
namespace COMP123_S2017_FinalExam_StudentID
{
    class ScoreBoard
    {
        // private instance variables
        private TextBox _finalscoreTextbox;
        private int _score;
        private TextBox _scoreTextbox;
        private int _time;
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
        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
                Finalscoretextbox.Text = this._score.ToString();
                ScoreTextbox.Text = this._score.ToString();
            }
        }
        public TextBox ScoreTextbox
        {
            get
            {
                return this._scoreTextbox;
            }
            set
            {
                this._scoreTextbox = value;
            }
        }
        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
                TimeTextbox.Text = this._time.ToString();
            }

        }
        public TextBox TimeTextbox
        {
            get
            {
                return this._timeTextbox;
            }
            set
            {
                this._timeTextbox = value;
            }
        }
        /// <summary>
        /// This is main constructor
        /// having 3 parameteres as below
        /// </summary>
        /// <param name="scoretextbox"></param>
        /// <param name="timetextbox"></param>
        /// <param name="finalScoretextbox"></param>
        public ScoreBoard( TextBox scoretextbox,TextBox timetextbox, TextBox finalScoretextbox)
        {
            ScoreTextbox = scoretextbox;
            TimeTextbox = timetextbox;
            Finalscoretextbox = finalScoretextbox;
        }
        /// <summary>
        /// This is UpdateTime method 
        /// </summary>
       
        public void UpdateTime()
        {
            int update;
            update = Convert.ToInt32(TimeTextbox.Text) - 1;
            Time = update;
            TimeTextbox.Text = Time.ToString();
        }
    }
}
