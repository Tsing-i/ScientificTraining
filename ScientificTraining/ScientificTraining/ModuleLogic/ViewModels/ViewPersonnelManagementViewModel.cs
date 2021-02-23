//Prsim框架
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
//用户自定义
using ModuleLogic.Views;
using ModuleLogic.Entity;
//系统
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows;

namespace ModuleLogic.ViewModels
{
    public class ViewPersonnelManagementViewModel : BindableBase, INavigationAware
    {
        #region 属性

        IEventAggregator _ea;

        private AddPerson addPerson;
        public ListViewData listViewData { get; set; }


        private ICollectionView personCollectionView;
        public ICollectionView PersonCollectionView
        {
            get
            {
                if (personCollectionView == null)
                {
                    personCollectionView = CollectionViewSource.GetDefaultView(ObservableObject);
                }
                return personCollectionView;
            }
        }


        public ObservableCollection<ListViewData> ObservableObject = new ObservableCollection<ListViewData>();

        #endregion


        #region 命令

        private void CommandOrder()
        {
            ObservableObject.Clear();

            DB dB = new DB();
            var reuslt = dB.GetUsers(ReadConfigure.ReadParameter(@"\venue.txt"));

            foreach (user item in reuslt)
            {
                ObservableObject.Add(new ListViewData()
                {
                    name = item.real_name,
                    power = GetPermissionName(item.role),
                    usr = item.user_name,
                    pwd = item.password,
                    remarks = item.remarks
                });
            }
        }

        //刷新
        public System.Windows.Input.ICommand RefreshCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    CommandOrder();
                });
            }
        }

        //增加
        public System.Windows.Input.ICommand AddCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (addPerson == null)
                        addPerson = new AddPerson();
                    addPerson.Show();
                });
            }
        }

        //删除
        public System.Windows.Input.ICommand DeleteCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (listViewData == null)
                        return;

                    DB dB = new DB();
                    dB.DeleteUser(listViewData.name);

                    CommandOrder();
                });
            }
        }

        #endregion

        //构造函数
        public ViewPersonnelManagementViewModel(IEventAggregator ea)
        {
            _ea = ea;

            DB dB = new DB();
            var reuslt = dB.GetUsers(ReadConfigure.ReadParameter(@"\venue.txt"));

            foreach (user item in reuslt)
            {
                ObservableObject.Add(new ListViewData()
                {
                    name = item.real_name,
                    power = GetPermissionName(item.role),
                    usr = item.user_name,
                    pwd = item.password,
                    remarks = item.remarks
                });
            }
        }

        #region 接口重写

        public void OnNavigatedTo(NavigationContext navigationContext)
        {

        }

        public bool IsNavigationTarget(NavigationContext navigationContext) => true;

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        #endregion


        private string GetPermissionName(int role)
        {
            string name = string.Empty;

            switch (role)
            {
                case 1:
                    name = "运动员";
                    break;
                case 2:
                    name = "教练";
                    break;
                case 3:
                    name = "系统管理员";
                    break;
                case 4:
                    name = "队医";
                    break;
                case 5:
                    name = "领队";
                    break;
            }

            return name;
        }

    }
}
