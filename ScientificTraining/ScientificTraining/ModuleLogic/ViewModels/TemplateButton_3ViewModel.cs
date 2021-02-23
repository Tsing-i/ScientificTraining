//Prism框架
using Prism.Mvvm;
using Prism.Events;
using UsingEventAggregator.Core;

namespace ModuleLogic.ViewModels
{
    public class TemplateButton_3ViewModel : BindableBase
    {
        IEventAggregator _ea;

        #region 属性

        #endregion

        //构造函数
        public TemplateButton_3ViewModel(IEventAggregator ea)
        {
            _ea = ea;
        }

        public void SendMessage(string message)
        {
            _ea.GetEvent<DashboardSentEvent>().Publish(message);
        }

    }
}
