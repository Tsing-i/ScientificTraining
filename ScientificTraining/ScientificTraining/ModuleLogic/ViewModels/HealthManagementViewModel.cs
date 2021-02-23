//Prsim框架
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
//系统
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
//用户自定义
using UsingEventAggregator.Core;
using ModuleLogic.Entity;

namespace ModuleLogic.ViewModels
{
    public class HealthManagementViewModel : BindableBase
    {
        IEventAggregator _ea;
        private readonly IRegionManager _regionManager;


        #region  inBody

        //01
        private string _inbody_field_1 = "0";
        public string inbody_field_1
        {
            get { return _inbody_field_1; }
            set { SetProperty(ref _inbody_field_1, value); }
        }

        private string _inbody_field_1_lately = "0";
        public string inbody_field_1_lately
        {
            get { return _inbody_field_1_lately; }
            set { SetProperty(ref _inbody_field_1_lately, value); }
        }

        private string _inbody_field_1_trend = "0";
        public string inbody_field_1_trend
        {
            get { return _inbody_field_1_trend; }
            set { SetProperty(ref _inbody_field_1_trend, value); }
        }

        //02
        private string _inbody_field_2 = "0";
        public string inbody_field_2
        {
            get { return _inbody_field_2; }
            set { SetProperty(ref _inbody_field_2, value); }
        }

        private string _inbody_field_2_lately = "0";
        public string inbody_field_2_lately
        {
            get { return _inbody_field_2_lately; }
            set { SetProperty(ref _inbody_field_2_lately, value); }
        }

        private string _inbody_field_2_trend = "0";
        public string inbody_field_2_trend
        {
            get { return _inbody_field_2_trend; }
            set { SetProperty(ref _inbody_field_2_trend, value); }
        }

        //03
        private string _inbody_field_3 = "0";
        public string inbody_field_3
        {
            get { return _inbody_field_3; }
            set { SetProperty(ref _inbody_field_3, value); }
        }

        private string _inbody_field_3_lately = "0";
        public string inbody_field_3_lately
        {
            get { return _inbody_field_3_lately; }
            set { SetProperty(ref _inbody_field_3_lately, value); }
        }

        private string _inbody_field_3_trend = "0";
        public string inbody_field_3_trend
        {
            get { return _inbody_field_3_trend; }
            set { SetProperty(ref _inbody_field_3_trend, value); }
        }

        //04
        private string _inbody_field_4 = "0";
        public string inbody_field_4
        {
            get { return _inbody_field_4; }
            set { SetProperty(ref _inbody_field_4, value); }
        }

        private string _inbody_field_4_lately = "0";
        public string inbody_field_4_lately
        {
            get { return _inbody_field_4_lately; }
            set { SetProperty(ref _inbody_field_4_lately, value); }
        }

        private string _inbody_field_4_trend = "0";
        public string inbody_field_4_trend
        {
            get { return _inbody_field_4_trend; }
            set { SetProperty(ref _inbody_field_4_trend, value); }
        }

        //05
        private string _inbody_field_5 = "0";
        public string inbody_field_5
        {
            get { return _inbody_field_5; }
            set { SetProperty(ref _inbody_field_5, value); }
        }

        private string _inbody_field_5_lately = "0";
        public string inbody_field_5_lately
        {
            get { return _inbody_field_5_lately; }
            set { SetProperty(ref _inbody_field_5_lately, value); }
        }

        private string _inbody_field_5_trend = "0";
        public string inbody_field_5_trend
        {
            get { return _inbody_field_5_trend; }
            set { SetProperty(ref _inbody_field_5_trend, value); }
        }

        //06
        private string _inbody_field_6 = "0";
        public string inbody_field_6
        {
            get { return _inbody_field_6; }
            set { SetProperty(ref _inbody_field_6, value); }
        }

        private string _inbody_field_6_lately = "0";
        public string inbody_field_6_lately
        {
            get { return _inbody_field_6_lately; }
            set { SetProperty(ref _inbody_field_6_lately, value); }
        }

        private string _inbody_field_6_trend = "0";
        public string inbody_field_6_trend
        {
            get { return _inbody_field_6_trend; }
            set { SetProperty(ref _inbody_field_6_trend, value); }
        }

        //07
        private string _inbody_field_7 = "0";
        public string inbody_field_7
        {
            get { return _inbody_field_7; }
            set { SetProperty(ref _inbody_field_7, value); }
        }

        private string _inbody_field_7_lately = "0";
        public string inbody_field_7_lately
        {
            get { return _inbody_field_7_lately; }
            set { SetProperty(ref _inbody_field_7_lately, value); }
        }

        private string _inbody_field_7_trend = "0";
        public string inbody_field_7_trend
        {
            get { return _inbody_field_7_trend; }
            set { SetProperty(ref _inbody_field_7_trend, value); }
        }

        //08
        private string _inbody_field_8 = "0";
        public string inbody_field_8
        {
            get { return _inbody_field_8; }
            set { SetProperty(ref _inbody_field_8, value); }
        }

        private string _inbody_field_8_lately = "0";
        public string inbody_field_8_lately
        {
            get { return _inbody_field_8_lately; }
            set { SetProperty(ref _inbody_field_8_lately, value); }
        }

        private string _inbody_field_8_trend = "0";
        public string inbody_field_8_trend
        {
            get { return _inbody_field_8_trend; }
            set { SetProperty(ref _inbody_field_8_trend, value); }
        }

        //09
        private string _inbody_field_9 = "0";
        public string inbody_field_9
        {
            get { return _inbody_field_9; }
            set { SetProperty(ref _inbody_field_9, value); }
        }

        private string _inbody_field_9_lately = "0";
        public string inbody_field_9_lately
        {
            get { return _inbody_field_9_lately; }
            set { SetProperty(ref _inbody_field_9_lately, value); }
        }

        private string _inbody_field_9_trend = "0";
        public string inbody_field_9_trend
        {
            get { return _inbody_field_9_trend; }
            set { SetProperty(ref _inbody_field_9_trend, value); }
        }

        //10
        private string _inbody_field_10 = "0";
        public string inbody_field_10
        {
            get { return _inbody_field_10; }
            set { SetProperty(ref _inbody_field_10, value); }
        }

        private string _inbody_field_10_lately = "0";
        public string inbody_field_10_lately
        {
            get { return _inbody_field_10_lately; }
            set { SetProperty(ref _inbody_field_10_lately, value); }
        }

        private string _inbody_field_10_trend = "0";
        public string inbody_field_10_trend
        {
            get { return _inbody_field_10_trend; }
            set { SetProperty(ref _inbody_field_10_trend, value); }
        }

        //11
        private string _inbody_field_11 = "0";
        public string inbody_field_11
        {
            get { return _inbody_field_11; }
            set { SetProperty(ref _inbody_field_11, value); }
        }

        private string _inbody_field_11_lately = "0";
        public string inbody_field_11_lately
        {
            get { return _inbody_field_11_lately; }
            set { SetProperty(ref _inbody_field_11_lately, value); }
        }

        private string _inbody_field_11_trend = "0";
        public string inbody_field_11_trend
        {
            get { return _inbody_field_11_trend; }
            set { SetProperty(ref _inbody_field_11_trend, value); }
        }

