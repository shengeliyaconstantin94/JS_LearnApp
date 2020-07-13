using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JS_LearnApp
{
    public class EducationText
    {
        List<string> topicText = new List<string>();

        public List<string> TopicText {
            get
            {
                return topicText;
            }
            set
            {
                value = topicText;
            }
            }
        public void GetTextValue(string theme)
        {
            SqlConnection connectionToJSDB = new SqlConnection(SQLConnector.GetSqlConnectionPath());
            string getTextQuery = "SELECT * FROM JS_TST_Text WHERE Text_Category LIKE'" + theme +"'";
            SqlCommand getTextCommand = new SqlCommand(getTextQuery, connectionToJSDB);
            connectionToJSDB.Open();
            SqlDataReader reader = getTextCommand.ExecuteReader();
            while (reader.Read())
            {
                TopicText.Add((reader["Text_Part_1"].ToString()));
                TopicText.Add((reader["Text_Part_2"].ToString()));
                TopicText.Add((reader["Text_Part_3"].ToString()));
                TopicText.Add((reader["Text_Part_4"].ToString()));
                TopicText.Add((reader["Text_Part_5"].ToString()));
               
            }
            connectionToJSDB.Close();
        }
    }
}
