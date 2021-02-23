//Prism框架
using Prism.Ioc;
using Prism.Modularity;
//用户自定义
using ModuleLogic.Views;


namespace ModuleLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //
        }
    }

    public class ModuleLogicModule : IModule
    {

        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        //注册模块
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //(1)“视频管理”页面
            containerRegistry.RegisterForNavigation<ViewVideoManagement>();
            //(2)“人员管理”页面
            containerRegistry.RegisterForNavigation<ViewPersonnelManagement>();
            //(3)“营养管理”页面
            containerRegistry.RegisterForNavigation<ViewHealthManagement1>();
            //(4)“健康管理基础数据”页面  
            containerRegistry.RegisterForNavigation<HealthManagement>();
            //(5)“训练课程”页面
            containerRegistry.RegisterForNavigation<TrainingCourses>();
            //(6)“日期时间”页面
            containerRegistry.RegisterForNavigation<TimeArea>();
            //(7)“键盘模板”页面
            containerRegistry.RegisterForNavigation<KeyboardTemplate>();
            //(8)“教练所属运动员”页面
            containerRegistry.RegisterForNavigation<AthletesShow>();
           
        }
    }
}
