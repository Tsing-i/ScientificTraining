using Prism.Events;

namespace UsingEventAggregator.Core
{

    //主窗体和各个模块之间的消息发送
    public class MessageSentEvent : PubSubEvent<string>
    {
        
    }

    //绿色小键盘和dashborad之间的命令发送
    public class DashboardSentEvent : PubSubEvent<string>
    {
        
    }

    //时间日期模块和dashborad之间的命令发送
    public class TimeSentEvent : PubSubEvent<string>
    {
        
    }

    //人员列表模块和基础数据机能数据之间的命令发送
    public class StaminaSentEvent : PubSubEvent<string>
    {
        
    }

    //发布任务后，更新日期区域命令
    public class UpdateSentEvent : PubSubEvent<string>
    {

    }


    class Program
    {
        static void Main(string[] args)
        {
            //
        }
    }
}
