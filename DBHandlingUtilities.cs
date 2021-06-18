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

        public void Add_User(string userName, string realUserName, string userPassword, string tagLine = null)
        {
            FileStream fs;
            BinaryReader br;
            try
            {
                if (dbConnection.State == ConnectionState.Closed)
                {
                    dbConnection.Open();
                    cmd = new SqlCommand("Add_User", dbConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    if(fileDirectory != null)
                    {
                        byte[] ImageData;
                        fs = new FileStream(fileDirectory, FileMode.Open, FileAccess.Read);
                        br = new BinaryReader(fs);
                        ImageData = br.ReadBytes((int)fs.Length);
                        br.Close();
                        fs.Close();
                        cmd.Parameters.AddWithValue("@Picture", ImageData);
                    }
                    else
                        cmd.Parameters.AddWithValue("@Picture", null);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@RealUserName", realUserName);
                    cmd.Parameters.AddWithValue("@UserPassword", userPassword);
                    cmd.Parameters.AddWithValue("@Tagline", tagLine);
                    int RowsAffected = cmd.ExecuteNonQuery();
                    if (RowsAffected > 0)
                    {
                        Console.WriteLine("User has been added!\n");
                    }
                    dbConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dbConnection.State == ConnectionState.Open)
                    dbConnection.Close();
            }
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
