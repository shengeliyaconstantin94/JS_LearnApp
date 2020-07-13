using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JS_LearnApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string fillComboBoxQuery = "SELECT Text_Category FROM JS_TST_Text";
            string cathegoryCountQuery = "SELECT COUNT(Text_Category) FROM JS_TST_Text AS CathegoryCount";
            List<string> categories = new List<string>();

            SqlConnection connectionToJSDB = new SqlConnection(SQLConnector.GetSqlConnectionPath());

            SqlCommand fillComand = new SqlCommand(fillComboBoxQuery, connectionToJSDB);
            SqlCommand cathegoryCountCommand = new SqlCommand(cathegoryCountQuery, connectionToJSDB);

            connectionToJSDB.Open();
            int cathegoryesCount = (int)cathegoryCountCommand.ExecuteScalar();
            connectionToJSDB.Close();

            connectionToJSDB.Open();
            SqlDataReader reader = fillComand.ExecuteReader();
            while (reader.Read())
            {
                categories.Add((reader["Text_Category"].ToString()));
            }
            connectionToJSDB.Close();

            int i = 0;
            while (i != categories.Count)
            {
                cathegoryComboBox.Items.Add(categories[i]);
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cathegoryComboBox.Text) ) 
            {
                EducationForm edForm = new EducationForm(cathegoryComboBox.Text);
                this.Hide();
                edForm.Show();
            }
            else
            {
                MessageBox.Show("Не выбрана категория");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cathegoryComboBox.Text))
            {
                TestForm tstForm = new TestForm(cathegoryComboBox.Text);
                this.Hide();
                tstForm.Show();
            }
            else
            {
                MessageBox.Show("Не выбрана категория");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProgInfo prog = new ProgInfo();
            prog.Show();
        }
    }
}
