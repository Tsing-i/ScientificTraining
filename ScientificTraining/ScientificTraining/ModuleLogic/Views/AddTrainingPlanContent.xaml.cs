using System.Windows;

namespace ModuleLogic.Views
{
    public partial class AddTrainingPlanContent : Window
    {
        public AddTrainingPlanContent()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e) => this.Close();
        

        private void Confirm_Click(object sender, RoutedEventArgs e) => this.Close();

    }
}
