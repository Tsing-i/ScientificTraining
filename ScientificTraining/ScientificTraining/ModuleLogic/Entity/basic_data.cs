//用户自定义
using Prism.Mvvm;
using System;

namespace ModuleLogic.Entity
{
    //运动员体测基础数据
    public class basic_data : BindableBase
    {
        private string _user_id;
        public string user_id
        {
            get { return _user_id; }
            set => SetProperty(ref _user_id, value);
        }

        private DateTime _time;
        public DateTime time
        {
            get { return _time; }
            set => SetProperty(ref _time, value);
        }

        private string _blood_oxygen;
        public string blood_oxygen
        {
            get { return _blood_oxygen; }
            set => SetProperty(ref _blood_oxygen, value);
        }

        private int _height;
        public int height
        {
            get { return _height; }
            set => SetProperty(ref _height, value);
        }

        private string _weight;
        public string weight
        {
            get { return _weight; }
            set => SetProperty(ref _weight, value);
        }

        private int _age;
        public int age
        {
            get { return _age; }
            set => SetProperty(ref _age, value);
        }

        private string _temperature;
        public string temperature
        {
            get { return _temperature; }
            set => SetProperty(ref _temperature, value);
        }

        private string _bmi;
        public string bmi
        {
            get { return _bmi; }
            set => SetProperty(ref _bmi, value);
        }

        private string _fat_percentage;
        public string fat_percentage
        {
            get { return _fat_percentage; }
            set => SetProperty(ref _fat_percentage, value);
        }

        private string _visceral_fat_grade;
        public string visceral_fat_grade
        {
            get { return _visceral_fat_grade; }
            set => SetProperty(ref _visceral_fat_grade, value);
        }

        private string _body_moisture;
        public string body_moisture
        {
            get { return _body_moisture; }
            set => SetProperty(ref _body_moisture, value);
        }

        private string _skeletal_muscle_rate;
        public string skeletal_muscle_rate
        {
            get { return _skeletal_muscle_rate; }
            set => SetProperty(ref _skeletal_muscle_rate, value);
        }

        private string _bone_mass;
        public string bone_mass
        {
            get { return _bone_mass; }
            set => SetProperty(ref _bone_mass, value);
        }

        private string _basal_metabolism;
        public string basal_metabolism
        {
            get { return _basal_metabolism; }
            set => SetProperty(ref _basal_metabolism, value);
        }

        private string _protein;
        public string protein
        {
            get { return _protein; }
            set => SetProperty(ref _protein, value);
        }

        private string _heart_rate;
        public string heart_rate
        {
            get { return _heart_rate; }
            set => SetProperty(ref _heart_rate, value);
        }

        private string _subcutaneous_fat_rate;
        public string subcutaneous_fat_rate
        {
            get { return _subcutaneous_fat_rate; }
            set => SetProperty(ref _subcutaneous_fat_rate, value);
        }
        
    }
}
