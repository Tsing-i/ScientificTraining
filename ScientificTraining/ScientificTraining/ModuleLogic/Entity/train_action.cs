//用户自定义
using Prism.Mvvm;
using SqlSugar;

namespace ModuleLogic.Entity
{
    //专项训练动作
    public class train_action : BindableBase
    {
        private int _train_actionId;
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int train_actionId
        {
            get { return _train_actionId; }
            set => SetProperty(ref _train_actionId, value);
        }

        private string _train_actionName;
        public string train_actionName
        {
            get { return _train_actionName; }
            set => SetProperty(ref _train_actionName, value);
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
