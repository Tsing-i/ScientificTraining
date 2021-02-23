using System;
//用户自定义
using Prism.Mvvm;


namespace ModuleLogic.Entity
{
    public class functional_data : BindableBase
    {
        private string _user_id;
        public string user_id
        {
            get { return _user_id; }
            set => SetProperty(ref _user_id, value);
        }

        private DateTime _datetime;
        public DateTime datetime
        {
            get { return _datetime; }
            set => SetProperty(ref _datetime, value);
        }

        private string _blood_lactic_acid;
        public string blood_lactic_acid
        {
            get { return _blood_lactic_acid; }
            set => SetProperty(ref _blood_lactic_acid, value);
        }

        private string _creatine_phosphate;
        public string creatine_phosphate
        {
            get { return _creatine_phosphate; }
            set => SetProperty(ref _creatine_phosphate, value);
        }

        private string _urine_protein;
        public string urine_protein
        {
            get { return _urine_protein; }
            set => SetProperty(ref _urine_protein, value);
        }

        private string _hemoglobin;
        public string hemoglobin
        {
            get { return _hemoglobin; }
            set => SetProperty(ref _hemoglobin, value);
        }

        private string _oxymyoglobin;
        public string oxymyoglobin
        {
            get { return _oxymyoglobin; }
            set => SetProperty(ref _oxymyoglobin, value);
        }
    }
}
