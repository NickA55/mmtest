using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaManager;
using Xamarin.Forms;

namespace mmtest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void btnPlay_Clicked(object sender, System.EventArgs e)
        {
            await CrossMediaManager.Current.Play("http://radiosgreatesthits.out.airtime.pro:8000/radiosgreatesthits_a");
        }

        void btnPause_Clicked(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnStop_Clicked(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
