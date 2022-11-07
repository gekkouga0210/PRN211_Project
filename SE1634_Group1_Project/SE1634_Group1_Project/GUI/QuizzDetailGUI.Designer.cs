namespace SE1634_Group1_Project.GUI
{
    partial class QuizzDetailGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FinishedLabel = new System.Windows.Forms.Label();
            this.FinishedValue = new System.Windows.Forms.Label();
            this.MaxScoreLabel = new System.Windows.Forms.Label();
            this.MaxScoreValue = new System.Windows.Forms.Label();
            this.AuthorValue = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.QuestionsValue = new System.Windows.Forms.Label();
            this.QuestionsLabel = new System.Windows.Forms.Label();
            this.ResumeButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.RankButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(89, 83);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(91, 28);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "SWT301";
            // 
            // FinishedLabel
            // 
            this.FinishedLabel.AutoSize = true;
            this.FinishedLabel.Location = new System.Drawing.Point(89, 216);
            this.FinishedLabel.Name = "FinishedLabel";
            this.FinishedLabel.Size = new System.Drawing.Size(66, 20);
            this.FinishedLabel.TabIndex = 1;
            this.FinishedLabel.Text = "Finished:";
            // 
            // FinishedValue
            // 
            this.FinishedValue.AutoSize = true;
            this.FinishedValue.Location = new System.Drawing.Point(161, 216);
            this.FinishedValue.Name = "FinishedValue";
            this.FinishedValue.Size = new System.Drawing.Size(57, 20);
            this.FinishedValue.TabIndex = 2;
            this.FinishedValue.Text = "2 times";
            // 
            // MaxScoreLabel
            // 
            this.MaxScoreLabel.AutoSize = true;
            this.MaxScoreLabel.Location = new System.Drawing.Point(89, 261);
            this.MaxScoreLabel.Name = "MaxScoreLabel";
            this.MaxScoreLabel.Size = new System.Drawing.Size(81, 20);
            this.MaxScoreLabel.TabIndex = 3;
            this.MaxScoreLabel.Text = "Max Score:";
            // 
            // MaxScoreValue
            // 
            this.MaxScoreValue.AutoSize = true;
            this.MaxScoreValue.Location = new System.Drawing.Point(176, 261);
            this.MaxScoreValue.Name = "MaxScoreValue";
            this.MaxScoreValue.Size = new System.Drawing.Size(47, 20);
            this.MaxScoreValue.TabIndex = 4;
            this.MaxScoreValue.Text = "28/30";
            // 
            // AuthorValue
            // 
            this.AuthorValue.AutoSize = true;
            this.AuthorValue.Location = new System.Drawing.Point(152, 130);
            this.AuthorValue.Name = "AuthorValue";
            this.AuthorValue.Size = new System.Drawing.Size(39, 20);
            this.AuthorValue.TabIndex = 6;
            this.AuthorValue.Text = "hadt";
            this.AuthorValue.Click += new System.EventHandler(this.label2_Click);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(89, 130);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(57, 20);
            this.AuthorLabel.TabIndex = 5;
            this.AuthorLabel.Text = "Author:";
            // 
            // QuestionsValue
            // 
            this.QuestionsValue.AutoSize = true;
            this.QuestionsValue.Location = new System.Drawing.Point(172, 172);
            this.QuestionsValue.Name = "QuestionsValue";
            this.QuestionsValue.Size = new System.Drawing.Size(25, 20);
            this.QuestionsValue.TabIndex = 8;
            this.QuestionsValue.Text = "30";
            // 
            // QuestionsLabel
            // 
            this.QuestionsLabel.AutoSize = true;
            this.QuestionsLabel.Location = new System.Drawing.Point(89, 172);
            this.QuestionsLabel.Name = "QuestionsLabel";
            this.QuestionsLabel.Size = new System.Drawing.Size(77, 20);
            this.QuestionsLabel.TabIndex = 7;
            this.QuestionsLabel.Text = "Questions:";
            // 
            // ResumeButton
            // 
            this.ResumeButton.Enabled = false;
            this.ResumeButton.Location = new System.Drawing.Point(427, 152);
            this.ResumeButton.Name = "ResumeButton";
            this.ResumeButton.Size = new System.Drawing.Size(178, 39);
            this.ResumeButton.TabIndex = 9;
            this.ResumeButton.Text = "Resume";
            this.ResumeButton.UseVisualStyleBackColor = true;
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(659, 152);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(178, 39);
            this.NewButton.TabIndex = 10;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // RankButton
            // 
            this.RankButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RankButton.Location = new System.Drawing.Point(229, 261);
            this.RankButton.Name = "RankButton";
            this.RankButton.Size = new System.Drawing.Size(71, 23);
            this.RankButton.TabIndex = 11;
            this.RankButton.Text = "Rank";
            this.RankButton.UseVisualStyleBackColor = true;
            // 
            // QuizzDetailGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 367);
            this.Controls.Add(this.RankButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.ResumeButton);
            this.Controls.Add(this.QuestionsValue);
            this.Controls.Add(this.QuestionsLabel);
            this.Controls.Add(this.AuthorValue);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.MaxScoreValue);
            this.Controls.Add(this.MaxScoreLabel);
            this.Controls.Add(this.FinishedValue);
            this.Controls.Add(this.FinishedLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "QuizzDetailGUI";
            this.Text = "QuizzDetailGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLabel;
        private Label FinishedLabel;
        private Label FinishedValue;
        private Label MaxScoreLabel;
        private Label MaxScoreValue;
        private Label AuthorValue;
        private Label AuthorLabel;
        private Label QuestionsValue;
        private Label QuestionsLabel;
        private Button ResumeButton;
        private Button NewButton;
        private Button RankButton;
    }
}