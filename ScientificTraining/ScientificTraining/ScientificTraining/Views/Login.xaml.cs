using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows;

namespace ScientificTraining.Views
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();

            string venue = string.Empty;

            var file = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\venue.txt";
            using (StreamReader sr = new StreamReader(file))
            {
                venue = sr.ReadLine();
            }

            region.Content = venue;
        }

        private void SignOut_Click(object sender, RoutedEventArgs e) => this.Close();


        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    var file = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Login.txt";

                    sqlSugarhelper sql = new sqlSugarhelper();
                    var result = sql.ValidateLogon(projectSupport.Text);

                    if (result != null)
                    {
                        if (result.role == 2 || result.role == 3 || result.role == 4 || result.role == 5)
                        {
                            using (StreamWriter sw = new StreamWriter(file))
                            {
                                sw.WriteLine(result.user_id);
                            }

                            wrapPanel2.Visibility = Visibility.Visible;
                            wrapPanel1.Visibility = Visibility.Collapsed;

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("请使用教练员账号登录！");
                            if (File.Exists(file))
                                File.Delete(file);
                        }
                    }
                    else
                    {
                        wrapPanel2.Visibility = Visibility.Collapsed;
                        wrapPanel1.Visibility = Visibility.Visible;
                        File.Delete(file);
                    }

                }));
            });

        }

    }
}