        //12
        private string _inbody_field_12 = "0";
        public string inbody_field_12
        {
            get { return _inbody_field_12; }
            set { SetProperty(ref _inbody_field_12, value); }
        }

        private string _inbody_field_12_lately = "0";
        public string inbody_field_12_lately
        {
            get { return _inbody_field_12_lately; }
            set { SetProperty(ref _inbody_field_12_lately, value); }
        }

        private string _inbody_field_12_trend = "0";
        public string inbody_field_12_trend
        {
            get { return _inbody_field_12_trend; }
            set { SetProperty(ref _inbody_field_12_trend, value); }
        }

        //13
        private string _inbody_field_13 = "0";
        public string inbody_field_13
        {
            get { return _inbody_field_13; }
            set { SetProperty(ref _inbody_field_13, value); }
        }

        private string _inbody_field_13_lately = "0";
        public string inbody_field_13_lately
        {
            get { return _inbody_field_13_lately; }
            set { SetProperty(ref _inbody_field_13_lately, value); }
        }

        private string _inbody_field_13_trend = "0";
        public string inbody_field_13_trend
        {
            get { return _inbody_field_13_trend; }
            set { SetProperty(ref _inbody_field_13_trend, value); }
        }

        //14
        private string _inbody_field_14 = "0";
        public string inbody_field_14
        {
            get { return _inbody_field_14; }
            set { SetProperty(ref _inbody_field_14, value); }
        }

        private string _inbody_field_14_lately = "0";
        public string inbody_field_14_lately
        {
            get { return _inbody_field_14_lately; }
            set { SetProperty(ref _inbody_field_14_lately, value); }
        }

        private string _inbody_field_14_trend = "0";
        public string inbody_field_14_trend
        {
            get { return _inbody_field_14_trend; }
            set { SetProperty(ref _inbody_field_14_trend, value); }
        }

        //15
        private string _inbody_field_15 = "0";
        public string inbody_field_15
        {
            get { return _inbody_field_15; }
            set { SetProperty(ref _inbody_field_15, value); }
        }

        private string _inbody_field_15_lately = "0";
        public string inbody_field_15_lately
        {
            get { return _inbody_field_15_lately; }
            set { SetProperty(ref _inbody_field_15_lately, value); }
        }

        private string _inbody_field_15_trend = "0";
        public string inbody_field_15_trend
        {
            get { return _inbody_field_15_trend; }
            set { SetProperty(ref _inbody_field_15_trend, value); }
        }

        #endregion


        #region  体测仪设备属性

        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set { SetProperty(ref _UserName, value); }
        }

        private string _Wrap4_Visibility;
        public string Wrap4_Visibility
        {
            get { return _Wrap4_Visibility; }
            set { SetProperty(ref _Wrap4_Visibility, value); }
        }

        private string _Wrap3_Visibility;
        public string Wrap3_Visibility
        {
            get { return _Wrap3_Visibility; }
            set { SetProperty(ref _Wrap3_Visibility, value); }
        }

        private string _Wrap2_Visibility;
        public string Wrap2_Visibility
        {
            get { return _Wrap2_Visibility; }
            set { SetProperty(ref _Wrap2_Visibility, value); }
        }

        private string _Wrap1_Visibility;
        public string Wrap1_Visibility
        {
            get { return _Wrap1_Visibility; }
            set { SetProperty(ref _Wrap1_Visibility, value); }
        }


        private string _sbp = "0";
        public string sbp
        {
            get { return _sbp; }
            set { SetProperty(ref _sbp, value); }
        }

        private string _dbp = "0";
        public string dbp
        {
            get { return _dbp; }
            set { SetProperty(ref _dbp, value); }
        }

        private string _pulse = "0";
        public string pulse
        {
            get { return _pulse; }
            set { SetProperty(ref _pulse, value); }
        }

        private string _fic = "0";
        public string fic
        {
            get { return _fic; }
            set { SetProperty(ref _fic, value); }
        }

        private string _basicMetabolismScope = "0";
        public string basicMetabolismScope
        {
            get { return _basicMetabolismScope; }
            set { SetProperty(ref _basicMetabolismScope, value); }
        }

        private string _exceptFat = "0";
        public string exceptFat
        {
            get { return _exceptFat; }
            set { SetProperty(ref _exceptFat, value); }
        }

        private string _muscle = "0";
        public string muscle
        {
            get { return _muscle; }
            set { SetProperty(ref _muscle, value); }
        }

        private string _fat = "0";
        public string fat
        {
            get { return _fat; }
            set { SetProperty(ref _fat, value); }
        }

        private string _basicMetabolism = "0";
        public string basicMetabolism
        {
            get { return _basicMetabolism; }
            set { SetProperty(ref _basicMetabolism, value); }
        }

        private string _otherComponent = "0";
        public string otherComponent
        {
            get { return _otherComponent; }
            set { SetProperty(ref _otherComponent, value); }
        }

        private string _waterRate = "0";
        public string waterRate
        {
            get { return _waterRate; }
            set { SetProperty(ref _waterRate, value); }
        }

        private string _water = "0";
        public string water
        {
            get { return _water; }
            set { SetProperty(ref _water, value); }
        }

        private string _bmc = "0";
        public string bmc
        {
            get { return _bmc; }
            set { SetProperty(ref _bmc, value); }
        }

        private string _foc = "0";
        public string foc
        {
            get { return _foc; }
            set { SetProperty(ref _foc, value); }
        }

        private string _viscera = "0";
        public string viscera
        {
            get { return _viscera; }
            set { SetProperty(ref _viscera, value); }
        }

        private string _oxygen = "0";
        public string oxygen
        {
            get { return _oxygen; }
            set { SetProperty(ref _oxygen, value); }
        }

        private string _tiwen = "0";
        public string tiwen
        {
            get { return _tiwen; }
            set { SetProperty(ref _tiwen, value); }
        }

        private string _Yaotunbi = "0";
        public string Yaotunbi
        {
            get { return _Yaotunbi; }
            set { SetProperty(ref _Yaotunbi, value); }
        }

        private string _yao = "0";
        public string yao
        {
            get { return _yao; }
            set { SetProperty(ref _yao, value); }
        }

        private string _tun = "0";
        public string tun
        {
            get { return _tun; }
            set { SetProperty(ref _tun, value); }
        }

        private string _Bmi = "0";
        public string Bmi
        {
            get { return _Bmi; }
            set { SetProperty(ref _Bmi, value); }
        }

        private string _physical_age_lately = "0";
        public string physical_age_lately
        {
            get { return _physical_age_lately; }
            set { SetProperty(ref _physical_age_lately, value); }
        }

        private string _physical_age_trend = "0";
        public string physical_age_trend
        {
            get { return _physical_age_trend; }
            set { SetProperty(ref _physical_age_trend, value); }
        }

        private string _physical_height_lately = "0";
        public string physical_height_lately
        {
            get { return _physical_height_lately; }
            set { SetProperty(ref _physical_height_lately, value); }
        }

