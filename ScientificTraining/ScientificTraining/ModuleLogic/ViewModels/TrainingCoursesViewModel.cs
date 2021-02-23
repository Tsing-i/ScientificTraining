//Prsim框架
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
//用户自定义
using UsingEventAggregator.Core;
using ModuleLogic.Views;
using ModuleLogic.Entity;
//
using System.Linq;
using System.ComponentModel;
using System.Windows.Data;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Collections.Generic;


namespace ModuleLogic.ViewModels
{
    public class TrainingCoursesViewModel : BindableBase
    {
        IEventAggregator _ea;
        private readonly IRegionManager _regionManager;

        #region

        private string _Dashboard_PC = "Visible";
        public string Dashboard_PC
        {
            get { return _Dashboard_PC; }
            set { SetProperty(ref _Dashboard_PC, value); }
        }

        private string _Dashboard_Android = "Hidden";
        public string Dashboard_Android
        {
            get { return _Dashboard_Android; }
            set { SetProperty(ref _Dashboard_Android, value); }
        }

        private string _DivingTitleTemplateVisibility = "Visible";
        public string DivingTitleTemplateVisibility
        {
            get { return _DivingTitleTemplateVisibility; }
            set { SetProperty(ref _DivingTitleTemplateVisibility, value); }
        }

        private string _TrampolineTitleTemplateVisibility = "Hidden";
        public string TrampolineTitleTemplateVisibility
        {
            get { return _TrampolineTitleTemplateVisibility; }
            set { SetProperty(ref _TrampolineTitleTemplateVisibility, value); }
        }

        #endregion


        #region


        private string _UserPosition;
        public string UserPosition
        {
            get { return _UserPosition; }
            set { SetProperty(ref _UserPosition, value); }
        }

        private string _Coach;
        public string Coach
        {
            get { return _Coach; }
            set { SetProperty(ref _Coach, value); }
        }

        private string _ExactDate;
        public string ExactDate
        {
            get { return _ExactDate; }
            set { SetProperty(ref _ExactDate, value); }
        }

        private string _TextDashboard_1_Text;
        public string TextDashboard_1_Text
        {
            get { return _TextDashboard_1_Text; }
            set { SetProperty(ref _TextDashboard_1_Text, value); }
        }

        private string _TextDashboard_2_Text;
        public string TextDashboard_2_Text
        {
            get { return _TextDashboard_2_Text; }
            set { SetProperty(ref _TextDashboard_2_Text, value); }
        }

        private string _TextDashboard_3_Text;
        public string TextDashboard_3_Text
        {
            get { return _TextDashboard_3_Text; }
            set { SetProperty(ref _TextDashboard_3_Text, value); }
        }

        private string _TextDashboard_4_Text;
        public string TextDashboard_4_Text
        {
            get { return _TextDashboard_4_Text; }
            set { SetProperty(ref _TextDashboard_4_Text, value); }
        }

        private string _TextDashboard_5_Text;
        public string TextDashboard_5_Text
        {
            get { return _TextDashboard_5_Text; }
            set { SetProperty(ref _TextDashboard_5_Text, value); }
        }

        private string _TextDashboard_6_Text;
        public string TextDashboard_6_Text
        {
            get { return _TextDashboard_6_Text; }
            set { SetProperty(ref _TextDashboard_6_Text, value); }
        }

        private string _TextDashboard_7_Text;
        public string TextDashboard_7_Text
        {
            get { return _TextDashboard_7_Text; }
            set { SetProperty(ref _TextDashboard_7_Text, value); }
        }

        private string _TextDashboard_8_Text;
        public string TextDashboard_8_Text
        {
            get { return _TextDashboard_8_Text; }
            set { SetProperty(ref _TextDashboard_8_Text, value); }
        }

        private string _TextDashboard_9_Text;
        public string TextDashboard_9_Text
        {
            get { return _TextDashboard_9_Text; }
            set { SetProperty(ref _TextDashboard_9_Text, value); }
        }

        private string _TextDashboard_10_Text;
        public string TextDashboard_10_Text
        {
            get { return _TextDashboard_10_Text; }
            set { SetProperty(ref _TextDashboard_10_Text, value); }
        }

        private string _TextDashboard_11_Text;
        public string TextDashboard_11_Text
        {
            get { return _TextDashboard_11_Text; }
            set { SetProperty(ref _TextDashboard_11_Text, value); }
        }

        private ICollectionView androidCollectionView;
        public ICollectionView AndroidCollectionView
        {
            get
            {
                if (androidCollectionView == null)
                {
                    androidCollectionView = CollectionViewSource.GetDefaultView(AndroidObservable);
                }
                return androidCollectionView;
            }
        }

