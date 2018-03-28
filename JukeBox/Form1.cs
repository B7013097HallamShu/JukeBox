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
        ListBox[] Media_Library;
        String[] GenreTitle;
        

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            //opens the setup form when the setup is clicked on the menu 
            Setup_Frm SetupForm2 = new Setup_Frm();
            SetupForm2.ShowDialog();

        }

        private void About_txtBoxMenu_Click(object sender, EventArgs e)
        {
            About_Frm AboutForm2 = new About_Frm();
            AboutForm2.ShowDialog();
        }

        private void JukeBox_frm_Load(object sender, EventArgs e)
        {
            String applicationPath = Directory.GetCurrentDirectory() + "\\Media\\";
            StreamReader MediaFile = File.OpenText(applicationPath + "Media.txt");
            String ReadMedia = MediaFile.ReadLine();
            int Cheak;
            if (int.TryParse(ReadMedia,out Cheak))
            {
                Media_Library = new ListBox[Cheak];
            }
            int count_genre = Media_Library.Count();
            hScrollBar1.Maximum = count_genre - 1;
            GenreTitle = new string[count_genre];

            ReadMedia = MediaFile.ReadLine();
            for (int ListIndex = 0; ListIndex < count_genre; ListIndex++)
            {
                Media_Library[ListIndex] = new ListBox();
                
                if (int.TryParse(ReadMedia, out Cheak) == true)
                {
                    ReadMedia = MediaFile.ReadLine();
                    GenreTitle[ListIndex] = ReadMedia;
                    ReadMedia = MediaFile.ReadLine();
                    while (int.TryParse(ReadMedia, out Cheak) != true && ReadMedia != null)
                    {
                        Media_Library[ListIndex].Items.Add(ReadMedia);
                        ReadMedia = MediaFile.ReadLine();
                    }
                }         
             }
            Displaytext(); 



        }

        private void Displaytext()
        {
            GenreList_LstBox.Items.Clear();
            int PositionScroll = hScrollBar1.Value;
            int num_item = Media_Library[PositionScroll].Items.Count;
            GenreTitle_txtBox.Text = GenreTitle[PositionScroll];

            for (int item_index = 0; item_index < num_item; item_index++)
            {
                GenreList_LstBox.Items.Add(Media_Library[PositionScroll].Items[item_index]);
            }
        }
        

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            Displaytext();
        }
    }
   }
