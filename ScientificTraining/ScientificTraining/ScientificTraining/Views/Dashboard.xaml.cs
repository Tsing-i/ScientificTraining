using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
//用户自定义
using ScientificTraining.ViewModels;

namespace ScientificTraining.Views
{
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();

            if (SystemParameters.PrimaryScreenWidth > 1920)
            {
                this.Width = 1920;
                this.Height = 1080;
            }
            else
            {
                this.Width = SystemParameters.PrimaryScreenWidth;
                this.Height = SystemParameters.PrimaryScreenHeight;
                this.WindowState = WindowState.Maximized;
            }

            this.gridDrag.MouseLeftButtonDown += (o, e) => { DragMove(); };

            NavigatePage("TrainingCourses");

            TimeInfo.Content = DateTime.Now.ToString();
        }

        private void NavigatePage(string pageName)
        {
            Task.Factory.StartNew(() =>
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    var VM = (DashboardViewModel)DataContext;
                    VM.Navigate(pageName);
                }));
            });
        }

        //训练课程页面 
        private void TrainingCourses_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => NavigatePage("TrainingCourses");

        //人员管理页面
        private void PersonnelManagement_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => NavigatePage("ViewPersonnelManagement");

        //视频管理页面
        private void VideoManagement_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => NavigatePage("ViewVideoManagement");

        //健康管理页面
        private void HealthManagement_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => NavigatePage("HealthManagement");

        //营养管理页面
        private void NutritionManagement_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e) => NavigatePage("ViewHealthManagement1");

        //程序退出
        private void Button_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();
        
        //打开配置文件
        private void configure_Click(object sender, RoutedEventArgs e) => Process.Start(Environment.CurrentDirectory);

        //公司网址
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            Hyperlink link = sender as Hyperlink;
            Process.Start(new ProcessStartInfo(link.NavigateUri.AbsoluteUri));
        }
    }
}
