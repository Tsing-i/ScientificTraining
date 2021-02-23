using System.Threading;
//Prsim框架
using Prism.Commands;
using Prism.Mvvm;
//用户自定义
using ModuleLogic.Views;

namespace ModuleLogic.ViewModels
{
    public class KeyboardTemplateViewModel : BindableBase
    {
        #region 命令

        public System.Windows.Input.ICommand PopupAddTrainingPlanContent
        {
            get
            {
                return new DelegateCommand<string>((str) =>
                {
                    PromptMessage promptMessage = new PromptMessage();
                    promptMessage.messageLabel.Content = "暂不支持...";
                    promptMessage.Show();
                    Thread.Sleep(2000);
                    promptMessage.Close();

                });
            }
        }

        #endregion


        //构造函数
        public KeyboardTemplateViewModel()
        {
         
        }
    }

}
