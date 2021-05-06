using System;
using Xamarin.Forms;

namespace FootbalTable
{

    public partial class MainPage : ContentPage
    {
        public int span_count = 0;
        public int russ_count = 0;
        public int temp = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Spain_Clicked(object sender, EventArgs e)
        {
            span_count++;
            spain_count.Text = span_count.ToString();
        }

        private void Russia_Clicked(object sender, EventArgs e)
        {
            russ_count++;
            rus_count.Text = russ_count.ToString();
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            span_count = 0;
            spain_count.Text = span_count.ToString();
            russ_count = 0;
            rus_count.Text = russ_count.ToString();
        }

        private void Switcher_Clicked(object sender, EventArgs e)
        {
            temp++;
            if (temp % 2 != 0)
            {
                Title = "Футбольный матч";
                Spain.Text = "Испания";
                Russia.Text = "Россия";
                Reset.Text = "Сброс";
                Switcher.Text = "Изменить язык";
            }
            else
            {
                Title = "Football cup";
                Spain.Text = "Spain";
                Russia.Text = "Russia";
                Reset.Text = "Reset";
                Switcher.Text = "Change language";
            }
        }

        private double width = 0;
        private double height = 0;

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (width != this.width || height != this.height)
            {
                this.width = width;
                this.height = height;
                if (width > height)
                {
                    outerStack.Orientation = StackOrientation.Horizontal;
                    Main.Spacing = 100;
                    img_rus.WidthRequest = 150;
                    img_rus.HeightRequest = 100;
                    img_spain.WidthRequest = 150;
                    img_spain.HeightRequest = 100;
                    buttons.Spacing = 110;
                }
                else
                {
                    outerStack.Orientation = StackOrientation.Vertical;
                    Main.Spacing = 10;
                    img_rus.WidthRequest = 120;
                    img_rus.HeightRequest = 80;
                    img_spain.WidthRequest = 120;
                    img_spain.HeightRequest = 80;
                    buttons.Spacing = 70;
                    Russia.WidthRequest = 120;
                    Spain.WidthRequest = 120;
                    Reset.WidthRequest = 150;
                }
            }
        }
    }
}
