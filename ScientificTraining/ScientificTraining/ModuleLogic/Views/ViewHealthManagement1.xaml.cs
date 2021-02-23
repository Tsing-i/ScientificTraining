using System.Windows;
using System.Windows.Controls;

namespace ModuleLogic.Views
{
    public partial class ViewHealthManagement1 : UserControl
    {
        private string currenURL = string.Empty;

        public ViewHealthManagement1()
        {
            InitializeComponent();
            Assignment("http://www.chinada.cn/");
        }

        private void Assignment(string url)
        {
            Browser.Address = url;
            currenURL = url;
        }


        //营养动态
        private void NutritionTrends_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => Assignment("http://www.cnsoc.org/sports/");

        //营养知识
        private void Nutritionknowledge_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => Assignment("http://www.cnsoc.org/sports/");

        //营养药品
        private void NutritionMedicine_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => Assignment("http://www.cnhfa.org.cn/");

        //中国反兴奋剂中心
        private void AntiDoping_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => Assignment("http://www.chinada.cn/");


        private void useIE_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(currenURL);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
    }
}
