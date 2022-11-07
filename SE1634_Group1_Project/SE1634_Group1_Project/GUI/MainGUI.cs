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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace SE1634_Group1_Project.GUI
{
    public partial class MainGUI : Form
    {
        HappyQuizzContext context;
        public MainGUI()
        {
            InitializeComponent();
            Global.toolStripContainer = toolStripContainer1;
            context = new HappyQuizzContext();
            HomeGUI homeGUI = new HomeGUI();
            homeGUI.TopLevel = false;
            homeGUI.FormBorderStyle = FormBorderStyle.None;
            homeGUI.Show();

            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(homeGUI);
        }

        
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeGUI homeGUI = new HomeGUI();
            homeGUI.TopLevel = false;
            homeGUI.FormBorderStyle = FormBorderStyle.None;
            homeGUI.Show();

            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(homeGUI);
        }

        private void MainGUI_Activated(object sender, EventArgs e)
        {
            if (Global.Role == 1) quizzesToolStripMenuItem.Visible = true;
            else quizzesToolStripMenuItem.Visible = false;

            if (Global.UserId != -1)
            {
                ongoingToolStripMenuItem.Visible = true;
                accomplishedToolStripMenuItem.Visible = true;
            }
            else
            {
                ongoingToolStripMenuItem.Visible = false;
                accomplishedToolStripMenuItem.Visible = false;

                IQueryable<RecordQuizz> records = context.RecordQuizzs
                .Where(r => r.UserId == Global.UserId && r.Status == true);
                ongoingToolStripMenuItem.Text = "On-going (" + records.Count() + ")";
            }

            if (Global.UserId != -1 && Global.UserName != "")
                loginToolStripMenuItem.Text = $"Logout ({Global.UserName})";
            else
                loginToolStripMenuItem.Text = $"Login";
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.UserId == -1)
            {
                LoginGUI loginGUI = new LoginGUI();
                DialogResult dialogResult = loginGUI.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    loginToolStripMenuItem.Text = $"Logout ({Global.UserName})";

                    HomeGUI homeGUI = new HomeGUI();
                    homeGUI.TopLevel = false;
                    homeGUI.FormBorderStyle = FormBorderStyle.None;
                    homeGUI.Show();

                    toolStripContainer1.ContentPanel.Controls.Clear();
                    toolStripContainer1.ContentPanel.Controls.Add(homeGUI);
                }
            }
            else
            {
                Global.UserName = "";
                Global.Role = -1;
                Global.UserId = -1;
                loginToolStripMenuItem.Text = $"Login";

                quizzesToolStripMenuItem.Visible = false;
                ongoingToolStripMenuItem.Visible = false;
                accomplishedToolStripMenuItem.Visible = false;

                HomeGUI homeGUI = new HomeGUI();
                homeGUI.TopLevel = false;
                homeGUI.FormBorderStyle = FormBorderStyle.None;
                homeGUI.Show();

                toolStripContainer1.ContentPanel.Controls.Clear();
                toolStripContainer1.ContentPanel.Controls.Add(homeGUI);
            }
        }
    }
}