        public ObservableCollection<string> AndroidObservable = new ObservableCollection<string>();

        #endregion


        #region 命令

        private int index = 0;
        private List<plan> plans = new List<plan>();

        DelegateCommand<ListBox> _SelectionChangedCmd = null;
        public DelegateCommand<ListBox> SelectionChangedCmd
        {
            get
            {
                if (this._SelectionChangedCmd == null)
                {
                    this._SelectionChangedCmd = new DelegateCommand<ListBox>(SelectionChanged);
                }

                return this._SelectionChangedCmd;
            }
        }
        void SelectionChanged(ListBox listBox)
        {
            if (plans == null || plans.Count == 0)
                return;

            var temp = listBox.SelectedItem as string;
            index = plans.FindIndex(delegate (plan p) { return p.startTime.ToString() == temp; });

            if (index < 0)
                return;

            if (plans[index].text_content_android == "" || plans[index].text_content_android == null)
            {
                Dashboard_PC = "Visible";
                Dashboard_Android = "Hidden";

                if (plans[index].text_content == null)
                    return;

                var list = plans[index].text_content.Split('#').ToList();

                //为空跳过
                if (list.Count < 10) return;

                TextDashboard_1_Text = list[1];
                TextDashboard_2_Text = list[2];
                TextDashboard_3_Text = list[3];
                TextDashboard_4_Text = list[4];
                TextDashboard_5_Text = list[5];
                TextDashboard_6_Text = list[6];
                TextDashboard_7_Text = list[7];
                TextDashboard_8_Text = list[8];
                TextDashboard_9_Text = list[9];
                TextDashboard_10_Text = list[10];
            }
            else
            {
                Dashboard_PC = "Hidden";
                Dashboard_Android = "Visible";
                TextDashboard_11_Text = plans[index].text_content_android.Replace("#", "\r\n"); ;
            }
        }


        public System.Windows.Input.ICommand PopupVirtualKeyboard
        {
            get
            {
                return new DelegateCommand<string>((str) =>
                {
                    DesignatedTraining designatedTraining = new DesignatedTraining(str);
                    designatedTraining.ShowDialog();
                });
            }
        }

        #endregion

        public void SendMessage(string message) => _ea.GetEvent<UpdateSentEvent>().Publish(message);

        //构造函数
        public TrainingCoursesViewModel(IRegionManager regionManager, IEventAggregator ea)
        {
            _regionManager = regionManager;

            _ea = ea;
            _ea.GetEvent<DashboardSentEvent>().Subscribe(MessageReceived);
            _ea.GetEvent<TimeSentEvent>().Subscribe(MessageReceived2);

            string type = ReadConfigure.ReadParameter(@"\type.txt");

            switch (type)
            {
                case "蹦床":
                    DivingTitleTemplateVisibility = "Hidden";
                    TrampolineTitleTemplateVisibility = "Visible";
                    break;
                case "跳水":
                    DivingTitleTemplateVisibility = "Visible";
                    TrampolineTitleTemplateVisibility = "Hidden";
                    break;
                case "体操":
                    break;
                case "田径":
                    break;
                default:
                    break;
            }
        }

        #region 实现

        private void MessageReceived2(string message)
        {
            TextDashboard_1_Text = string.Empty;
            TextDashboard_2_Text = string.Empty;
            TextDashboard_3_Text = string.Empty;
            TextDashboard_4_Text = string.Empty;
            TextDashboard_5_Text = string.Empty;
            TextDashboard_6_Text = string.Empty;
            TextDashboard_7_Text = string.Empty;
            TextDashboard_8_Text = string.Empty;
            TextDashboard_9_Text = string.Empty;
            TextDashboard_10_Text = string.Empty;
            TextDashboard_11_Text = string.Empty;

            ExactDate = message;

            message = message.Replace("/", "-");

            int temp = int.Parse(message.Split('-')[2]);
            if (temp < 10)
                message = message.Insert(message.Length - 1, "0");

            int temp1 = int.Parse(message.Split('-')[1]);
            if (temp1 < 10)
                message = message.Insert(message.Length - 4, "0");

            DB dB = new DB();
            plans = dB.GetTrainingPlanWithOneDay(message);

            AndroidObservable.Clear();

            foreach (var itme in plans)
                AndroidObservable.Add(itme.startTime.ToString());

            if (plans == null || plans.Count == 0)
                return;

            if (plans[index].text_content_android == "" || plans[index].text_content_android == null)
            {
                Dashboard_PC = "Visible";
                Dashboard_Android = "Hidden";

                if (plans[index].text_content == null)
                    return;

                var list = plans[index].text_content.Split('#').ToList();

                //任务计划为空，直接不显示
                if (list.Count < 10) return;

                TextDashboard_1_Text = list[1];
                TextDashboard_2_Text = list[2];
                TextDashboard_3_Text = list[3];
                TextDashboard_4_Text = list[4];
                TextDashboard_5_Text = list[5];
                TextDashboard_6_Text = list[6];
                TextDashboard_7_Text = list[7];
                TextDashboard_8_Text = list[8];
                TextDashboard_9_Text = list[9];
                TextDashboard_10_Text = list[10];
            }
            else
            {
                Dashboard_PC = "Hidden";
                Dashboard_Android = "Visible";
                TextDashboard_11_Text = plans[index].text_content_android.Replace("#", "\r\n"); ;
            }
        }

