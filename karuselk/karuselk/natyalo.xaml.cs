using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace karuselk
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class natyalo : ContentPage
    {
        public natyalo()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            AbsoluteLayout bb = new AbsoluteLayout();
            BackgroundImageSource = "natalo.png";

            ImageButton mik = new ImageButton { Source = "logo.png", HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center,  };
            AbsoluteLayout.SetLayoutBounds(mik, new Rectangle(0.5, 1, 300, 100));
            mik.Clicked += Mik_Clicked;
            AbsoluteLayout.SetLayoutFlags(mik, AbsoluteLayoutFlags.PositionProportional);
            bb.Children.Add(mik);

            Content = bb;


        }

        private async void Mik_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage() );
        }
    }
}