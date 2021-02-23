using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
//用户自定义
using ModuleLogic.ViewModels;
using ModuleLogic.Entity;

namespace ModuleLogic.Views
{
    public partial class TrainingCourses : UserControl
    {
        private void NavigatePage(string adaptationArea, string navigatePath)
        {
            Task.Factory.StartNew(() =>
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    var VM = (TrainingCoursesViewModel)DataContext;
                    VM.Navigate(adaptationArea, navigatePath);
                }));
            });
        }

        public TrainingCourses()
        {
            InitializeComponent();

            NavigatePage("TimeAreaContentRegion", "TimeArea");
            NavigatePage("KeyboardTemplateContentRegion", "KeyboardTemplate");

            Task.Factory.StartNew(() =>
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    AthletesCombox.Items.Clear();

                    var line = ReadConfigure.ReadParameter(@"\Login.txt");
                    DB dB = new DB();
                    var result = dB.GetUsers(int.Parse(line));

                    AthletesCombox.Items.Add("全部");
                    foreach (var item in result)
                        AthletesCombox.Items.Add(item.user_name);


                    var usr = dB.ValidateLogon(int.Parse(line));

                    Label_Coach.Content = usr.user_name;

                    switch (usr.role)
                    {
                        case 1:
                            Label_UserPosition.Content = "运动员:";
                            break;
                        case 2:
                            Label_UserPosition.Content = "教练:";
                            break;
                        case 3:
                            Label_UserPosition.Content = "系统管理员:";
                            break;
                        case 4:
                            Label_UserPosition.Content = "队医:";
                            break;
                        case 5:
                            Label_UserPosition.Content = "领队:";
                            break;
                    }
                    
                }));
            });
        }

        private string GetVale(TextBox textBox)
        {
            if (textBox.Text.Trim() != "")
                return @"#" + textBox.Text;
            else
                return @"#null";
        }

        private void Utilities(string parameter)
        {
            PromptMessage promptMessage = new PromptMessage();
            promptMessage.messageLabel.Content = parameter;
            promptMessage.Show();
            Thread.Sleep(1500);
            promptMessage.Close();
        }

        //发布训练计划
        private void PublishPlan_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DB dB = new DB();

            var coachId = ReadConfigure.ReadParameter(@"\Login.txt");//教练id

            var Loginer = dB.ValidateLogon(int.Parse(coachId));
            if (Loginer.role != 2)
            {
                Utilities("非教练员不能发布训练计划...");
                return;
            }

            var VM = (TrainingCoursesViewModel)DataContext;
            if (VM.ExactDate != null)
            {
                var select = Convert.ToDateTime(VM.ExactDate);
                if (select < DateTime.Now.AddDays(-1))
                {
                    Utilities("请勿选择过去日期...");
                }
                else
                {
                    string parameter1, parameter2, parameter3, parameter4, parameter5, parameter6, parameter7, parameter8, parameter9, parameter10 = string.Empty;

                    parameter1 = GetVale(TextDashboard_1);
                    parameter2 = GetVale(TextDashboard_2);
                    parameter3 = GetVale(TextDashboard_3);
                    parameter4 = GetVale(TextDashboard_4);
                    parameter5 = GetVale(TextDashboard_5);
                    parameter6 = GetVale(TextDashboard_6);
                    parameter7 = GetVale(TextDashboard_7);
                    parameter8 = GetVale(TextDashboard_8);
                    parameter9 = GetVale(TextDashboard_9);
                    parameter10 = GetVale(TextDashboard_10);

                    if ((parameter1 == @"#null") &&
                        (parameter2 == @"#null") &&
                        (parameter3 == @"#null") &&
                        (parameter4 == @"#null") &&
                        (parameter5 == @"#null") &&
                        (parameter6 == @"#null") &&
                        (parameter7 == @"#null") &&
                        (parameter8 == @"#null") &&
                        (parameter9 == @"#null") &&
                        (parameter10 == @"#null"))
                    {
                        Utilities("无法发布空计划...");
                        return;
                    }

                    var time = DateTime.Parse(currenTimeLabel.Content.ToString());//训练时间
                    var players = AthletesCombox.Text.Split(',').ToList();

                    if (players.First() == "")
                    {
                        Utilities("请选择运动员...");
                        return;
                    }

                    if (players.Contains("全部"))
                    {
                        players.Clear();
                        for (int i = 0; i < AthletesCombox.Items.Count; i++)
                            players.Add(AthletesCombox.Items[1].ToString());
                    }

                    var count = dB.IsExist(time, int.Parse(ReadConfigure.ReadParameter(@"\Login.txt")));

                    if (count == 0)
                    {
                        foreach (var plan in from item in players
                                             let plan = new plan()
                                             {
                                                 startTime = time,
                                                 endTime = time.AddDays(1),
                                                 coachId = int.Parse(coachId),
                                                 playerId = dB.GetUser(item).user_id,
                                                 text_content = parameter1 + parameter2 + parameter3 + parameter4 + parameter5 + parameter6 + parameter7 + parameter8 + parameter9 + parameter10
                                             }
                                             select plan)
                        {
                            dB.Insert(plan);
                        }
                    }
                    else
                    {
                        dB.DeleteTraining(time, int.Parse(ReadConfigure.ReadParameter(@"\Login.txt")));

                        foreach (var plan in from item in players
                                             let plan = new plan()
                                             {
                                                 startTime = time,
                                                 endTime = time.AddDays(1),
                                                 coachId = int.Parse(coachId),
                                                 playerId = dB.GetUser(item).user_id,
                                                 text_content = parameter1 + parameter2 + parameter3 + parameter4 + parameter5 + parameter6 + parameter7 + parameter8 + parameter9 + parameter10
                                             }
                                             select plan)
                        {
                            dB.Insert(plan);
                        }
                    }

                    VM.SendMessage("update");

                    Utilities("训练计划发布成功");
                }
            }
            else
                Utilities("尚未选择发布日期...");

        }

        //及时刷新
        private void AthletesCombox_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var line = ReadConfigure.ReadParameter(@"\Login.txt");

            AthletesCombox.Items.Clear();

            DB dB = new DB();
            var result = dB.GetUsers(int.Parse(line));

            AthletesCombox.Items.Add("全部");
            foreach (var item in result)
                AthletesCombox.Items.Add(item.user_name);
        }
    }
}
