using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
//用户自定义
using ModuleLogic.ViewModels;
using ModuleLogic.Entity;

namespace ModuleLogic.Views
{
    public partial class HealthManagement : UserControl
    {
        private void NavigatePage(string adaptationArea, string navigatePath)
        {
            Task.Factory.StartNew(() =>
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    var VM = (HealthManagementViewModel)DataContext;
                    VM.Navigate(adaptationArea, navigatePath);
                }));
            });
        }

        public HealthManagement()
        {
            InitializeComponent();

            NavigatePage("TimeAreaContentRegion1", "TimeArea");
            NavigatePage("AthletesShowContentRegion", "AthletesShow");
        }

        //pdf
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (userLabel.Content == null)
            {
                PromptMessage popMessage = new PromptMessage();
                popMessage.messageLabel.Content = "请选择运动员...";
                popMessage.Show();
                Thread.Sleep(1500);
                popMessage.Close();

                return;
            }

            List<double> list = new List<double>();

            var line = ReadConfigure.ReadParameter(@"\instrument.txt");

            if (line == "体测仪")
            {
                list.Add(double.Parse(this.label2.Content.ToString()));//身高
                list.Add(double.Parse(this.label1.Content.ToString()));//年龄
                list.Add(double.Parse(this.label3.Content.ToString()));//体重
                list.Add(double.Parse(this.label4.Content.ToString()));//收缩压
                list.Add(double.Parse(this.label5.Content.ToString()));//舒张压
                list.Add(double.Parse(this.label6.Content.ToString()));//脉搏
                list.Add(double.Parse(this.label7.Content.ToString()));//细胞内液
                list.Add(double.Parse(this.label8.Content.ToString()));//建议每日摄取卡路里
                list.Add(double.Parse(this.label9.Content.ToString()));//除脂肪量（Kg）
                list.Add(double.Parse(this.label10.Content.ToString()));//肌肉量（Kg）
                list.Add(double.Parse(this.label11.Content.ToString()));//脂肪量（Kg）
                list.Add(double.Parse(this.label12.Content.ToString()));//基础代谢值
                list.Add(double.Parse(this.label13.Content.ToString()));//水分率（%）
                list.Add(double.Parse(this.label14.Content.ToString()));//水分含量（kg）
                list.Add(double.Parse(this.label15.Content.ToString()));//骨骼量（kg）
                list.Add(double.Parse(this.label16.Content.ToString()));//细胞外液（kg）
                list.Add(double.Parse(this.label17.Content.ToString()));//内脏等级（kg）
                list.Add(double.Parse(this.label18.Content.ToString()));//血氧
                list.Add(double.Parse(this.label19.Content.ToString()));//体温
                list.Add(double.Parse(this.label20.Content.ToString()));//腰臀比
                list.Add(double.Parse(this.label21.Content.ToString()));//腰围
                list.Add(double.Parse(this.label22.Content.ToString()));//臀围
                list.Add(double.Parse(this.label23.Content.ToString()));//体质指数
                list.Add(double.Parse(this.label24.Content.ToString()));//其他成份（kg）
            }
            else if (line == "手环与体脂秤")
            {
                list.Add(double.Parse(this.label25.Content.ToString()));//血氧（M/F）
                list.Add(double.Parse(this.label26.Content.ToString()));//身高（cm）
                list.Add(double.Parse(this.label27.Content.ToString()));//体重（kg）
                list.Add(double.Parse(this.label28.Content.ToString()));//年龄（岁）
                list.Add(double.Parse(this.label29.Content.ToString()));//体温（℃）
                list.Add(double.Parse(this.label30.Content.ToString()));//去掉脂肪身体重量（kg）
                list.Add(double.Parse(this.label31.Content.ToString()));//脂肪率（%）
                list.Add(double.Parse(this.label32.Content.ToString()));//皮下脂肪率（%）
                list.Add(double.Parse(this.label33.Content.ToString()));//内脏脂肪等级
                list.Add(double.Parse(this.label34.Content.ToString()));//身体水分（%）
                list.Add(double.Parse(this.label35.Content.ToString()));//骨骼肌率（%）
                list.Add(double.Parse(this.label36.Content.ToString()));//骨量（%）
                list.Add(double.Parse(this.label37.Content.ToString()));//基础代谢（Kcal）
                list.Add(double.Parse(this.label38.Content.ToString()));//心率

                list.Add(double.Parse(this.textBox39.Text.Trim()));//蛋白质（%）
                list.Add(double.Parse(this.textBox40.Text.Trim()));//血乳酸
                list.Add(double.Parse(this.textBox41.Text.Trim()));//磷酸肌酸
                list.Add(double.Parse(this.textBox42.Text.Trim()));//尿蛋白
                list.Add(double.Parse(this.textBox43.Text.Trim()));//血红蛋白
                list.Add(double.Parse(this.textBox44.Text.Trim()));//氧合肌红蛋白
            }
            else if(line == "inbody")
            {
                list.Add(double.Parse(this.label45.Content.ToString())); //inBody字段1
                list.Add(double.Parse(this.label46.Content.ToString())); //inBody字段2
                list.Add(double.Parse(this.label47.Content.ToString())); //inBody字段3
                list.Add(double.Parse(this.label48.Content.ToString())); //inBody字段4
                list.Add(double.Parse(this.label49.Content.ToString())); //inBody字段5
                list.Add(double.Parse(this.label50.Content.ToString())); //inBody字段6
                list.Add(double.Parse(this.label51.Content.ToString())); //inBody字段7
                list.Add(double.Parse(this.label52.Content.ToString())); //inBody字段8
                list.Add(double.Parse(this.label53.Content.ToString())); //inBody字段9
                list.Add(double.Parse(this.label54.Content.ToString())); //inBody字段10
                list.Add(double.Parse(this.label55.Content.ToString())); //inBody字段11
                list.Add(double.Parse(this.label56.Content.ToString())); //inBody字段12
                list.Add(double.Parse(this.label57.Content.ToString())); //inBody字段13
                list.Add(double.Parse(this.label58.Content.ToString())); //inBody字段14
                list.Add(double.Parse(this.label59.Content.ToString())); //inBody字段15
            }

            Table table = new Table(list, userLabel.Content.ToString());
            table.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            table.ShowDialog();
        }

        //机能数据
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (userLabel.Content != null)
            {
                DB dB = new DB();

                var userId = dB.GetUser(userLabel.Content.ToString()).user_id.ToString();
                dB.Insertfunctional_data(new functional_data()
                {
                    user_id = userId,
                    datetime = DateTime.Now,
                    blood_lactic_acid = textBox40.Text,
                    creatine_phosphate = textBox41.Text,
                    urine_protein = textBox42.Text,
                    hemoglobin = textBox43.Text,
                    oxymyoglobin = textBox44.Text
                });

                var model = (HealthManagementViewModel)DataContext;
                model.SendMessage(userId);
            }
            else
            {
                PromptMessage popMessage = new PromptMessage();
                popMessage.messageLabel.Content = "请选择运动员...";
                popMessage.Show();
                Thread.Sleep(1500);
                popMessage.Close();
            }
        }
    }
}
