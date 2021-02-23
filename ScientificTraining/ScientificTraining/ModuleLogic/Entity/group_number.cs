//用户自定义
using Prism.Mvvm;
using SqlSugar;

namespace ModuleLogic.Entity
{
    //专项训练
    public class group_numbers : BindableBase
    {
        private string _group_number_id;
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public string group_number_id
        {
            get { return _group_number_id; }
            set => SetProperty(ref _group_number_id, value);
        }

        private string _group_number;
        public string group_number
        {
            get { return _group_number; }
            set => SetProperty(ref _group_number, value);
        }

        private string _Type;
        public string Type
        {
            get { return _Type; }
            set => SetProperty(ref _Type, value);
        }

        private string _coachId;
        public string coachId
        {
            get { return _coachId; }
            set => SetProperty(ref _coachId, value);
        }
    }
}
