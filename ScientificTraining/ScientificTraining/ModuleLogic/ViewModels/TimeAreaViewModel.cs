//Prsim框架
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
//用户自定义
using UsingEventAggregator.Core;
using ModuleLogic.Views;
//系统
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ModuleLogic.ViewModels
{
    public class TimeAreaViewModel : BindableBase
    {
        IEventAggregator _ea;

        #region 属性

        private int _Complement = 0;
        public int Complement
        {
            get { return _Complement; }
            set { SetProperty(ref _Complement, value); }
        }

        //ShowDate
        private string _ShowDate;
        public string ShowDate
        {
            get { return _ShowDate; }
            set { SetProperty(ref _ShowDate, value); }
        }

        //01
        private string _day1Visi = "Visible";
        public string day1Visi
        {
            get { return _day1Visi; }
            set { SetProperty(ref _day1Visi, value); }
        }

        private string _day1Back = "White";
        public string day1Back
        {
            get { return _day1Back; }
            set { SetProperty(ref _day1Back, value); }
        }

        private string _day1Fore = "Black";
        public string day1Fore
        {
            get { return _day1Fore; }
            set { SetProperty(ref _day1Fore, value); }
        }

        //02
        private string _day2Visi = "Visible";
        public string day2Visi
        {
            get { return _day2Visi; }
            set { SetProperty(ref _day2Visi, value); }
        }
        private string _day2Back = "White";
        public string day2Back
        {
            get { return _day2Back; }
            set { SetProperty(ref _day2Back, value); }
        }

        private string _day2Fore = "Black";
        public string day2Fore
        {
            get { return _day2Fore; }
            set { SetProperty(ref _day2Fore, value); }
        }

        //03
        private string _day3Visi = "Visible";
        public string day3Visi
        {
            get { return _day3Visi; }
            set { SetProperty(ref _day3Visi, value); }
        }
        private string _day3Back = "White";
        public string day3Back
        {
            get { return _day3Back; }
            set { SetProperty(ref _day3Back, value); }
        }

        private string _day3Fore = "Black";
        public string day3Fore
        {
            get { return _day3Fore; }
            set { SetProperty(ref _day3Fore, value); }
        }

        //04
        private string _day4Visi = "Visible";
        public string day4Visi
        {
            get { return _day4Visi; }
            set { SetProperty(ref _day4Visi, value); }
        }
        private string _day4Back = "White";
        public string day4Back
        {
            get { return _day4Back; }
            set { SetProperty(ref _day4Back, value); }
        }

        private string _day4Fore = "Black";
        public string day4Fore
        {
            get { return _day4Fore; }
            set { SetProperty(ref _day4Fore, value); }
        }

        //05
        private string _day5Visi = "Visible";
        public string day5Visi
        {
            get { return _day5Visi; }
            set { SetProperty(ref _day5Visi, value); }
        }
        private string _day5Back = "White";
        public string day5Back
        {
            get { return _day5Back; }
            set { SetProperty(ref _day5Back, value); }
        }

        private string _day5Fore = "Black";
        public string day5Fore
        {
            get { return _day5Fore; }
            set { SetProperty(ref _day5Fore, value); }
        }

        //06
        private string _day6Visi = "Visible";
        public string day6Visi
        {
            get { return _day6Visi; }
            set { SetProperty(ref _day6Visi, value); }
        }
        private string _day6Back = "White";
        public string day6Back
        {
            get { return _day6Back; }
            set { SetProperty(ref _day6Back, value); }
        }

        private string _day6Fore = "Black";
        public string day6Fore
        {
            get { return _day6Fore; }
            set { SetProperty(ref _day6Fore, value); }
        }
        //07
        private string _day7Visi = "Visible";
        public string day7Visi
        {
            get { return _day7Visi; }
            set { SetProperty(ref _day7Visi, value); }
        }
        private string _day7Back = "White";
        public string day7Back
        {
            get { return _day7Back; }
            set { SetProperty(ref _day7Back, value); }
        }

        private string _day7Fore = "Black";
        public string day7Fore
        {
            get { return _day7Fore; }
            set { SetProperty(ref _day7Fore, value); }
        }
        //08
        private string _day8Visi = "Visible";
        public string day8Visi
        {
            get { return _day8Visi; }
            set { SetProperty(ref _day8Visi, value); }
        }
        private string _day8Back = "White";
        public string day8Back
        {
            get { return _day8Back; }
            set { SetProperty(ref _day8Back, value); }
        }

        private string _day8Fore = "Black";
        public string day8Fore
        {
            get { return _day8Fore; }
            set { SetProperty(ref _day8Fore, value); }
        }

        //09
        private string _day9Visi = "Visible";
        public string day9Visi
        {
            get { return _day9Visi; }
            set { SetProperty(ref _day9Visi, value); }
        }
        private string _day9Back = "White";
        public string day9Back
        {
            get { return _day9Back; }
            set { SetProperty(ref _day9Back, value); }
        }

        private string _day9Fore = "Black";
        public string day9Fore
        {
            get { return _day9Fore; }
            set { SetProperty(ref _day9Fore, value); }
        }
        //10
        private string _day10Visi = "Visible";
        public string day10Visi
        {
            get { return _day10Visi; }
            set { SetProperty(ref _day10Visi, value); }
        }
        private string _day10Back = "White";
        public string day10Back
        {
            get { return _day10Back; }
            set { SetProperty(ref _day10Back, value); }
        }

        private string _day10Fore = "Black";
        public string day10Fore
        {
            get { return _day10Fore; }
            set { SetProperty(ref _day10Fore, value); }
        }
        //11
        private string _day11Visi = "Visible";
        public string day11Visi
        {
            get { return _day11Visi; }
            set { SetProperty(ref _day11Visi, value); }
        }
        private string _day11Back = "White";
        public string day11Back
        {
            get { return _day11Back; }
            set { SetProperty(ref _day11Back, value); }
        }

        private string _day11Fore = "Black";
        public string day11Fore
        {
            get { return _day11Fore; }
            set { SetProperty(ref _day11Fore, value); }
        }
        //12
        private string _day12Visi = "Visible";
        public string day12Visi
        {
            get { return _day12Visi; }
            set { SetProperty(ref _day12Visi, value); }
        }
        private string _day12Back = "White";
        public string day12Back
        {
            get { return _day12Back; }
            set { SetProperty(ref _day12Back, value); }
        }

        private string _day12Fore = "Black";
        public string day12Fore
        {
            get { return _day12Fore; }
            set { SetProperty(ref _day12Fore, value); }
        }
        //13
        private string _day13Visi = "Visible";
        public string day13Visi
        {
            get { return _day13Visi; }
            set { SetProperty(ref _day13Visi, value); }
        }
        private string _day13Back = "White";
        public string day13Back
        {
            get { return _day13Back; }
            set { SetProperty(ref _day13Back, value); }
        }

        private string _day13Fore = "Black";
        public string day13Fore
        {
            get { return _day13Fore; }
            set { SetProperty(ref _day13Fore, value); }
        }
        //14
        private string _day14Visi = "Visible";
        public string day14Visi
        {
            get { return _day14Visi; }
            set { SetProperty(ref _day14Visi, value); }
        }
        private string _day14Back = "White";
        public string day14Back
        {
            get { return _day14Back; }
            set { SetProperty(ref _day14Back, value); }
        }

        private string _day14Fore = "Black";
        public string day14Fore
        {
            get { return _day14Fore; }
            set { SetProperty(ref _day14Fore, value); }
        }
        //15
        private string _day15Visi = "Visible";
        public string day15Visi
        {
            get { return _day15Visi; }
            set { SetProperty(ref _day15Visi, value); }
        }
        private string _day15Back = "White";
        public string day15Back
        {
            get { return _day15Back; }
            set { SetProperty(ref _day15Back, value); }
        }

        private string _day15Fore = "Black";
        public string day15Fore
        {
            get { return _day15Fore; }
            set { SetProperty(ref _day15Fore, value); }
        }
        //16
        private string _day16Visi = "Visible";
        public string day16Visi
        {
            get { return _day16Visi; }
            set { SetProperty(ref _day16Visi, value); }
        }
        private string _day16Back = "White";
        public string day16Back
        {
            get { return _day16Back; }
            set { SetProperty(ref _day16Back, value); }
        }

        private string _day16Fore = "Black";
        public string day16Fore
        {
            get { return _day16Fore; }
            set { SetProperty(ref _day16Fore, value); }
        }
        //17
        private string _day17Visi = "Visible";
        public string day17Visi
        {
            get { return _day17Visi; }
            set { SetProperty(ref _day17Visi, value); }
        }
        private string _day17Back = "White";
        public string day17Back
        {
            get { return _day17Back; }
            set { SetProperty(ref _day17Back, value); }
        }

        private string _day17Fore = "Black";
        public string day17Fore
        {
            get { return _day17Fore; }
            set { SetProperty(ref _day17Fore, value); }
        }
        //18
        private string _day18Visi = "Visible";
        public string day18Visi
        {
            get { return _day18Visi; }
            set { SetProperty(ref _day18Visi, value); }
        }
        private string _day18Back = "White";
        public string day18Back
        {
            get { return _day18Back; }
            set { SetProperty(ref _day18Back, value); }
        }

        private string _day18Fore = "Black";
        public string day18Fore
        {
            get { return _day18Fore; }
            set { SetProperty(ref _day18Fore, value); }
        }
        //19
        private string _day19Visi = "Visible";
        public string day19Visi
        {
            get { return _day19Visi; }
            set { SetProperty(ref _day19Visi, value); }
        }
        private string _day19Back = "White";
        public string day19Back
        {
            get { return _day19Back; }
            set { SetProperty(ref _day19Back, value); }
        }

        private string _day19Fore = "Black";
        public string day19Fore
        {
            get { return _day19Fore; }
            set { SetProperty(ref _day19Fore, value); }
        }
        //20
        private string _day20Visi = "Visible";
        public string day20Visi
        {
            get { return _day20Visi; }
            set { SetProperty(ref _day20Visi, value); }
        }
        private string _day20Back = "White";
        public string day20Back
        {
            get { return _day20Back; }
            set { SetProperty(ref _day20Back, value); }
        }

        private string _day20Fore = "Black";
        public string day20Fore
        {
            get { return _day20Fore; }
            set { SetProperty(ref _day20Fore, value); }
        }
        //21
        private string _day21Visi = "Visible";
        public string day21Visi
        {
            get { return _day21Visi; }
            set { SetProperty(ref _day21Visi, value); }
        }
        private string _day21Back = "White";
        public string day21Back
        {
            get { return _day21Back; }
            set { SetProperty(ref _day21Back, value); }
        }

        private string _day21Fore = "Black";
        public string day21Fore
        {
            get { return _day21Fore; }
            set { SetProperty(ref _day21Fore, value); }
        }
        //22
        private string _day22Visi = "Visible";
        public string day22Visi
        {
            get { return _day22Visi; }
            set { SetProperty(ref _day22Visi, value); }
        }
        private string _day22Back = "White";
        public string day22Back
        {
            get { return _day22Back; }
            set { SetProperty(ref _day22Back, value); }
        }

        private string _day22Fore = "Black";
        public string day22Fore
        {
            get { return _day22Fore; }
            set { SetProperty(ref _day22Fore, value); }
        }
        //23
        private string _day23Visi = "Visible";
        public string day23Visi
        {
            get { return _day23Visi; }
            set { SetProperty(ref _day23Visi, value); }
        }
        private string _day23Back = "White";
        public string day23Back
        {
            get { return _day23Back; }
            set { SetProperty(ref _day23Back, value); }
        }

        private string _day23Fore = "Black";
        public string day23Fore
        {
            get { return _day23Fore; }
            set { SetProperty(ref _day23Fore, value); }
        }
        //24
        private string _day24Visi = "Visible";
        public string day24Visi
        {
            get { return _day24Visi; }
            set { SetProperty(ref _day24Visi, value); }
        }
        private string _day24Back = "White";
        public string day24Back
        {
            get { return _day24Back; }
            set { SetProperty(ref _day24Back, value); }
        }

        private string _day24Fore = "Black";
        public string day24Fore
        {
            get { return _day24Fore; }
            set { SetProperty(ref _day24Fore, value); }
        }
        //25
        private string _day25Visi = "Visible";
        public string day25Visi
        {
            get { return _day25Visi; }
            set { SetProperty(ref _day25Visi, value); }
        }
        private string _day25Back = "White";
        public string day25Back
        {
            get { return _day25Back; }
            set { SetProperty(ref _day25Back, value); }
        }

        private string _day25Fore = "Black";
        public string day25Fore
        {
            get { return _day25Fore; }
            set { SetProperty(ref _day25Fore, value); }
        }
        //26
        private string _day26Visi = "Visible";
        public string day26Visi
        {
            get { return _day26Visi; }
            set { SetProperty(ref _day26Visi, value); }
        }
        private string _day26Back = "White";
        public string day26Back
        {
            get { return _day26Back; }
            set { SetProperty(ref _day26Back, value); }
        }

        private string _day26Fore = "Black";
        public string day26Fore
        {
            get { return _day26Fore; }
            set { SetProperty(ref _day26Fore, value); }
        }
        //27
        private string _day27Visi = "Visible";
        public string day27Visi
        {
            get { return _day27Visi; }
            set { SetProperty(ref _day27Visi, value); }
        }
        private string _day27Back = "White";
        public string day27Back
        {
            get { return _day27Back; }
            set { SetProperty(ref _day27Back, value); }
        }

        private string _day27Fore = "Black";
        public string day27Fore
        {
            get { return _day27Fore; }
            set { SetProperty(ref _day27Fore, value); }
        }
        //28
        private string _day28Visi = "Visible";
        public string day28Visi
        {
            get { return _day28Visi; }
            set { SetProperty(ref _day28Visi, value); }
        }
        private string _day28Back = "White";
        public string day28Back
        {
            get { return _day28Back; }
            set { SetProperty(ref _day28Back, value); }
        }

        private string _day28Fore = "Black";
        public string day28Fore
        {
            get { return _day28Fore; }
            set { SetProperty(ref _day28Fore, value); }
        }
        //29
        private string _day29Visi = "Visible";
        public string day29Visi
        {
            get { return _day29Visi; }
            set { SetProperty(ref _day29Visi, value); }
        }
        private string _day29Back = "White";
        public string day29Back
        {
            get { return _day29Back; }
            set { SetProperty(ref _day29Back, value); }
        }

        private string _day29Fore = "Black";
        public string day29Fore
        {
            get { return _day29Fore; }
            set { SetProperty(ref _day29Fore, value); }
        }
        //30
        private string _day30Visi = "Visible";
        public string day30Visi
        {
            get { return _day30Visi; }
            set { SetProperty(ref _day30Visi, value); }
        }
        private string _day30Back = "White";
        public string day30Back
        {
            get { return _day30Back; }
            set { SetProperty(ref _day30Back, value); }
        }

        private string _day30Fore = "Black";
        public string day30Fore
        {
            get { return _day30Fore; }
            set { SetProperty(ref _day30Fore, value); }
        }
        //31
        private string _day31Visi = "Visible";
        public string day31Visi
        {
            get { return _day31Visi; }
            set { SetProperty(ref _day31Visi, value); }
        }
        private string _day31Back = "White";
        public string day31Back
        {
            get { return _day31Back; }
            set { SetProperty(ref _day31Back, value); }
        }

        private string _day31Fore = "Black";
        public string day31Fore
        {
            get { return _day31Fore; }
            set { SetProperty(ref _day31Fore, value); }
        }

        public static int Month { get; set; } = 0;

        #endregion


        #region 命令

        public System.Windows.Input.ICommand CancelTraining
        {
            get
            {
                return new DelegateCommand<string>((parameter) =>
                {
                    PromptMessage promptMessage = new PromptMessage();
                    promptMessage.messageLabel.Content = "将删除此次训练计划？";
                    promptMessage.Show();
                    Thread.Sleep(2000);
                    promptMessage.Close();

                    DB dB = new DB();
                    dB.DeleteTraining(new DateTime(DateTime.Now.Year, Month, int.Parse(parameter)), int.Parse(ReadConfigure.ReadParameter(@"\Login.txt")));

                    _ea.GetEvent<UpdateSentEvent>().Publish("update");
                });
            }
        }

        //向dashborad发送具体日期
        public System.Windows.Input.ICommand SendTime
        {
            get
            {
                return new DelegateCommand<string>((parameter) =>
                {
                    var format = DateTime.Now.Year.ToString() + @"/" + Month.ToString() + @"/" + parameter;
                    _ea.GetEvent<TimeSentEvent>().Publish(format);
                });
            }
        }

        #endregion


        #region  method

        private void ShowMonthFormat(string year, int mounth)
        {
            switch (mounth)
            {
                case 1:
                    ShowDate = "Jan " + year;
                    break;
                case 2:
                    ShowDate = "Feb " + year;
                    break;
                case 3:
                    ShowDate = "Mar " + year;
                    break;
                case 4:
                    ShowDate = "Apr " + year;
                    break;
                case 5:
                    ShowDate = "May " + year;
                    break;
                case 6:
                    ShowDate = "Jun " + year;
                    break;
                case 7:
                    ShowDate = "Jul " + year;
                    break;
                case 8:
                    ShowDate = "Aug " + year;
                    break;
                case 9:
                    ShowDate = "Sept " + year;
                    break;
                case 10:
                    ShowDate = "Oct " + year;
                    break;
                case 11:
                    ShowDate = "Nov " + year;
                    break;
                case 12:
                    ShowDate = "Dec " + year;
                    break;
            }

        }

        private void HideDate(int count)
        {
            switch (count)
            {
                case 1:
                    day31Visi = "hidden";
                    break;
                case 2:
                    day31Visi = "hidden";
                    day30Visi = "hidden";
                    break;
                case 3:
                    day31Visi = "hidden";
                    day30Visi = "hidden";
                    day29Visi = "hidden";
                    break;
            }
        }

        #endregion


        #region 命令声明

        public DelegateCommand TimeBackofCommand { get; private set; }
        public DelegateCommand TimeForwardCommand { get; private set; }

        #endregion


        #region  命令实现


        public void CalendarJump(int step)
        {
            try
            {
                day31Visi = "Visible";
                day30Visi = "Visible";
                day29Visi = "Visible";

                Month += step;

                if (Month >= 12)
                    Month = 12;

                if (Month <= 1)
                    Month = 1;

                int merchant = 31 - DateTime.DaysInMonth(DateTime.Now.Year, Month);
                HideDate(merchant);

                ShowMonthFormat(DateTime.Now.Year.ToString(), Month);
            }
            catch (Exception ex)
            {

            }
        }

        //日历错位设置
        private void Malposition()
        {
            var result = new DateTime(DateTime.Now.Year, Month, 1).DayOfWeek.ToString();

            switch (result)
            {
                case "Monday":
                    Complement = 0;
                    break;
                case "Tuesday":
                    Complement = 50;
                    break;
                case "Wednesday":
                    Complement = 100;
                    break;
                case "Thursday":
                    Complement = 150;
                    break;
                case "Friday":
                    Complement = 200;
                    break;
                case "Saturday":
                    Complement = 250;
                    break;
                case "Sunday":
                    Complement = 300;
                    break;
            }

        }

        public void TimeBackofExecute()
        {
            CalendarJump(-1);
            Malposition();
            Utilities();
        }


        public void TimeForwardExecute()
        {
            CalendarJump(1);
            Malposition();
            Utilities();
        }

        private void DefaultStyle()
        {
            day1Back = "White";
            day1Fore = "Black";
            day2Back = "White";
            day2Fore = "Black";
            day3Back = "White";
            day3Fore = "Black";
            day4Back = "White";
            day4Fore = "Black";
            day5Back = "White";
            day5Fore = "Black";
            day6Back = "White";
            day6Fore = "Black";
            day7Back = "White";
            day7Fore = "Black";
            day8Back = "White";
            day8Fore = "Black";
            day9Back = "White";
            day9Fore = "Black";
            day10Back = "White";
            day10Fore = "Black";
            day11Back = "White";
            day11Fore = "Black";
            day12Back = "White";
            day12Fore = "Black";
            day13Back = "White";
            day13Fore = "Black";
            day14Back = "White";
            day14Fore = "Black";
            day15Back = "White";
            day15Fore = "Black";
            day16Back = "White";
            day16Fore = "Black";
            day17Back = "White";
            day17Fore = "Black";
            day18Back = "White";
            day18Fore = "Black";
            day19Back = "White";
            day19Fore = "Black";
            day20Back = "White";
            day20Fore = "Black";
            day21Back = "White";
            day21Fore = "Black";
            day22Back = "White";
            day22Fore = "Black";
            day23Back = "White";
            day23Fore = "Black";
            day24Back = "White";
            day24Fore = "Black";
            day25Back = "White";
            day25Fore = "Black";
            day26Back = "White";
            day26Fore = "Black";
            day27Back = "White";
            day27Fore = "Black";
            day28Back = "White";
            day28Fore = "Black";
            day29Back = "White";
            day29Fore = "Black";
            day30Back = "White";
            day30Fore = "Black";
            day31Back = "White";
            day31Fore = "Black";
        }

        private void DisPlay_Today(int day)
        {
            switch (day)
            {
                case 1:
                    day1Back = "#d4237a";
                    day1Fore = "White";
                    break;
                case 2:
                    day2Back = "#d4237a";
                    day2Fore = "White";
                    break;
                case 3:
                    day3Back = "#d4237a";
                    day3Fore = "White";
                    break;
                case 4:
                    day4Back = "#d4237a";
                    day4Fore = "White";
                    break;
                case 5:
                    day5Back = "#d4237a";
                    day5Fore = "White";
                    break;
                case 6:
                    day6Back = "#d4237a";
                    day6Fore = "White";
                    break;
                case 7:
                    day7Back = "#d4237a";
                    day7Fore = "White";
                    break;
                case 8:
                    day8Back = "#d4237a";
                    day8Fore = "White";
                    break;
                case 9:
                    day9Back = "#d4237a";
                    day9Fore = "White";
                    break;
                case 10:
                    day10Back = "#d4237a";
                    day10Fore = "White";
                    break;
                case 11:
                    day11Back = "#d4237a";
                    day11Fore = "White";
                    break;
                case 12:
                    day12Back = "#d4237a";
                    day12Fore = "White";
                    break;
                case 13:
                    day13Back = "#d4237a";
                    day13Fore = "White";
                    break;
                case 14:
                    day14Back = "#d4237a";
                    day14Fore = "White";
                    break;
                case 15:
                    day15Back = "#d4237a";
                    day15Fore = "White";
                    break;
                case 16:
                    day16Back = "#d4237a";
                    day16Fore = "White";
                    break;
                case 17:
                    day17Back = "#d4237a";
                    day17Fore = "White";
                    break;
                case 18:
                    day18Back = "#d4237a";
                    day18Fore = "White";
                    break;
                case 19:
                    day19Back = "#d4237a";
                    day19Fore = "White";
                    break;
                case 20:
                    day20Back = "#d4237a";
                    day20Fore = "White";
                    break;
                case 21:
                    day21Back = "#d4237a";
                    day21Fore = "White";
                    break;
                case 22:
                    day22Back = "#d4237a";
                    day22Fore = "White";
                    break;
                case 23:
                    day23Back = "#d4237a";
                    day23Fore = "White";
                    break;
                case 24:
                    day23Back = "#d4237a";
                    day23Fore = "White";
                    break;
                case 25:
                    day25Back = "#d4237a";
                    day25Fore = "White";
                    break;
                case 26:
                    day26Back = "#d4237a";
                    day26Fore = "White";
                    break;
                case 27:
                    day27Back = "#d4237a";
                    day27Fore = "White";
                    break;
                case 28:
                    day28Back = "#d4237a";
                    day28Fore = "White";
                    break;
                case 29:
                    day29Back = "#d4237a";
                    day29Fore = "White";
                    break;
                case 30:
                    day30Back = "#d4237a";
                    day30Fore = "White";
                    break;
                case 31:
                    day31Back = "#d4237a";
                    day31Fore = "White";
                    break;
            }
        }

        private void DisPlay(int day)
        {
            switch (day)
            {
                case 1:
                    day1Back = "#FF8B50";
                    day1Fore = "White";
                    break;
                case 2:
                    day2Back = "#FF8B50";
                    day2Fore = "White";
                    break;
                case 3:
                    day3Back = "#FF8B50";
                    day3Fore = "White";
                    break;
                case 4:
                    day4Back = "#FF8B50";
                    day4Fore = "White";
                    break;
                case 5:
                    day5Back = "#FF8B50";
                    day5Fore = "White";
                    break;
                case 6:
                    day6Back = "#FF8B50";
                    day6Fore = "White";
                    break;
                case 7:
                    day7Back = "#FF8B50";
                    day7Fore = "White";
                    break;
                case 8:
                    day8Back = "#FF8B50";
                    day8Fore = "White";
                    break;
                case 9:
                    day9Back = "#FF8B50";
                    day9Fore = "White";
                    break;
                case 10:
                    day10Back = "#FF8B50";
                    day10Fore = "White";
                    break;
                case 11:
                    day11Back = "#FF8B50";
                    day11Fore = "White";
                    break;
                case 12:
                    day12Back = "#FF8B50";
                    day12Fore = "White";
                    break;
                case 13:
                    day13Back = "#FF8B50";
                    day13Fore = "White";
                    break;
                case 14:
                    day14Back = "#FF8B50";
                    day14Fore = "White";
                    break;
                case 15:
                    day15Back = "#FF8B50";
                    day15Fore = "White";
                    break;
                case 16:
                    day16Back = "#FF8B50";
                    day16Fore = "White";
                    break;
                case 17:
                    day17Back = "#FF8B50";
                    day17Fore = "White";
                    break;
                case 18:
                    day18Back = "#FF8B50";
                    day18Fore = "White";
                    break;
                case 19:
                    day19Back = "#FF8B50";
                    day19Fore = "White";
                    break;
                case 20:
                    day20Back = "#FF8B50";
                    day20Fore = "White";
                    break;
                case 21:
                    day21Back = "#FF8B50";
                    day21Fore = "White";
                    break;
                case 22:
                    day22Back = "#FF8B50";
                    day22Fore = "White";
                    break;
                case 23:
                    day23Back = "#FF8B50";
                    day23Fore = "White";
                    break;
                case 24:
                    day23Back = "#FF8B50";
                    day23Fore = "White";
                    break;
                case 25:
                    day25Back = "#FF8B50";
                    day25Fore = "White";
                    break;
                case 26:
                    day26Back = "#FF8B50";
                    day26Fore = "White";
                    break;
                case 27:
                    day27Back = "#FF8B50";
                    day27Fore = "White";
                    break;
                case 28:
                    day28Back = "#FF8B50";
                    day28Fore = "White";
                    break;
                case 29:
                    day29Back = "#FF8B50";
                    day29Fore = "White";
                    break;
                case 30:
                    day30Back = "#FF8B50";
                    day30Fore = "White";
                    break;
                case 31:
                    day31Back = "#FF8B50";
                    day31Fore = "White";
                    break;
            }
        }

        #endregion

        //更新
        private void MessageReceived(string message) => Utilities();

        private void Utilities()
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    DefaultStyle();

                    DB dB = new DB();
                    var result = dB.GetTrainingDate(Month);

                    foreach (var item in result)
                        DisPlay(item.startTime.Day);

                    //设置系统今日，默认显示
                    DisPlay_Today(DateTime.Now.Day);
                }
                catch (Exception ex)
                {

                }
            });
        }

        //构造函数
        public TimeAreaViewModel(IEventAggregator ea)
        {
            _ea = ea;
            _ea.GetEvent<UpdateSentEvent>().Subscribe(MessageReceived);

            //命令实例化
            TimeBackofCommand = new DelegateCommand(TimeBackofExecute);
            TimeForwardCommand = new DelegateCommand(TimeForwardExecute);

            Month = DateTime.Now.Month;

            Utilities();
            Malposition();

            try
            {
                int merchant = 31 - DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                HideDate(merchant);

                ShowMonthFormat(DateTime.Now.Year.ToString(), Month);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
