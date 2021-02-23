//用户自定义
using Prism.Mvvm;

namespace ModuleLogic.Entity
{
    //新版体测仪器实体-用于访问数据库
    public class Instrument : BindableBase
    {
        private string _phone; //唯一标识，用于反查用户的体测报告
        public string phone
        {
            get { return _phone; }
            set { SetProperty(ref _phone, value); }
        }

        private string _sex; //性别
        public string sex
        {
            get { return _createTime; }
            set { SetProperty(ref _createTime, value); }
        }

        private string _createTime; //体测报告写入数据库的时间
        public string createTime
        {
            get { return _createTime; }
            set { SetProperty(ref _createTime, value); }
        }

        private string _sbp;
        public string sbp
        {
            get { return _sbp; }
            set { SetProperty(ref _sbp, value); }
        }

        private string _dbp;
        public string dbp
        {
            get { return _dbp; }
            set { SetProperty(ref _dbp, value); }
        }

        private string _pulse;
        public string pulse
        {
            get { return _pulse; }
            set { SetProperty(ref _pulse, value); }
        }

        private string _fic;
        public string fic
        {
            get { return _fic; }
            set { SetProperty(ref _fic, value); }
        }

        private string _basicMetabolismScope;
        public string basicMetabolismScope
        {
            get { return _basicMetabolismScope; }
            set { SetProperty(ref _basicMetabolismScope, value); }
        }

        private string _exceptFat;
        public string exceptFat
        {
            get { return _exceptFat; }
            set { SetProperty(ref _exceptFat, value); }
        }

        private string _muscle;
        public string muscle
        {
            get { return _muscle; }
            set { SetProperty(ref _muscle, value); }
        }

        private string _fat;
        public string fat
        {
            get { return _fat; }
            set { SetProperty(ref _fat, value); }
        }

        private string _height;
        public string height
        {
            get { return _height; }
            set { SetProperty(ref _height, value); }
        }

        private string _basicMetabolism;
        public string basicMetabolism
        {
            get { return _basicMetabolism; }
            set { SetProperty(ref _basicMetabolism, value); }
        }

        private string _otherComponent;
        public string otherComponent
        {
            get { return _otherComponent; }
            set { SetProperty(ref _otherComponent, value); }
        }

        private string _waterRate;
        public string waterRate
        {
            get { return _waterRate; }
            set { SetProperty(ref _waterRate, value); }
        }

        private string _water;
        public string water
        {
            get { return _water; }
            set { SetProperty(ref _water, value); }
        }

        private string _bmc;
        public string bmc
        {
            get { return _bmc; }
            set { SetProperty(ref _bmc, value); }
        }

        private string _foc;
        public string foc
        {
            get { return _foc; }
            set { SetProperty(ref _foc, value); }
        }

        private string _age;
        public string age
        {
            get { return _age; }
            set { SetProperty(ref _age, value); }
        }

        private string _viscera;
        public string viscera
        {
            get { return _viscera; }
            set { SetProperty(ref _viscera, value); }
        }

        private string _oxygen;
        public string oxygen
        {
            get { return _oxygen; }
            set { SetProperty(ref _oxygen, value); }
        }

        private string _tiwen;
        public string tiwen
        {
            get { return _tiwen; }
            set { SetProperty(ref _tiwen, value); }
        }

        private string _Yaotunbi;
        public string Yaotunbi
        {
            get { return _Yaotunbi; }
            set { SetProperty(ref _Yaotunbi, value); }
        }

        private string _yao;
        public string yao
        {
            get { return _yao; }
            set { SetProperty(ref _yao, value); }
        }

        private string _tun;
        public string tun
        {
            get { return _tun; }
            set { SetProperty(ref _tun, value); }
        }

        private string _weight;
        public string weight
        {
            get { return _weight; }
            set { SetProperty(ref _weight, value); }
        }

        private string _Bmi;
        public string Bmi
        {
            get { return _Bmi; }
            set { SetProperty(ref _Bmi, value); }
        }

        private string _device;
        public string device
        {
            get { return _device; }
            set { SetProperty(ref _device, value); }
        }
    }
}
