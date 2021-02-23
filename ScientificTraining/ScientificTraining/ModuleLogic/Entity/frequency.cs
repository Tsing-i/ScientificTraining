//用户自定义
using Prism.Mvvm;

namespace ModuleLogic.Entity
{
    //力量训练
    public class frequencys : BindableBase
    {
        private int _frequency_id;
        public int frequency_id
        {
            get { return _frequency_id; }
            set => SetProperty(ref _frequency_id, value);
        }

        private int _frequency;
        public int frequency
        {
            get { return _frequency; }
            set => SetProperty(ref _frequency, value);
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
