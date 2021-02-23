using System;
using System.Text.RegularExpressions;
using System.Windows;
//用户自定义
using ModuleLogic.Entity;
using System.Linq;

namespace ModuleLogic.Views
{
    public partial class AddPerson : Window
    {
        public AddPerson()
        {
            InitializeComponent();

            this.Topmost = true;

            DB dB = new DB();

            var list1 = dB.Getroles();
            foreach (var itme in from itme in list1
                                 where itme.limitsName != "系统管理员"
                                 select itme)
            {
                Jurisdiction.Items.Add(itme.limitsName);
            }

            Gender.Items.Add("男");
            Gender.Items.Add("女");
        }

        //窗口关闭
        private void Close_Click(object sender, RoutedEventArgs e) => this.Hide();

        private int GetJurisdictionName(string role)
        {
            int Permission = 0;

            switch (role)
            {
                case "运动员":
                    Permission = 1;
                    break;
                case "教练":
                    Permission = 2;
                    break;
                case "队医":
                    Permission = 4;
                    break;
                case "领队":
                    Permission = 5;
                    break;
            }

            return Permission;
        }

        private int GetTypeName(string role)
        {
            int type = 0;

            switch (role)
            {
                case "跳水":
                    type = 1;
                    break;
                case "田径":
                    type = 2;
                    break;
                case "体操":
                    type = 3;
                    break;
                case "蹦床":
                    type = 4;
                    break;
            }

            return type;
        }


        //确认
        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Regex rx = new Regex(@"^0{0,1}(13[4-9]|15[7-9]|15[0-2]|18[7-8])[0-9]{8}$");

                if (!rx.IsMatch(textbox_4.Text.Trim()))
                {
                    MessageBox.Show("请输入正确的手机号....");
                }
                else
                {
                    user user = new user()
                    {
                        user_name = textbox_1.Text.Trim(),
                        password = textbox_3.Text.Trim(),
                        real_name = textbox_2.Text.Trim(),
                        sex = Gender.Text,
                        telephonenumber = textbox_4.Text.Trim(),
                        role = GetJurisdictionName(Jurisdiction.Text),
                        remarks = textbox_6.Text.Trim(),
                        coach_id = GetJurisdictionName(Jurisdiction.Text) > 1 ? 0 : int.Parse(ReadConfigure.ReadParameter(@"\Login.txt")),
                        venue = ReadConfigure.ReadParameter(@"\venue.txt"),
                        type = GetTypeName(ReadConfigure.ReadParameter(@"\type.txt"))
                    };

                    DB dB = new DB();
                    dB.InsertUser(user);

                    this.Hide();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
