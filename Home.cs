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
        List<string[]> dataTable;
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
            dataTable = dbHandler.Import_Data_Using_SQL("5", "Ahmad", "FollowingTable");
            Generate_Valid_Stories(dataTable);
        }

        public void Generate_Valid_Stories(List<string[]> usersList)
        {
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(50, 50);
            for (int i = 0; i < usersList.Count; i++)
            {
                //dbHandler.Create_Valid_Story_View(usersList[i][1], usersList[i][2]);
                if (dbHandler.Check_If_Story_Exists(usersList[i][1], usersList[i][2]))
                {
                    try
                    {
                        imgs.Images.Add(dbHandler.Retrieve_Profile_Picture_Using_SQL(Int32.Parse(usersList[i][1])));
                        listView1.Items.Add(new ListViewItem
                        {
                            ImageIndex = listViewItemsCount,
                            Text = usersList[i][2],
                            Tag = usersList[i][2]
                        }); ; ; ; ; ;
                        listViewItemsCount++;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                listView1.LargeImageList = imgs; 
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
