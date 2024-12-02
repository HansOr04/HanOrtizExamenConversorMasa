<!-- MainPage.xaml -->
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:views="clr-namespace:HanOrtizExamenConversorMasa.Views"
             x:Class="HanOrtizExamenConversorMasa.MainPage">
    <views:HOConversionPage />
</ContentPage>

<!-- App.xaml.cs -->
namespace HanOrtizExamenConversorMasa
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }
    }
}

<!-- MainPage.xaml.cs -->
namespace HanOrtizExamenConversorMasa
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}