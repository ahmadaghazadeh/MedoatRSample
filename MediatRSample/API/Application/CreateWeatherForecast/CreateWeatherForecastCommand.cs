﻿using MediatR;

namespace API.Application.CreateWeatherForecast
{
    public class CreateWeatherForecastCommand: IRequest
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }
  
    }
}
