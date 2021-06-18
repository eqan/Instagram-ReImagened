using System;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Instagram
{
    class DBHandlingUtilities
    {
        public SqlConnection dbConnection;
        public SqlCommand cmd;
        public SqlDataAdapter adapt;
        public string fileDirectory = null;

        public DBHandlingUtilities()
        {
            Initialize_Information();
        }

        public void Initialize_Information()
        {
            dbConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename= E:\Instagram\Instagram\Instagram\InstagramDB.mdf; Integrated Security=True; Connect Timeout=30");
        }

        public void Get_Picture()
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = System.Windows.Forms.Application.StartupPath;
                    openFileDialog.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff";
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        fileDirectory = openFileDialog.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int[] Check_UserName_And_Password(string userName, string password)
        {
            int[] results = { 0, 0 };
            try
            {
                if (dbConnection.State == ConnectionState.Closed)
                {
                    // Check User
                    cmd = new SqlCommand(@"SELECT [dbo].[Check_UserName](@UserName);", dbConnection);
                    SqlParameter param1 = new SqlParameter();
                    param1 = new SqlParameter("@UserName", SqlDbType.VarChar);
                    param1.Value = userName;
                    cmd.Parameters.Add(param1);
                    dbConnection.Open();
                    results[0] = (Int32)cmd.ExecuteScalar();
                    Console.WriteLine("Result User: {0}",results[0].ToString());
                    dbConnection.Close();
                    if(results[0] == 1)
                    {
                        // Check Password
                        cmd = new SqlCommand(@"SELECT [dbo].[Check_Password](@UserName, @Password);", dbConnection);
                        SqlParameter param2 = new SqlParameter();
                        param2 = new SqlParameter("@UserName", SqlDbType.VarChar);
                        param2.Value = userName;
                        cmd.Parameters.Add(param2);
                        SqlParameter param3 = new SqlParameter();
                        param3 = new SqlParameter("@Password", SqlDbType.VarChar);
                        param3.Value = password;
                        cmd.Parameters.Add(param3);
                        dbConnection.Open();
                        results[1] = (Int32)cmd.ExecuteScalar();
                        Console.WriteLine("Result Password: {0}", results[1].ToString());
                        dbConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (dbConnection.State == ConnectionState.Open)
                    dbConnection.Close();
            }
            return results;
        }

        public void Create_Post(string userID, string userName, string postDescription, string location)
        {
            try
            {
                if (dbConnection.State == ConnectionState.Closed)
                {
                    dbConnection.Open();
                    cmd = new SqlCommand("INSERT INTO " + userName + "_" + userID + "_PostTable(BookMarked, PostDesc, Location, Image) VALUES(@BookMarked ,@PostDesc, @Location, @Image)", dbConnection);
                    cmd.Parameters.AddWithValue("@BookMarked", 0);
                    cmd.Parameters.AddWithValue("@PostDesc", postDescription);
                    cmd.Parameters.AddWithValue("@Location", location);
                    cmd.Parameters.AddWithValue("@Image", Get_Binary_Of_File());
                    cmd.ExecuteNonQuery();
                    dbConnection.Close();
                    Console.WriteLine("Post Created for {0}", userName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (dbConnection.State == ConnectionState.Open)
                    dbConnection.Close();
            }

        }
        public void Create_Story(string userID, string userName)
        {
            try
            {
                if (dbConnection.State == ConnectionState.Closed)
                {
                    dbConnection.Open();
                    cmd = new SqlCommand("INSERT INTO " + userName + "_" + userID + "_StoryTable(Image, DueDate) VALUES(@Image, @DueDate)", dbConnection);
                    cmd.Parameters.AddWithValue("@DueDate", DateTime.Now.AddDays(1));
                    cmd.Parameters.AddWithValue("@Image", Get_Binary_Of_File());
                    cmd.ExecuteNonQuery();
                    dbConnection.Close();
                    Console.WriteLine("Story Created for {0}", userName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (dbConnection.State == ConnectionState.Open)
                    dbConnection.Close();
            }
        }

        public void Create_Story_Table(string userID, string userName)
        {
            try
            {
                if (dbConnection.State == ConnectionState.Closed)
                {
                    dbConnection.Open();
                    cmd = new SqlCommand("Build_User_Stories_Table", dbConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.ExecuteNonQuery();
                    dbConnection.Close();
                    Console.WriteLine("Table Created for {0}", userName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (dbConnection.State == ConnectionState.Open)
                    dbConnection.Close();
            }
        }

        public void Create_Post_Table(string userID, string userName)
        {
            try
            {
                if (dbConnection.State == ConnectionState.Closed)
                {
                    dbConnection.Open();
                    cmd = new SqlCommand("Build_User_Posts_Table", dbConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.ExecuteNonQuery();
                    dbConnection.Close();
                    Console.WriteLine("Table Created for {0}", userName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (dbConnection.State == ConnectionState.Open)
                    dbConnection.Close();
            }
        }

        public byte[] Get_Binary_Of_File()
        {
            FileStream fs;
            BinaryReader br;
            byte[] ImageData;
            fs = new FileStream(fileDirectory, FileMode.Open, FileAccess.Read);
            br = new BinaryReader(fs);
            ImageData = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            return ImageData;
        }

        public bool Add_User(string userName, string realUserName, string userPassword, string tagLine = null)
        {
            try
            {
                if (dbConnection.State == ConnectionState.Closed)
                {
                    dbConnection.Open();
                    cmd = new SqlCommand("Add_User", dbConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if(fileDirectory != null)
                    {
                        cmd.Parameters.AddWithValue("@Picture", Get_Binary_Of_File());
                    }
                    else
                        cmd.Parameters.AddWithValue("@Picture", null);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@RealUserName", realUserName);
                    cmd.Parameters.AddWithValue("@UserPassword", userPassword);
                    cmd.Parameters.AddWithValue("@Tagline", tagLine);
                    cmd.ExecuteNonQuery();
                    dbConnection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                if (dbConnection.State == ConnectionState.Open)
                    dbConnection.Close();
            }
            return true; 
        }

        public DataTable Display_Record()
        {
            DataTable intervieweeTable = new DataTable();
            dbConnection.Open();
            cmd = new SqlCommand("SELECT * FROM USERS", dbConnection);
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(intervieweeTable);
            dbConnection.Close();
            return intervieweeTable;
        }
    }
}
