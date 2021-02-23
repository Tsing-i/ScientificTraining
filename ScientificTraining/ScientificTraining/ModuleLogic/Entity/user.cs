using System;
//用户自定义
using Prism.Mvvm;
using SqlSugar;

namespace ModuleLogic.Entity
{
    //用户
    public class user : BindableBase
    {
        private int _user_id;
        public int user_id
        {
            get { return _user_id; }
            set => SetProperty(ref _user_id, value);
        }

        private string _user_name;
        public string user_name
        {
            get { return _user_name; }
            set => SetProperty(ref _user_name, value);
        }

        private string _password;
        public string password
        {
            get { return _password; }
            set => SetProperty(ref _password, value);
        }

        private string _real_name;
        public string real_name
        {
            get { return _real_name; }
            set => SetProperty(ref _real_name, value);
        }

        private string _sex;
        public string sex
        {
            get { return _sex; }
            set => SetProperty(ref _sex, value);
        }

        private DateTime _birthday;
        public DateTime birthday
        {
            get { return _birthday; }
            set => SetProperty(ref _birthday, value);
        }

        private string _telephonenumber;
        public string telephonenumber
        {
            get { return _telephonenumber; }
            set => SetProperty(ref _telephonenumber, value);
        }

        private string _email;
        public string email
        {
            get { return _email; }
            set => SetProperty(ref _email, value);
        }

        private int _role;
        public int role
        {
            get { return _role; }
            set => SetProperty(ref _role, value);
        }

        private string _remarks;
        public string remarks
        {
            get { return _remarks; }
            set => SetProperty(ref _remarks, value);
        }

        private string _user_image;
        public string user_image
        {
            get { return _user_image; }
            set => SetProperty(ref _user_image, value);
        }

        private int _coach_id;
        public int coach_id
        {
            get { return _coach_id; }
            set => SetProperty(ref _coach_id, value);
        }

        private string _venue;
        public string venue
        {
            get { return _venue; }
            set => SetProperty(ref _venue, value);
        }

        private int _type;
        public int type
        {
            get { return _type; }
            set => SetProperty(ref _type, value);
        }
    }

}
