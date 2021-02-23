//用户自定义
using Prism.Mvvm;
using SqlSugar;

namespace ModuleLogic.Entity
{
    //App总类型(例如跳水,田径等)
    public class apptype : BindableBase
    {
        private int _typeId;
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int typeId
        {
            get { return _typeId; }
            set => SetProperty(ref _typeId, value);
        }

        private string _typeName;
        public string typeName
        {
            get { return _typeName; }
            set => SetProperty(ref _typeName, value);
        }
    }
}
