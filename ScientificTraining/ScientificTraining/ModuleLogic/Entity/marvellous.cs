//用户自定义
using Prism.Mvvm;
using SqlSugar;

namespace ModuleLogic.Entity
{
    //精彩视频
    public class marvellous : BindableBase
    {
        private int _id;
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id
        {
            get { return _id; }
            set => SetProperty(ref _id, value);
        }

        private int _VideoId;
        public int VideoId
        {
            get { return _VideoId; }
            set => SetProperty(ref _VideoId, value);
        }

        private int _user_id;
        public int user_id
        {
            get { return _user_id; }
            set => SetProperty(ref _user_id, value);
        }
    }
}
