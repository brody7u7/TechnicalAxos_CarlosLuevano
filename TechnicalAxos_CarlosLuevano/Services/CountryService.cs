using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalAxos_CarlosLuevano.Models.Newtonsoft;
using TechnicalAxos_CarlosLuevano.Models.TextJson;

namespace TechnicalAxos_CarlosLuevano.Services
{
    public class CountryService
    {
        const string Url = "https://restcountries.com/v3.1/";
        
        private readonly HttpClient _httpClient;

        public CountryService() 
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Url);
        }

        /// <summary>
        /// Get all countries from restcontries.com. Response is deserialized using NewtonSoft.
        /// </summary>
        /// <returns>Array of countries</returns>
        public async Task<CountryNewtonsoft[]?> GetAllCountriesAsyncUsingNewtonSoft()
        {
            var response = await _httpClient.GetAsync("all").ConfigureAwait(false);
            var countries = Newtonsoft.Json.JsonConvert.DeserializeObject<CountryNewtonsoft[]>(
                await response.Content.ReadAsStringAsync(),
                Models.Newtonsoft.Converter.Settings);
            return countries;
        }

        /// <summary>
        /// Get all countries from restcontries.com. Response is deserialized using System.Text.Json.
        /// </summary>
        /// <returns>Array of countries</returns>
        public async Task<CountryTextJson[]?> GetAllCountriesAsyncUsingTextJson()
        {
            var response = await _httpClient.GetAsync("all").ConfigureAwait(false);
            var countries = await System.Text.Json.JsonSerializer.DeserializeAsync<CountryTextJson[]>(
                await response.Content.ReadAsStreamAsync(),
                Models.TextJson.Converter.Settings);
            return countries;
        }
    }
}
