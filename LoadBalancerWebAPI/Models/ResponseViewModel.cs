namespace LoadBalancerWebAPI.Models
{
    public class ResponseViewModel
    {
        public string ActulalServerUrl { get; set; }
        public List<WeatherForecast> Forecasts { get; set; }
    }
}
