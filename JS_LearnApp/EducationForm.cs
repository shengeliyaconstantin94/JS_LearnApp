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
    public partial class EducationForm : Form
    {
        public EducationForm(string theme)
        {
            InitializeComponent();
             currentTheme = theme;
        }

        string currentTheme = "";
        int currentTextPart = 0;
        EducationText currentText = new EducationText();
        private void EducationForm_Load(object sender, EventArgs e)
        {
           
            currentText.GetTextValue(currentTheme);
            FormFiller(currentTextPart);

        }
        private void FormFiller (int currentpart)
        {
            topicRichTextBox.Text = currentText.TopicText[currentpart];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentTextPart++;
            if (currentTextPart != currentText.TopicText.Count)
            {
                
                FormFiller(currentTextPart);
            }
            else
            {
                TestForm tst = new TestForm(currentTheme);
                tst.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentTextPart == 0)
            {
                MessageBox.Show("Предыдущего вопроса не существует");

            }
            else
            {
                currentTextPart--;
                FormFiller(currentTextPart);
            }
        }
    }
}
