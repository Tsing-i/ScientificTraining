using System.Windows;
using System.Windows.Controls;
//用户自定义
using ModuleLogic.ViewModels;

namespace ModuleLogic.Views
{
    public partial class TemplateButton_3 : UserControl
    {
        public string _param;

        public TemplateButton_3(string param)
        {
            InitializeComponent();
            _param = param;
        }

        private void templateButtonContent_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var VM = (TemplateButton_3ViewModel)DataContext;

            VM.SendMessage(_param + @"#" + templateButtonContent.Content.ToString());
        }
    }
}
