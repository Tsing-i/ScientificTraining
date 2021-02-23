//用户自定义
using Prism.Mvvm;
using SqlSugar;

namespace ModuleLogic.Entity
{
    //用户权限-运动员，教练员，领队......
    public class roles : BindableBase
    {
        private int _id;
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id
        {
            get { return _id; }
            set => SetProperty(ref _id, value);
        }

        private int _limits;
        public int limits
        {
            get { return _limits; }
            set => SetProperty(ref _limits, value);
        }

        private string _limitsName;
        public string limitsName
        {
            get { return _limitsName; }
            set => SetProperty(ref _limitsName, value);
        }
    }
}
