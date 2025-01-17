namespace WeatherApp;

public partial class WeatherPage : ContentPage
{
	public WeatherPage()
	{
		InitializeComponent();
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        var result = await ApiService.GetWeather(47.6829, -122.1209);
        if (result != null)
        {
            LblCity.Text = result.city.name;
            LblWeatherDescription.Text = result.list[0].weather[0].description;
            LblTemperature.Text = result.list[0].main.temperature+ "°C";
            LblWind.Text = result.list[0].wind.speed + "Km/h";
            ImgWeatherIcon.Source = result.list[0].weather[0].fullIconUrl;
        }
        else
        {
            // Handle the case when result is null
            LblCity.Text = "Unknown";
            LblWeatherDescription.Text = "No data";
            LblTemperature.Text = "N/A";

        }
    }

}