        private string _physical_height_trend = "0";
        public string physical_height_trend
        {
            get { return _physical_height_trend; }
            set { SetProperty(ref _physical_height_trend, value); }
        }

        private string _physical_weight_lately = "0";
        public string physical_weight_lately
        {
            get { return _physical_weight_lately; }
            set { SetProperty(ref _physical_weight_lately, value); }
        }

        private string _physical_weight_trend = "0";
        public string physical_weight_trend
        {
            get { return _physical_weight_trend; }
            set { SetProperty(ref _physical_weight_trend, value); }
        }

        private string _physical_sbp_lately = "0";
        public string physical_sbp_lately
        {
            get { return _physical_sbp_lately; }
            set { SetProperty(ref _physical_sbp_lately, value); }
        }

        private string _physical_sbp_trend = "0";
        public string physical_sbp_trend
        {
            get { return _physical_sbp_trend; }
            set { SetProperty(ref _physical_sbp_trend, value); }
        }

        private string _physical_dbp_lately = "0";
        public string physical_dbp_lately
        {
            get { return _physical_dbp_lately; }
            set { SetProperty(ref _physical_dbp_lately, value); }
        }

        private string _physical_dbp_trend = "0";
        public string physical_dbp_trend
        {
            get { return _physical_dbp_trend; }
            set { SetProperty(ref _physical_dbp_trend, value); }
        }

        private string _physical_pulse_lately = "0";
        public string physical_pulse_lately
        {
            get { return _physical_pulse_lately; }
            set { SetProperty(ref _physical_pulse_lately, value); }
        }

        private string _physical_pulse_trend = "0";
        public string physical_pulse_trend
        {
            get { return _physical_pulse_trend; }
            set { SetProperty(ref _physical_pulse_trend, value); }
        }

        private string _physical_fic_lately = "0";
        public string physical_fic_lately
        {
            get { return _physical_fic_lately; }
            set { SetProperty(ref _physical_fic_lately, value); }
        }

        private string _physical_fic_trend = "0";
        public string physical_fic_trend
        {
            get { return _physical_fic_trend; }
            set { SetProperty(ref _physical_fic_trend, value); }
        }

        private string _physical_basicMetabolismScope_lately = "0";
        public string physical_basicMetabolismScope_lately
        {
            get { return _physical_basicMetabolismScope_lately; }
            set { SetProperty(ref _physical_basicMetabolismScope_lately, value); }
        }

        private string _physical_basicMetabolismScope_trend = "0";
        public string physical_basicMetabolismScope_trend
        {
            get { return _physical_basicMetabolismScope_trend; }
            set { SetProperty(ref _physical_basicMetabolismScope_trend, value); }
        }

        private string _physical_exceptFat_lately = "0";
        public string physical_exceptFat_lately
        {
            get { return _physical_exceptFat_lately; }
            set { SetProperty(ref _physical_exceptFat_lately, value); }
        }

        private string _physical_exceptFat_trend = "0";
        public string physical_exceptFat_trend
        {
            get { return _physical_exceptFat_trend; }
            set { SetProperty(ref _physical_exceptFat_trend, value); }
        }

        private string _physical_muscle_lately = "0";
        public string physical_muscle_lately
        {
            get { return _physical_muscle_lately; }
            set { SetProperty(ref _physical_muscle_lately, value); }
        }

        private string _physical_muscle_trend = "0";
        public string physical_muscle_trend
        {
            get { return _physical_muscle_trend; }
            set { SetProperty(ref _physical_muscle_trend, value); }
        }

        private string _physical_fat_lately = "0";
        public string physical_fat_lately
        {
            get { return _physical_fat_lately; }
            set { SetProperty(ref _physical_fat_lately, value); }
        }

        private string _physical_fat_trend = "0";
        public string physical_fat_trend
        {
            get { return _physical_fat_trend; }
            set { SetProperty(ref _physical_fat_trend, value); }
        }

        private string _physical_basicMetabolism_lately = "0";
        public string physical_basicMetabolism_lately
        {
            get { return _physical_basicMetabolism_lately; }
            set { SetProperty(ref _physical_basicMetabolism_lately, value); }
        }

        private string _physical_basicMetabolism_trend = "0";
        public string physical_basicMetabolism_trend
        {
            get { return _physical_basicMetabolism_trend; }
            set { SetProperty(ref _physical_basicMetabolism_trend, value); }
        }

        private string _physical_waterRate_lately = "0";
        public string physical_waterRate_lately
        {
            get { return _physical_waterRate_lately; }
            set { SetProperty(ref _physical_waterRate_lately, value); }
        }

        private string _physical_waterRate_trend = "0";
        public string physical_waterRate_trend
        {
            get { return _physical_waterRate_trend; }
            set { SetProperty(ref _physical_waterRate_trend, value); }
        }

        private string _physical_water_lately = "0";
        public string physical_water_lately
        {
            get { return _physical_water_lately; }
            set { SetProperty(ref _physical_water_lately, value); }
        }

        private string _physical_water_trend = "0";
        public string physical_water_trend
        {
            get { return _physical_water_trend; }
            set { SetProperty(ref _physical_water_trend, value); }
        }

        private string _physical_bmc_lately = "0";
        public string physical_bmc_lately
        {
            get { return _physical_bmc_lately; }
            set { SetProperty(ref _physical_bmc_lately, value); }
        }

        private string _physical_bmc_trend = "0";
        public string physical_bmc_trend
        {
            get { return _physical_bmc_trend; }
            set { SetProperty(ref _physical_bmc_trend, value); }
        }

        private string _physical_foc_lately = "0";
        public string physical_foc_lately
        {
            get { return _physical_foc_lately; }
            set { SetProperty(ref _physical_foc_lately, value); }
        }

        private string _physical_foc_trend = "0";
        public string physical_foc_trend
        {
            get { return _physical_foc_trend; }
            set { SetProperty(ref _physical_foc_trend, value); }
        }

        private string _physical_viscera_lately = "0";
        public string physical_viscera_lately
        {
            get { return _physical_viscera_lately; }
            set { SetProperty(ref _physical_viscera_lately, value); }
        }

        private string _physical_viscera_trend = "0";
        public string physical_viscera_trend
        {
            get { return _physical_viscera_trend; }
            set { SetProperty(ref _physical_viscera_trend, value); }
        }

        private string _physical_tiwen_lately = "0";
        public string physical_tiwen_lately
        {
            get { return _physical_tiwen_lately; }
            set { SetProperty(ref _physical_tiwen_lately, value); }
        }

        private string _physical_tiwen_trend = "0";
        public string physical_tiwen_trend
        {
            get { return _physical_tiwen_trend; }
            set { SetProperty(ref _physical_tiwen_trend, value); }
        }

        private string _physical_oxygen_lately = "0";
        public string physical_oxygen_lately
        {
            get { return _physical_oxygen_lately; }
            set { SetProperty(ref _physical_oxygen_lately, value); }
        }

        private string _physical_oxygen_trend = "0";
        public string physical_oxygen_trend
        {
            get { return _physical_oxygen_trend; }
            set { SetProperty(ref _physical_oxygen_trend, value); }
        }

