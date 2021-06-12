using System;
using System.Data.SqlClient;
using System.Data;

namespace Instagram
{
    class DBHandlingUtilities
    {
        public SqlConnection dbConnection;
        public SqlCommand cmd;
        public SqlDataAdapter adapt;

        DBHandlingUtilities()
        {
            Initialize_Information();
        }

        public void Initialize_Information()
        {
            dbConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename= "+ Environment.CurrentDirectory + @"\InstagramDB.mdf; Integrated Security=True; Connect Timeout=30");
        }

        // Example reference code for an sqlcommand
        private void btn_AddData_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("INSERT INTO Interviewee(ID, Name, Age, Gender, Skills) VALUES(@id, @name, @age, @gender, @skills)", dbConnection);
            dbConnection.Open();
            //cmd.Parameters.AddWithValue("@id", ID);
            //cmd.Parameters.AddWithValue("@name", nameBox.Text);
            //cmd.Parameters.AddWithValue("@age", ageBox.Text);
            //cmd.Parameters.AddWithValue("@gender", genderBox.Text);
            //cmd.Parameters.AddWithValue("@skills", skillBox.Text);
            cmd.ExecuteNonQuery();
            dbConnection.Close();
            //Display_Record();
            //Clear_Data();
        }

        // Example reference code for an sqlcommand
        private void Display_Record()
        {
            DataTable intervieweeTable = new DataTable();
            dbConnection.Open();
            cmd = new SqlCommand("SELECT * FROM Interviewee", dbConnection);
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(intervieweeTable);
            //dgInterviewees.DataSource = intervieweeTable;
            dbConnection.Close();
        }
    }
}
