using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;

namespace ModuleLogic.Views
{
    public partial class DesignatedTraining : Window
    {
        public DesignatedTraining(string param)
        {
            InitializeComponent();

            this.border.MouseLeftButtonDown += (o, e) => { DragMove(); };

            Task.Factory.StartNew(() =>
            {
               this.Dispatcher.Invoke(() =>
               {
                   List<string> Digitals = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                   for (int i = 0; i < Digitals.Count; i++)
                   {
                       var template = new TemplateButton_3(param);
                       template.templateButtonContent.Content = Digitals[i];
                       DigitalContainer.Children.Add(template);
                   }

                   List<string> Letterls = new List<string>() { "A", "B", "C", "D", "~", "X" };
                   for (int i = 0; i < Letterls.Count; i++)
                   {
                       var template = new TemplateButton_3(param);
                       template.templateButtonContent.Content = Letterls[i];
                       LetterlContainer.Children.Add(template);
                   }

                   var space = new TemplateButton_3(param);
                   space.templateButtonContent.Width = 70;
                   space.templateButtonContent.Content = "Space";
                   LetterlContainer.Children.Add(space);
                   var enter = new TemplateButton_3(param);
                   enter.templateButtonContent.Width = 70;
                   enter.templateButtonContent.Content = "Enter";
                   LetterlContainer.Children.Add(enter);

                   string type = ReadConfigure.ReadParameter(@"\type.txt");

                   DB dB = new DB();

                   switch (type)
                   {
                       case "蹦床":
                           {
                               var list2 = dB.GetTablePowers(4);//这是蹦床专用
                            for (int i = 0; i < list2.Count; i++)
                               {
                                   var template = new TemplateButton_3(param);
                                   template.templateButtonContent.Width = 90;
                                   template.templateButtonContent.Content = list2[i].tablePowerName;
                                   PowerWordsContainer.Children.Add(template);
                               }

                               var list4 = dB.GetTtrain_actions(4);//这是蹦床专用
                            for (int i = 0; i < list4.Count; i++)
                               {
                                   var template = new TemplateButton_3(param);
                                   template.templateButtonContent.Width = 70;
                                   template.templateButtonContent.Content = list4[i].train_actionName;
                                   WordsContainer.Children.Add(template);
                               }
                           }
                           break;
                       case "跳水":
                           {
                               var list1 = dB.GetTablePowers(1);//这是跳水专用
                            for (int i = 0; i < list1.Count; i++)
                               {
                                   var template = new TemplateButton_3(param);
                                   template.templateButtonContent.Width = 90;
                                   template.templateButtonContent.Content = list1[i].tablePowerName;
                                   PowerWordsContainer.Children.Add(template);
                               }

                               var list3 = dB.GetTtrain_actions(1);//这是跳水专用
                            for (int i = 0; i < list3.Count; i++)
                               {
                                   var template = new TemplateButton_3(param);
                                   template.templateButtonContent.Width = 70;
                                   template.templateButtonContent.Content = list3[i].train_actionName;
                                   WordsContainer.Children.Add(template);
                               }
                           }
                           break;
                       case "体操":
                           break;
                       case "田径":
                           break;
                       default:
                           break;
                   }
               });
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e) => this.Close();

    }
}
