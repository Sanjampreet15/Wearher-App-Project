import { Component, OnInit } from '@angular/core';
import { WeatherService } from '../service/weather.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css',
})
export class HomeComponent implements OnInit {
  constructor(private service: WeatherService) {}

  weather: any = {};
  showHourly: boolean = false;

  isWeatherEmpty(): boolean {
    return !this.weather || Object.keys(this.weather).length === 0;
  }

  ngOnInit(): void {
    this.service.getPosition().then((pos) => {
      this.service.getWeatherForecast(pos.lat, pos.lng).subscribe((result) => {
        this.weather = result;
      });
    });
  }

  filterHourlyData(): string[] {
    const currentDate = new Date().toISOString().split('T')[0];
    return this.weather?.hourly?.time.filter(
      (time: string) => time.split('T')[0] === currentDate
    );
  }

  // toggleForecast() {
  //   this.showHourly = !this.showHourly;
  // }
}
