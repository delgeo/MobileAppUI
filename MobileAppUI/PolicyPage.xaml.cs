using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PolicyPage : ContentPage
    {
        private bool isMenuExpanded = false;

        public PolicyPage()
        {
            InitializeComponent();
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.Black;
        }

        public Color BarTextColor { get; }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Policy = e.Item as PolicyModel;
            var xx = BindingContext as PolicyMenu;

            xx?.ShowHide(Policy);


        }


    }
}