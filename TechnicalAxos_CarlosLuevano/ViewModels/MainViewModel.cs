using AsyncAwaitBestPractices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalAxos_CarlosLuevano.Services;

namespace TechnicalAxos_CarlosLuevano.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        // Maybe put this constant in another class
        const string ImageUrl = "https://random.dog/af70ad75-24af-4518-bf03-fec4a997004c.jpg";

        private readonly IAppInfo _appInfo;
        private readonly IToastService _toastService;
        private readonly CountryService _countryService;

        [ObservableProperty]
        private string? _bundleId;

        [ObservableProperty]
        private ImageSource? _source;

        [ObservableProperty]
        private ObservableCollection<Models.Newtonsoft.CountryNewtonsoft>? _countriesNS;

        [ObservableProperty]
        private ObservableCollection<Models.TextJson.CountryTextJson>? _countriesTJ;

        public MainViewModel(ILogger<MainViewModel> logger,
                             IToastService toastService,
                             IAppInfo appInfo,
                             CountryService countryService) : base(logger)
        {
            _appInfo = appInfo;
            _toastService = toastService;
            _countryService = countryService;

            // Get package name
            BundleId = _appInfo.PackageName;
            Source = ImageUrl;

            //Task.Run(() => GetCountriesNewtonsoftAsync());
            Task.Run(() => GetCountriesTextJsonAsync());
        }

        [RelayCommand]
        private async Task OnPickImage()
        {
            try
            {
                var file = await MediaPicker.Default.PickPhotoAsync();
                if (file != null)
                {
                    var stream = await file.OpenReadAsync();
                    Source = ImageSource.FromStream(() => stream);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "Error while picking image from gallery");
                _toastService.DisplayErrorToastAsync(Resources.Labels.Texts.GenericError).SafeFireAndForget();
            }
        }

        public async Task GetCountriesNewtonsoftAsync()
        {
            IsBusy = true;
            try
            {
                var countries = await _countryService.GetAllCountriesAsyncUsingNewtonSoft();
                CountriesNS = new ObservableCollection<Models.Newtonsoft.CountryNewtonsoft>(countries);
            }
            catch (Exception exc)
            {
                Logger.LogError(exc, "Error while getting countries using Newtonsoft");
            }
            finally
            {
                IsBusy = false;
            }
        }

        public async Task GetCountriesTextJsonAsync()
        {
            IsBusy = true;
            try
            {
                var countries = await _countryService.GetAllCountriesAsyncUsingTextJson();
                CountriesTJ = new ObservableCollection<Models.TextJson.CountryTextJson>(countries);
            }
            catch (Exception exc)
            {
                Logger.LogError(exc, "Error while getting countries using Text.Json");
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}