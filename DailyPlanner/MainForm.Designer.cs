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
            ((System.ComponentModel.ISupportInitialize)dailyEntryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // AddTaskButton
            // 
            AddTaskButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddTaskButton.Location = new Point(102, 509);
            AddTaskButton.Margin = new Padding(3, 4, 3, 4);
            AddTaskButton.Name = "AddTaskButton";
            AddTaskButton.Size = new Size(151, 45);
            AddTaskButton.TabIndex = 2;
            AddTaskButton.Text = "Добавить";
            AddTaskButton.UseVisualStyleBackColor = true;
            AddTaskButton.Click += AddTaskButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClearButton.Location = new Point(259, 509);
            ClearButton.Margin = new Padding(3, 4, 3, 4);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(141, 45);
            ClearButton.TabIndex = 3;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // statisticsButton
            // 
            statisticsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statisticsButton.Location = new Point(407, 509);
            statisticsButton.Margin = new Padding(3, 4, 3, 4);
            statisticsButton.Name = "statisticsButton";
            statisticsButton.Size = new Size(155, 45);
            statisticsButton.TabIndex = 5;
            statisticsButton.Text = "Статистика";
            statisticsButton.UseVisualStyleBackColor = true;
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
            TaskListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TaskListBox.FormattingEnabled = true;
            TaskListBox.ItemHeight = 28;
            TaskListBox.Location = new Point(102, 145);
            TaskListBox.Margin = new Padding(3, 4, 3, 4);
            TaskListBox.Name = "TaskListBox";
            TaskListBox.Size = new Size(390, 284);
            TaskListBox.TabIndex = 6;
            // 
            // TaskTextBox
            // 
            TaskTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TaskTextBox.Location = new Point(102, 463);
            TaskTextBox.Margin = new Padding(3, 4, 3, 4);
            TaskTextBox.Name = "TaskTextBox";
            TaskTextBox.PlaceholderText = "Введите название";
            TaskTextBox.Size = new Size(298, 34);
            TaskTextBox.TabIndex = 7;
            // 
            // TaskCalendar
            // 
            TaskCalendar.Location = new Point(519, 215);
            TaskCalendar.Margin = new Padding(10, 12, 10, 12);
            TaskCalendar.Name = "TaskCalendar";
            TaskCalendar.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(102, 72);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 9;
            label1.Text = "Список планов:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(921, 600);
            Controls.Add(label1);
            Controls.Add(TaskCalendar);
            Controls.Add(TaskTextBox);
            Controls.Add(TaskListBox);
            Controls.Add(statisticsButton);
            Controls.Add(ClearButton);
            Controls.Add(AddTaskButton);
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

        private DateTimePicker dateTimePicker1;
        private ListBox actionListBox;
        private Button AddTaskButton;
        private Button ClearButton;
        private Button button3;
        private TextBox actionTextBox;
        private Button statisticsButton;
        private DataGridViewTextBoxColumn Планы;
        private BindingSource dailyEntryBindingSource;
        private ListBox TaskListBox;
        private TextBox TaskTextBox;
        private MonthCalendar TaskCalendar;
        private Label label1;
    }
}