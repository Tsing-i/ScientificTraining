using System.Windows.Controls;
//用户自定义
using ModuleLogic.Entity;
using ModuleLogic.ViewModels;

namespace ModuleLogic.Views
{
    public partial class AthletesShow : UserControl
    {
        //构造函数
        public AthletesShow()
        {
            InitializeComponent();

            var line = ReadConfigure.ReadParameter(@"\Login.txt");

            DB dB = new DB();

            var user = dB.ValidateLogon(int.Parse(line));
            if (user.role == 2)
            {
                var result = dB.GetUsers(int.Parse(line));

                foreach (user item in result)
                    UserList.Items.Add(item);
            }
            else if (user.role == 5 || user.role == 4)
            {
                var result = dB.GetUsers(ReadConfigure.ReadParameter(@"\venue.txt"));

                foreach (user item in result)
                    UserList.Items.Add(item);
            }
        }

        private void UserList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var model = (HealthManagementViewModel)DataContext;

            var item = UserList.SelectedItem as user;
            model.SendMessage(item.user_id.ToString());
        }
    }
}
