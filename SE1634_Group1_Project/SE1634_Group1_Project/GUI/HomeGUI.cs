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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SE1634_Group1_Project.GUI
{
    public partial class HomeGUI : Form
    {
        HappyQuizzContext context;
        PageList<Quizz> pageList;
        public HomeGUI()
        {
            InitializeComponent();
            context = new HappyQuizzContext();
            bindPanel(1);
        }

        private void bindPanel(int pageIndex)
        {
            IQueryable<Quizz> quizzs = context.Quizzs
                .Where(a => a.Title.Contains(TitleValue.Text.Trim())).Include(a => a.AuthorNavigation).Include(a => a.Questions);

            pageList = PageList<Quizz>.Create(quizzs, pageIndex, 3);

            PreviousButton.Enabled = pageList.HasPreviousPage;
            NextButton.Enabled = pageList.HasNextPage;

            panel1.Controls.Clear();
            int height = panel1.Height - 20;
            int width = (panel1.Width - 40) / 3;
            int i = 0;

            foreach (Quizz quizz in pageList)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Height = height;
                groupBox.Width = width;
                groupBox.Location = new Point(10 + i * (width + 10), 10);

                Label lbltitle = new Label();
                lbltitle.AutoSize = true;
                lbltitle.Text = quizz.Title;
                lbltitle.Location = new Point(10, 0);
                groupBox.Controls.Add(lbltitle);

                Label lblauthor = new Label();
                lblauthor.Height = 20;
                lblauthor.Width = 60;
                lblauthor.TextAlign = ContentAlignment.MiddleCenter;
                lblauthor.Text = quizz.AuthorNavigation.UserName;
                lblauthor.Location = new Point((groupBox.Width - lblauthor.Width) / 2, 80);
                groupBox.Controls.Add(lblauthor);

                Label lblquestion = new Label();
                lblquestion.Height = 20;
                lblquestion.Width = 60;
                lblquestion.TextAlign = ContentAlignment.MiddleCenter;
                lblquestion.Text = quizz.Questions.Count().ToString();
                lblquestion.Location = new Point((groupBox.Width - lblquestion.Width) / 2, 90);
                groupBox.Controls.Add(lblquestion);

                MyButton myButton = new MyButton();
                myButton.AutoSize = true;
                myButton.Text = "Take Quizz";
                myButton.BackColor = Color.Blue;
                myButton.ForeColor = Color.White;
                myButton.Click += ButtonClickHandler;
                myButton.quizz = quizz;
                myButton.Show();
                myButton.Location = new Point((groupBox.Width - myButton.Width) / 2, 120);
                groupBox.Controls.Add(myButton);

                panel1.Controls.Add(groupBox);

                i++;
            }
        }

        void ButtonClickHandler(object sender, EventArgs args)
        {
            MyButton mb = (sender as MyButton);

            QuizzDetailGUI quizzDetailGUI = new QuizzDetailGUI(mb.quizz);
            quizzDetailGUI.TopLevel = false;
            quizzDetailGUI.FormBorderStyle = FormBorderStyle.None;
            quizzDetailGUI.Show();

            Global.toolStripContainer.ContentPanel.Controls.Clear();
            Global.toolStripContainer.ContentPanel.Controls.Add(quizzDetailGUI);
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            bindPanel(pageList.PageIndex + 1);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            bindPanel(1);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            bindPanel(pageList.PageIndex - 1);
        }
    }
}
