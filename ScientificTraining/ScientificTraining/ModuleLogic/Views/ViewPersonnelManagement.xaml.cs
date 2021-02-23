using System.Windows.Controls;
//用户自定义
using ModuleLogic.Entity;
using ModuleLogic.ViewModels;

namespace ModuleLogic.Views
{
    public partial class ViewPersonnelManagement : UserControl
    {
        public ViewPersonnelManagement()
        {
            InitializeComponent();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var result = ListView.SelectedItem as ListViewData;
            var VM = (ViewPersonnelManagementViewModel)DataContext;
            VM.listViewData = result;
           
        }
    }
}