        private void MessageReceived(string message)
        {
            var list = message.Split('#');

            switch (list.First())
            {
                case "Dashboard_1":
                    {
                        if (list[1] == "Space")
                        {
                            TextDashboard_1_Text += " ";
                        }
                        else if (list[1] == "Enter")
                        {
                            TextDashboard_1_Text += "\r\n";
                        }
                        else
                        {
                            TextDashboard_1_Text += list[1];
                        }
                    }
                    break;
                case "Dashboard_2":
                    {
                        if (list[1] == "Space")
                        {
                            TextDashboard_2_Text += " ";
                        }
                        else if (list[1] == "Enter")
                        {
                            TextDashboard_2_Text += "\r\n";
                        }
                        else
                        {
                            TextDashboard_2_Text += list[1];
                        }
                    }
                    break;
                case "Dashboard_3":
                    {
                        if (list[1] == "Space")
                        {
                            TextDashboard_3_Text += " ";
                        }
                        else if (list[1] == "Enter")
                        {
                            TextDashboard_3_Text += "\r\n";
                        }
                        else
                        {
                            TextDashboard_3_Text += list[1];
                        }
                    }
                    break;
                case "Dashboard_4":
                    {
                        if (list[1] == "Space")
                        {
                            TextDashboard_4_Text += " ";
                        }
                        else if (list[1] == "Enter")
                        {
                            TextDashboard_4_Text += "\r\n";
                        }
                        else
                        {
                            TextDashboard_4_Text += list[1];
                        }
                    }
                    break;
                case "Dashboard_5":
                    {
                        if (list[1] == "Space")
                        {
                            TextDashboard_5_Text += " ";
                        }
                        else if (list[1] == "Enter")
                        {
                            TextDashboard_5_Text += "\r\n";
                        }
                        else
                        {
                            TextDashboard_5_Text += list[1];
                        }
                    }
                    break;
                case "Dashboard_6":
                    {
                        if (list[1] == "Space")
                        {
                            TextDashboard_6_Text += " ";
                        }
                        else if (list[1] == "Enter")
                        {
                            TextDashboard_6_Text += "\r\n";
                        }
                        else
                        {
                            TextDashboard_6_Text += list[1];
                        }
                    }
                    break;
                case "Dashboard_7":
                    {
                        if (list[1] == "Space")
                        {
                            TextDashboard_7_Text += " ";
                        }
                        else if (list[1] == "Enter")
                        {
                            TextDashboard_7_Text += "\r\n";
                        }
                        else
                        {
                            TextDashboard_7_Text += list[1];
                        }
                    }
                    break;
                case "Dashboard_8":
                    {
                        if (list[1] == "Space")
                        {
                            TextDashboard_8_Text += " ";
                        }
                        else if (list[1] == "Enter")
                        {
                            TextDashboard_8_Text += "\r\n";
                        }
                        else
                        {
                            TextDashboard_8_Text += list[1];
                        }
                    }
                    break;
                case "Dashboard_9":
                    {
                        if (list[1] == "Space")
                        {
                            TextDashboard_9_Text += " ";
                        }
                        else if (list[1] == "Enter")
                        {
                            TextDashboard_9_Text += "\r\n";
                        }
                        else
                        {
                            TextDashboard_9_Text += list[1];
                        }
                    }
                    break;
                case "Dashboard_10":
                    {
                        if (list[1] == "Space")
                        {
                            TextDashboard_9_Text += " ";
                        }
                        else if (list[1] == "Enter")
                        {
                            TextDashboard_9_Text += "\r\n";
                        }
                        else
                        {
                            TextDashboard_9_Text += list[1];
                        }
                    }
                    break;
            }
        }

        //页面导航
        public void Navigate(string adaptationArea, string navigatePath)
        {
            if (navigatePath != null)
                _regionManager.RequestNavigate(adaptationArea, navigatePath);
        }

        #endregion


    }
}
