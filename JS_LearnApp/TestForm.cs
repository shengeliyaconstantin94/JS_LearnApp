using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JS_LearnApp
{
    public partial class TestForm : Form
    {
        public TestForm(string theme)
        {
            InitializeComponent();
            currentTheme = theme;




        }
        string currentTheme = "null";
        List<TestTask> curentTasks = new List<TestTask>();
        int currentTestQuestion = 0;
        List<RadioButton> checkList = new List<RadioButton>();
        int errors = 0;
        int rightAnswers = 0;

        private void TestForm_Load(object sender, EventArgs e)
        {

            curentTasks = TestTask.GetQuestionValue(curentTasks, currentTheme);
            curentTasks = TestTask.FillQuestionVariant(curentTasks);
            FormFiller(currentTestQuestion);

        }
        private void FormFiller(int currentQuestionIndex)
        {
            testRichTextBox1.Text = curentTasks[currentQuestionIndex].TaskText;
            int x1 = 50;
            int y1 = 100;
            
            foreach (string s in curentTasks[currentQuestionIndex].AnswersVar)
            {
                RadioButton rb = new RadioButton();
                rb.Text = s;
                rb.Location = new Point(x1, y1);
                rb.Name = $"radiobutton{curentTasks[currentQuestionIndex].AnswersVar.IndexOf(s)}";
                this.Controls.Add(rb);
                if (string.IsNullOrWhiteSpace(rb.Text))
                {
                    rb.Hide();
                }
                checkList.Add(rb);
                y1 += 20;
            }
        }

        private void answeBbutton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkList.Count; i++)
            {
                if (checkList[i].Checked)
                {
                    if (checkList[i].Text.Trim() == curentTasks[currentTestQuestion].CorrectAnswer.Trim())
                    {
                        rightAnswers++;
                        if (currentTestQuestion < curentTasks.Count)
                        {
                            foreach (RadioButton rb in checkList)
                            {
                                rb.Dispose();

                            }
                            checkList.Clear();
                            currentTestQuestion++;
                            if (currentTestQuestion < curentTasks.Count)
                            {
                                FormFiller(currentTestQuestion);
                            }

                            else
                            {
                                MessageBox.Show("Вы успешно прошли тест");

                                Cert cert = new Cert(currentTheme);
                                cert.Show();
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ответ неверен");
                        errors++;
                        
                        if (errors == 2)
                        {
                            MessageBox.Show("Большое количество ошмбок. Повторите теорию");
                            EducationForm ed = new EducationForm(currentTheme);
                            ed.Show();
                            this.Close();
                        }
                        break;
                    }
                }
            }
                }
            }
        }
    

