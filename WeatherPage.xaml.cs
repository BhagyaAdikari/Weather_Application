namespace WeatherApp
{
    public partial class WeatherPage : ContentPage
    {
        public List<Models.List> WeatherList; // Holds weather data
        private double latitude;
        private double longitude;

        public WeatherPage()
        {
            InitializeComponent();
            WeatherList = new List<Models.List>(); // Ensure WeatherList is initialized
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            // Get the location and weather data
            await GetLocation();
            await GetWeatherData(latitude, longitude);
        }

        public async Task GetLocation()
        {
            try
            {
                var location = await Geolocation.GetLocationAsync();
                if (location != null)
                {
                    latitude = location.Latitude;
                    longitude = location.Longitude;
                }
                else
                {
                    // Handle case where location is null
                    await DisplayAlert("Error", "Unable to fetch location.", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Failed to get location: {ex.Message}", "OK");
            }
        }

        public async Task GetWeatherData(double latitude, double longitude)
        {
            try
            {
                var result = await ApiService.GetWeather(latitude, longitude);

                // Check if result and result.list are valid before accessing them
                if (result?.list != null)
                {
                    // Ensure WeatherList is initialized before use
                    if (WeatherList == null)
                    {
                        WeatherList = new List<Models.List>();
                    }

                    WeatherList.Clear(); // Clear old data
                    foreach (var item in result.list)
                    {
                        WeatherList.Add(item);
                    }
                    CvWeather.ItemsSource = WeatherList;
                }

                // Set city information if available
                if (result?.city != null)
                {
                    LblCity.Text = result.city.name;
                }

                // Set weather description and icon if available
                if (result?.list?.FirstOrDefault()?.weather?.FirstOrDefault() != null)
                {
                    var weather = result.list[0].weather[0];
                    LblWeatherDescription.Text = weather.description;
                    ImgWeatherIcon.Source = weather.fullIconUrl;
                }

                // Set temperature and humidity if available
                if (result?.list?.FirstOrDefault()?.main != null)
                {
                    var main = result.list[0].main;
                    LblTemperature.Text = main.temperature + "°C";
                    LblHumidity.Text = main.humidity + "%";
                }

                // Set wind speed if available
                if (result?.list?.FirstOrDefault()?.wind != null)
                {
                    LblWind.Text = result.list[0].wind.speed + "Km/h";
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Failed to fetch weather data: {ex.Message}", "OK");
            }
        }

        public async void TapLocation_Tapped(object sender, EventArgs e)
        {
            await GetLocation();
            await GetWeatherData(latitude, longitude);
        }
    }
}
