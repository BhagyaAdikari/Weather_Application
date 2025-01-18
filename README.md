# Weather Application

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Technologies Used](#technologies-used)
- [Setup and Installation](#setup-and-installation)
- [How to Use](#how-to-use)
- [Folder Structure](#folder-structure)
- [API Details](#api-details)
- [Troubleshooting](#troubleshooting)
- [Future Enhancements](#future-enhancements)

---

## Introduction
This Weather Application is a cross-platform application built with C#. It fetches real-time weather data based on the user's current location and displays details such as temperature, humidity, wind speed, and a general weather description. The app provides an intuitive user interface and integrates with a weather API to offer accurate and up-to-date weather information.

![image](https://github.com/user-attachments/assets/e9c808d7-08ca-46c0-8f7a-6f6f76f4aec5)

---

## Features
- Fetches the user’s current location using device GPS.
- Retrieves real-time weather data using an external weather API.
- Displays detailed weather information including:
  - Temperature
  - Humidity
  - Wind Speed
  - Weather Description
  - Weather Icon
- Refreshes weather data on demand by tapping a location icon.
- Clean and user-friendly interface.

---

## Technologies Used
- **C#**: Core programming language.
- **Xamarin.Forms**: For creating the user interface.
- **External Weather API**: To fetch real-time weather data.
- **Microsoft Visual Studio**: For development and debugging.
- **Geolocation Plugin**: To fetch the user's current GPS location.

---

## Setup and Installation
### Prerequisites
- Install [Microsoft Visual Studio](https://visualstudio.microsoft.com/) with Xamarin workload.
- Ensure your environment is set up for cross-platform development.
- An active internet connection is required for API requests.

### Installation Steps
1. Clone or download the repository to your local machine:
   ```bash
   git clone https://github.com/BhagyaAdikari/Weather_Application.git
   ```
2. Open the solution file (`.sln`) in Visual Studio.
3. Restore NuGet packages by building the solution.
4. Update the `ApiService.cs` file with your API key from the weather API provider.
5. Deploy the application to an emulator or a physical device.

---

## How to Use
1. Launch the application on your device.
2. Upon opening, the app will fetch your current location and retrieve weather data for that location.
3. View the following weather details on the main page:
   - City Name
   - Weather Description
   - Temperature
   - Humidity
   - Wind Speed
   - Weather Icon
4. To refresh the weather data:
   - Tap the location icon.
   - The app will fetch your updated location and display the latest weather data.

---

## Folder Structure
```
WeatherApp/
  |-- Models/
  |   |-- City.cs
  |   |-- Weather.cs
  |   |-- Main.cs
  |-- Services/
  |   |-- ApiService.cs
  |-- Views/
  |   |-- WeatherPage.xaml
  |   |-- WeatherPage.xaml.cs
  |-- App.xaml
  |-- App.xaml.cs
```
- **Models**: Contains data models for API responses.
- **Services**: Contains logic for API calls.
- **Views**: Contains UI components and their logic.

---

## API Details
This application integrates with a third-party weather API (e.g., OpenWeatherMap). Below are the key details:
- **Base URL**: `https://api.openweathermap.org/data/2.5/weather`
- **API Key**: Replace `<Your-API-Key>` in `ApiService.cs` with your key.
- **Endpoints Used**:
  - Weather data by geographic coordinates.

---

## Troubleshooting
- **NullReferenceException**: Ensure all variables like `WeatherList` are initialized before use.
- **Location Access Denied**: Check if the app has location permissions enabled.
- **API Key Error**: Confirm that your API key is valid and correctly placed in the `ApiService.cs` file.
- **Build Issues**: Restore NuGet packages and ensure all dependencies are installed.

---

## Future Enhancements
- Add support for searching weather data by city name.
- Implement a forecast feature to display weather for the next few days.
- Improve UI/UX with custom themes and animations.
- Add offline support by caching the last retrieved weather data.
- Localize the application to support multiple languages.

---

## License
This project is licensed under the MIT License. Feel free to use, modify, and distribute this application as needed.

---

## Acknowledgments
- **OpenWeatherMap API**: For providing the weather data.
- **Microsoft Xamarin.Forms**: For enabling cross-platform development.

