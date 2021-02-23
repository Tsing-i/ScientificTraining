//用户自定义
using Prism.Mvvm;
using SqlSugar;

namespace ModuleLogic.Entity
{

    //力量训练
    public class tablepower : BindableBase
    {
        private int _tablePowerId;
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int tablePowerId
        {
            get { return _tablePowerId; }
            set => SetProperty(ref _tablePowerId, value);
        }

        private string _tablePowerName;
        public string tablePowerName
        {
            get { return _tablePowerName; }
            set => SetProperty(ref _tablePowerName, value);
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