        private string _physical_Yaotunbi_lately = "0";
        public string physical_Yaotunbi_lately
        {
            get { return _physical_Yaotunbi_lately; }
            set { SetProperty(ref _physical_Yaotunbi_lately, value); }
        }

        private string _physical_Yaotunbi_trend = "0";
        public string physical_Yaotunbi_trend
        {
            get { return _physical_Yaotunbi_trend; }
            set { SetProperty(ref _physical_Yaotunbi_trend, value); }
        }

        private string _physical_yao_lately = "0";
        public string physical_yao_lately
        {
            get { return _physical_yao_lately; }
            set { SetProperty(ref _physical_yao_lately, value); }
        }

        private string _physical_yao_trend = "0";
        public string physical_yao_trend
        {
            get { return _physical_yao_trend; }
            set { SetProperty(ref _physical_yao_trend, value); }
        }

        private string _physical_tun_lately = "0";
        public string physical_tun_lately
        {
            get { return _physical_tun_lately; }
            set { SetProperty(ref _physical_tun_lately, value); }
        }

        private string _physical_tun_trend = "0";
        public string physical_tun_trend
        {
            get { return _physical_tun_trend; }
            set { SetProperty(ref _physical_tun_trend, value); }
        }

        private string _physical_Bmi_lately = "0";
        public string physical_Bmi_lately
        {
            get { return _physical_Bmi_lately; }
            set { SetProperty(ref _physical_Bmi_lately, value); }
        }

        private string _physical_Bmi_trend = "0";
        public string physical_Bmi_trend
        {
            get { return _physical_Bmi_trend; }
            set { SetProperty(ref _physical_Bmi_trend, value); }
        }

        private string _physical_otherComponent_lately = "0";
        public string physical_otherComponent_lately
        {
            get { return _physical_otherComponent_lately; }
            set { SetProperty(ref _physical_otherComponent_lately, value); }
        }

        private string _physical_otherComponent_trend = "0";
        public string physical_otherComponent_trend
        {
            get { return _physical_otherComponent_trend; }
            set { SetProperty(ref _physical_otherComponent_trend, value); }
        }

        #endregion


        #region 属性

        private string _ExactDate;
        public string ExactDate
        {
            get { return _ExactDate; }
            set { SetProperty(ref _ExactDate, value); }
        }

        //01
        private string _blood_oxygen = "0";
        public string blood_oxygen
        {
            get { return _blood_oxygen; }
            set { SetProperty(ref _blood_oxygen, value); }
        }

        private string _blood_oxygen_trend = "0";
        public string blood_oxygen_trend
        {
            get { return _blood_oxygen_trend; }
            set { SetProperty(ref _blood_oxygen_trend, value); }
        }

        private string _blood_oxygen_lately = "0";
        public string blood_oxygen_lately
        {
            get { return _blood_oxygen_lately; }
            set { SetProperty(ref _blood_oxygen_lately, value); }
        }

        //02
        private string _height = "0";
        public string height
        {
            get { return _height; }
            set { SetProperty(ref _height, value); }
        }

        private string _height_trend = "0";
        public string height_trend
        {
            get { return _height_trend; }
            set { SetProperty(ref _height_trend, value); }
        }

        private string _height_lately = "0";
        public string height_lately
        {
            get { return _height_lately; }
            set { SetProperty(ref _height_lately, value); }
        }

        //03
        private string _weight = "0";
        public string weight
        {
            get { return _weight; }
            set { SetProperty(ref _weight, value); }
        }

        private string _weight_trend = "0";
        public string weight_trend
        {
            get { return _weight_trend; }
            set { SetProperty(ref _weight_trend, value); }
        }

        private string _weight_lately = "0";
        public string weight_lately
        {
            get { return _weight_lately; }
            set { SetProperty(ref _weight_lately, value); }
        }


        //04
        private string _age = "0";
        public string age
        {
            get { return _age; }
            set { SetProperty(ref _age, value); }
        }

        private string _age_trend = "0";
        public string age_min
        {
            get { return _age_trend; }
            set { SetProperty(ref _age_trend, value); }
        }

        private string _age_lately = "0";
        public string age_lately
        {
            get { return _age_lately; }
            set { SetProperty(ref _age_lately, value); }
        }

        //05
        private string _temperature = "0";
        public string temperature
        {
            get { return _temperature; }
            set { SetProperty(ref _temperature, value); }
        }

        private string _temperature_trend = "0";
        public string temperature_min
        {
            get { return _temperature_trend; }
            set { SetProperty(ref _temperature_trend, value); }
        }

        private string _temperature_lately = "0";
        public string temperature_lately
        {
            get { return _temperature_lately; }
            set { SetProperty(ref _temperature_lately, value); }
        }

        //06
        private string _bmi = "0";
        public string bmi
        {
            get { return _bmi; }
            set { SetProperty(ref _bmi, value); }
        }

        private string _bmi_trend = "0";
        public string bmi_min
        {
            get { return _bmi_trend; }
            set { SetProperty(ref _bmi_trend, value); }
        }

        private string _bmi_lately = "0";
        public string bmi_lately
        {
            get { return _bmi_lately; }
            set { SetProperty(ref _bmi_lately, value); }
        }


        //07
        private string _fat_percentage = "0";
        public string fat_percentage
        {
            get { return _fat_percentage; }
            set { SetProperty(ref _fat_percentage, value); }
        }

        private string _fat_percentage_trend = "0";
        public string fat_percentage_trend
        {
            get { return _fat_percentage_trend; }
            set { SetProperty(ref _fat_percentage_trend, value); }
        }

        private string _fat_percentage_lately = "0";
        public string fat_percentage_lately
        {
            get { return _fat_percentage_lately; }
            set { SetProperty(ref _fat_percentage_lately, value); }
        }


        //08
        private string _subcutaneous_fat_rate = "0";
        public string subcutaneous_fat_rate
        {
            get { return _subcutaneous_fat_rate; }
            set { SetProperty(ref _subcutaneous_fat_rate, value); }
        }

        private string _subcutaneous_fat_rate_trend = "0";
        public string subcutaneous_fat_rate_trend
        {
            get { return _subcutaneous_fat_rate_trend; }
            set { SetProperty(ref _subcutaneous_fat_rate_trend, value); }
        }

        private string _subcutaneous_fat_rate_lately = "0";
        public string subcutaneous_fat_rate_lately
        {
            get { return _subcutaneous_fat_rate_lately; }
            set { SetProperty(ref _subcutaneous_fat_rate_lately, value); }
        }


        //09
        private string _visceral_fat_grade = "0";
        public string visceral_fat_grade
        {
            get { return _visceral_fat_grade; }
            set { SetProperty(ref _visceral_fat_grade, value); }
        }

        private string _visceral_fat_grade_trend = "0";
        public string visceral_fat_grade_trend
        {
            get { return _visceral_fat_grade_trend; }
            set { SetProperty(ref _visceral_fat_grade_trend, value); }
        }

        private string _visceral_fat_grade_lately = "0";
        public string visceral_fat_grade_lately
        {
            get { return _visceral_fat_grade_lately; }
            set { SetProperty(ref _visceral_fat_grade_lately, value); }
        }


