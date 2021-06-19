using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;


namespace Instagram
{
    public partial class Home : Form
    {
        bool isLightModeOn = true;
        DBHandlingUtilities dbHandler;
        UIUtilities UI;
        string ImageNewName = "";
        int listViewItemsCount = 0;

        public Home()
        {
            InitializeComponent();
            dbHandler = new DBHandlingUtilities();
            UI = new UIUtilities(this, true);
        }

        private void Add_All_Stories()
        {
            
        }

        private void Add_Post()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string[]> dataTable = dbHandler.Import_Data_Using_SQL("3", "Eqan", "FollowingTable");
            Generate_Valid_Stories(dataTable);
        }

        public void Generate_Valid_Stories(List<string[]> usersList)
        {
            for (int i = 0; i < usersList.Count; i++)
            {
                dbHandler.Create_Valid_Story_View(usersList[i][1], usersList[i][2]);
            }
        }

        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label == null)
                return;
            ImageNewName = Convert.ToString(e.Label);
            ListViewItem item1 = listView1.SelectedItems[0];
            FileInfo fileInfo = new FileInfo(item1.Tag.ToString());
            fileInfo.MoveTo(fileInfo.Directory.FullName + "\\" + ImageNewName + fileInfo.Extension);
            listView1.Items[listViewItemsCount].Text = ImageNewName;
        }


        private void populate()
        {
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(110, 75);
            string[] paths = { };
            //for (int i = 0; i < circularLinkedList.str_name.Length; i++)
            //{
            //    try
            //    {
            //        if (circularLinkedList.str_name[i] == " " || circularLinkedList.str_name[i] == "\n")
            //            continue;
            //        imageLocation = Environment.CurrentDirectory + @"\Data\Movie Titles\Movie Icons\" + circularLinkedList.str_name[i] + ".png";
            //        imgs.Images.Add(Image.FromFile(imageLocation));
            //        listView1.Items.Add(new ListViewItem
            //        {
            //            ImageIndex = count,
            //            Text = circularLinkedList.str_name[i],
            //            Tag = circularLinkedList.str_name[i],
            //        }); ; ; ;
            //        count++;
            //    }
            //    catch
            //    {
            //        Console.WriteLine(circularLinkedList.str_name[i] + " is not found");
            //    }
            //}
            listView1.LargeImageList = imgs; // Setting Size Of Images
        }


        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0)
            {
                Console.WriteLine(listView1.SelectedItems.Count);
                return;
            }
            int intselectedindex = listView1.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                //axMoviePlayer1.Stop();
                //currentMovie = listView1.SelectedItems[0].Text;
                //string fileDirectory = Environment.CurrentDirectory + @"\Data\Profiles\" + accountName + @"\" + userName + @"\Log.txt";
                //fileHandling.WriteData(fileDirectory, currentMovie);
                //startMovie();
            }
        }

    }
}
