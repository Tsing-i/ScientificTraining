//用户自定义
using Prism.Mvvm;
using SqlSugar;

namespace ModuleLogic.Entity
{
    public class images : BindableBase
    {
        private int _imageId;
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int imageId
        {
            get { return _imageId; }
            set => SetProperty(ref _imageId, value);
        }

        private string _imageOss;
        public string imageOss
        {
            get { return _imageOss; }
            set => SetProperty(ref _imageOss, value);
        }
    }
}
