//用户自定义
using Prism.Mvvm;
using SqlSugar;

namespace ModuleLogic.Entity
{
    //专项训练
    public class table : BindableBase
    {
        private int _tableId;
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int tableId
        {
            get { return _tableId; }
            set => SetProperty(ref _tableId, value);
        }

        private string _tableName;
        public string tableName
        {
            get { return _tableName; }
            set => SetProperty(ref _tableName, value);
        }

        private int _Type;
        public int Type
        {
            get { return _Type; }
            set => SetProperty(ref _Type, value);
        }

        private int _coachId;
        public int coachId
        {
            get { return _coachId; }
            set => SetProperty(ref _coachId, value);
        }
    }
}
