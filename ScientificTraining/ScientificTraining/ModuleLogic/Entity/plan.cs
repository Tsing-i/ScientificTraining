using System;
//用户自定义
using Prism.Mvvm; 
using SqlSugar;

namespace ModuleLogic.Entity
{
    public class plan : BindableBase
    {
        private int _PlanId;
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int PlanId
        {
            get { return _PlanId; }
            set => SetProperty(ref _PlanId, value);
        }

        private DateTime _startTime;
        public DateTime startTime
        {
            get { return _startTime; }
            set => SetProperty(ref _startTime, value);
        }

        private DateTime _endTime;
        public DateTime endTime
        {
            get { return _endTime; }
            set => SetProperty(ref _endTime, value);
        }

        private int _coachId;
        public int coachId
        {
            get { return _coachId; }
            set => SetProperty(ref _coachId, value);
        }

        private int _playerId;
        public int playerId
        {
            get { return _playerId; }
            set => SetProperty(ref _playerId, value);
        }

        private string _tableId;
        public string tableId
        {
            get { return _tableId; }
            set => SetProperty(ref _tableId, value);
        }

        private string _actionId;
        public string actionId
        {
            get { return _actionId; }
            set => SetProperty(ref _actionId, value);
        }

        private string _group_number;
        public string group_number
        {
            get { return _group_number; }
            set => SetProperty(ref _group_number, value);
        }

        private string _train_actionId;
        public string train_actionId
        {
            get { return _train_actionId; }
            set => SetProperty(ref _train_actionId, value);
        }

        private string _tablePowerId;
        public string tablePowerId
        {
            get { return _tablePowerId; }
            set => SetProperty(ref _tablePowerId, value);
        }

        private string _group_number_power;
        public string group_number_power
        {
            get { return _group_number_power; }
            set => SetProperty(ref _group_number_power, value);
        }

        private string _frequency;
        public string frequency
        {
            get { return _frequency; }
            set => SetProperty(ref _frequency, value);
        }

        private string _voice;
        public string voice
        {
            get { return _voice; }
            set => SetProperty(ref _voice, value);
        }

        private string _text_content;
        public string text_content
        {
            get { return _text_content; }
            set => SetProperty(ref _text_content, value);
        }

        private string _text_content_android;
        public string text_content_android
        {
            get { return _text_content_android; }
            set => SetProperty(ref _text_content_android, value);
        }
    }

}
