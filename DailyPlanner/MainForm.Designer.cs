using System.Windows.Forms;

namespace DailyPlanner
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            AddTaskButton = new Button();
            ClearButton = new Button();
            statisticsButton = new Button();
            dailyEntryBindingSource = new BindingSource(components);
            Планы = new DataGridViewTextBoxColumn();
            TaskListBox = new ListBox();
            TaskTextBox = new TextBox();
            TaskCalendar = new MonthCalendar();
            label1 = new Label();
            notesButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dailyEntryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // AddTaskButton
            // 
            AddTaskButton.BackColor = Color.DodgerBlue;
            AddTaskButton.FlatAppearance.BorderSize = 0;
            AddTaskButton.FlatStyle = FlatStyle.Flat;
            AddTaskButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddTaskButton.ForeColor = Color.White;
            AddTaskButton.Location = new Point(59, 501);
            AddTaskButton.Margin = new Padding(3, 4, 3, 4);
            AddTaskButton.Name = "AddTaskButton";
            AddTaskButton.Size = new Size(151, 45);
            AddTaskButton.TabIndex = 2;
            AddTaskButton.Text = "Добавить";
            AddTaskButton.UseVisualStyleBackColor = false;
            AddTaskButton.Click += AddTaskButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.DodgerBlue;
            ClearButton.FlatAppearance.BorderSize = 0;
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClearButton.ForeColor = Color.White;
            ClearButton.Location = new Point(216, 501);
            ClearButton.Margin = new Padding(3, 4, 3, 4);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(141, 45);
            ClearButton.TabIndex = 3;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // statisticsButton
            // 
            statisticsButton.BackColor = Color.DodgerBlue;
            statisticsButton.FlatAppearance.BorderColor = Color.DodgerBlue;
            statisticsButton.FlatAppearance.BorderSize = 0;
            statisticsButton.FlatStyle = FlatStyle.Flat;
            statisticsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statisticsButton.ForeColor = Color.White;
            statisticsButton.Location = new Point(363, 501);
            statisticsButton.Margin = new Padding(3, 4, 3, 4);
            statisticsButton.Name = "statisticsButton";
            statisticsButton.Size = new Size(155, 45);
            statisticsButton.TabIndex = 5;
            statisticsButton.Text = "Статистика";
            statisticsButton.UseVisualStyleBackColor = false;
            statisticsButton.Click += StatisticsButton_Click;
            // 
            // Планы
            // 
            Планы.HeaderText = "Column1";
            Планы.MinimumWidth = 6;
            Планы.Name = "Планы";
            Планы.Width = 125;
            // 
            // TaskListBox
            // 
            TaskListBox.BackColor = SystemColors.ActiveCaption;
            TaskListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TaskListBox.ForeColor = Color.FromArgb(0, 18, 39);
            TaskListBox.FormattingEnabled = true;
            TaskListBox.HorizontalScrollbar = true;
            TaskListBox.ItemHeight = 28;
            TaskListBox.Location = new Point(59, 139);
            TaskListBox.Margin = new Padding(3, 4, 3, 4);
            TaskListBox.Name = "TaskListBox";
            TaskListBox.Size = new Size(516, 284);
            TaskListBox.TabIndex = 6;
            // 
            // TaskTextBox
            // 
            TaskTextBox.BackColor = SystemColors.ActiveCaption;
            TaskTextBox.BorderStyle = BorderStyle.None;
            TaskTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TaskTextBox.ForeColor = Color.FromArgb(0, 18, 25);
            TaskTextBox.Location = new Point(59, 443);
            TaskTextBox.Margin = new Padding(3, 4, 3, 4);
            TaskTextBox.Multiline = true;
            TaskTextBox.Name = "TaskTextBox";
            TaskTextBox.PlaceholderText = "Введите название";
            TaskTextBox.ScrollBars = ScrollBars.Vertical;
            TaskTextBox.Size = new Size(459, 39);
            TaskTextBox.TabIndex = 7;
            // 
            // TaskCalendar
            // 
            TaskCalendar.BackColor = SystemColors.Highlight;
            TaskCalendar.ForeColor = Color.OrangeRed;
            TaskCalendar.Location = new Point(590, 139);
            TaskCalendar.Margin = new Padding(10, 12, 10, 12);
            TaskCalendar.Name = "TaskCalendar";
            TaskCalendar.TabIndex = 8;
            TaskCalendar.TitleBackColor = Color.Blue;
            TaskCalendar.TitleForeColor = Color.Yellow;
            TaskCalendar.TrailingForeColor = Color.Red;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 18, 39);
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(59, 31);
            label1.Name = "label1";
            label1.Size = new Size(362, 62);
            label1.TabIndex = 9;
            label1.Text = "Список планов:";
            // 
            // notesButton
            // 
            notesButton.BackColor = Color.DodgerBlue;
            notesButton.FlatAppearance.BorderColor = Color.DodgerBlue;
            notesButton.FlatAppearance.BorderSize = 0;
            notesButton.FlatStyle = FlatStyle.Flat;
            notesButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            notesButton.ForeColor = Color.White;
            notesButton.Location = new Point(524, 501);
            notesButton.Margin = new Padding(3, 4, 3, 4);
            notesButton.Name = "notesButton";
            notesButton.Size = new Size(155, 45);
            notesButton.TabIndex = 10;
            notesButton.Text = "Записки";
            notesButton.UseVisualStyleBackColor = false;
            notesButton.Click += NotesButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 18, 39);
            BackgroundImage = Properties.Resources.bkgr1;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(921, 600);
            Controls.Add(notesButton);
            Controls.Add(label1);
            Controls.Add(TaskCalendar);
            Controls.Add(TaskTextBox);
            Controls.Add(TaskListBox);
            Controls.Add(statisticsButton);
            Controls.Add(ClearButton);
            Controls.Add(AddTaskButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "DailyPlanner";
            ((System.ComponentModel.ISupportInitialize)dailyEntryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddTaskButton;
        private Button ClearButton;
        private Button statisticsButton;
        private DataGridViewTextBoxColumn Планы;
        private BindingSource dailyEntryBindingSource;
        private ListBox TaskListBox;
        private TextBox TaskTextBox;
        private Label label1;
        private MonthCalendar TaskCalendar;
        private Button notesButton;
    }
}