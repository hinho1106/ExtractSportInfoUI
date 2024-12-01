using System.ComponentModel;

namespace SportInfoUI
{
    partial class MainUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //Define UI Object
        

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SportText = new Label();
            SportTextBox = new TextBox();
            SportDescription = new Label();
            InputSectionPanel = new Panel();
            SearchButton = new Button();
            ExcludedWordDescription = new Label();
            ExcludedWordTextBox = new TextBox();
            ExcludedWordText = new Label();
            ExcludedAgeDescription = new Label();
            ExcludedAgeTextBox = new TextBox();
            ExcludedAgeText = new Label();
            DayComboBox = new ComboBox();
            DayText = new Label();
            WeekDescription = new Label();
            WeekComboBox = new ComboBox();
            WeekText = new Label();
            InputSection = new Label();
            SportInfoView = new DataGridView();
            InputSectionPanel.SuspendLayout();
            ((ISupportInitialize)SportInfoView).BeginInit();
            SuspendLayout();
            // 
            // SportText
            // 
            SportText.AutoSize = true;
            SportText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SportText.Location = new Point(19, 54);
            SportText.Name = "SportText";
            SportText.Size = new Size(57, 25);
            SportText.TabIndex = 0;
            SportText.Text = "Sport";
            // 
            // SportTextBox
            // 
            SportTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SportTextBox.Location = new Point(82, 51);
            SportTextBox.Name = "SportTextBox";
            SportTextBox.Size = new Size(141, 33);
            SportTextBox.TabIndex = 1;
            SportTextBox.Text = "Pickleball";
            // 
            // SportDescription
            // 
            SportDescription.AutoSize = true;
            SportDescription.Location = new Point(106, 87);
            SportDescription.Name = "SportDescription";
            SportDescription.Size = new Size(84, 15);
            SportDescription.TabIndex = 2;
            SportDescription.Text = "(e.g Pickleball)";
            // 
            // InputSectionPanel
            // 
            InputSectionPanel.BackColor = SystemColors.Control;
            InputSectionPanel.Controls.Add(SearchButton);
            InputSectionPanel.Controls.Add(ExcludedWordDescription);
            InputSectionPanel.Controls.Add(ExcludedWordTextBox);
            InputSectionPanel.Controls.Add(ExcludedWordText);
            InputSectionPanel.Controls.Add(ExcludedAgeDescription);
            InputSectionPanel.Controls.Add(ExcludedAgeTextBox);
            InputSectionPanel.Controls.Add(ExcludedAgeText);
            InputSectionPanel.Controls.Add(DayComboBox);
            InputSectionPanel.Controls.Add(DayText);
            InputSectionPanel.Controls.Add(WeekDescription);
            InputSectionPanel.Controls.Add(WeekComboBox);
            InputSectionPanel.Controls.Add(WeekText);
            InputSectionPanel.Controls.Add(InputSection);
            InputSectionPanel.Controls.Add(SportDescription);
            InputSectionPanel.Controls.Add(SportText);
            InputSectionPanel.Controls.Add(SportTextBox);
            InputSectionPanel.Location = new Point(25, 23);
            InputSectionPanel.Name = "InputSectionPanel";
            InputSectionPanel.Size = new Size(715, 274);
            InputSectionPanel.TabIndex = 3;
            // 
            // SearchButton
            // 
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchButton.Location = new Point(491, 203);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(116, 36);
            SearchButton.TabIndex = 15;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            SearchButton.Paint += button_Paint;
            // 
            // ExcludedWordDescription
            // 
            ExcludedWordDescription.AutoSize = true;
            ExcludedWordDescription.Location = new Point(202, 239);
            ExcludedWordDescription.Name = "ExcludedWordDescription";
            ExcludedWordDescription.Size = new Size(110, 15);
            ExcludedWordDescription.TabIndex = 14;
            ExcludedWordDescription.Text = "(use ; as separators)";
            // 
            // ExcludedWordTextBox
            // 
            ExcludedWordTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExcludedWordTextBox.Location = new Point(191, 203);
            ExcludedWordTextBox.Name = "ExcludedWordTextBox";
            ExcludedWordTextBox.Size = new Size(141, 33);
            ExcludedWordTextBox.TabIndex = 13;
            ExcludedWordTextBox.Text = "Family;LGBT";
            // 
            // ExcludedWordText
            // 
            ExcludedWordText.AutoSize = true;
            ExcludedWordText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExcludedWordText.Location = new Point(19, 206);
            ExcludedWordText.Name = "ExcludedWordText";
            ExcludedWordText.Size = new Size(159, 25);
            ExcludedWordText.TabIndex = 12;
            ExcludedWordText.Text = "Excluded Word(s)";
            // 
            // ExcludedAgeDescription
            // 
            ExcludedAgeDescription.AutoSize = true;
            ExcludedAgeDescription.Location = new Point(439, 167);
            ExcludedAgeDescription.Name = "ExcludedAgeDescription";
            ExcludedAgeDescription.Size = new Size(110, 15);
            ExcludedAgeDescription.TabIndex = 11;
            ExcludedAgeDescription.Text = "(use ; as separators)";
            // 
            // ExcludedAgeTextBox
            // 
            ExcludedAgeTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExcludedAgeTextBox.Location = new Point(426, 131);
            ExcludedAgeTextBox.Name = "ExcludedAgeTextBox";
            ExcludedAgeTextBox.Size = new Size(141, 33);
            ExcludedAgeTextBox.TabIndex = 10;
            ExcludedAgeTextBox.Text = "55;60";
            // 
            // ExcludedAgeText
            // 
            ExcludedAgeText.AutoSize = true;
            ExcludedAgeText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExcludedAgeText.Location = new Point(274, 134);
            ExcludedAgeText.Name = "ExcludedAgeText";
            ExcludedAgeText.Size = new Size(146, 25);
            ExcludedAgeText.TabIndex = 9;
            ExcludedAgeText.Text = "Excluded Age(s)";
            // 
            // DayComboBox
            // 
            DayComboBox.AllowDrop = true;
            DayComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DayComboBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DayComboBox.FormattingEnabled = true;
            DayComboBox.ImeMode = ImeMode.NoControl;
            DayComboBox.Items.AddRange(new object[] { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" });
            DayComboBox.Location = new Point(82, 131);
            DayComboBox.MaxDropDownItems = 4;
            DayComboBox.Name = "DayComboBox";
            DayComboBox.Size = new Size(121, 33);
            DayComboBox.TabIndex = 7;
            // 
            // DayText
            // 
            DayText.AutoSize = true;
            DayText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DayText.Location = new Point(19, 134);
            DayText.Name = "DayText";
            DayText.Size = new Size(44, 25);
            DayText.TabIndex = 8;
            DayText.Text = "Day";
            // 
            // WeekDescription
            // 
            WeekDescription.AutoSize = true;
            WeekDescription.Location = new Point(274, 87);
            WeekDescription.Name = "WeekDescription";
            WeekDescription.Size = new Size(312, 15);
            WeekDescription.TabIndex = 7;
            WeekDescription.Text = "(e.g 1 for the current week; 2 for the next week; and so on)";
            // 
            // WeekComboBox
            // 
            WeekComboBox.AllowDrop = true;
            WeekComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            WeekComboBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WeekComboBox.FormattingEnabled = true;
            WeekComboBox.ImeMode = ImeMode.NoControl;
            WeekComboBox.Items.AddRange(new object[] { "1", "2", "3", "4" });
            WeekComboBox.Location = new Point(345, 51);
            WeekComboBox.MaxDropDownItems = 4;
            WeekComboBox.Name = "WeekComboBox";
            WeekComboBox.Size = new Size(121, 33);
            WeekComboBox.TabIndex = 4;
            // 
            // WeekText
            // 
            WeekText.AutoSize = true;
            WeekText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WeekText.Location = new Point(274, 54);
            WeekText.Name = "WeekText";
            WeekText.Size = new Size(58, 25);
            WeekText.TabIndex = 5;
            WeekText.Text = "Week";
            // 
            // InputSection
            // 
            InputSection.AutoSize = true;
            InputSection.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            InputSection.Location = new Point(19, 9);
            InputSection.Name = "InputSection";
            InputSection.Size = new Size(123, 25);
            InputSection.TabIndex = 4;
            InputSection.Text = "Input Section";
            // 
            // SportInfoView
            // 
            SportInfoView.AllowUserToAddRows = false;
            SportInfoView.AllowUserToDeleteRows = false;
            SportInfoView.AllowUserToResizeColumns = false;
            SportInfoView.AllowUserToResizeRows = false;
            SportInfoView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SportInfoView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SportInfoView.Location = new Point(25, 303);
            SportInfoView.Name = "SportInfoView";
            SportInfoView.RowHeadersWidth = 70;
            SportInfoView.Size = new Size(697, 302);
            SportInfoView.TabIndex = 4;
            // 
            // MainUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 631);
            Controls.Add(SportInfoView);
            Controls.Add(InputSectionPanel);
            Name = "MainUI";
            Text = "ExtractSportInfo";
            Load += Form1_Load;
            InputSectionPanel.ResumeLayout(false);
            InputSectionPanel.PerformLayout();
            ((ISupportInitialize)SportInfoView).EndInit();
            ResumeLayout(false);
        }

        #endregion



        private ContextMenuStrip contextMenuStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private Label SportText;
        private TextBox SportTextBox;
        private Label SportDescription;
        private Panel InputSectionPanel;
        private Label InputSection;
        private ComboBox WeekComboBox;
        private Label WeekText;
        private Label WeekDescription;
        private ComboBox DayComboBox;
        private Label DayText;
        private Label ExcludedAgeDescription;
        private TextBox ExcludedAgeTextBox;
        private Label ExcludedAgeText;
        private TextBox ExcludedWordTextBox;
        private Label ExcludedWordText;
        private Button SearchButton;
        private Label ExcludedWordDescription;

        private BindingList<SportInfo> SportList = new BindingList<SportInfo>();
        private DataGridView SportInfoView;
        
    }
}
