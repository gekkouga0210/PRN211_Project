using Microsoft.EntityFrameworkCore;
using SE1634_Group1_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SE1634_Group1_Project.GUI
{
    public partial class DoQuizzGUI : Form
    {
        Quizz quizz;
        HappyQuizzContext quizzContext;
        PageList<Question> pageList;
        IQueryable<Question> questions;
        MyCheckbox lastChecked;
        public DoQuizzGUI(Quizz _quizz)
        {
            InitializeComponent();
            quizz = _quizz;
            quizzContext = new HappyQuizzContext();
            questions = quizzContext.Questions
                .Where(a => a.QuizzId == quizz.QuizzId).Include(a => a.Answers);

            TitleLabel.Text = quizz.Title;
            bindData(1);
        }

        private void bindData(int pageIndex)
        {
            QuestionsLable.Text = pageIndex.ToString() + "/" + questions.Count().ToString();

            pageList = PageList<Question>.Create(questions, pageIndex, 1);

            PreviousButton.Enabled = pageList.HasPreviousPage;
            NextButton.Enabled = pageList.HasNextPage;

            groupBox2.Controls.Clear();

            foreach(Question question in pageList)
            {
                Label lblquestion = new Label();
                lblquestion.AutoSize = true;
                lblquestion.Text = question.Text;
                lblquestion.Location = new Point(10, 20);
                groupBox2.Controls.Add(lblquestion);

                groupBox1.Controls.Clear();
                int i = 1;
                foreach(Answer answer in question.Answers)
                {
                    MyCheckbox lblcheckbox = new MyCheckbox();
                    lblcheckbox.AutoSize = true;
                    lblcheckbox.answer = answer;
                    lblcheckbox.Text = answer.Text;
                    lblcheckbox.Click += CheckboxClickHandler;
                    lblcheckbox.Location = new Point(10, i * 30);
                    groupBox1.Controls.Add(lblcheckbox);
                    i++;
                }
            }
        }

        void CheckboxClickHandler(object sender, EventArgs args)
        {
            MyCheckbox activeCheckBox = (sender as MyCheckbox);
            if (activeCheckBox != lastChecked && lastChecked != null) lastChecked.Checked = false;
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;

        }
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            bindData(pageList.PageIndex - 1);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            bindData(pageList.PageIndex + 1);
        }
    }
}