        //10
        private string _body_moisture = "0";
        public string body_moisture
        {
            get { return _body_moisture; }
            set { SetProperty(ref _body_moisture, value); }
        }

        private string _body_moisture_trend = "0";
        public string body_moisture_trend
        {
            get { return _body_moisture_trend; }
            set { SetProperty(ref _body_moisture_trend, value); }
        }

        private string _body_moisture_lately = "0";
        public string body_moisture_lately
        {
            get { return _body_moisture_lately; }
            set { SetProperty(ref _body_moisture_lately, value); }
        }


        //11
        private string _skeletal_muscle_rate = "0";
        public string skeletal_muscle_rate
        {
            get { return _skeletal_muscle_rate; }
            set { SetProperty(ref _skeletal_muscle_rate, value); }
        }

        private string _skeletal_muscle_rate_trend = "0";
        public string skeletal_muscle_rate_trend
        {
            get { return _skeletal_muscle_rate_trend; }
            set { SetProperty(ref _skeletal_muscle_rate_trend, value); }
        }

        private string _skeletal_muscle_rate_lately = "0";
        public string skeletal_muscle_rate_lately
        {
            get { return _skeletal_muscle_rate_lately; }
            set { SetProperty(ref _skeletal_muscle_rate_lately, value); }
        }

        //12
        private string _bone_mass = "0";
        public string bone_mass
        {
            get { return _bone_mass; }
            set { SetProperty(ref _bone_mass, value); }
        }

        private string _bone_mass_trend = "0";
        public string bone_mass_trend
        {
            get { return _bone_mass_trend; }
            set { SetProperty(ref _bone_mass_trend, value); }
        }

        private string _bone_mass_lately = "0";
        public string bone_mass_lately
        {
            get { return _bone_mass_lately; }
            set { SetProperty(ref _bone_mass_lately, value); }
        }

        //13
        private string _basal_metabolism = "0";
        public string basal_metabolism
        {
            get { return _basal_metabolism; }
            set { SetProperty(ref _basal_metabolism, value); }
        }

        private string _basal_metabolism_trend = "0";
        public string basal_metabolism_trend
        {
            get { return _basal_metabolism_trend; }
            set { SetProperty(ref _basal_metabolism_trend, value); }
        }

        private string _basal_metabolism_lately = "0";
        public string basal_metabolism_lately
        {
            get { return _basal_metabolism_lately; }
            set { SetProperty(ref _basal_metabolism_lately, value); }
        }

        //14
        private string _heart_rate = "0";
        public string heart_rate
        {
            get { return _heart_rate; }
            set { SetProperty(ref _heart_rate, value); }
        }

        private string _heart_rate_trend = "0";
        public string heart_rate_trend
        {
            get { return _heart_rate_trend; }
            set { SetProperty(ref _heart_rate_trend, value); }
        }

        private string _heart_rate_lately = "0";
        public string heart_rate_lately
        {
            get { return _heart_rate_lately; }
            set { SetProperty(ref _heart_rate_lately, value); }
        }


        //15
        private string _protein = "0";
        public string protein
        {
            get { return _protein; }
            set { SetProperty(ref _protein, value); }
        }

        private string _protein_trend = "0";
        public string protein_trend
        {
            get { return _protein_trend; }
            set { SetProperty(ref _protein_trend, value); }
        }

        private string _protein_lately = "0";
        public string protein_lately
        {
            get { return _protein_lately; }
            set { SetProperty(ref _protein_lately, value); }
        }

        //16
        private string _blood_lactic_acid = "0";
        public string blood_lactic_acid
        {
            get { return _blood_lactic_acid; }
            set { SetProperty(ref _blood_lactic_acid, value); }
        }

        private string _blood_lactic_acid_trend = "0";
        public string blood_lactic_acid_trend
        {
            get { return _blood_lactic_acid_trend; }
            set { SetProperty(ref _blood_lactic_acid_trend, value); }
        }

        private string _blood_lactic_acid_lately = "0";
        public string blood_lactic_acid_lately
        {
            get { return _blood_lactic_acid_lately; }
            set { SetProperty(ref _blood_lactic_acid_lately, value); }
        }


        //17
        private string _creatine_phosphate = "0";
        public string creatine_phosphate
        {
            get { return _creatine_phosphate; }
            set { SetProperty(ref _creatine_phosphate, value); }
        }

        private string _creatine_phosphate_trend = "0";
        public string creatine_phosphate_trend
        {
            get { return _creatine_phosphate_trend; }
            set { SetProperty(ref _creatine_phosphate_trend, value); }
        }

        private string _creatine_phosphate_lately = "0";
        public string creatine_phosphate_lately
        {
            get { return _creatine_phosphate_lately; }
            set { SetProperty(ref _creatine_phosphate_lately, value); }
        }

        //18
        private string _urine_protein = "0";
        public string urine_protein
        {
            get { return _urine_protein; }
            set { SetProperty(ref _urine_protein, value); }
        }

        private string _urine_protein_trend = "0";
        public string urine_protein_trend
        {
            get { return _urine_protein_trend; }
            set { SetProperty(ref _urine_protein_trend, value); }
        }

        private string _urine_protein_lately = "0";
        public string urine_protein_lately
        {
            get { return _urine_protein_lately; }
            set { SetProperty(ref _urine_protein_lately, value); }
        }


        //19
        private string _hemoglobin = "0";
        public string hemoglobin
        {
            get { return _hemoglobin; }
            set { SetProperty(ref _hemoglobin, value); }
        }

        private string _hemoglobin_trend = "0";
        public string hemoglobin_trend
        {
            get { return _hemoglobin_trend; }
            set { SetProperty(ref _hemoglobin_trend, value); }
        }

        private string _hemoglobin_lately = "0";
        public string hemoglobin_lately
        {
            get { return _hemoglobin_lately; }
            set { SetProperty(ref _hemoglobin_lately, value); }
        }


        //20
        private string _oxymyoglobin = "0";
        public string oxymyoglobin
        {
            get { return _oxymyoglobin; }
            set { SetProperty(ref _oxymyoglobin, value); }
        }

        private string _oxymyoglobin_trend = "0";
        public string oxymyoglobin_trend
        {
            get { return _oxymyoglobin_trend; }
            set { SetProperty(ref _oxymyoglobin_trend, value); }
        }

        private string _oxymyoglobin_lately = "0";
        public string oxymyoglobin_lately
        {
            get { return _oxymyoglobin_lately; }
            set { SetProperty(ref _oxymyoglobin_lately, value); }
        }

        #endregion


        //
        private ICollectionView basicsCollectionView;
        public ICollectionView BasicsCollectionView
        {
            get
            {
                if (basicsCollectionView == null)
                {
                    basicsCollectionView = CollectionViewSource.GetDefaultView(BasicsObservable);
                }
                return basicsCollectionView;
            }
        }
        public ObservableCollection<string> BasicsObservable = new ObservableCollection<string>();


        //基础数据-时间列表
        private ICollectionView functionCollectionView;
        public ICollectionView FunctionCollectionView
        {
            get
            {
                if (functionCollectionView == null)
                {
                    functionCollectionView = CollectionViewSource.GetDefaultView(functionObservable);
                }
                return functionCollectionView;
            }
        }

