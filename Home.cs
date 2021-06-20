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
        ImageList listViewImageList = new ImageList();

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
            listViewImageList.ImageSize = new Size(50, 50);
            for (int i = 0; i < usersList.Count; i++)
            {
                //dbHandler.Create_Valid_Story_View(usersList[i][1], usersList[i][2]);
                if (dbHandler.Check_If_Story_Exists(usersList[i][1], usersList[i][2]))
                {
                    try
                    {
                        listViewImageList.Images.Add(dbHandler.Retrieve_Profile_Picture_Using_SQL(Int32.Parse(usersList[i][1])));
                        listView1.Items.Add(new ListViewItem
                        {
                            ImageIndex = listViewItemsCount,
                            Text = usersList[i][2],
                            Tag = usersList[i][2] + '_' + usersList[i][1]
                        }); ; ; ; ; ; ;
                        listViewItemsCount++;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            listView1.LargeImageList = listViewImageList; 
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
            if (listView1.SelectedIndices[0] >= 0)
            {
                var item = listView1.SelectedItems[0];
                Image img = listViewImageList.Images[item.ImageIndex];
                this.Hide();
                Story story = new Story(listView1.SelectedItems[0].Tag.ToString(), img);
                story.Show();
            }
        }
    }
}
