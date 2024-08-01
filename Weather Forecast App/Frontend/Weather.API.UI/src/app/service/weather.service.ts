import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class WeatherService {
  constructor(private http: HttpClient) {}
  url = 'http://localhost:5026/WeatherForecast';

  getPosition(): Promise<any> {
    return new Promise((resolve, reject) => {
      navigator.geolocation.getCurrentPosition(
        (resp) => {
          resolve({ lng: resp.coords.longitude, lat: resp.coords.latitude });
        },
        (err) => {
          reject(err);
        }
      );
    });
  }

  getWeatherForecast(latitude: any, longitude: any): Observable<any> {
    return this.http.get<any>(
      `${this.url}/GetWeatherForecast/${latitude}/${longitude}`
    );
  }
}
