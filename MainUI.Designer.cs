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
            DropInTypeComboBox = new ComboBox();
            DropInTypeText = new Label();
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
            SportInfoView = new DataGridView();
            InputSectionPanel.SuspendLayout();
            ((ISupportInitialize)SportInfoView).BeginInit();
            SuspendLayout();
            // 
            // SportText
            // 
            SportText.AutoSize = true;
            SportText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SportText.Location = new Point(19, 64);
            SportText.Name = "SportText";
            SportText.Size = new Size(57, 25);
            SportText.TabIndex = 0;
            SportText.Text = "Sport";
            // 
            // SportTextBox
            // 
            SportTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SportTextBox.Location = new Point(82, 61);
            SportTextBox.Name = "SportTextBox";
            SportTextBox.Size = new Size(141, 33);
            SportTextBox.TabIndex = 1;
            SportTextBox.Text = "Pickleball";
            // 
            // SportDescription
            // 
            SportDescription.AutoSize = true;
            SportDescription.Location = new Point(46, 97);
            SportDescription.Name = "SportDescription";
            SportDescription.Size = new Size(157, 15);
            SportDescription.TabIndex = 2;
            SportDescription.Text = "(e.g Pickleball/Leisure Skate)";
            // 
            // InputSectionPanel
            // 
            InputSectionPanel.BackColor = SystemColors.Control;
            InputSectionPanel.Controls.Add(DropInTypeComboBox);
            InputSectionPanel.Controls.Add(DropInTypeText);
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
            InputSectionPanel.Controls.Add(SportDescription);
            InputSectionPanel.Controls.Add(SportText);
            InputSectionPanel.Controls.Add(SportTextBox);
            InputSectionPanel.Location = new Point(25, 23);
            InputSectionPanel.Name = "InputSectionPanel";
            InputSectionPanel.Size = new Size(715, 291);
            InputSectionPanel.TabIndex = 3;
            // 
            // DropInTypeComboBox
            // 
            DropInTypeComboBox.AllowDrop = true;
            DropInTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DropInTypeComboBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DropInTypeComboBox.FormattingEnabled = true;
            DropInTypeComboBox.ImeMode = ImeMode.NoControl;
            DropInTypeComboBox.Items.AddRange(new object[] { "Ice", "Non-ice" });
            DropInTypeComboBox.Location = new Point(274, 8);
            DropInTypeComboBox.MaxDropDownItems = 2;
            DropInTypeComboBox.Name = "DropInTypeComboBox";
            DropInTypeComboBox.Size = new Size(121, 33);
            DropInTypeComboBox.TabIndex = 17;
            // 
            // DropInTypeText
            // 
            DropInTypeText.AutoSize = true;
            DropInTypeText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DropInTypeText.Location = new Point(19, 11);
            DropInTypeText.Name = "DropInTypeText";
            DropInTypeText.Size = new Size(222, 25);
            DropInTypeText.TabIndex = 16;
            DropInTypeText.Text = "Type of Drop-in Program";
            // 
            // SearchButton
            // 
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatAppearance.MouseOverBackColor = SystemColors.ControlLight;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchButton.Location = new Point(491, 213);
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
            ExcludedWordDescription.Location = new Point(202, 249);
            ExcludedWordDescription.Name = "ExcludedWordDescription";
            ExcludedWordDescription.Size = new Size(110, 15);
            ExcludedWordDescription.TabIndex = 14;
            ExcludedWordDescription.Text = "(use ; as separators)";
            // 
            // ExcludedWordTextBox
            // 
            ExcludedWordTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExcludedWordTextBox.Location = new Point(191, 213);
            ExcludedWordTextBox.Name = "ExcludedWordTextBox";
            ExcludedWordTextBox.Size = new Size(141, 33);
            ExcludedWordTextBox.TabIndex = 13;
            ExcludedWordTextBox.Text = "Family;LGBT";
            // 
            // ExcludedWordText
            // 
            ExcludedWordText.AutoSize = true;
            ExcludedWordText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExcludedWordText.Location = new Point(19, 216);
            ExcludedWordText.Name = "ExcludedWordText";
            ExcludedWordText.Size = new Size(159, 25);
            ExcludedWordText.TabIndex = 12;
            ExcludedWordText.Text = "Excluded Word(s)";
            // 
            // ExcludedAgeDescription
            // 
            ExcludedAgeDescription.AutoSize = true;
            ExcludedAgeDescription.Location = new Point(439, 177);
            ExcludedAgeDescription.Name = "ExcludedAgeDescription";
            ExcludedAgeDescription.Size = new Size(110, 15);
            ExcludedAgeDescription.TabIndex = 11;
            ExcludedAgeDescription.Text = "(use ; as separators)";
            // 
            // ExcludedAgeTextBox
            // 
            ExcludedAgeTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExcludedAgeTextBox.Location = new Point(426, 141);
            ExcludedAgeTextBox.Name = "ExcludedAgeTextBox";
            ExcludedAgeTextBox.Size = new Size(141, 33);
            ExcludedAgeTextBox.TabIndex = 10;
            ExcludedAgeTextBox.Text = "50;55;60";
            // 
            // ExcludedAgeText
            // 
            ExcludedAgeText.AutoSize = true;
            ExcludedAgeText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExcludedAgeText.Location = new Point(274, 144);
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
            DayComboBox.Location = new Point(82, 141);
            DayComboBox.MaxDropDownItems = 4;
            DayComboBox.Name = "DayComboBox";
            DayComboBox.Size = new Size(121, 33);
            DayComboBox.TabIndex = 7;
            // 
            // DayText
            // 
            DayText.AutoSize = true;
            DayText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DayText.Location = new Point(19, 144);
            DayText.Name = "DayText";
            DayText.Size = new Size(44, 25);
            DayText.TabIndex = 8;
            DayText.Text = "Day";
            // 
            // WeekDescription
            // 
            WeekDescription.AutoSize = true;
            WeekDescription.Location = new Point(274, 97);
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
            WeekComboBox.Location = new Point(345, 61);
            WeekComboBox.MaxDropDownItems = 4;
            WeekComboBox.Name = "WeekComboBox";
            WeekComboBox.Size = new Size(121, 33);
            WeekComboBox.TabIndex = 4;
            // 
            // WeekText
            // 
            WeekText.AutoSize = true;
            WeekText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WeekText.Location = new Point(274, 64);
            WeekText.Name = "WeekText";
            WeekText.Size = new Size(58, 25);
            WeekText.TabIndex = 5;
            WeekText.Text = "Week";
            // 
            // SportInfoView
            // 
            SportInfoView.AllowUserToAddRows = false;
            SportInfoView.AllowUserToDeleteRows = false;
            SportInfoView.AllowUserToResizeColumns = false;
            SportInfoView.AllowUserToResizeRows = false;
            SportInfoView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SportInfoView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SportInfoView.Location = new Point(25, 320);
            SportInfoView.Name = "SportInfoView";
            SportInfoView.RowHeadersWidth = 70;
            SportInfoView.Size = new Size(715, 338);
            SportInfoView.TabIndex = 4;
            // 
            // MainUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 661);
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
        private ComboBox DropInTypeComboBox;
        private Label DropInTypeText;
    }
}
