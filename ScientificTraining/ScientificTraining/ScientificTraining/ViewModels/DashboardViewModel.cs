using System.IO;
//用户自定义
using UsingEventAggregator.Core;
//Prsim框架
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System.Diagnostics;
using System;
using System.Windows.Forms;

namespace ScientificTraining.ViewModels
{
    public class DashboardViewModel : BindableBase
    {
        IEventAggregator _ea;
        private readonly IRegionManager _regionManager;

        #region 属性

        private string _photo = "/Images/head.png";

        public string photo
        {
            get { return _photo; }
            set { SetProperty(ref _photo, value); }
        }

        private string _title = "训科医";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        #endregion

        #region 命令

        public System.Windows.Input.ICommand HeadPortrait
        {
            get
            {
                return new DelegateCommand<string>((parameter) =>
                {
                    try
                    {
                        System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();
                        dialog.Multiselect = false;
                        dialog.Title = "请选择文件夹";

                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            string pLocalFilePath = dialog.FileName;
                            var file = new FileInfo(pLocalFilePath);
                            string pSaveFilePath = System.AppDomain.CurrentDomain.BaseDirectory + @"HeadPortrait\\" + file.Name;
                            if (File.Exists(pLocalFilePath))
                                File.Copy(pLocalFilePath, pSaveFilePath, true);

                            photo = pSaveFilePath;

                            string line = "";
                            using (StreamReader sr = new StreamReader(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Login.txt"))
                            {
                                line = sr.ReadLine();
                            }

                            using (StreamWriter sw = new StreamWriter(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\HeadPortrait.txt"))
                            {
                                sw.WriteLine(photo);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                });
            }
        }


        public DelegateCommand<string> NavigateCommand { get; private set; }

        #endregion

        //构造函数
        public DashboardViewModel(IRegionManager regionManager, IEventAggregator ea)
        {
            _regionManager = regionManager;
            _ea = ea;

            NavigateCommand = new DelegateCommand<string>(Navigate);
            _ea.GetEvent<MessageSentEvent>().Subscribe(MessageReceived);

            try
            {
                using (StreamReader sr = new StreamReader(System.AppDomain.CurrentDomain.BaseDirectory + @"HeadPortrait.txt"))
                {
                    photo = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region 实现

        //消息处理
        private void MessageReceived(string message) => Navigate(message);

        public void Navigate(string navigatePath)
        {
            if (navigatePath != null)
                _regionManager.RequestNavigate("ContentRegion", navigatePath);
        }

        #endregion

    }
}
