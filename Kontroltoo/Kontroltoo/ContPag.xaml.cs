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
            TimePicker time1 = new TimePicker
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
                var vremja = time1.Time.Hours;
                if (vremja == 12)
                {
                    img.Source = "Beg.jpg";
                    lbl.Text = "You choose 12";
                }
            }
        }
        //Functions------------------------------------------------------------------------------------------------------------------------------------
    }
}