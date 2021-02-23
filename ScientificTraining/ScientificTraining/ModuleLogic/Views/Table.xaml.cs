using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows;
//用户自定义
using LiveCharts;

namespace ModuleLogic.Views
{
    class ViewModelBase : INotifyPropertyChanged
    {
        List<string> labels = new List<string>();
        List<double> data = new List<double>();
        SeriesCollection seriesBar = new SeriesCollection();

        public List<double> Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
                RaisePropertyChanged("Data");
            }
        }

        public List<string> Labels
        {
            get
            {
                return labels;
            }
            set
            {
                labels = value;
                RaisePropertyChanged("Labels");
            }
        }

        public SeriesCollection SeriesBar
        {
            get
            {
                return seriesBar;
            }
            set
            {
                seriesBar = value;
                RaisePropertyChanged("SeriesBar");
            }
        }

        public ViewModelBase()
        {
            Labels = new List<string>();

            var line = ReadConfigure.ReadParameter(@"\instrument.txt");

            if (line == "体测仪")
            {
                for (int i = 1; i < 25; i++)
                    Labels.Add(i.ToString());
            }
            else if (line == "手环与体脂秤")
            {
                for (int j = 1; j < 21; j++)
                    Labels.Add(j.ToString());
            }
            else if (line == "inbody") 
            {
                for (int j = 1; j < 15; j++)
                    Labels.Add(j.ToString());
            }

            ChartValues<double> cv = new ChartValues<double>();
            cv.AddRange(TransferStation._parameter);

            var barSerie = new BarSeries
            {
                Title = "Values",
                Values = cv,
            };

            SeriesBar.Clear();
            SeriesBar.Add(barSerie);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(String propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }

    //temp
    class TransferStation
    {
        public static List<double> _parameter = new List<double>();
    }

    public partial class Table : Window
    {
        public Table(List<double> parameter,string userName)
        {
            InitializeComponent();

            var line = ReadConfigure.ReadParameter(@"\instrument.txt");

            if (line == "体测仪")
            {
                userNameLabel1.Content = userName;
                this.wrapPanel1.Visibility = Visibility.Visible;
                this.wrapPanel2.Visibility = Visibility.Hidden;
                this.wrapPanel3.Visibility = Visibility.Hidden;
            }
            else if (line == "手环与体脂秤")
            {
                userNameLabel2.Content = userName;
                this.wrapPanel2.Visibility = Visibility.Visible;
                this.wrapPanel1.Visibility = Visibility.Hidden;
                this.wrapPanel3.Visibility = Visibility.Hidden;
            }
            else if (line == "inbody")
            {
                userNameLabel3.Content = userName;
                this.wrapPanel3.Visibility = Visibility.Visible;
                this.wrapPanel1.Visibility = Visibility.Hidden;
                this.wrapPanel2.Visibility = Visibility.Hidden;  
            }

            TransferStation._parameter.Clear();
            TransferStation._parameter = parameter;

            this.DataContext = new ViewModelBase();
            this.Topmost = true;
        }

        //pdf导出
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string jpg = string.Empty;
                string pdf = string.Empty;

                System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    jpg = dialog.SelectedPath + @"\" + Guid.NewGuid() + @".jpg";
                    pdf = dialog.SelectedPath + @"\" + Guid.NewGuid() + @".pdf";
                }

                var myPDF = new MyPDF();
                myPDF.CreatePDF(this.grid1, jpg, pdf);

            }
            catch (Exception ex)
            {

            }
        }
    }
}
