using MLNet_Xamarin.Models;
using MLNet_Xamarin.Services;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MLNet_Xamarin.ViewModels
{
    public class PredictViewModel : BaseViewModel
    {
        private PredictionService _predictionService;

        public ICommand PredictCommand { get; }

        private string _wineType;

        public string WineType
        {
            get { return _wineType; }
            set 
            { 
                _wineType = value;
                SetProperty(ref _wineType, value);
            }
        }

        private float _fixedAcidity;

        public float FixedAcidity
        {
            get { return _fixedAcidity; }
            set 
            { 
                _fixedAcidity = value;
                SetProperty(ref _fixedAcidity, value);
            }
        }

        private float _volatileAcidity;

        public float VolatileAcidity
        {
            get { return _volatileAcidity; }
            set 
            { 
                _volatileAcidity = value;
                SetProperty(ref _volatileAcidity, value);
            }
        }

        private float _citricAcid;

        public float CitricAcid
        {
            get { return _citricAcid; }
            set 
            { 
                _citricAcid = value;
                SetProperty(ref _citricAcid, value);
            }
        }

        private float _residualSugar;

        public float ResidualSugar
        {
            get { return _residualSugar; }
            set 
            { 
                _residualSugar = value;
                SetProperty(ref _residualSugar, value);
            }
        }

        private float _chlorides;

        public float Chlorides
        {
            get { return _chlorides; }
            set 
            { 
                _chlorides = value;
                SetProperty(ref _chlorides, value);
            }
        }

        private float _freeSulferDioxide;

        public float FreeSulferDioxide
        {
            get { return _freeSulferDioxide; }
            set 
            { 
                _freeSulferDioxide = value;
                SetProperty(ref _freeSulferDioxide, value);
            }
        }

        private float _totalSulferDioxide;

        public float TotalSulferDioxide
        {
            get { return _totalSulferDioxide; }
            set 
            { 
                _totalSulferDioxide = value;
                SetProperty(ref _totalSulferDioxide, value);
            }
        }

        private float _density;

        public float Density
        {
            get { return _density; }
            set 
            { 
                _density = value;
                SetProperty(ref _density, value);
            }
        }

        private float _ph;

        public float Ph
        {
            get { return _ph; }
            set 
            { 
                _ph = value;
                SetProperty(ref _ph, value);
            }
        }

        private float _sulphates;

        public float Sulphates
        {
            get { return _sulphates; }
            set 
            { 
                _sulphates = value;
                SetProperty(ref _sulphates, value);
            }
        }

        private float _alcohol;

        public float Alcohol
        {
            get { return _alcohol; }
            set 
            { 
                _alcohol = value;
                SetProperty(ref _alcohol, value);
            }
        }


        public PredictViewModel()
        {
            _predictionService = new PredictionService();

            PredictCommand = new Command(async () => await ExecutePredictCommand());
        }

        private async Task ExecutePredictCommand()
        {
            var data = new WineData
            {
                Type = WineType,
                FixedAcidity = FixedAcidity,
                VolatileAcidity = VolatileAcidity,
                CitricAcid = CitricAcid,
                ResidualSugar = ResidualSugar,
                Chlorides = Chlorides,
                FreeSulfurDioxide = FreeSulferDioxide,
                TotalSulfurDioxide = TotalSulferDioxide,
                Density = Density,
                Ph = Ph,
                Sulphates = Sulphates,
                Alcohol = Alcohol
            };

            var quality = await _predictionService.Predict(data);

            MessagingCenter.Send(this, "Predict", quality);
        }
    }
}
