using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JukeBox
{
    public partial class JukeBox_frm : Form
    {
        public JukeBox_frm()
        {
            InitializeComponent();
        }
        //Global Variables
        ListBox[] Media_Library; //Variable - holds all tracks from media file
        String[] GenreTitle; //Variable - holds all the genre titles 
        bool PlayingNow=false; //Variable - Green Playing now text box set to false

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            //opens the setup form when the setup is clicked on the menu 
            Setup_Frm SetupForm2 = new Setup_Frm();
            SetupForm2.ShowDialog();

        }

        private void About_txtBoxMenu_Click(object sender, EventArgs e)
        {
            //Opens up about form when about is clicked on the menu
            About_Frm AboutForm2 = new About_Frm();
            AboutForm2.ShowDialog();
        }

        private void JukeBox_frm_Load(object sender, EventArgs e)
        {
            //ApplicationPath holds the path of where the media file is located
            String applicationPath = Directory.GetCurrentDirectory() + "\\Media\\"; 
            //Opens up the file through variable called MediaFile
            StreamReader MediaFile = File.OpenText(applicationPath + "Media.txt");
            //Reads the 1st line of text inside the media file
            String ReadMedia = MediaFile.ReadLine();

            //Varibale Check - to check if it's a number or not
            int Check;
            //1st line is overall how many genres there will be
            if (int.TryParse(ReadMedia,out Check))
            {
                Media_Library = new ListBox[Check]; //Creates Listbox with overall number from variable 
            }
            //Counts how many so the scroll bar knows how far along to go 
            int count_genre = Media_Library.Count();
            hScrollBar1.Maximum = count_genre - 1;
            GenreTitle = new string[count_genre];

            //Reads second line
            ReadMedia = MediaFile.ReadLine();
            //sets index to 0 and overall genres ... and add 1 each time 
            for (int ListIndex = 0; ListIndex < count_genre; ListIndex++)
            {
                Media_Library[ListIndex] = new ListBox(); //Creates the listbox to hold it
                
                //Checks if it is a number then reads the next line for the genre title 
                if (int.TryParse(ReadMedia, out Check) == true)
                {
                    ReadMedia = MediaFile.ReadLine();
                    GenreTitle[ListIndex] = ReadMedia; 
                    ReadMedia = MediaFile.ReadLine(); //Reads the track

                    //if not number then & not null then put track into playlist and reads next line and runs again
                    while (int.TryParse(ReadMedia, out Check) != true && ReadMedia != null)
                    {
                        Media_Library[ListIndex].Items.Add(ReadMedia);
                        ReadMedia = MediaFile.ReadLine();
                    }
                }         
             }
            Displaytext(); //Goes to displaytext
        }

        private void Displaytext()
        {
            //Shows the name on the jukebox program
            GenreList_LstBox.Items.Clear(); //Clears the name first before its changed
            int PositionScroll = hScrollBar1.Value;
            int num_item = Media_Library[PositionScroll].Items.Count;
            GenreTitle_txtBox.Text = GenreTitle[PositionScroll];

            //Allows multiple tracks into the genre list
            for (int item_index = 0; item_index < num_item; item_index++)
            {
                GenreList_LstBox.Items.Add(Media_Library[PositionScroll].Items[item_index]);
            }
        }
        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            Displaytext();
        }

        private void GenreList_LstBox_DoubleClick(object sender, EventArgs e)
        {
            //Track selected put into playlist 
            int TrackIndex = GenreList_LstBox.SelectedIndex;
            string TrackSelected = GenreList_LstBox.Items[TrackIndex].ToString();

            //If there is something inside the playing now text box then add to playlist 
            if (PlayingNow == true )
            {
                PlayList_LstBox.Items.Add(TrackSelected);
            }
            //Else if playing now text box is empty & playlist has nothing in it then...
            else if(PlayingNow == false && PlayList_LstBox.Items.Count == 0)
            {
                Playing_txtBox.Text = TrackSelected; //Put track selected in playing now text box 
                String TrackPath = Directory.GetCurrentDirectory() + "\\Tracks\\"; //Gets path of the tracks 
                WinMediaPlay.URL = TrackPath + TrackSelected; //Matches the track inside the track folder
                WinMediaPlay.Ctlcontrols.play(); //Plays the tracks
                PlayingNow = true; //Changes palying now back to true as there is something in it now
            }           
        }

        private void TrackTime_Timer_Tick(object sender, EventArgs e)
        {
            //If windows player has stopped then stop timer and go to next song 
            if (WinMediaPlay.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                TrackTime_Timer.Enabled = false;
                NextSong();
            }
            //Else if windows player is playing then change playing now to true as there is a track inside playingnow text box
            else if(WinMediaPlay.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                PlayingNow = true;
            }
        }

        private void WinMediaPlay_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //If the windows player has stopped then make playing now false as the track will be finsihed and enable timer
            if (WinMediaPlay.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                PlayingNow = false;
                TrackTime_Timer.Enabled = true;
            }
        }

        private void NextSong() 
        {
            //Converts what is in playlist to a string and makes it 0 to move it up in the queue
            Playing_txtBox.Text = PlayList_LstBox.Items[0].ToString();
            PlayList_LstBox.Items.RemoveAt(0); //Removes 0 so next one can be 0 so it moves up on the playlist

           //Gets the path of the tracks 
            String TrackPath = Directory.GetCurrentDirectory() + "\\Tracks\\";
            WinMediaPlay.URL = TrackPath + Playing_txtBox.Text; // Matches the track inside the track folder
            WinMediaPlay.Ctlcontrols.play(); //Plays the tracks

        }

    }
   }
