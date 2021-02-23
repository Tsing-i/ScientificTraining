using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Linq;
//用户自定义
using ModuleLogic.Entity;

namespace ModuleLogic.Views
{
    public partial class ViewVideoManagement : UserControl
    {
        public ViewVideoManagement()
        {
            InitializeComponent();

            Task.Factory.StartNew(() =>
            {
                this.Dispatcher.Invoke(() =>
                {
                    DB dB = new DB();

                    var line = ReadConfigure.ReadParameter(@"\Login.txt");
                    var user = dB.ValidateLogon(int.Parse(line));

                    if (user.role == 2)
                    {

                        var result = dB.GetUsers(int.Parse(line));

                        foreach (user item in result)
                        {
                            var template = new TemplateButton_2();
                            template.templateButtonContent.Width = 75;
                            template.templateButtonContent.Content = item.real_name;
                            PeopleContainer.Children.Add(template);
                        }

                        //01
                        var list = dB.Getvideos(int.Parse(line));
                        foreach (video item in list)
                            TrainingVideo.Items.Add(item);

                        //02
                        foreach (var item in from video item in list
                                             where item.isCoachUpload == 1
                                             select item)
                        {
                            UploadVideo.Items.Add(item);
                        }

                        //03
                        var list2 = dB.Getmarvellous(int.Parse(ReadConfigure.ReadParameter(@"\Login.txt")));
                        foreach (video item in list2)
                            WonderfulVideo.Items.Add(item);
                    }
                    else if (user.role == 5 || user.role == 4) //如果是队医和领队登录，显示该队伍的所有的训练视频
                    {
                        var result = dB.GetUsers(ReadConfigure.ReadParameter(@"\venue.txt"));
                        foreach (user item in result)
                        {
                            var template = new TemplateButton_2();
                            template.templateButtonContent.Width = 75;
                            template.templateButtonContent.Content = item.real_name;
                            PeopleContainer.Children.Add(template);
                        }

                        var coachs = dB.GetCoach(ReadConfigure.ReadParameter(@"\venue.txt"));
                        foreach (var item in coachs)
                        {
                            var list = dB.Getvideos(item.user_id);
                            foreach (var t in list)
                                TrainingVideo.Items.Add(t);
                        }
                    }
                });
            });
        }

        #region 在线观看

        private void TrainingVideo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = TrainingVideo.SelectedItem as video;
            Process.Start(item.OSS);
        }

        private void WonderfulVideo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = WonderfulVideo.SelectedItem as video;
            Process.Start(item.OSS);
        }

        private void UploadVideo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = UploadVideo.SelectedItem as video;
            Process.Start(item.OSS);
        }

        #endregion
    }
}