        public ObservableCollection<string> functionObservable = new ObservableCollection<string>();



        #region 命令

        DelegateCommand<ListBox> _SelectionBasicsContainerChangedCmd = null;
        public DelegateCommand<ListBox> SelectionBasicsContainerChangedCmd
        {
            get
            {
                if (this._SelectionBasicsContainerChangedCmd == null)
                {
                    this._SelectionBasicsContainerChangedCmd = new DelegateCommand<ListBox>(SelectionBasicsContainerChanged);
                }

                return this._SelectionBasicsContainerChangedCmd;
            }
        }


        private int index = 0;

        private string CalTrend(string parameter1, string parameter2)
        {
            var trend = double.Parse(parameter2) - double.Parse(parameter1);

            if (trend > 0)
                return trend.ToString();
            else if (trend == 0)
                return trend.ToString();
            else
                return trend.ToString();
        }

        void SelectionBasicsContainerChanged(ListBox listBox)
        {
            var line = ReadConfigure.ReadParameter(@"\instrument.txt");
            if (line == "手环与体脂秤")
            {
                if (list1 == null || list1.Count == 0)
                    return;

                var temp = listBox.SelectedItem as string;
                index = list1.FindIndex(delegate (basic_data p) { return p.time.ToString() == temp; });

                if (index < 0)
                    return;

                blood_oxygen_lately = list1[index].blood_oxygen; //01
                height_lately = list1[index].height.ToString(); //02
                weight_lately = list1[index].weight; //03
                age_lately = list1[index].age.ToString(); //04
                temperature_lately = list1[index].temperature; //05
                bmi_lately = list1[index].bmi; //06
                fat_percentage_lately = list1[index].fat_percentage; //07
                subcutaneous_fat_rate_lately = list1[index].subcutaneous_fat_rate; //08
                visceral_fat_grade_lately = list1[index].visceral_fat_grade; //09
                body_moisture_lately = list1[index].body_moisture; //10
                skeletal_muscle_rate_lately = list1[index].skeletal_muscle_rate; //11
                bone_mass_lately = list1[index].bone_mass; //12
                basal_metabolism_lately = list1[index].basal_metabolism; //13;
                heart_rate_lately = list1[index].heart_rate; //14
                protein_lately = list1[index].protein; //15

                //变化趋势
                blood_oxygen_trend = CalTrend(list1[index].blood_oxygen, list1[0].blood_oxygen);
                height_trend = CalTrend(list1[index].height.ToString(), list1[0].height.ToString());
                weight_trend = CalTrend(list1[index].weight.ToString(), list1[0].weight.ToString());
                age_lately = CalTrend(list1[index].age.ToString(), list1[0].age.ToString());
                temperature_lately = CalTrend(list1[index].temperature, list1[0].temperature);
                bmi_lately = CalTrend(list1[index].bmi, list1[0].bmi);
                fat_percentage_trend = CalTrend(list1[index].fat_percentage, list1[0].fat_percentage);
                subcutaneous_fat_rate_trend = CalTrend(list1[index].subcutaneous_fat_rate, list1[0].subcutaneous_fat_rate);
                visceral_fat_grade_trend = CalTrend(list1[index].visceral_fat_grade, list1[0].visceral_fat_grade);
                body_moisture_trend = CalTrend(list1[index].body_moisture, list1[0].body_moisture);
                skeletal_muscle_rate_trend = CalTrend(list1[index].skeletal_muscle_rate, list1[0].skeletal_muscle_rate);
                bone_mass_trend = CalTrend(list1[index].bone_mass, list1[0].bone_mass);
                basal_metabolism_trend = CalTrend(list1[index].basal_metabolism, list1[0].basal_metabolism);
                heart_rate_trend = CalTrend(list1[index].heart_rate, list1[0].heart_rate);
                protein_trend = CalTrend(list1[index].protein, list1[0].protein);
            }
            else if (line == "体测仪")
            {
                if (list3 == null || list3.Count == 0)
                    return;

                var temp = listBox.SelectedItem as string;
                index = list3.FindIndex(delegate (Instrument p) { return p.createTime.ToString() == temp; });

                if (index < 0)
                    return;

                //用户选择-显示记录
                physical_height_lately = list3[index].height;
                physical_age_lately = list3[index].age;
                physical_weight_lately = list3[index].weight;
                physical_sbp_lately = list3[index].sbp;
                physical_dbp_lately = list3[index].dbp;
                physical_pulse_lately = list3[index].pulse;
                physical_fic_lately = list3[index].fic;
                physical_basicMetabolismScope_lately = list3[index].basicMetabolismScope;
                physical_exceptFat_lately = list3[index].exceptFat;
                physical_muscle_lately = list3[index].muscle;
                physical_fat_lately = list3[index].fat;
                physical_basicMetabolism_lately = list3[index].basicMetabolism;
                physical_waterRate_lately = list3[index].waterRate;
                physical_water_lately = list3[index].water;
                physical_bmc_lately = list3[index].bmc;
                physical_foc_lately = list3[index].foc;
                physical_viscera_lately = list3[index].viscera;
                physical_oxygen_lately = list3[index].oxygen;
                physical_tiwen_lately = list3[index].tiwen;
                physical_Yaotunbi_lately = list3[index].Yaotunbi;
                physical_yao_lately = list3[index].yao;
                physical_tun_lately = list3[index].tun;
                physical_Bmi_lately = list3[index].Bmi;
                physical_otherComponent_lately = list3[index].otherComponent;
                //变化趋势
                physical_height_trend = CalTrend(list3[index].height, list3[0].height);
                physical_age_trend = CalTrend(list3[index].age, list3[0].age);
                physical_weight_trend = CalTrend(list3[index].weight, list3[0].weight);
                physical_sbp_trend = CalTrend(list3[index].sbp, list3[0].sbp);
                physical_dbp_trend = CalTrend(list3[index].dbp, list3[0].dbp);
                physical_pulse_trend = CalTrend(list3[index].pulse, list3[0].pulse);
                physical_fic_trend = CalTrend(list3[index].fic, list3[0].fic);
                physical_basicMetabolismScope_trend = CalTrend(list3[index].basicMetabolismScope, list3[0].basicMetabolismScope);
                physical_exceptFat_trend = CalTrend(list3[index].exceptFat, list3[0].exceptFat);
                physical_muscle_trend = CalTrend(list3[index].muscle, list3[0].muscle);
                physical_fat_trend = CalTrend(list3[index].fat, list3[0].fat);
                physical_basicMetabolism_trend = CalTrend(list3[index].basicMetabolism, list3[0].basicMetabolism);
                physical_waterRate_trend = CalTrend(list3[index].waterRate, list3[0].waterRate);
                physical_water_trend = CalTrend(list3[index].water, list3[0].water);
                physical_bmc_trend = CalTrend(list3[index].bmc, list3[0].bmc);
                physical_foc_trend = CalTrend(list3[index].foc, list3[0].foc);
                physical_viscera_trend = CalTrend(list3[index].viscera, list3[0].viscera);
                physical_oxygen_trend = CalTrend(list3[index].oxygen, list3[0].oxygen);
                physical_tiwen_trend = CalTrend(list3[index].tiwen, list3[0].tiwen);
                physical_Yaotunbi_trend = CalTrend(list3[index].Yaotunbi, list3[0].Yaotunbi);
                physical_yao_trend = CalTrend(list3[index].yao, list3[0].yao);
                physical_tun_trend = CalTrend(list3[index].tun, list3[0].tun);
                physical_Bmi_trend = CalTrend(list3[index].Bmi, list3[0].Bmi);
                physical_otherComponent_trend = CalTrend(list3[index].otherComponent, list3[0].otherComponent);
            }
            else if (line == "inbody")
            {

                if (list4 == null || list4.Count == 0)
                    return;

                var temp = listBox.SelectedItem as string;
                index = list4.FindIndex(delegate (inBody p) { return p.createTime.ToString() == temp; });

                if (index < 0)
                    return;

                inbody_field_1_lately = list4[index].field_1;
                inbody_field_2_lately = list4[index].field_2;
                inbody_field_3_lately = list4[index].field_3;
                inbody_field_4_lately = list4[index].field_4;
                inbody_field_5_lately = list4[index].field_5;
                inbody_field_6_lately = list4[index].field_6;
                inbody_field_7_lately = list4[index].field_7;
                inbody_field_8_lately = list4[index].field_8;
                inbody_field_9_lately = list4[index].field_9;
                inbody_field_10_lately = list4[index].field_10;
                inbody_field_11_lately = list4[index].field_11;
                inbody_field_12_lately = list4[index].field_12;
                inbody_field_13_lately = list4[index].field_13;
                inbody_field_14_lately = list4[index].field_14;
                inbody_field_15_lately = list4[index].field_15;
                //变化趋势
                inbody_field_1_trend = CalTrend(list4[index].field_1, list4[0].field_1);
                inbody_field_2_trend = CalTrend(list4[index].field_2, list4[0].field_2);
                inbody_field_3_trend = CalTrend(list4[index].field_3, list4[0].field_3);
                inbody_field_4_trend = CalTrend(list4[index].field_4, list4[0].field_4);
                inbody_field_5_trend = CalTrend(list4[index].field_5, list4[0].field_5);
                inbody_field_6_trend = CalTrend(list4[index].field_6, list4[0].field_6);
                inbody_field_7_trend = CalTrend(list4[index].field_7, list4[0].field_7);
                inbody_field_8_trend = CalTrend(list4[index].field_8, list4[0].field_8);
                inbody_field_9_trend = CalTrend(list4[index].field_9, list4[0].field_9);
                inbody_field_10_trend = CalTrend(list4[index].field_10, list4[0].field_10);
                inbody_field_11_trend = CalTrend(list4[index].field_11, list4[0].field_11);
                inbody_field_12_trend = CalTrend(list4[index].field_12, list4[0].field_12);
                inbody_field_13_trend = CalTrend(list4[index].field_13, list4[0].field_13);
                inbody_field_14_trend = CalTrend(list4[index].field_14, list4[0].field_14);
                inbody_field_15_trend = CalTrend(list4[index].field_15, list4[0].field_15);

            }
        }


