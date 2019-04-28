using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotifictionView 
    {
        public NotifictionView()
        {
            InitializeComponent();
        }

        private void Entry_Focused(object sender, FocusEventArgs e)
        {
            frame1.BackgroundColor = Color.LightGray;
            frame1.BorderColor = Color.Black;
            Button.Margin = new Thickness(0,20,0,250);

        }



        private void Entry_unFocused(object sender, FocusEventArgs e)
        {
            frame1.BackgroundColor = Color.White;
            frame1.BorderColor = Color.LightGray;
            Button.Margin = new Thickness(0, 0, 0, 10);

        }


        private void Entry_Focused1(object sender, FocusEventArgs e)
        {
            frame2.BackgroundColor = Color.LightGray;
            frame2.BorderColor = Color.Black;
            Button.Margin = new Thickness(0, 20, 0, 250);

        }

        private void Entry_unFocused1(object sender, FocusEventArgs e)
        {
            frame2.BackgroundColor = Color.White;
            frame2.BorderColor = Color.LightGray;
            Button.Margin = new Thickness(0, 0, 0, 10);

        }

        private void Entry_Focused2(object sender, FocusEventArgs e)
        {
            frame3.BackgroundColor = Color.LightGray;
            frame3.BorderColor = Color.Black;
            Button.Margin = new Thickness(0, 20, 0, 250);

        }

        private void Entry_unFocused2(object sender, FocusEventArgs e)
        {
            frame3.BackgroundColor = Color.White;
            frame3.BorderColor = Color.LightGray;
            Button.Margin = new Thickness(0, 0, 0, 10);

        }
        private void Entry_Focused3(object sender, FocusEventArgs e)
        {
            frame4.BackgroundColor = Color.LightGray;
            frame4.BorderColor = Color.Black;
            Button.Margin = new Thickness(0, 20, 0, 250);

        }


        private void Entry_unFocused3(object sender, FocusEventArgs e)
        {
            frame4.BackgroundColor = Color.White;
            frame4.BorderColor = Color.LightGray;
            Button.Margin = new Thickness(0, 0, 0, 10);

        }
    }
}