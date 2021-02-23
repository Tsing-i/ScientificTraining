//用户自定义
using Prism.Mvvm;

namespace ModuleLogic.Entity
{
    public class inBody : BindableBase
    {
        public string createTime { set; get; } //体测报告创建时间
        public string venue { set; get; }//场馆地点
        public string device { set; get; }//数据来源，设备名称
        public string phone { set; get; } //手机号
        public string sex { set; get; }//性别
        public string idCard { set; get; }//身份证号

        /*下面式体测数据预留字段*/
        public string field_1 { set; get; }
        public string field_2 { set; get; }
        public string field_3 { set; get; }
        public string field_4 { set; get; }
        public string field_5 { set; get; }
        public string field_6 { set; get; }
        public string field_7 { set; get; }
        public string field_8 { set; get; }
        public string field_9 { set; get; }
        public string field_10 { set; get; }
        public string field_11 { set; get; }
        public string field_12 { set; get; }
        public string field_13 { set; get; }
        public string field_14 { set; get; }
        public string field_15 { set; get; }
    }
}