        DelegateCommand<ListBox> _SelectionFunctionContainerChangedCmd = null;
        public DelegateCommand<ListBox> SelectionFunctionContainerChangedCmd
        {
            get
            {
                if (this._SelectionFunctionContainerChangedCmd == null)
                {
                    this._SelectionFunctionContainerChangedCmd = new DelegateCommand<ListBox>(SelectionFunctionContainerChanged);
                }

                return this._SelectionFunctionContainerChangedCmd;
            }
        }

        void SelectionFunctionContainerChanged(ListBox listBox)
        {
            if (list2 == null || list2.Count == 0)
                return;

            var temp = listBox.SelectedItem as string;
            index = list2.FindIndex(delegate (functional_data p) { return p.datetime.ToString() == temp; });

            if (index < 0)
                return;

            blood_lactic_acid_lately = list2[index].blood_lactic_acid;
            creatine_phosphate_lately = list2[index].creatine_phosphate;
            urine_protein_lately = list2[index].urine_protein;
            hemoglobin_lately = list2[index].hemoglobin;
            oxymyoglobin_lately = list2[index].oxymyoglobin;

            //变化趋势
            blood_lactic_acid_trend = CalTrend(list2[index].blood_lactic_acid, list2[0].blood_lactic_acid);
            creatine_phosphate_lately = CalTrend(list2[index].creatine_phosphate, list2[0].creatine_phosphate);
            urine_protein_lately = CalTrend(list2[index].urine_protein, list2[0].urine_protein);
            hemoglobin_lately = CalTrend(list2[index].hemoglobin, list2[0].hemoglobin);
            oxymyoglobin_lately = CalTrend(list2[index].oxymyoglobin, list2[0].oxymyoglobin);

        }

        #endregion

        //构造函数
        public HealthManagementViewModel(IRegionManager regionManager, IEventAggregator ea)
        {
            _regionManager = regionManager;
            _ea = ea;
            _ea.GetEvent<TimeSentEvent>().Subscribe(MessageReceived);
            _ea.GetEvent<StaminaSentEvent>().Subscribe(MessageReceived2);

            var line = ReadConfigure.ReadParameter(@"\instrument.txt");

            if (line == "体测仪")
            {
                Wrap1_Visibility = "Visible";
                Wrap2_Visibility = "Hidden";
                Wrap3_Visibility = "Visible";
                Wrap4_Visibility = "Hidden";
            }
            else if (line == "手环与体脂秤")
            {
                Wrap1_Visibility = "Hidden";
                Wrap2_Visibility = "Visible";
                Wrap3_Visibility = "Visible";
                Wrap4_Visibility = "Hidden";
            }
            else if (line == "inbody")
            {
                Wrap1_Visibility = "Hidden";
                Wrap2_Visibility = "Hidden";
                Wrap3_Visibility = "Visible";
                Wrap4_Visibility = "Visible";
            }
        }


        #region 实现

        public void SendMessage(string message) => _ea.GetEvent<StaminaSentEvent>().Publish(message);

        private void MessageReceived(string message) => ExactDate = message;

        private int list1Index = 0;
        private int list2Index = 0;
        private int list3Index = 0;
        private int list4Index = 0;

        List<basic_data> list1 = new List<basic_data>();
        List<functional_data> list2 = new List<functional_data>();
        List<Instrument> list3 = new List<Instrument>();
        List<inBody> list4 = new List<inBody>();


