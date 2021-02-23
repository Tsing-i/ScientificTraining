//用户自定义
using Prism.Mvvm;
using SqlSugar;

namespace ModuleLogic.Entity
{
    //力量训练
    public class group_number_powers : BindableBase
    {
        private int _group_number_power_id;
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int group_number_power_id
        {
            get { return _group_number_power_id; }
            set => SetProperty(ref _group_number_power_id, value);
        }

        private int _group_number_power;
        public int group_number_power
        {
            get { return _group_number_power; }
            set => SetProperty(ref _group_number_power, value);
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
