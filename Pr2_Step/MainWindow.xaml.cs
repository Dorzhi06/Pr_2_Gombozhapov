using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pr2_Step
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Persons> pers = new List<Persons>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Okey_Click(object sender, RoutedEventArgs e)
        {
            DateTime time = (DateTime)date_of_birdth.SelectedDate;
            string[] buf = time.ToString().Split('.');
            int day = Convert.ToInt32(buf[0]);
            int month = Convert.ToInt32(buf[1]);
            string[] yearString = buf[2].Split(' ');
            int year = Convert.ToInt32(yearString[0]);

            DateTime timeNow = DateTime.Now;
            string[] bufNow = timeNow.ToString().Split('.');
            int dayNow = Convert.ToInt32(bufNow[0]);
            int monthNow = Convert.ToInt32(bufNow[1]);
            string[] yearStringNow = bufNow[2].Split(' ');
            int yearNow = Convert.ToInt32(yearStringNow[0]);

            double yearPeople;
            if (monthNow > month)
            {
                yearPeople = yearNow - year;
            }
            else
            {
                if (dayNow > day || dayNow == day)
                {
                    yearPeople = yearNow - year;
                }
                else
                {
                    yearPeople = yearNow - year - 1;
                }
            }

            textYear.Visibility = Visibility.Visible;
            numberYear.Visibility = Visibility.Visible;
            if (yearPeople % 10 < 5 && yearPeople < 10)
            {
                numberYear.Text = yearPeople.ToString() + " Года";
            }
            else
            {
                if (yearPeople >= 10 && yearPeople <= 20)
                {
                    numberYear.Text = yearPeople.ToString() + " Лет";
                }
                else
                {
                    if (yearPeople > 20 && yearPeople % 10 < 5)
                    {
                        if(yearPeople%10==1)
                        {
                            numberYear.Text = yearPeople.ToString() + " Год";
                        }
                        else
                        {
                            numberYear.Text = yearPeople.ToString() + " Года";
                        }
                        
                    }
                    else
                    {
                        numberYear.Text = yearPeople.ToString() + " Лет";
                    }
                }
            }

            Persons per = new Persons(pers.Count() + 1, surname.Text, name.Text, lastname.Text, (DateTime)date_of_birdth.SelectedDate);
            pers.Add(per);
        }
    }
}

