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

namespace SE1634_Group1_Project.GUI
{
    public partial class QuizzDetailGUI : Form
    {
        Quizz quizz;
        HappyQuizzContext quizzContext;
        public QuizzDetailGUI(Quizz _quizz)
        {
            InitializeComponent();
            quizz = _quizz;
            quizzContext = new HappyQuizzContext();
            setupLabel();
        }
        
        private void setupLabel()
        {
            TitleLabel.Text = quizz.Title;
            AuthorValue.Text = quizz.AuthorNavigation.UserName;
            QuestionsValue.Text = quizz.Questions.Count().ToString();
            
            if(Global.UserId != -1)
            {
                FinishedLabel.Visible = true;
                FinishedValue.Visible = true;
                MaxScoreLabel.Visible = true;
                MaxScoreValue.Visible = true;
                RankButton.Visible = true;
            }
            else
            {
                FinishedLabel.Visible = false;
                FinishedValue.Visible = false;
                MaxScoreLabel.Visible = false;
                MaxScoreValue.Visible = false;
                RankButton.Visible = false;
                ResumeButton.Enabled = false;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            DoQuizzGUI doQuizzGUI = new DoQuizzGUI(quizz);
            doQuizzGUI.TopLevel = false;
            doQuizzGUI.FormBorderStyle = FormBorderStyle.None;
            doQuizzGUI.Show();

            Global.toolStripContainer.ContentPanel.Controls.Clear();
            Global.toolStripContainer.ContentPanel.Controls.Add(doQuizzGUI);
        }
    }

}
