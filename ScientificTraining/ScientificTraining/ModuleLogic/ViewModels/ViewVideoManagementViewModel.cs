//Prsim框架
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;

namespace ModuleLogic.ViewModels
{
    public class ViewVideoManagementViewModel : BindableBase, INavigationAware
    {
        #region 属性

        IEventAggregator _ea;

        #endregion

        //构造函数
        public ViewVideoManagementViewModel(IEventAggregator ea)
        {
            _ea = ea;
            
        }

        #region 接口重写

        public void OnNavigatedTo(NavigationContext navigationContext)
        {

        }

        public bool IsNavigationTarget(NavigationContext navigationContext) => true;

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        #endregion
    }
}
