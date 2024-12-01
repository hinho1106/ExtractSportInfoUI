using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInfoUI
{
    internal class LoadingMessageBox : Form
    {
        //public string Text { get; set; }

        public LoadingMessageBox()
        {
            InitializeComponent();
        }

        

        private void InitializeComponent()
        {
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 23);
            label1.Name = "label1";
            label1.Size = new Size(114, 32);
            label1.TabIndex = 0;
            label1.Text = "Loading...";
            // 
            // LoadingMessageBox
            // 
            ClientSize = new Size(212, 83);
            Controls.Add(label1);
            Name = "LoadingMessageBox";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
    }
}
