using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;

namespace Kontroltoo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContPag : ContentPage
    {
        Grid grd;
        Label lbl, lbl1;
        TimePicker time1;
        Image img;
        public ContPag()
        {
            InitializeComponent();
            //BackgroundColor-------------------------------------------------------------------------------------------------------------------------------
            BackgroundColor = Color.LightBlue;
            //Grid------------------------------------------------------------------------------------------------------------------------------------------
            Grid grd = new Grid();
            //Columndefinition------------------------------------------------------------------------------------------------------------------------------
            ColumnDefinition colDef1 = new ColumnDefinition();
            ColumnDefinition colDef2 = new ColumnDefinition();
            grd.ColumnDefinitions.Add(colDef1);
            grd.ColumnDefinitions.Add(colDef2);

            //RowDefinition---------------------------------------------------------------------------------------------------------------------------------
            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            grd.RowDefinitions.Add(rowDef1);
            grd.RowDefinitions.Add(rowDef2);
            grd.RowDefinitions.Add(rowDef3);

            //Label-----------------------------------------------------------------------------------------------------------------------------------------
            lbl = new Label { Text = "You choose the time", BackgroundColor = Color.LightSkyBlue, HorizontalTextAlignment = TextAlignment.Center };
            
            grd.Children.Add(lbl, 0, 0);
            Grid.SetColumnSpan(lbl, 2);

            //Timepicker------------------------------------------------------------------------------------------------------------------------------------
            time1 = new TimePicker()
            {
                Time = new TimeSpan(18, 0, 0),
                
            };
            time1.PropertyChanged += Time1_PropertyChanged1;
            grd.Children.Add(time1, 0, 1);
            Grid.SetColumnSpan(time1, 2);
            //Label1----------------------------------------------------------------------------------------------------------------------------------------
            lbl1 = new Label
            {
                Text = "Thank you for choose the time",
            };
            grd.Children.Add(lbl1, 0, 2);
            Grid.SetColumnSpan(lbl1, 2);
            //Images----------------------------------------------------------------------------------------------------------------------------------------
            img = new Image
            {
            };
            grd.Children.Add(img, 0, 3);
            Grid.SetColumnSpan(img, 2);


            Content = grd;
        }
        //Functions------------------------------------------------------------------------------------------------------------------------------------

        private void Time1_PropertyChanged1(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                var time = time1.Time.Hours;
                if (time == 0)
                {
                    lbl.Text = "Сплю";
                    img.Source = "sleep.jpg";
                }
                else if (time == 1)
                {
                    lbl.Text = "Бег";
                    img.Source = "Beg.jpg";
                }
                else if (time == 2)
                {
                    lbl.Text = "Обед";
                    img.Source = "Obed.jpg";
                }
                else if (time == 3)
                {
                    lbl.Text = "Работа";
                    img.Source = "Rabota.jpg";
                }
                else if (time == 4)
                {
                    lbl.Text = "Сон";
                    img.Source = "sleep.jpg";
                }
                else if (time == 5)
                {
                    lbl.Text = "Сон кота";
                    img.Source = "Smotrtnasonkota.jpg";
                }
                else if (time == 6)
                {
                    lbl.Text = "Типо того";
                    img.Source = "sonnimer2.jpg";
                }
                else if (time == 7)
                {
                    lbl.Text = "Суп";
                    img.Source = "sup.jpg";
                }
                else if (time == 8)
                {
                    lbl.Text = "Завтрак";
                    img.Source = "Zavtrak.jpg";
                }
                else if (time == 9)
                {
                    lbl.Text = "Тренеровка";
                    img.Source = "trenerovka.jpg";
                }
                else if (time == 10)
                {
                    lbl.Text = "Человек идет домой";
                    img.Source = "tselidetdomoi.jpg";
                }
                else if (time == 11)
                {
                    lbl.Text = "Уставший человек";
                    img.Source = "Ystavshijtsel.jpg";
                }
                else if (time == 12)
                {
                    lbl.Text = "Ужин";
                    img.Source = "Yzin.jpg";
                }
               
            }
        }

    }
}
    
