using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace karuselk
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            ImageButton pulll ;
            ImageButton ppp;
            ImageButton vvv;
            ImageButton korolik;
            ImageButton lilit;


            vvv = new ImageButton
            {
                Source = "ida.png"
            };
            vvv.Clicked += Vvv_Clicked;
            var Sith = new ContentPage
            {

                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text = "Ида Клаторн",
                        FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center,
                        TextColor = Color.Black
                    },
                    }
                }
            };



            ppp = new ImageButton
            {
                Source = "emiti.png"


            };
            ppp.Clicked += Ppp_Clicked;
            var nSith = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text = "Эмити Блайт",
                        FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center,
                        TextColor = Color.Black
                    },
                       ppp
                    }
                }
            };
            pulll = new ImageButton
            {
                Source = "uz.PNG"


            };
            pulll.Clicked += Pulll_Clicked;

            var luz = new ContentPage
            {

                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text = "Луз",
                        FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center,
                        TextColor = Color.Black
                    }, 
                    pulll
                }
                }
            };

            lilit = new ImageButton
            {
                Source = "lilith.png"


            };
            lilit.Clicked += Lilit_Clicked;


            var lilith = new ContentPage
            {

                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text = "Лилит Клаторн",
                        FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center,
                        TextColor = Color.Black
                    },
                    lilit
                }
                }
            };

            korolik = new ImageButton
            {
                Source = "koroll.png"


            };
            korolik.Clicked += Korolik_Clicked;

            var koroll = new ContentPage
            {

                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {
                        Text = "Лилит Клаторн",
                        FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center,
                        TextColor = Color.Black
                    },
                    korolik
                }
                }
            };

            Children.Add(Sith);
            Children.Add(nSith);
            Children.Add(luz);
            Children.Add(koroll);
            Children.Add(lilith);

        }

        private async void Lilit_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://theowlhouse.fandom.com/ru/wiki/%D0%9B%D0%B8%D0%BB%D0%B8%D1%82_%D0%9A%D0%BB%D0%B0%D1%82%D0%BE%D1%80%D0%BD", BrowserLaunchMode.SystemPreferred);
        }

        private async void Korolik_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://theowlhouse.fandom.com/ru/wiki/%D0%9A%D0%BE%D1%80%D0%BE%D0%BB%D1%8C", BrowserLaunchMode.SystemPreferred);
        }

        private async void Vvv_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://the-owl-house.fandom.com/ru/wiki/%D0%98%D0%B4%D0%B0", BrowserLaunchMode.SystemPreferred);
        }

        private async void Ppp_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://theowlhouse.fandom.com/ru/wiki/%D0%AD%D0%BC%D0%B8%D1%82%D0%B8_%D0%91%D0%BB%D0%B0%D0%B9%D1%82", BrowserLaunchMode.SystemPreferred);
        }

        private async void Pulll_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://theowlhouse.fandom.com/ru/wiki/%D0%9B%D1%83%D0%B7_%D0%9D%D0%BE%D1%81%D0%B5%D0%B4%D0%B0", BrowserLaunchMode.SystemPreferred);
        }
    }
}
