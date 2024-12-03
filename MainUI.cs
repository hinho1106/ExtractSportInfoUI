using System.Windows.Forms;

namespace SportInfoUI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void button_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, SearchButton.ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Update SportInfoHeader
            SportInfoView.DataSource = SportList;

            
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            //Clear all data in the DataGrid table
            SportInfoView.Rows.Clear();

            bool isValidated = true;

            //Validataion check
            if (WeekComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select week");
                isValidated = false;
            }
            else if (DayComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select day");
                isValidated = false;
            }
            else if (DropInTypeComboBox.SelectedIndex == -1) 
            {
                MessageBox.Show("Please select Sport Type");
                isValidated = false;
            }

            //When Validated
            if (isValidated)
            {

                //Loading Message Box Controlling
                bool isAllLoaded = false;
                {
                    LoadingMessageBox LoadingMsgBox = new LoadingMessageBox();


                    Task.Run(() =>
                    {
                        LoadingMsgBox.ShowDialog();
                       
                    });


                    Task.Run(() =>
                    {

                        while (!isAllLoaded)
                        {
                            Thread.Sleep(200);
                        }
                        
                        LoadingMsgBox.Dispose();
                        LoadingMsgBox.Close();
                    });


                        
                }
                
                //Pass UI text to DataHandler
                string sport = SportTextBox.Text;
                string week = WeekComboBox.Text;
                string day = DayComboBox.Text;
                string excludedAges = ExcludedAgeTextBox.Text;
                string excludedWords = ExcludedWordTextBox.Text;
                string sportType = DropInTypeComboBox.Text;

                List<SportInfo> infoTable = new List<SportInfo>();
                infoTable = await DataHandler.processSportInput(sport, week, day, excludedAges, excludedWords, sportType);
                

                //Print all info on DataGrid Table

                //use binding source to hold dummy data
                BindingSource binding = new BindingSource();
                binding.DataSource = infoTable;

                //bind datagridview to binding source
                SportInfoView.DataSource = binding;

                isAllLoaded = true;
            }
        }
    }
}
