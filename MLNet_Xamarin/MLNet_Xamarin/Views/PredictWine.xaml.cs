using MLNet_Xamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MLNet_Xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PredictWine : ContentPage
    {
        PredictViewModel viewModel;

        public PredictWine()
        {
            InitializeComponent();

            BindingContext = viewModel = new PredictViewModel();

            MessagingCenter.Subscribe<PredictViewModel, string>(this, "Predict",
                async (obj, prediction) => await DisplayAlert("Prediction", $"Wine quality: {prediction}", "OK"));
        }
    }
}