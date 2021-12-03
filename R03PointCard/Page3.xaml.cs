using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace R03PointCard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
            if (Application.Current.Properties.ContainsKey("defaultUrl"))
            {
                bool defaultSw = (bool)Application.Current.Properties["defaultUrl"];
                radioDefaultUrl.IsChecked = defaultSw;
                radioDefaultUrl.IsChecked = !defaultSw;
            }

        }

        private void Button1_Clicked(object sender, EventArgs e)
        {

        }

        private void radioDefaultUrl_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            Application.Current.Properties["defaultUrl"] = true;

        }

        private void radioCustomUrl_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            Application.Current.Properties["defaultUrl"] = false;

        }
    }
}