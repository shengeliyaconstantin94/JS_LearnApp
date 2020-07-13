using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JS_LearnApp
{
    public class TestTask
    {
         List<string> answersVar = new List<string>();
         string taskText;
         string correctAnswer;
         string studentAnswer;
        
        public string TaskText
        {
            get
            {
                return taskText;
            }
            set
            {
                 taskText = value ;
            }
        }
        public List<string> AnswersVar
        {
            get
            {
                return answersVar;
            }
            set
            {
                answersVar=value;
            }
        }
        public string CorrectAnswer
        {
            get
            {
                return correctAnswer;
            }
            set
            {
                correctAnswer =value;
            }
        }
        public string StudentAnswer
        {
            get
            {
                return studentAnswer;
            }
            set
            {
                studentAnswer = value;

            }
        }

        public static List<TestTask> GetQuestionValue(List<TestTask> taskList, string theme)
        {
            List<string> taskQuestions = new List<string>();
            using (SqlConnection con = new SqlConnection(SQLConnector.GetSqlConnectionPath()))
            {

                SqlCommand comm = new SqlCommand($"SELECT Question_Text FROM JS_TST_Questions WHERE Question_Cathegory ='{theme.Trim()}'", con);

                con.Open();
                DbDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    taskQuestions.Add(reader["Question_Text"].ToString());
                }


            }


            foreach (string questText in taskQuestions)
            {
                taskList.Add(new TestTask { TaskText = questText});
            }
            
            return taskList;


        }
        public static List<TestTask> FillQuestionVariant(List<TestTask> tasksWithText)
        {
            using (SqlConnection con = new SqlConnection(SQLConnector.GetSqlConnectionPath()))
            {

                foreach (TestTask task in tasksWithText)
                {
                    SqlCommand fillCommand = new SqlCommand($"SELECT * FROM JS_TST_Questions WHERE Question_Text ='{task.TaskText}'", con);

                    con.Open();
                    DbDataReader reader = fillCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        task.answersVar.Add((reader["Question_Var_1"].ToString()));
                        task.answersVar.Add((reader["Question_Var_2"].ToString()));
                        task.answersVar.Add((reader["Question_Var_3"].ToString()));
                        task.answersVar.Add((reader["Question_Var_4"].ToString()));
                        task.answersVar.Add((reader["Question_Var_5"].ToString()));
                        task.answersVar.Add((reader["Question_Var_6"].ToString()));
                        task.answersVar.Add((reader["Question_Var_7"].ToString()));
                        task.correctAnswer = reader["Question_Answer"].ToString();

                    }
                    con.Close();
                    int i = 0;
                  while(i< task.answersVar.Count)
                    {
                        if (string.IsNullOrWhiteSpace(task.answersVar[i]))
                        {
                            task.answersVar.Remove(task.answersVar[i]);
                        }
                        i++;
                    }
                    
                }

                return tasksWithText;
            }

        }
    }
}
