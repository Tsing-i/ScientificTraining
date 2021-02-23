using System;
//用户自定义
using Prism.Mvvm;
using SqlSugar;
namespace ModuleLogic.Entity
{
    public class video : BindableBase
    {
        private int _id;
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id
        {
            get { return _id; }
            set => SetProperty(ref _id, value);
        }

        private string _VideoName;
        public string VideoName
        {
            get { return _VideoName; }
            set => SetProperty(ref _VideoName, value);
        }

        private DateTime _UpLoadVideoTime;
        public DateTime UpLoadVideoTime
        {
            get { return _UpLoadVideoTime; }
            set => SetProperty(ref _UpLoadVideoTime, value);
        }

        private string _VideoDuration;
        public string VideoDuration
        {
            get { return _VideoDuration; }
            set => SetProperty(ref _VideoDuration, value);
        }

        private double _VideoSize;
        public double VideoSize
        {
            get { return _VideoSize; }
            set => SetProperty(ref _VideoSize, value);
        }

        private string _Thumbnail;
        public string Thumbnail
        {
            get { return _Thumbnail; }
            set => SetProperty(ref _Thumbnail, value);
        }

        private string _OSS;
        public string OSS
        {
            get { return _OSS; }
            set => SetProperty(ref _OSS, value);
        }

        private string _KeyWord;
        public string KeyWord
        {
            get { return _KeyWord; }
            set => SetProperty(ref _KeyWord, value);
        }

        private int _PlayerId;
        public int PlayerId
        {
            get { return _PlayerId; }
            set => SetProperty(ref _PlayerId, value);
        }

        private int _isCoachUpload;
        public int isCoachUpload
        {
            get { return _isCoachUpload; }
            set => SetProperty(ref _isCoachUpload, value);
        }

        private int _coachId;
        public int coachId
        {
            get { return _coachId; }
            set => SetProperty(ref _coachId, value);
        }

    }
}
