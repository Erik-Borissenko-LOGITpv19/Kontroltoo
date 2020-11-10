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
        Label lbl;
        TimePicker time;
        Image beg, obed, rabota, sleep, smotykot, sonnimer, sup, zavtrak, trenerovka, tselidetdomoi, ystavshijtsel, yzin;
        Entry entr;
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
            grd.RowDefinitions.Add(rowDef1);
            grd.RowDefinitions.Add(rowDef2);
            //Label-----------------------------------------------------------------------------------------------------------------------------------------
            lbl = new Label { Text = "This is my Plan", BackgroundColor = Color.LightSkyBlue, HorizontalTextAlignment = TextAlignment.Center };
            
            
            grd.Children.Add(lbl, 0, 0);
            Grid.SetColumnSpan(lbl, 2);

            //Timepicker------------------------------------------------------------------------------------------------------------------------------------
            TimePicker time = new TimePicker
            {
                Time = new TimeSpan(18, 0, 0),
            };
            
            grd.Children.Add(time, 0, 1);
            Grid.SetColumnSpan(time, 2);
            //Images---------------------------------------------------------------------------------------------------------------------------------------
            beg.Source = "Beg.jpg";
            obed.Source = "Obed.jpg";
            rabota.Source = "Rabota.jpg";
            sleep.Source = "sleep.jpg";
            smotykot.Source = "Smotretnasonkota.jpg";
            sonnimer.Source = "sonnimer2";
            sup.Source = "sup.jpg";
            zavtrak.Source = "Zavtrak.jpg";
            trenerovka.Source = "trenerovka.jpg";
            tselidetdomoi.Source = "tselidetdomoi.jpg";
            ystavshijtsel.Source = "Ystavshijtsel.jpg";
            yzin.Source = "Yzing.jpg";
            //Entry----------------------------------------------------------------------------------------------------------------------------------------
            entr = new Entry
            {
                Text = "Thank you for choose\na time",
            };
            grd.Children.Add(entr, 0, 2);





            Content = grd;

        }
    }
}