        private void MessageReceived2(string message)
        {
            DB dB = new DB();
            var user = dB.ValidateLogon(int.Parse(message));
            UserName = user.real_name;

            functionObservable.Clear();
            BasicsObservable.Clear();
            list1.Clear();
            list2.Clear();
            list3.Clear();
            list4.Clear();

            var line = ReadConfigure.ReadParameter(@"\instrument.txt");


            int j = 0;
            list2 = dB.Getfunctional_datas(message);
            if (list2.Count < 5)
                j = 0;
            else
                j = list2.Count - 5;

            for (int i = j; i < list2.Count; i++)
            {
                BasicsObservable.Add(list2[i].datetime.ToString());
            }

            if (list2.Count != 0)
            {
                //机能数据表
                blood_lactic_acid = list2[list2Index].blood_lactic_acid;  //16
                creatine_phosphate = list2[list2Index].creatine_phosphate; //17
                urine_protein = list2[list2Index].urine_protein; //18
                hemoglobin = list2[list2Index].hemoglobin; //19
                oxymyoglobin = list2[list2Index].oxymyoglobin; //20
            }
            else
            {
                blood_lactic_acid = "0";  //16
                creatine_phosphate = "0"; //17
                urine_protein = "0"; //18
                hemoglobin = "0"; //19
                oxymyoglobin = "0"; //20
            }

            if (line == "手环与体脂秤")
            {
                if (list1.Count == 0)
                    return;

                list1 = dB.Getbasic_datas(message);

                if (list1.Count < 5)
                    j = 0;
                else
                    j = list1.Count - 5;

                for (int i = j; i < list1.Count; i++)
                {
                    functionObservable.Add(list1[i].time.ToString());
                }

                Task.Factory.StartNew(() =>
                {
                    //默认显示
                    if (list1.Count != 0)
                    {
                        //基础数据表
                        blood_oxygen = list1[list1Index].blood_oxygen; //01
                        height = list1[list1Index].height.ToString(); //02
                        weight = list1[list1Index].weight; //03
                        age = list1[list1Index].age.ToString(); //04
                        temperature = list1[list1Index].temperature; //05
                        bmi = list1[list1Index].bmi; //06
                        fat_percentage = list1[list1Index].fat_percentage; //07
                        subcutaneous_fat_rate = list1[list1Index].subcutaneous_fat_rate; //08
                        visceral_fat_grade = list1[list1Index].visceral_fat_grade; //09
                        body_moisture = list1[list1Index].body_moisture; //10
                        skeletal_muscle_rate = list1[list1Index].skeletal_muscle_rate; //11
                        bone_mass = list1[list1Index].bone_mass; //12
                        basal_metabolism = list1[list1Index].basal_metabolism; //13;
                        heart_rate = list1[list1Index].heart_rate; //14
                        protein = list1[list1Index].protein; //15
                    }
                    else
                    {
                        blood_oxygen = "0";
                        height = "0";
                        weight = "0";
                        age = "0";
                        temperature = "0";
                        bmi = "0";
                        fat_percentage = "0";
                        subcutaneous_fat_rate = "0";
                        visceral_fat_grade = "0";
                        body_moisture = "0";
                        skeletal_muscle_rate = "0";
                        bone_mass = "0";
                        basal_metabolism = "0";
                        heart_rate = "0";
                        protein = "0";
                    }

                });
            }
            else if (line == "体测仪")
            {
                if (list3.Count == 0)
                    return;

                list3 = dB.GetInstruments(int.Parse(message));

                if (list3.Count < 5)
                    j = 0;
                else
                    j = list3.Count - 5;

                for (int i = j; i < list3.Count; i++)
                {
                    functionObservable.Add(list3[i].createTime.ToString());
                }

                if (list3.Count != 0)
                {
                    //默认显示
                    height = list3[list3Index].height;
                    age = list3[list3Index].age;
                    weight = list3[list3Index].weight;
                    sbp = list3[list3Index].sbp;
                    dbp = list3[list3Index].dbp; //05
                    pulse = list3[list3Index].pulse;//06
                    fic = list3[list3Index].fic;//07
                    basicMetabolismScope = list3[list3Index].basicMetabolismScope;//08
                    exceptFat = list3[list3Index].exceptFat;//09
                    muscle = list3[list3Index].muscle;//10
                    fat = list3[list3Index].fat;//11
                    basicMetabolism = list3[list3Index].basicMetabolism;//12
                    waterRate = list3[list3Index].waterRate;//13
                    water = list3[list3Index].water;//14
                    bmc = list3[list3Index].bmc;//15
                    foc = list3[list3Index].foc;//16
                    viscera = list3[list3Index].viscera;//17
                    oxygen = list3[list3Index].oxygen;//18
                    tiwen = list3[list3Index].tiwen;//19
                    Yaotunbi = list3[list3Index].Yaotunbi;//20
                    yao = list3[list3Index].yao;//21
                    tun = list3[list3Index].tun;//22
                    Bmi = list3[list3Index].Bmi;//23
                    otherComponent = list3[list3Index].otherComponent;//24
                }
                else
                {
                    //默认显示
                    height = "0";
                    age = "0";
                    weight = "0";
                    sbp = "0";
                    dbp = "0";
                    pulse = "0";
                    fic = "0";
                    basicMetabolismScope = "0";
                    exceptFat = "0";
                    muscle = "0";
                    fat = "0";
                    basicMetabolism = "0";
                    waterRate = "0";
                    water = "0";
                    bmc = "0";
                    foc = "0";
                    viscera = "0";
                    oxygen = "0";
                    tiwen = "0";
                    Yaotunbi = "0";
                    yao = "0";
                    tun = "0";
                    Bmi = "0";
                    otherComponent = "0";
                }
            }
            else if (line == "inbody")
            {
                if (list4.Count == 0)
                    return;

                list4 = dB.GetinBodys(int.Parse(message));

                if (list4.Count < 5)
                    j = 0;
                else
                    j = list4.Count - 5;

                for (int i = j; i < list4.Count; i++)
                {
                    functionObservable.Add(list4[i].createTime.ToString());
                }

                if (list4.Count != 0)
                {
                    inbody_field_1 = list4[list4Index].field_1;
                    inbody_field_2 = list4[list4Index].field_2;
                    inbody_field_3 = list4[list4Index].field_3;
                    inbody_field_4 = list4[list4Index].field_4;
                    inbody_field_5 = list4[list4Index].field_5;
                    inbody_field_6 = list4[list4Index].field_6;
                    inbody_field_7 = list4[list4Index].field_7;
                    inbody_field_8 = list4[list4Index].field_8;
                    inbody_field_9 = list4[list4Index].field_9;
                    inbody_field_10 = list4[list4Index].field_10;
                    inbody_field_11 = list4[list4Index].field_11;
                    inbody_field_12 = list4[list4Index].field_12;
                    inbody_field_13 = list4[list4Index].field_13;
                    inbody_field_14 = list4[list4Index].field_14;
                    inbody_field_15 = list4[list4Index].field_15;
                }
                else
                {
                    inbody_field_1 = "0";
                    inbody_field_2 = "0";
                    inbody_field_3 = "0";
                    inbody_field_4 = "0";
                    inbody_field_5 = "0";
                    inbody_field_6 = "0";
                    inbody_field_7 = "0";
                    inbody_field_8 = "0";
                    inbody_field_9 = "0";
                    inbody_field_10 = "0";
                    inbody_field_11 = "0";
                    inbody_field_12 = "0";
                    inbody_field_13 = "0";
                    inbody_field_14 = "0";
                    inbody_field_15 = "0";
                }
            }
        }

        public void Navigate(string adaptationArea, string navigatePath)
        {
            if (navigatePath != null)
                _regionManager.RequestNavigate(adaptationArea, navigatePath);
        }

        #endregion
    }
}
