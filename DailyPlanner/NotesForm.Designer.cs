namespace DailyPlanner
{
    partial class NotesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesForm));
            date1 = new Label();
            TaskNotesBox = new TextBox();
            SuspendLayout();
            // 
            // date1
            // 
            date1.AutoSize = true;
            date1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            date1.ForeColor = Color.DodgerBlue;
            date1.Location = new Point(109, 14);
            date1.Name = "date1";
            date1.Size = new Size(161, 50);
            date1.TabIndex = 7;
            date1.Text = "Записки";
            // 
            // TaskNotesBox
            // 
            TaskNotesBox.BackColor = SystemColors.ActiveCaption;
            TaskNotesBox.BorderStyle = BorderStyle.None;
            TaskNotesBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TaskNotesBox.ForeColor = Color.FromArgb(0, 18, 25);
            TaskNotesBox.Location = new Point(16, 79);
            TaskNotesBox.Margin = new Padding(3, 4, 3, 4);
            TaskNotesBox.Multiline = true;
            TaskNotesBox.Name = "TaskNotesBox";
            TaskNotesBox.PlaceholderText = "Запишите комментарии";
            TaskNotesBox.ScrollBars = ScrollBars.Vertical;
            TaskNotesBox.Size = new Size(331, 233);
            TaskNotesBox.TabIndex = 0;
            TaskNotesBox.TabStop = false;
            // 
            // NotesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 18, 39);
            ClientSize = new Size(359, 325);
            Controls.Add(date1);
            Controls.Add(TaskNotesBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NotesForm";
            Text = "NotesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label date1;
        private TextBox TaskNotesBox;
    }
}